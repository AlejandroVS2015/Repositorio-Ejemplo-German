using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class BannerRss : IBanner
    {

        public ICollection<string> Leer(object pObjetoALeer) 
        {
            //MODIFICAR ESTO
            throw new NotImplementedException();
            //Buscar fuente
            //Leer del URL
            //Sino Buscar en la DB
        }
    }
}
