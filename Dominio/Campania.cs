using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Dominio
{
    public class Campania
    {
        public int CampaniaId { get; set; }
                [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }
        public TimeSpan HoraInicio { get; set; }
                [DataType(DataType.Date)]
        public DateTime FechaFin { get; set; }
        public TimeSpan HoraFin { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int DuracionImagen { get; set; }
        
        public virtual ICollection<Imagen> Imagenes {get; set;}

        public Campania()
        {
            this.Imagenes = new List<Imagen>();
        }
    }
}
