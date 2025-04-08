using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia_Pro
{
    public class PreguntaFacil : Preguntas
    {
        public override int ObtenerPuntaje()
        {
            return 10;
        }

        public override int ObtenerTiempoLimite()
        {
            return 30;
        }
    }
}
