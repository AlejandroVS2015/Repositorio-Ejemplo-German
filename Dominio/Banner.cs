using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Banner
    {
        private TipoBanner iTipo;
        
        public int BannerId { get; set; }
        public string Descripcion { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaFin { get; set; }

        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }

        public TipoBanner Tipo
        {
            get { return this.iTipo; }

            set
            {
                if (this.CambioDeTipo(value))
                {
                    if (value == TipoBanner.TextoPlano)
                    {
                        this.BannerStrategy = new BannerTextoPlano();
                        //this.PasoBanners = new List<PasoBanner>(); ;
                        //this.FuenteRss = null;
                    }
                    else if (value == TipoBanner.Rss)
                    {
                        this.BannerStrategy = new BannerRss();
                        //this.FuenteRss = new FuenteRss(); ;
                        //this.PasoBanners = null;
                    }
                    this.iTipo = value;
                }
            }
        }
        public IBanner BannerStrategy { get; set; }

        public virtual ICollection<PasoBanner> PasoBanners { get; set; } //puede ser null si es de tipo Rss

        public int? FuenteRssId { get; set; } //puede ser null si es de tipo TextoPlano
        public virtual FuenteRss FuenteRss{get; set;}

        //Constructor
        public Banner()
        {
            this.PasoBanners = new List<PasoBanner>();
            this.FuenteRss = null;
        }

        private bool CambioDeTipo(TipoBanner pValor)
        {
            bool cambio = false;
            if (pValor != this.iTipo)
                cambio = !cambio;
            return cambio;
        }

        /// <summary>
        /// Lee los datos, de acuerdo al BannerStrategy
        /// </summary>
        /// <returns></returns>
        public ICollection<string> Leer()
        {
            object objetoAPasar=new object();
            switch(Tipo)
            {
                case TipoBanner.TextoPlano:
                    objetoAPasar = this.PasoBanners;
                    break;
                case TipoBanner.Rss: 
                    objetoAPasar = this.FuenteRss;
                    break;
            }
            if (objetoAPasar == null)
                return new List<string>();
            else
                return this.BannerStrategy.Leer(objetoAPasar);
        }
    }
}
