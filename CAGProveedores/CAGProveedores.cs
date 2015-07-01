using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
namespace CAGProveedores
{
	public class CAGProveedores : Form
	{
		private IContainer components = null;
		private Button botonsalir;
		private Label Titulotxt;
		private PictureBox Logo;
		private Label cleuzetxt1;
		private Label cleuzetxt2;
		private Label cleuzetxt3;
		private Button grabarbtn;
		private Button leerbtn;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem arhivoToolStripMenuItem;
		private ToolStripMenuItem salirToolStripMenuItem;
		private ToolStripMenuItem configuraciónToolStripMenuItem;
		private ToolStripMenuItem configurarCOMToolStripMenuItem;
		private ToolStripMenuItem interfacesToolStripMenuItem;
		private SerialPort serialPort1;
		private ToolStripMenuItem desactivarSonidoToolStripMenuItem;
		public Form2 comconf;
		public string[] puertoscom;
		public bool sonido = true;
        private ToolStripMenuItem opcionesToolStripMenuItem;
		public string path_sonido = "";
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAGProveedores));
            this.botonsalir = new System.Windows.Forms.Button();
            this.Titulotxt = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.cleuzetxt1 = new System.Windows.Forms.Label();
            this.cleuzetxt2 = new System.Windows.Forms.Label();
            this.cleuzetxt3 = new System.Windows.Forms.Label();
            this.grabarbtn = new System.Windows.Forms.Button();
            this.leerbtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arhivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarCOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interfacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desactivarSonidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonsalir
            // 
            this.botonsalir.Location = new System.Drawing.Point(390, 166);
            this.botonsalir.Name = "botonsalir";
            this.botonsalir.Size = new System.Drawing.Size(76, 31);
            this.botonsalir.TabIndex = 42;
            this.botonsalir.Text = "Salir";
            this.botonsalir.UseVisualStyleBackColor = true;
            this.botonsalir.Click += new System.EventHandler(this.botonsalir_Click);
            // 
            // Titulotxt
            // 
            this.Titulotxt.AutoSize = true;
            this.Titulotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulotxt.Location = new System.Drawing.Point(12, 39);
            this.Titulotxt.Name = "Titulotxt";
            this.Titulotxt.Size = new System.Drawing.Size(178, 24);
            this.Titulotxt.TabIndex = 43;
            this.Titulotxt.Text = "CAG Proveedores";
            // 
            // Logo
            // 
            this.Logo.Image = global::Properties.Resources.Logo3;
            this.Logo.Location = new System.Drawing.Point(235, 38);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(300, 67);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Logo.TabIndex = 44;
            this.Logo.TabStop = false;
            // 
            // cleuzetxt1
            // 
            this.cleuzetxt1.AutoSize = true;
            this.cleuzetxt1.Location = new System.Drawing.Point(213, 217);
            this.cleuzetxt1.Name = "cleuzetxt1";
            this.cleuzetxt1.Size = new System.Drawing.Size(131, 13);
            this.cleuzetxt1.TabIndex = 49;
            this.cleuzetxt1.Text = "© Leuze electronic S.A.U.";
            // 
            // cleuzetxt2
            // 
            this.cleuzetxt2.AutoSize = true;
            this.cleuzetxt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleuzetxt2.Location = new System.Drawing.Point(113, 241);
            this.cleuzetxt2.Name = "cleuzetxt2";
            this.cleuzetxt2.Size = new System.Drawing.Size(334, 13);
            this.cleuzetxt2.TabIndex = 50;
            this.cleuzetxt2.Text = "La reproducción, publicacion, copiado o distribución  de este software ";
            // 
            // cleuzetxt3
            // 
            this.cleuzetxt3.AutoSize = true;
            this.cleuzetxt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleuzetxt3.Location = new System.Drawing.Point(91, 259);
            this.cleuzetxt3.Name = "cleuzetxt3";
            this.cleuzetxt3.Size = new System.Drawing.Size(381, 13);
            this.cleuzetxt3.TabIndex = 51;
            this.cleuzetxt3.Text = "de grabación queda prohibido salvo con autorización de Leuze electronic S.A.U.";
            // 
            // grabarbtn
            // 
            this.grabarbtn.Location = new System.Drawing.Point(108, 168);
            this.grabarbtn.Name = "grabarbtn";
            this.grabarbtn.Size = new System.Drawing.Size(82, 29);
            this.grabarbtn.TabIndex = 52;
            this.grabarbtn.Text = "Grabar";
            this.grabarbtn.UseVisualStyleBackColor = true;
            this.grabarbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // leerbtn
            // 
            this.leerbtn.Location = new System.Drawing.Point(251, 166);
            this.leerbtn.Name = "leerbtn";
            this.leerbtn.Size = new System.Drawing.Size(82, 29);
            this.leerbtn.TabIndex = 53;
            this.leerbtn.Text = "Leer";
            this.leerbtn.UseVisualStyleBackColor = true;
            this.leerbtn.Click += new System.EventHandler(this.leerbtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arhivoToolStripMenuItem,
            this.configuraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 24);
            this.menuStrip1.TabIndex = 176;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arhivoToolStripMenuItem
            // 
            this.arhivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.arhivoToolStripMenuItem.Name = "arhivoToolStripMenuItem";
            this.arhivoToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.arhivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.botonsalir_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarCOMToolStripMenuItem,
            this.desactivarSonidoToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.configuraciónToolStripMenuItem.Text = "Ajustes";
            // 
            // configurarCOMToolStripMenuItem
            // 
            this.configurarCOMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interfacesToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.configurarCOMToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.configurarCOMToolStripMenuItem.Name = "configurarCOMToolStripMenuItem";
            this.configurarCOMToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.configurarCOMToolStripMenuItem.Text = "Configuración del PC";
            this.configurarCOMToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // interfacesToolStripMenuItem
            // 
            this.interfacesToolStripMenuItem.Name = "interfacesToolStripMenuItem";
            this.interfacesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.interfacesToolStripMenuItem.Text = "Interfaz";
            this.interfacesToolStripMenuItem.Click += new System.EventHandler(this.interfacesToolStripMenuItem_Click);
            // 
            // desactivarSonidoToolStripMenuItem
            // 
            this.desactivarSonidoToolStripMenuItem.Name = "desactivarSonidoToolStripMenuItem";
            this.desactivarSonidoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.desactivarSonidoToolStripMenuItem.Text = "Desactivar sonido";
            this.desactivarSonidoToolStripMenuItem.Click += new System.EventHandler(this.desactivarSonidoToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            this.opcionesToolStripMenuItem.Click += new System.EventHandler(this.opcionesToolStripMenuItem_Click);
            // 
            // CAGProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(565, 301);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.leerbtn);
            this.Controls.Add(this.grabarbtn);
            this.Controls.Add(this.cleuzetxt3);
            this.Controls.Add(this.cleuzetxt2);
            this.Controls.Add(this.cleuzetxt1);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Titulotxt);
            this.Controls.Add(this.botonsalir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CAGProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAG Proveedores soft v2.4.1";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		public CAGProveedores()
		{
			this.InitializeComponent();
			this.puertoscom = SerialPort.GetPortNames();
			string path = Directory.GetCurrentDirectory() + "\\confcag.txt";
			if (File.Exists(path))
			{
				StreamReader streamReader = new StreamReader(path);
				string text = streamReader.ReadToEnd();
				streamReader.Close();
				int num = -1;
				do
				{
					num++;
				}
				while (text[num] != ',' & text[num] != ';');
				if (text[num] != ';')
				{
					string text2 = text.Substring(0, num);
					text = text.Substring(num + 1);
					this.serialPort1.PortName = text2;
					num = -1;
					do
					{
						num++;
					}
					while (text[num] != ',');
					text2 = text.Substring(0, num);
					text = text.Substring(num + 1);
					this.serialPort1.BaudRate = Convert.ToInt32(text2);
					num = -1;
					do
					{
						num++;
					}
					while (text[num] != ',');
					text2 = text.Substring(0, num);
					text = text.Substring(num + 1);
					this.serialPort1.DataBits = Convert.ToInt32(text2);
					num = -1;
					do
					{
						num++;
					}
					while (text[num] != ',');
					text2 = text.Substring(0, num);
					text = text.Substring(num + 1);
					if (text2 == "One")
					{
						this.serialPort1.StopBits = StopBits.One;
					}
					else
					{
						if (text2 == "Two")
						{
							this.serialPort1.StopBits = StopBits.Two;
						}
					}
					num = -1;
					do
					{
						num++;
					}
					while (text[num] != ';');
					text2 = text.Substring(0, num);
					text = text.Substring(num + 1);
					if (text2 == "None")
					{
						this.serialPort1.Parity = Parity.None;
					}
					else
					{
						if (text2 == "Odd")
						{
							this.serialPort1.Parity = Parity.Odd;
						}
						else
						{
							if (text2 == "Even")
							{
								this.serialPort1.Parity = Parity.Even;
							}
						}
					}
				}
				else
				{
					text = text.Substring(1);
				}
				num = 0;
				if (text[num] != ';')
				{
					num = -1;
					do
					{
						num++;
					}
					while (text[num] != ';');
					text = text.Substring(num + 1);
				}
				else
				{
					text = text.Substring(1);
				}
				num = 0;
				if (text[num] != ';')
				{
					num = -1;
					do
					{
						num++;
					}
					while (text[num] != ';');
					string text2 = text.Substring(0, num);
					if (text2 == "True")
					{
						this.sonido = true;
					}
					else
					{
						this.sonido = false;
						this.desactivarSonidoToolStripMenuItem.Text = "Activar sonido";
					}
				}
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			grabar grabar = new grabar(this.serialPort1.PortName, this.serialPort1.BaudRate, this.serialPort1.DataBits, this.serialPort1.StopBits.ToString(), this.serialPort1.Parity.ToString(), this.sonido);
			grabar.ShowDialog();
		}
		private void botonsalir_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void leerbtn_Click(object sender, EventArgs e)
		{
			leer leer = new leer(this.serialPort1.PortName, this.serialPort1.BaudRate, this.serialPort1.DataBits, this.serialPort1.StopBits.ToString(), this.serialPort1.Parity.ToString(), this.sonido);
			leer.ShowDialog();
		}
		private void interfacesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2 form = new Form2(this.puertoscom, this.serialPort1.PortName, this.serialPort1.BaudRate, this.serialPort1.DataBits, this.serialPort1.StopBits.ToString(), this.serialPort1.Parity.ToString());
			form.ShowDialog();
			this.comconf = form;
			if (this.comconf.aceptar == 1)
			{
				this.serialPort1.Close();
				this.serialPort1.PortName = this.comconf.com;
				this.serialPort1.BaudRate = this.comconf.baud;
				this.serialPort1.DataBits = this.comconf.numbit;
				this.serialPort1.StopBits = this.comconf.bitstop;
				this.serialPort1.Parity = this.comconf.parity;
			}
		}
		private void desactivarSonidoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string path = Directory.GetCurrentDirectory() + "\\confcag.txt";
			string text = ";;";
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
				do
				{
					num++;
				}
				while (text[num] != ';');
				text = text.Substring(0, num + 1);
			}
			StreamWriter streamWriter = new StreamWriter(path);
			if (this.sonido)
			{
				streamWriter.WriteLine(text + "False;");
				this.desactivarSonidoToolStripMenuItem.Text = "Activar sonido";
				this.sonido = false;
			}
			else
			{
				streamWriter.WriteLine(text + "True;");
				this.desactivarSonidoToolStripMenuItem.Text = "Desactivar sonido";
				this.sonido = true;
			}
			streamWriter.Close();
		}

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* Frm_Opciones opt = new Frm_Opciones();
            opt.ShowDialog();
            if (opt.DialogResult == DialogResult.OK)
            {
                hay_log = opt.logactivo;
                ruta_newLog = opt.rutalog;
                if (!System.IO.Directory.Exists(ruta_newLog))
                {
                    System.IO.Directory.CreateDirectory(ruta_newLog);
                }
                fich_newLog = ruta_newLog + @"\" + DateTime.Today.ToString("dd_MM_yyyy") + "_Cag_control.csv";
            }*/
        }
	}
}
