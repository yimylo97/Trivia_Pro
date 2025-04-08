using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia_Pro
{
    public class Preguntaslistas : Preguntas
    {
        public override int ObtenerPuntaje()
        {
            return Nivel switch
            {
                "Fácil" => 10,
                "Medio" => 20,
                "Difícil" => 30,
                _ => 0
            };
        }

        public override int ObtenerTiempoLimite()
        {
            return Nivel switch
            {
                "Fácil" => 30,     // 30 segundos
                "Medio" => 20,     // 20 segundos
                "Difícil" => 10,   // 10 segundos
                _ => 0
            };
        }
    }
}

