using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.Entity;

namespace Persistencia
{
    public interface IEntityFrameworkUnitOfWork : IUnitOfWork
    {
        IDbSet<Banner> Banners { get; }
        IDbSet<PasoBanner> PasoBanners { get; }
        IDbSet<FuenteRss> FuenteRss { get; }
        IDbSet<Campania> Campanias { get; }
        IDbSet<Imagen> Imagenes { get; }


        IDbSet<TEntity> Set<TEntity>() where TEntity : class;

        void Attach<TEntity>(TEntity item) where TEntity : class;

        void SetModified<TEntity>(TEntity item) where TEntity : class;

        IEnumerable<TEntity> ExecuteQuery<TEntity>(string sqlQuery, params object[] parameters);

        int ExecuteCommand(string sqlCommand, params object[] parameters);
    }
}
