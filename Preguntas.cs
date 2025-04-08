using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia_Pro
{
    public abstract class Preguntas
    {
        public string Texto { get; protected set; }
        public List<string> Opciones { get; protected set; }
        public string RespuestaCorrecta { get; protected set; }
        public string Categoria { get; protected set; }
        public string Nivel { get; protected set; }
        public abstract int ObtenerPuntaje();
        public abstract int ObtenerTiempoLimite();

        public bool EvaluarRespuesta(string respuesta)
        {
            return respuesta == RespuestaCorrecta;
        }
    }
}
