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
        public Frm_Comprobacion(Color colear, int segundos, string mensaje)
        {
            InitializeComponent();
            this.BackColor = colear;
            timer1.Interval = segundos * 1000;    // pasamos de segundos a milisegundos

            if (!timer1.Enabled)
                timer1.Enabled = true;    // Activamos el Timer si no esta Enabled (Activado)

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
