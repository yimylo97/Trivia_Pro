using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia_Pro
{
    public static class PuntajeManager
    {
        public static int PuntajeTotal { get; private set; } = 0;

        public static void SumarPuntaje(int puntos)
        {
            PuntajeTotal += puntos;
        }

        public static void ReiniciarPuntaje()
        {
            PuntajeTotal = 0;
        }
    }
}
