using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class FuenteRss
    {
        public int FuenteRssId { get; set; }
        public string Titulo { get; set; }
        public string Url { get; set; }
        public virtual ICollection<Banner> Banners { get; set; }
        

        public FuenteRss()
        {
            this.Banners = new List<Banner>();
            this.Titulo = "";
        }

        public override string ToString()
        {
            return Titulo;
        }
    }
}
