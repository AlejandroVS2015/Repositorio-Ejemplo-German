using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public interface IUnitOfWork : IDisposable
    {
        //Commit sobre la base de datos. Si hay un problema de concurrencia lanzará una excepción
        void Commit();
        //Rollback de los cambios que se han producido en la Unit of Work y que están siendo observados por ella
        void Rollback();
    }
}
