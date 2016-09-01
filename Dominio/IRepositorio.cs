using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Dominio
{
    /// <summary>
    /// Métodos genéricos para todos los repositorios
    /// </summary>
    public interface IRepositorio<TEntity>
    {
        /// <summary>
        /// Traemos la Unit of Work al repositorio para así poder hacer Commit, Rollback ... de los cambios
        /// </summary>
        IUnitOfWork UnitOfWork { get; }
        IEnumerable<TEntity> Obtener(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);
        IEnumerable<TEntity> ObtenerTodos(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);
        TEntity ObtenerPorId(object id);
        IEnumerable<TEntity> ObtenerPorAtributo(Expression<Func<TEntity, bool>> filter = null);
        void Agregar(TEntity entidad);
        void Borrar(object id);
        void Borrar(TEntity objetoABorrar);
        void Modificar(TEntity objetoAEliminar);
    }
}
