using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia_Pro
{
    public abstract class Preguntas
    {
        public string Texto { get;  set; }
        public List<string> Opciones { get;  set; }
        public string RespuestaCorrecta { get; set; }
        public string Categoria { get; set; }
        public string Nivel { get;  set; }
        public abstract int ObtenerPuntaje();
        public abstract int ObtenerTiempoLimite();

        public bool EvaluarRespuesta(string respuesta)
        {
            return respuesta == RespuestaCorrecta;
        }
    }
}
