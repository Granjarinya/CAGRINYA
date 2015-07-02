using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CAGProveedores
{
	public partial class Frm_Comprobacion: Form
	{
        /*Constructor de la pantalla que se lanza tras leer un TAG.
          Es un formulario vacio (a escepto de un mensaje) que se pinta de un color u otro,
          dependiendo del tipo de mensaje que tenga que mostrar*/
        public Frm_Comprobacion(int segundos, int tipoMensaje, int contador)
        {
            InitializeComponent();
            timer1.Interval = segundos * 1000;    // pasamos de segundos a milisegundos
            string mensaje = "Nº de TAG grabado:  " + Convert.ToString(contador) + " de 40";
            this.NumTAGStxt.Text = mensaje;
            if (!timer1.Enabled)
                timer1.Enabled = true;    // Activamos el Timer si no esta Enabled (Activado)

            switch (tipoMensaje)
            {
                case 1:                                 //grabado correcto, pantalla VERDE
                    this.TAGGRABADOtxt.Visible = true;
                    this.BackColor = Color.Green;
                    break;
                case 2:                                 //grabado incorrecto, pantalla ROJA
                    this.TAGNOGRABADOtxt.Visible = true;
                    this.BackColor = Color.Red;
                    break;
                default:                                //palet completo, pantalla MARRON
                    this.PALETCOMPLETOtxt.Visible = true;
                    this.BackColor = Color.Brown;
                    break;
            }

        }

        public void cambio_color(Color colear)
        {
            this.BackColor = colear;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();     // Se para el timer.
            this.Close();      // Cerramos el formulario.
        }
	}
}
