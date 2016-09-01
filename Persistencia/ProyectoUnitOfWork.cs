using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Dominio;
using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Collections.Specialized;
using System.Data.Entity.Core.Objects.DataClasses;
using System.ComponentModel;
using System.Data.Entity.Validation;
using Excepciones;

namespace Persistencia
{
    public class ProyectoUnitOfWork : DbContext, IEntityFrameworkUnitOfWork
    {
        public ProyectoUnitOfWork() : base("DataBase")
        {
            //Database.SetInitializer<ProyectoUnitOfWork>(new DropCreateDatabaseIfModelChanges<ProyectoUnitOfWork>());
        }

        // Implementación de IEntityFrameworkUnitOfWork

        IDbSet<Banner> banners;
        public IDbSet<Banner> Banners
        {
            get
            {
                if (banners == null)
                    banners = base.Set<Banner>();
                return banners;
            }
        }

        IDbSet<PasoBanner> pasoBanners;
        public IDbSet<PasoBanner> PasoBanners
        {
            get
            {
                if (pasoBanners == null)
                    pasoBanners = base.Set<PasoBanner>();
                return pasoBanners;
            }
        }

        IDbSet<FuenteRss> fuenteRss;
        public IDbSet<FuenteRss> FuenteRss
        {
            get
            {
                if (fuenteRss == null)
                    fuenteRss = base.Set<FuenteRss>();
                return fuenteRss;
            }
        }

        IDbSet<Campania> campanias;
        public IDbSet<Campania> Campanias
        {
            get
            {
                if (campanias == null)
                    campanias = base.Set<Campania>();
                return campanias;
            }
        }

        IDbSet<Imagen> imagenes;
        public IDbSet<Imagen> Imagenes
        {
            get
            {
                if (imagenes == null)
                    imagenes = base.Set<Imagen>();
                return imagenes;
            }
        }


        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            try
            {
                //Returns a DbSet<TEntity> instance for access to entities of the given type in the context
                return base.Set<TEntity>();
            }
            catch (Exception ex)
            {
                throw new ExcepcionAlCargarPantalla("Error al intentar acceder a la entidad",ex);
            }
        }

        public void Attach<TEntity>(TEntity entity) where TEntity : class
        {
            try
            {
                if (base.Entry<TEntity>(entity).State == EntityState.Detached)
                {
                    base.Set<TEntity>().Attach(entity);
                }
            }
            catch (Exception ex)
            {
                throw new ExcepcionAlCargarPantalla("Se ha producido un error en la base de datos",ex);
            } 
        }

        public IEnumerable<TEntity> ExecuteQuery<TEntity>(string sqlQuery, params object[] parameters)
        {
            return base.Database.SqlQuery<TEntity>(sqlQuery, parameters);
        }

        public int ExecuteCommand(string sqlCommand, params object[] parameters)
        {
            return base.Database.ExecuteSqlCommand(sqlCommand, parameters);
        }

        // Implementación de IUnitOfWork

        public void SetModified<TEntity>(TEntity entity) where TEntity : class
        {
            try
            {
                base.Entry<TEntity>(entity).State = EntityState.Modified;
            }
            catch (Exception ex)
            {
                throw new ExcepcionAlCargarPantalla("Se ha producido un error en la base de datos",ex);
            }
        }

        public void Commit()
        {
            try
            {
                this.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw new ExcepcionErrorAlGuardar("Ha ocurrido un error al intentar actualizar la base de datos",ex);
            }
            catch (DbEntityValidationException ex)
            {
                throw new ExcepcionErrorAlGuardar("Ha ocurrido un error de validacion al intentar actualizar la base de datos",ex);
            }
            catch (ObjectDisposedException ex)
            {
                throw new ExcepcionErrorAlGuardar("La conexión con la base de datos se ha perdido",ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new ExcepcionErrorAlGuardar("No se ha podido procesar la entidad en la base de datos",ex);
            }
            catch  (Exception ex)
            { throw new ExcepcionAlCargarPantalla("Se ha producido un error en la base de datos",ex); }
        }

        public void Rollback()
        {
            try
            {
                base.ChangeTracker.Entries()
                  .ToList()
                  .ForEach(entry => entry.State = EntityState.Unchanged);
            }
            catch (Exception ex)
            {
                throw new ExcepcionAlCargarPantalla("Se ha producido un error en la base de datos",ex);
            }
        }

        /// <summary>
        /// Sobreescribimos el SaveChanges() para salvaguardar los hijos huérfanos de las relaciones 1 a *
        /// </summary>
        public override int SaveChanges()
        {
            for (int i = 0; i < this.PasoBanners.Local.Count; i++)
            {
                if (this.PasoBanners.Local[i].Banner == null)
                {
                    this.PasoBanners.Local.RemoveAt(i);
                    i--;
                }
            }

            for (int i = 0; i < this.Imagenes.Local.Count; i++)
            {
                if (this.Imagenes.Local[i].Campania == null)
                {
                    this.Imagenes.Local.RemoveAt(i);
                    i--;
                }
            }

                return base.SaveChanges();
        }



        /// <summary>
        /// Sobreescibimos OnModelCreating de DdContext
        /// </summary>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //Para que no pluralice las tablas
            modelBuilder.Conventions.Add(new DateConvention());

            //RELACIÓN BANNER 1--* PASOBANNER: delete en cascada
            modelBuilder.Entity<PasoBanner>().HasRequired<Banner>(x => x.Banner).WithMany(x => x.PasoBanners).HasForeignKey(x => x.BannerId).WillCascadeOnDelete(true);
            //modelBuilder.Entity<Banner>().HasMany(x => x.PasoBanners).WithOptional().HasForeignKey(x => x.BannerId).WillCascadeOnDelete();

            //RELACIÓN FUENTE RSS 1--* BANNER: con delete en cascada
            modelBuilder.Entity<FuenteRss>().HasMany(x => x.Banners).WithOptional().HasForeignKey(x => x.FuenteRssId).WillCascadeOnDelete(true);
            //modelBuilder.Entity<Banner>().HasOptional<FuenteRss>(s => s.FuenteRss).WithMany(s => s.Banners).HasForeignKey(s => s.FuenteRssId).WillCascadeOnDelete(false);

            //RELACIÓN CAMPAÑA 1--* IMAGENES: delete en cascada
            modelBuilder.Entity<Imagen>().HasRequired<Campania>(x => x.Campania).WithMany(x => x.Imagenes).HasForeignKey(x => x.CampaniaId).WillCascadeOnDelete(true);
            //modelBuilder.Entity<>().HasRequired(x => x.).WithRequiredDependent(x => x.);


            modelBuilder.Entity<Banner>().Ignore(x=>x.BannerStrategy);

        }

        public new void Dispose()
        {
            base.Dispose();
        }
    }
}
