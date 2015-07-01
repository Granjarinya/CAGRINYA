using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
namespace CAGProveedores
{
	public class Form2 : Form
	{
		public string com;
		public int baud;
		public int aceptar;
		public int numbit;
		public StopBits bitstop;
		public Parity parity;
		private IContainer components = null;
		private GroupBox grupoopciones;
		private Label baudiostxt;
		private Label puertotxt;
		private ComboBox puerto;
		private RadioButton dosbitsstop;
		private RadioButton unbitstop;
		private RadioButton sietebits;
		private RadioButton ochobits;
		private ComboBox baudios;
		private RadioButton paridadimpar;
		private RadioButton paridadpar;
		private RadioButton sinparidad;
		private Button aceptarbtn;
		private Button cancelarbtn;
		private GroupBox gruponumbit;
		private GroupBox grupoparidad;
		private GroupBox grupobitstop;
		public Form2(string[] puertospc, string puertocom, int puertobaud, int nbit, string sbit, string paridad)
		{
			this.InitializeComponent();
			this.aceptar = 0;
			this.puerto.Items.AddRange(puertospc);
			this.puerto.Text = puertocom;
			this.com = puertocom;
			this.baudios.Text = puertobaud.ToString();
			this.baud = puertobaud;
			if (nbit == 8)
			{
				this.ochobits.Checked = true;
				this.numbit = 8;
			}
			else
			{
				if (nbit == 7)
				{
					this.sietebits.Checked = true;
					this.numbit = 7;
				}
			}
			if (sbit == "One")
			{
				this.unbitstop.Checked = true;
				this.bitstop = StopBits.One;
			}
			else
			{
				if (sbit == "Two")
				{
					this.dosbitsstop.Checked = true;
					this.bitstop = StopBits.Two;
				}
			}
			if (paridad == "None")
			{
				this.sinparidad.Checked = true;
				this.parity = Parity.None;
			}
			else
			{
				if (paridad == "Odd")
				{
					this.paridadimpar.Checked = true;
					this.parity = Parity.Odd;
				}
				else
				{
					if (paridad == "Even")
					{
						this.paridadpar.Checked = true;
						this.parity = Parity.Even;
					}
				}
			}
		}
		private void aceptarbtn_Click(object sender, EventArgs e)
		{
			this.aceptar = 1;
			string path = Directory.GetCurrentDirectory() + "\\confcag.txt";
			string text = ";;;";
			if (File.Exists(path))
			{
				StreamReader streamReader = new StreamReader(path);
				text = streamReader.ReadToEnd();
				streamReader.Close();
				int num = -1;
				do
				{
					num++;
				}
				while (text[num] != ';');
				text = text.Substring(num);
			}
			StreamWriter streamWriter = new StreamWriter(path);
			streamWriter.WriteLine(string.Concat(new object[]
			{
				this.com,
				",",
				this.baud,
				",",
				this.numbit,
				",",
				this.bitstop,
				",",
				this.parity,
				text
			}));
			streamWriter.Close();
			base.Close();
		}
		private void cancelarbtn_Click(object sender, EventArgs e)
		{
			base.Close();
		}
		private void puerto_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.com = this.puerto.Text;
		}
		private void baudios_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.baud = Convert.ToInt32(this.baudios.Text);
		}
		private void ochobits_CheckedChanged(object sender, EventArgs e)
		{
			this.numbit = 8;
		}
		private void sietebits_CheckedChanged(object sender, EventArgs e)
		{
			this.numbit = 7;
		}
		private void unbitstop_CheckedChanged(object sender, EventArgs e)
		{
			this.bitstop = StopBits.One;
		}
		private void dosbitsstop_CheckedChanged(object sender, EventArgs e)
		{
			this.bitstop = StopBits.Two;
		}
		private void sinparidad_CheckedChanged(object sender, EventArgs e)
		{
			this.parity = Parity.None;
		}
		private void paridadpar_CheckedChanged(object sender, EventArgs e)
		{
			this.parity = Parity.Even;
		}
		private void paridadimpar_CheckedChanged(object sender, EventArgs e)
		{
			this.parity = Parity.Odd;
		}
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.grupoopciones = new System.Windows.Forms.GroupBox();
            this.grupoparidad = new System.Windows.Forms.GroupBox();
            this.sinparidad = new System.Windows.Forms.RadioButton();
            this.paridadimpar = new System.Windows.Forms.RadioButton();
            this.paridadpar = new System.Windows.Forms.RadioButton();
            this.grupobitstop = new System.Windows.Forms.GroupBox();
            this.unbitstop = new System.Windows.Forms.RadioButton();
            this.dosbitsstop = new System.Windows.Forms.RadioButton();
            this.gruponumbit = new System.Windows.Forms.GroupBox();
            this.sietebits = new System.Windows.Forms.RadioButton();
            this.ochobits = new System.Windows.Forms.RadioButton();
            this.baudios = new System.Windows.Forms.ComboBox();
            this.baudiostxt = new System.Windows.Forms.Label();
            this.puertotxt = new System.Windows.Forms.Label();
            this.puerto = new System.Windows.Forms.ComboBox();
            this.aceptarbtn = new System.Windows.Forms.Button();
            this.cancelarbtn = new System.Windows.Forms.Button();
            this.grupoopciones.SuspendLayout();
            this.grupoparidad.SuspendLayout();
            this.grupobitstop.SuspendLayout();
            this.gruponumbit.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupoopciones
            // 
            this.grupoopciones.Controls.Add(this.grupoparidad);
            this.grupoopciones.Controls.Add(this.grupobitstop);
            this.grupoopciones.Controls.Add(this.gruponumbit);
            this.grupoopciones.Controls.Add(this.baudios);
            this.grupoopciones.Controls.Add(this.baudiostxt);
            this.grupoopciones.Controls.Add(this.puertotxt);
            this.grupoopciones.Controls.Add(this.puerto);
            this.grupoopciones.Location = new System.Drawing.Point(12, 12);
            this.grupoopciones.Name = "grupoopciones";
            this.grupoopciones.Size = new System.Drawing.Size(260, 245);
            this.grupoopciones.TabIndex = 3;
            this.grupoopciones.TabStop = false;
            this.grupoopciones.Text = "Opciones";
            // 
            // grupoparidad
            // 
            this.grupoparidad.Controls.Add(this.sinparidad);
            this.grupoparidad.Controls.Add(this.paridadimpar);
            this.grupoparidad.Controls.Add(this.paridadpar);
            this.grupoparidad.Location = new System.Drawing.Point(11, 170);
            this.grupoparidad.Name = "grupoparidad";
            this.grupoparidad.Size = new System.Drawing.Size(238, 68);
            this.grupoparidad.TabIndex = 16;
            this.grupoparidad.TabStop = false;
            this.grupoparidad.Text = "Paridad";
            // 
            // sinparidad
            // 
            this.sinparidad.AutoSize = true;
            this.sinparidad.Checked = true;
            this.sinparidad.Location = new System.Drawing.Point(60, 19);
            this.sinparidad.Name = "sinparidad";
            this.sinparidad.Size = new System.Drawing.Size(78, 17);
            this.sinparidad.TabIndex = 11;
            this.sinparidad.TabStop = true;
            this.sinparidad.Text = "Sin paridad";
            this.sinparidad.UseVisualStyleBackColor = true;
            this.sinparidad.CheckedChanged += new System.EventHandler(this.sinparidad_CheckedChanged);
            // 
            // paridadimpar
            // 
            this.paridadimpar.AutoSize = true;
            this.paridadimpar.Location = new System.Drawing.Point(144, 42);
            this.paridadimpar.Name = "paridadimpar";
            this.paridadimpar.Size = new System.Drawing.Size(90, 17);
            this.paridadimpar.TabIndex = 13;
            this.paridadimpar.Text = "Paridad Impar";
            this.paridadimpar.UseVisualStyleBackColor = true;
            this.paridadimpar.CheckedChanged += new System.EventHandler(this.paridadimpar_CheckedChanged);
            // 
            // paridadpar
            // 
            this.paridadpar.AutoSize = true;
            this.paridadpar.Location = new System.Drawing.Point(144, 19);
            this.paridadpar.Name = "paridadpar";
            this.paridadpar.Size = new System.Drawing.Size(80, 17);
            this.paridadpar.TabIndex = 12;
            this.paridadpar.Text = "Paridad Par";
            this.paridadpar.UseVisualStyleBackColor = true;
            this.paridadpar.CheckedChanged += new System.EventHandler(this.paridadpar_CheckedChanged);
            // 
            // grupobitstop
            // 
            this.grupobitstop.Controls.Add(this.unbitstop);
            this.grupobitstop.Controls.Add(this.dosbitsstop);
            this.grupobitstop.Location = new System.Drawing.Point(9, 128);
            this.grupobitstop.Name = "grupobitstop";
            this.grupobitstop.Size = new System.Drawing.Size(241, 38);
            this.grupobitstop.TabIndex = 15;
            this.grupobitstop.TabStop = false;
            this.grupobitstop.Text = "Bits de stop";
            // 
            // unbitstop
            // 
            this.unbitstop.AutoSize = true;
            this.unbitstop.Checked = true;
            this.unbitstop.Location = new System.Drawing.Point(106, 15);
            this.unbitstop.Name = "unbitstop";
            this.unbitstop.Size = new System.Drawing.Size(45, 17);
            this.unbitstop.TabIndex = 8;
            this.unbitstop.TabStop = true;
            this.unbitstop.Text = "1 bit";
            this.unbitstop.UseVisualStyleBackColor = true;
            this.unbitstop.CheckedChanged += new System.EventHandler(this.unbitstop_CheckedChanged);
            // 
            // dosbitsstop
            // 
            this.dosbitsstop.AutoSize = true;
            this.dosbitsstop.Location = new System.Drawing.Point(185, 15);
            this.dosbitsstop.Name = "dosbitsstop";
            this.dosbitsstop.Size = new System.Drawing.Size(50, 17);
            this.dosbitsstop.TabIndex = 9;
            this.dosbitsstop.Text = "2 bits";
            this.dosbitsstop.UseVisualStyleBackColor = true;
            this.dosbitsstop.CheckedChanged += new System.EventHandler(this.dosbitsstop_CheckedChanged);
            // 
            // gruponumbit
            // 
            this.gruponumbit.Controls.Add(this.sietebits);
            this.gruponumbit.Controls.Add(this.ochobits);
            this.gruponumbit.Location = new System.Drawing.Point(9, 84);
            this.gruponumbit.Name = "gruponumbit";
            this.gruponumbit.Size = new System.Drawing.Size(241, 38);
            this.gruponumbit.TabIndex = 14;
            this.gruponumbit.TabStop = false;
            this.gruponumbit.Text = "Numero de bits";
            // 
            // sietebits
            // 
            this.sietebits.AutoSize = true;
            this.sietebits.Location = new System.Drawing.Point(106, 15);
            this.sietebits.Name = "sietebits";
            this.sietebits.Size = new System.Drawing.Size(50, 17);
            this.sietebits.TabIndex = 6;
            this.sietebits.Text = "7 bits";
            this.sietebits.UseVisualStyleBackColor = true;
            this.sietebits.CheckedChanged += new System.EventHandler(this.sietebits_CheckedChanged);
            // 
            // ochobits
            // 
            this.ochobits.AutoSize = true;
            this.ochobits.Checked = true;
            this.ochobits.Cursor = System.Windows.Forms.Cursors.Default;
            this.ochobits.Location = new System.Drawing.Point(185, 15);
            this.ochobits.Name = "ochobits";
            this.ochobits.Size = new System.Drawing.Size(50, 17);
            this.ochobits.TabIndex = 5;
            this.ochobits.TabStop = true;
            this.ochobits.Text = "8 bits";
            this.ochobits.UseVisualStyleBackColor = true;
            this.ochobits.CheckedChanged += new System.EventHandler(this.ochobits_CheckedChanged);
            // 
            // baudios
            // 
            this.baudios.FormattingEnabled = true;
            this.baudios.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.baudios.Location = new System.Drawing.Point(127, 57);
            this.baudios.Name = "baudios";
            this.baudios.Size = new System.Drawing.Size(99, 21);
            this.baudios.TabIndex = 3;
            this.baudios.SelectedIndexChanged += new System.EventHandler(this.baudios_SelectedIndexChanged);
            // 
            // baudiostxt
            // 
            this.baudiostxt.AutoSize = true;
            this.baudiostxt.Location = new System.Drawing.Point(62, 60);
            this.baudiostxt.Name = "baudiostxt";
            this.baudiostxt.Size = new System.Drawing.Size(51, 13);
            this.baudiostxt.TabIndex = 2;
            this.baudiostxt.Text = "Baudios :";
            // 
            // puertotxt
            // 
            this.puertotxt.AutoSize = true;
            this.puertotxt.Location = new System.Drawing.Point(6, 26);
            this.puertotxt.Name = "puertotxt";
            this.puertotxt.Size = new System.Drawing.Size(107, 13);
            this.puertotxt.TabIndex = 1;
            this.puertotxt.Text = "Interfaz Puerto serie :";
            // 
            // puerto
            // 
            this.puerto.FormattingEnabled = true;
            this.puerto.Location = new System.Drawing.Point(127, 23);
            this.puerto.Name = "puerto";
            this.puerto.Size = new System.Drawing.Size(99, 21);
            this.puerto.TabIndex = 0;
            this.puerto.SelectedIndexChanged += new System.EventHandler(this.puerto_SelectedIndexChanged);
            // 
            // aceptarbtn
            // 
            this.aceptarbtn.Location = new System.Drawing.Point(12, 270);
            this.aceptarbtn.Name = "aceptarbtn";
            this.aceptarbtn.Size = new System.Drawing.Size(96, 30);
            this.aceptarbtn.TabIndex = 4;
            this.aceptarbtn.Text = "Aceptar";
            this.aceptarbtn.UseVisualStyleBackColor = true;
            this.aceptarbtn.Click += new System.EventHandler(this.aceptarbtn_Click);
            // 
            // cancelarbtn
            // 
            this.cancelarbtn.Location = new System.Drawing.Point(177, 270);
            this.cancelarbtn.Name = "cancelarbtn";
            this.cancelarbtn.Size = new System.Drawing.Size(95, 30);
            this.cancelarbtn.TabIndex = 5;
            this.cancelarbtn.Text = "Cancelar";
            this.cancelarbtn.UseVisualStyleBackColor = true;
            this.cancelarbtn.Click += new System.EventHandler(this.cancelarbtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.cancelarbtn);
            this.Controls.Add(this.aceptarbtn);
            this.Controls.Add(this.grupoopciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuración del PC";
            this.grupoopciones.ResumeLayout(false);
            this.grupoopciones.PerformLayout();
            this.grupoparidad.ResumeLayout(false);
            this.grupoparidad.PerformLayout();
            this.grupobitstop.ResumeLayout(false);
            this.grupobitstop.PerformLayout();
            this.gruponumbit.ResumeLayout(false);
            this.gruponumbit.PerformLayout();
            this.ResumeLayout(false);

		}
	}
}
