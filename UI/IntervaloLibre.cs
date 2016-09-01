using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    /// <summary>
    /// Representa un intervalo horario
    /// </summary>
    public class IntervaloHorario
    {
        /// <summary>
        /// Hora inicio del intervalo 
        /// </summary>
        public TimeSpan Inicio { get; set; }

        /// <summary>
        /// Hora fin del intervalo
        /// </summary>
        public TimeSpan Fin { get; set; }
    }
}
