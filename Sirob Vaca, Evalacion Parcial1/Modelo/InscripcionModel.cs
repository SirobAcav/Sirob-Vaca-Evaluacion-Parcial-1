using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirob_Vaca__Evalacion_Parcial1.Modelo
{
    public class InscripcionModel
    {
        public int InscripcionId { get; set; }
        public int EstudianteId { get; set; }
        public int CursoId { get; set; }
        public DateTime FechaInscripcion { get; set; }
    }
}
