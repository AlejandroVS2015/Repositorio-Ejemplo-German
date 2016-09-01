using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.Entity;
using System.Linq.Expressions;
using Excepciones;

namespace Persistencia
{
    /// <summary>
    /// Implementacion de un repositorio generico
    /// </summary>
    public class Repositorio<TEntity> : IRepositorio<TEntity> where TEntity : class
    {
        [ThreadStatic]
        /// <summary>
        /// Unidad de trabajo de este contexto de trabajo
        /// </summary>
        IEntityFrameworkUnitOfWork unitofwork;

        /// <summary>
        /// Unidad de trabajo expuesta a la aplicacion
        /// </summary>
        /// <param name="unitofwork">The current Unit of Work</param>
        public IUnitOfWork UnitOfWork
        {
            get
            {
                return this.unitofwork;
            }
        }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="unitofwork">Unidad de trabajo</param>
        public Repositorio(IEntityFrameworkUnitOfWork unitofwork)
        {
            this.unitofwork = unitofwork;
        }

        /// <summary>
        /// Metodo generico para recuperar una coleccion de entidades
        /// </summary>
        /// <param name="filter">Expresion para filtrar las entidades</param>
        /// <param name="orderBy">Orden en el que se quiere recuperar las entidades</param>
        /// <returns>Un listado de objetos de la entidadgenerica</returns>
        public virtual IEnumerable<TEntity> Obtener(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null)
        {
            try
            {
                IQueryable<TEntity> query = unitofwork.Set<TEntity>();

                if (filter != null)
                    query = query.Where(filter);

                if (orderBy != null)
                    return orderBy(query).ToList();
                else
                    return query.ToList();
            }
            catch (Exception ex)
            {
                throw new ExcepcionAlCargarPantalla("Error al obtener las entidades",ex);
            }
        }

        public virtual IEnumerable<TEntity> ObtenerTodos(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null)
        {
            try
            {
                if (orderBy == null)
                    return this.Obtener(null, null);
                else
                    return this.Obtener(null, orderBy);
            }
            catch (Exception ex)
            {
                throw new ExcepcionAlCargarPantalla("Error al obtener las entidades",ex);
            }
        }

        /// <summary>
        /// Metodo generico para recuperar una entidad a partir de su identidad
        /// </summary>
        /// <param name="id">La identidad de la entidad</param>
        /// <returns>La entidad</returns>
        public virtual TEntity ObtenerPorId(object id)
        {
            try
            {
                return unitofwork.Set<TEntity>().Find(id);
            }
            catch (Exception ex)
            {
                throw new ExcepcionAlCargarPantalla("Error al obtener la entidad",ex);
            }
        }

        public virtual IEnumerable<TEntity> ObtenerPorAtributo(Expression<Func<TEntity, bool>> filter = null)
        {
            try
            {
                IQueryable<TEntity> query = unitofwork.Set<TEntity>();

                if (filter != null)
                {
                    query = query.Where(filter);
                }

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new ExcepcionAlCargarPantalla("Error al obtener las entidades",ex);
            }
        }

        /// <summary>
        /// Metodo generico para añadir una entidad al contexto de trabajo
        /// </summary>
        /// <param name="entity">La entidad para añadir</param>
        public virtual void Agregar(TEntity entidad)
        {
            try
            {
                unitofwork.Set<TEntity>().Add(entidad);
            }
            catch (Exception ex)
            {
                throw new ExcepcionAlCargarPantalla("Error al agregar la entidad",ex);
            }
        }

        /// <summary>
        /// Metodo generico para eliminar una entidad del contexto de trabajo
        /// </summary>
        /// <param name="id">La identidad de la entidad</param>
        public virtual void Borrar(object id)
        {
            try
            {
                TEntity entidadABorrar = unitofwork.Set<TEntity>().Find(id);
                this.Borrar(entidadABorrar);
            }
            catch (Exception ex)
            {
                
                throw new ExcepcionAlCargarPantalla("Error al borrar la entidad",ex);
            }
        }

        /// <summary>
        /// Metodo generico para eliminar una entidad del contexto de trabajo pasandole la entidad
        /// </summary>
        /// <param name="entityToDelete">Entidad a eliminar</param>
        public virtual void Borrar(TEntity entityToDelete)
        {
            try
            {
                unitofwork.Attach<TEntity>(entityToDelete);
                unitofwork.Set<TEntity>().Remove(entityToDelete);
            }
            catch (Exception ex)
            {
                
                throw new ExcepcionAlCargarPantalla("Error al borrar la entidad",ex);
            }
        }

        /// <summary>
        /// Metodo generico para modificar una entidad en el contexto de trabajo
        /// </summary>
        /// <param name="entityToUpdate">La entidad a modificar</param>
        public virtual void Modificar(TEntity entityToUpdate)
        {
            try
            {
                unitofwork.SetModified<TEntity>(entityToUpdate);
            }
            catch (Exception ex)
            {
                throw new ExcepcionAlCargarPantalla("Error al modificar la entidad",ex);
            }
        }
    }
}
