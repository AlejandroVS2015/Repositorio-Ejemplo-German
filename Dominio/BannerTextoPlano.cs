using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class BannerTextoPlano : IBanner
    {

        public ICollection<string> Leer(object pObjetoAPasar)
        {
            List<string> listaADevolver = new List<string>();
            List<PasoBanner> listaOrdenada = ((List<PasoBanner>)pObjetoAPasar).OrderBy(x => x.Orden).ToList();
            foreach (var pB in listaOrdenada)
            {
                listaADevolver.Add(pB.ToString());
            }
            return listaADevolver;
        }
    }
}
