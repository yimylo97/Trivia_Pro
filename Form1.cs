using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivia_Pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnResponder.Enabled = false;
        }

        private int cantidadPreguntasRespondidas = 0;
        private string categoriaSeleccionada;
        private string nivelSeleccionado;
        private Preguntas preguntaActual;
        private int puntaje = 0;
        private int tiempoRestante = 0;
        private int preguntasRespondidas = 0;
        private const int maxPreguntas = 3;
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedItem == null || cmbNivel.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una categoría y un nivel.");
                return;
            }

            puntaje = 0;
            preguntasRespondidas = 0;
            lblPuntaje.Text = "Puntaje: 0";

            CargarNuevaPregunta();
        }

        private void CargarNuevaPregunta()
        {
            if (preguntasRespondidas >= maxPreguntas)
            {
                MostrarResumenFinal();
                btnResponder.Enabled = false;
                return;
            }
            try
            {
                string categoria = cmbCategoria.SelectedItem.ToString();
                string nivel = cmbNivel.SelectedItem.ToString();

                if (string.IsNullOrEmpty(categoria) || string.IsNullOrEmpty(nivel))
                {
                    MessageBox.Show("Selecciona una categoría y un nivel antes de continuar.");
                    return;
                }

                preguntaActual = PreguntaFactory.ObtenerPregunta(categoria, nivel);

                lblPregunta.Text = preguntaActual.Texto;

                var opciones = preguntaActual.Opciones;
                rbOpcion1.Text = opciones[0];
                rbOpcion2.Text = opciones[1];
                rbOpcion3.Text = opciones[2];
                rbOpcion4.Text = opciones[3];

                rbOpcion1.Checked = false;
                rbOpcion2.Checked = false;
                rbOpcion3.Checked = false;
                rbOpcion4.Checked = false;

                tiempoRestante = preguntaActual.ObtenerTiempoLimite();
                lblTiempo.Text = $"Tiempo: {tiempoRestante} segundos";
                progressTiempo.Maximum = tiempoRestante;
                progressTiempo.Value = tiempoRestante;

                timerPregunta.Start();
                btnResponder.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("¡Has respondido todas las preguntas disponibles!\n" +
                        "Se mostrará tu resumen final.");
                MostrarResumenFinal();
                btnResponder.Enabled = false;
            }
        }

        private void timerPregunta_Tick(object sender, EventArgs e)
        {
            tiempoRestante--;
            lblTiempo.Text = $"Tiempo: {tiempoRestante} segundos";
            progressTiempo.Value = tiempoRestante;

            if (tiempoRestante <= 0)
            {
                timerPregunta.Stop();
                MessageBox.Show("Tiempo agotado. Respuesta incorrecta.");
                preguntasRespondidas++;
                CargarNuevaPregunta();
            }
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            timerPregunta.Stop();

            string seleccion = obtenerRespuestaSeleccionada();

            if (string.IsNullOrEmpty(seleccion))
            {
                MessageBox.Show("Por favor, selecciona una opción.");
                return;
            }

            bool esCorrecta = preguntaActual.EvaluarRespuesta(seleccion);

            MessageBox.Show(esCorrecta ? "Respuesta correcta!" : $"Respuesta incorrecta, la respuesta correcta es : {preguntaActual.RespuestaCorrecta}");

            ActualizarPuntaje(esCorrecta);

            preguntasRespondidas++;

            try
            {
                CargarNuevaPregunta();
            }
            catch (Exception)
            {
                MostrarResumenFinal();
                btnResponder.Enabled = false;
            }
        }

        private string obtenerRespuestaSeleccionada()
        {
            if (rbOpcion1.Checked) return rbOpcion1.Text;
            if (rbOpcion2.Checked) return rbOpcion2.Text;
            if (rbOpcion3.Checked) return rbOpcion3.Text;
            if (rbOpcion4.Checked) return rbOpcion4.Text;
            return null;
        }

        private void ActualizarPuntaje(bool correcta)
        {
            if (correcta)
            {
                puntaje += preguntaActual.ObtenerPuntaje();
            }
            else
            {
                puntaje = Math.Max(0, puntaje - 2);
            }
            lblPuntaje.Text = $"Puntaje: {puntaje}";
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            timerPregunta.Stop();

            PreguntaFactory.ReiniciarPreguntas();
            PuntajeManager.ReiniciarPuntaje();

            lblPregunta.Text = "Selecciona una categoría y nivel para comenzar";
            rbOpcion1.Text = "";
            rbOpcion2.Text = "";
            rbOpcion3.Text = "";
            rbOpcion4.Text = "";

            rbOpcion1.Checked = false;
            rbOpcion2.Checked = false;
            rbOpcion3.Checked = false;
            rbOpcion4.Checked = false;

            lblPuntaje.Text = "Puntaje: 0";
            lblTiempo.Text = "Tiempo: 0 segundos";
            progressTiempo.Value = 0;

            puntaje = 0;
            preguntasRespondidas = 0;
            btnResponder.Enabled = false;

            cmbCategoria.Enabled = true;
            cmbNivel.Enabled = true;
            btnIniciar.Enabled = true;
            btnResponder.Enabled = false;

            lstHistorial.Items.Add("-----Nueva Partida-----");
        }

        private void MostrarResumenFinal()
        {
            lstHistorial.Items.Clear(); 
            lstHistorial.Items.Add("🎉 Fin del juego 🎉");
            lstHistorial.Items.Add($"Preguntas respondidas: {cantidadPreguntasRespondidas}");
            lstHistorial.Items.Add($"Puntaje final: {PuntajeManager.PuntajeTotal}");

            string comentario;
            if (PuntajeManager.PuntajeTotal >= 80)
                comentario = "Excelente";
            else if (PuntajeManager.PuntajeTotal >= 50)
                comentario = "Buen trabajo";
            else
                comentario = "Mal puntaje";

            lstHistorial.Items.Add(comentario);
        }

        private void MostrarPregunta(Preguntas pregunta)
        {
            lblPregunta.Text = pregunta.Texto;
            rbOpcion1.Text = pregunta.Opciones[0];
            rbOpcion2.Text = pregunta.Opciones[1];
            rbOpcion3.Text = pregunta.Opciones[2];
            rbOpcion4.Text = pregunta.Opciones[3];

            rbOpcion1.Checked = false;
            rbOpcion2.Checked = false;
            rbOpcion3.Checked = false;
            rbOpcion4.Checked = false;
        }

    }
}
