using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace CAGProveedores
{
    public partial class Frm_Opciones : Form
    {
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public Frm_Opciones()
        {
            InitializeComponent();
            Tiempo_textBox.Text = tiempo_String;
            ruta_texbox.Text = rutalog;
            log_check.Checked = logactivo;
        }

        private void Guardar_btn_Click(object sender, EventArgs e)
        {
            tiempo_String = Tiempo_textBox.Text;
            rutalog = ruta_texbox.Text;
            logactivo = log_check.Checked;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            this.DialogResult = DialogResult.OK;
        }
        public bool logactivo
        {
            get
            {
                bool resultado = false;
                string tmp = ConfigurationManager.AppSettings["log_activa"];
                if (tmp.Equals("true") || tmp.Equals("True"))
                {
                    resultado = true;
                }
                return resultado;
            }
            set
            {
                if (value == true)
                    config.AppSettings.Settings["log_activa"].Value = "true";
                else
                    config.AppSettings.Settings["log_activa"].Value = "false";

            }
        }
        public string rutalog
        {
            get
            {
                return ConfigurationManager.AppSettings["ruta_log"];
            }
            set
            {
                config.AppSettings.Settings["ruta_log"].Value = value;
                //  config.Save(ConfigurationSaveMode.Modified);
            }
        }
        public string tiempo_String
        {
            get
            {
                return ConfigurationManager.AppSettings["tiempo"];
            }
            set
            {
                config.AppSettings.Settings["tiempo"].Value = value;
                // config.Save(ConfigurationSaveMode.Modified);
            }
        }

        private void Tiempo_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)13)
            {
                tiempo_String = Tiempo_textBox.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

    }
}
