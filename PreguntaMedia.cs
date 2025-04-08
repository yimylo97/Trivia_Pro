using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia_Pro
{
    public class PreguntaMedia : Preguntas
    {
        public override int ObtenerPuntaje()
        {
            return 20;
        }

        public override int ObtenerTiempoLimite()
        {
            return 20;
        }
    }
  
}
