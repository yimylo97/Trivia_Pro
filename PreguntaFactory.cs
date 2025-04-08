using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Trivia_Pro
{
    public static class PreguntaFactory
    {
        private static Dictionary<string, List<Preguntas>> preguntasDisponibles = new Dictionary<string, List<Preguntas>>();

        static PreguntaFactory()
        {
            Inicializar("Ciencia", "Fácil");
            Inicializar("Ciencia", "Medio");
            Inicializar("Ciencia", "Difícil");

            Inicializar("Historia", "Fácil");
            Inicializar("Historia", "Medio");
            Inicializar("Historia", "Difícil");

            Inicializar("Cultura General", "Fácil");
            Inicializar("Cultura General", "Medio");
            Inicializar("Cultura General", "Difícil");

        }

        private static void Inicializar(string categoria, string nivel)
        {
            string clave = $"{categoria}-{nivel}";
            if (!preguntasDisponibles.ContainsKey(clave))
            {
                preguntasDisponibles[clave] = new List<Preguntas>();
            }
        }

        public static void AgregarPregunta(Preguntas pregunta)
        {
            string clave = $"{pregunta.Categoria}-{pregunta.Nivel}";
            if (preguntasDisponibles.ContainsKey(clave))
            {
                preguntasDisponibles[clave].Add(pregunta);
            }
        }

        public static Preguntas ObtenerPregunta(string categoria, string nivel)
        {
            string clave = $"{categoria}-{nivel}";
            if (preguntasDisponibles.ContainsKey(clave) && preguntasDisponibles[clave].Count > 0)
            {
                var lista = preguntasDisponibles[clave];
                var random = new Random();
                int indice = random.Next(lista.Count);
                var pregunta = lista[indice];
                lista.RemoveAt(indice);
                return pregunta;
            }
            else
            {
                throw new Exception("No hay preguntas disponibles");
            }
        }

        public static void ReiniciarPreguntas()
        {
            preguntasDisponibles.Clear();

            Inicializar("Ciencia", "Fácil");
            Inicializar("Ciencia", "Medio");
            Inicializar("Ciencia", "Difícil");

            Inicializar("Historia", "Fácil");
            Inicializar("Historia", "Medio");
            Inicializar("Historia", "Difícil");

            Inicializar("Cultura General", "Fácil");
            Inicializar("Cultura General", "Medio");
            Inicializar("Cultura General", "Difícil");
        }

        
    }
}

