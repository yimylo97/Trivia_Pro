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
            switch (Nivel)
            {
                case "Fácil":
                    return 30;
                case "Medio":
                    return 20;
                case "Difícil":
                    return 10;
                default:
                    return 0;
            }
        }
    }
}

