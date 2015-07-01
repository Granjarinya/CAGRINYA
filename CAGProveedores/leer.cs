using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Media;
using System.Text;
using System.Windows.Forms;
namespace CAGProveedores
{
	public class leer : Form
	{
		private IContainer components = null;
		private Button leerbtn;
		private ToolStripMenuItem configuraciónToolStripMenuItem;
		private ToolStripMenuItem configurarCOMToolStripMenuItem;
		private ToolStripMenuItem interfacesToolStripMenuItem;
		private Label logtxt;
		private Button modobtn;
		private Label modotxt;
		private Label lecturatag;
		private Label comprobaciontxt;
		private TextBox Recibido;
		private Label cleuzetxt3;
		private Label cleuzetxt2;
		private Label cleuzetxt1;
		private Label confirmaciontxt;
		private PictureBox Logo;
		private Label Titulotxt;
		private Button botonsalir;
		private Label libre2ej;
		private Label libre1ej;
		private Label identificadorej;
		private Label numeroej;
		private Label pesoej;
		private Label pvpej;
		private Label unidadesej;
		private Label fechafabricacionej;
		private Label tipoej;
		private Label diasej;
		private Label fechacaducidadej;
		private Label destinoej;
		private Label codigoej;
		private Label identificador;
		private TextBox identificadortxt;
		private TextBox numerotxt;
		private Label numero;
		private TextBox libre2txt;
		private Label libre2;
		private TextBox pesotxt;
		private Label peso;
		private TextBox pvptxt;
		private Label pvp;
		private TextBox unidadestxt;
		private Label unidades;
		private Label libre1;
		private TextBox libre1txt;
		private TextBox fechafabricaciontxt;
		private Label fechafabricacion;
		private TextBox tipotxt;
		private Label tipo;
		private TextBox diastxt;
		private Label dias;
		private TextBox fechacaducidadtxt;
		private Label fechacaducidad;
		private TextBox destinotxt;
		private Label Codigo;
		private ToolStripMenuItem salirToolStripMenuItem;
		private Label destino;
		private TextBox codigotxt;
		private ToolStripMenuItem arhivoToolStripMenuItem;
		private ToolStripMenuItem crearLogToolStripMenuItem;
		private MenuStrip menuStrip1;
		private SerialPort serialPort1;
		private Label contador_txt;
		private ToolStripMenuItem desactivarSonidoToolStripMenuItem;
		public int[] leido = new int[100];
		private char[] envio = new char[100];
		public int[] tagleido = new int[50];
		public int buffleido = -1;
		public int edicion = 0;
		public int modo = 0;
		public int inicio = 0;
		public int auto = 0;
		public int logactivo = 0;
		public int auxauto = 0;
		public int grabadook = 0;
		public int auxcomplect = 0;
		public int finallectura = 0;
		public int bits;
		public int x;
		public int comprobar;
		public Form2 comconf;
		public string[] puertoscom;
		public string log;
		public int contador;
        public SoundPlayer soundPlayer = new SoundPlayer();
		public bool sonido;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(leer));
            this.leerbtn = new System.Windows.Forms.Button();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarCOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interfacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desactivarSonidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logtxt = new System.Windows.Forms.Label();
            this.modobtn = new System.Windows.Forms.Button();
            this.modotxt = new System.Windows.Forms.Label();
            this.lecturatag = new System.Windows.Forms.Label();
            this.comprobaciontxt = new System.Windows.Forms.Label();
            this.Recibido = new System.Windows.Forms.TextBox();
            this.cleuzetxt3 = new System.Windows.Forms.Label();
            this.cleuzetxt2 = new System.Windows.Forms.Label();
            this.cleuzetxt1 = new System.Windows.Forms.Label();
            this.confirmaciontxt = new System.Windows.Forms.Label();
            this.Titulotxt = new System.Windows.Forms.Label();
            this.botonsalir = new System.Windows.Forms.Button();
            this.libre2ej = new System.Windows.Forms.Label();
            this.libre1ej = new System.Windows.Forms.Label();
            this.identificadorej = new System.Windows.Forms.Label();
            this.numeroej = new System.Windows.Forms.Label();
            this.pesoej = new System.Windows.Forms.Label();
            this.pvpej = new System.Windows.Forms.Label();
            this.unidadesej = new System.Windows.Forms.Label();
            this.fechafabricacionej = new System.Windows.Forms.Label();
            this.tipoej = new System.Windows.Forms.Label();
            this.diasej = new System.Windows.Forms.Label();
            this.fechacaducidadej = new System.Windows.Forms.Label();
            this.destinoej = new System.Windows.Forms.Label();
            this.codigoej = new System.Windows.Forms.Label();
            this.identificador = new System.Windows.Forms.Label();
            this.identificadortxt = new System.Windows.Forms.TextBox();
            this.numerotxt = new System.Windows.Forms.TextBox();
            this.numero = new System.Windows.Forms.Label();
            this.libre2txt = new System.Windows.Forms.TextBox();
            this.libre2 = new System.Windows.Forms.Label();
            this.pesotxt = new System.Windows.Forms.TextBox();
            this.peso = new System.Windows.Forms.Label();
            this.pvptxt = new System.Windows.Forms.TextBox();
            this.pvp = new System.Windows.Forms.Label();
            this.unidadestxt = new System.Windows.Forms.TextBox();
            this.unidades = new System.Windows.Forms.Label();
            this.libre1 = new System.Windows.Forms.Label();
            this.libre1txt = new System.Windows.Forms.TextBox();
            this.fechafabricaciontxt = new System.Windows.Forms.TextBox();
            this.fechafabricacion = new System.Windows.Forms.Label();
            this.tipotxt = new System.Windows.Forms.TextBox();
            this.tipo = new System.Windows.Forms.Label();
            this.diastxt = new System.Windows.Forms.TextBox();
            this.dias = new System.Windows.Forms.Label();
            this.fechacaducidadtxt = new System.Windows.Forms.TextBox();
            this.fechacaducidad = new System.Windows.Forms.Label();
            this.destinotxt = new System.Windows.Forms.TextBox();
            this.Codigo = new System.Windows.Forms.Label();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destino = new System.Windows.Forms.Label();
            this.codigotxt = new System.Windows.Forms.TextBox();
            this.arhivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.contador_txt = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // leerbtn
            // 
            this.leerbtn.Location = new System.Drawing.Point(577, 419);
            this.leerbtn.Name = "leerbtn";
            this.leerbtn.Size = new System.Drawing.Size(76, 31);
            this.leerbtn.TabIndex = 176;
            this.leerbtn.Text = "Leer";
            this.leerbtn.UseVisualStyleBackColor = true;
            this.leerbtn.Click += new System.EventHandler(this.leerbtn_Click);
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
            this.interfacesToolStripMenuItem});
            this.configurarCOMToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.configurarCOMToolStripMenuItem.Name = "configurarCOMToolStripMenuItem";
            this.configurarCOMToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.configurarCOMToolStripMenuItem.Text = "Configuración del PC";
            this.configurarCOMToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // interfacesToolStripMenuItem
            // 
            this.interfacesToolStripMenuItem.Name = "interfacesToolStripMenuItem";
            this.interfacesToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
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
            // logtxt
            // 
            this.logtxt.AutoSize = true;
            this.logtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logtxt.Location = new System.Drawing.Point(659, 391);
            this.logtxt.Name = "logtxt";
            this.logtxt.Size = new System.Drawing.Size(118, 13);
            this.logtxt.TabIndex = 177;
            this.logtxt.Text = "Registro Log activo";
            this.logtxt.Visible = false;
            // 
            // modobtn
            // 
            this.modobtn.Location = new System.Drawing.Point(25, 83);
            this.modobtn.Name = "modobtn";
            this.modobtn.Size = new System.Drawing.Size(118, 28);
            this.modobtn.TabIndex = 174;
            this.modobtn.Text = "Cambiar a Automático";
            this.modobtn.UseVisualStyleBackColor = true;
            this.modobtn.Click += new System.EventHandler(this.modobtn_Click);
            // 
            // modotxt
            // 
            this.modotxt.AutoSize = true;
            this.modotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modotxt.ForeColor = System.Drawing.Color.Red;
            this.modotxt.Location = new System.Drawing.Point(186, 89);
            this.modotxt.Name = "modotxt";
            this.modotxt.Size = new System.Drawing.Size(150, 17);
            this.modotxt.TabIndex = 173;
            this.modotxt.Text = "Modo Manual activado";
            // 
            // lecturatag
            // 
            this.lecturatag.AutoSize = true;
            this.lecturatag.Location = new System.Drawing.Point(57, 437);
            this.lecturatag.Name = "lecturatag";
            this.lecturatag.Size = new System.Drawing.Size(0, 13);
            this.lecturatag.TabIndex = 172;
            // 
            // comprobaciontxt
            // 
            this.comprobaciontxt.AutoSize = true;
            this.comprobaciontxt.ForeColor = System.Drawing.Color.Red;
            this.comprobaciontxt.Location = new System.Drawing.Point(491, 391);
            this.comprobaciontxt.Name = "comprobaciontxt";
            this.comprobaciontxt.Size = new System.Drawing.Size(0, 13);
            this.comprobaciontxt.TabIndex = 171;
            // 
            // Recibido
            // 
            this.Recibido.Location = new System.Drawing.Point(8, 498);
            this.Recibido.Name = "Recibido";
            this.Recibido.Size = new System.Drawing.Size(203, 20);
            this.Recibido.TabIndex = 170;
            this.Recibido.Visible = false;
            // 
            // cleuzetxt3
            // 
            this.cleuzetxt3.AutoSize = true;
            this.cleuzetxt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleuzetxt3.Location = new System.Drawing.Point(232, 511);
            this.cleuzetxt3.Name = "cleuzetxt3";
            this.cleuzetxt3.Size = new System.Drawing.Size(381, 13);
            this.cleuzetxt3.TabIndex = 169;
            this.cleuzetxt3.Text = "de grabación queda prohibido salvo con autorización de Leuze electronic S.A.U.";
            // 
            // cleuzetxt2
            // 
            this.cleuzetxt2.AutoSize = true;
            this.cleuzetxt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleuzetxt2.Location = new System.Drawing.Point(254, 493);
            this.cleuzetxt2.Name = "cleuzetxt2";
            this.cleuzetxt2.Size = new System.Drawing.Size(334, 13);
            this.cleuzetxt2.TabIndex = 168;
            this.cleuzetxt2.Text = "La reproducción, publicacion, copiado o distribución  de este software ";
            // 
            // cleuzetxt1
            // 
            this.cleuzetxt1.AutoSize = true;
            this.cleuzetxt1.Location = new System.Drawing.Point(354, 469);
            this.cleuzetxt1.Name = "cleuzetxt1";
            this.cleuzetxt1.Size = new System.Drawing.Size(131, 13);
            this.cleuzetxt1.TabIndex = 167;
            this.cleuzetxt1.Text = "© Leuze electronic S.A.U.";
            // 
            // confirmaciontxt
            // 
            this.confirmaciontxt.AutoSize = true;
            this.confirmaciontxt.BackColor = System.Drawing.SystemColors.Control;
            this.confirmaciontxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmaciontxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.confirmaciontxt.Location = new System.Drawing.Point(68, 402);
            this.confirmaciontxt.Name = "confirmaciontxt";
            this.confirmaciontxt.Size = new System.Drawing.Size(0, 24);
            this.confirmaciontxt.TabIndex = 166;
            // 
            // Titulotxt
            // 
            this.Titulotxt.AutoSize = true;
            this.Titulotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulotxt.Location = new System.Drawing.Point(8, 37);
            this.Titulotxt.Name = "Titulotxt";
            this.Titulotxt.Size = new System.Drawing.Size(178, 24);
            this.Titulotxt.TabIndex = 164;
            this.Titulotxt.Text = "CAG Proveedores";
            // 
            // botonsalir
            // 
            this.botonsalir.Location = new System.Drawing.Point(701, 419);
            this.botonsalir.Name = "botonsalir";
            this.botonsalir.Size = new System.Drawing.Size(76, 31);
            this.botonsalir.TabIndex = 163;
            this.botonsalir.Text = "Salir";
            this.botonsalir.UseVisualStyleBackColor = true;
            this.botonsalir.Click += new System.EventHandler(this.botonsalir_Click);
            // 
            // libre2ej
            // 
            this.libre2ej.AutoSize = true;
            this.libre2ej.Location = new System.Drawing.Point(703, 281);
            this.libre2ej.Name = "libre2ej";
            this.libre2ej.Size = new System.Drawing.Size(47, 13);
            this.libre2ej.TabIndex = 162;
            this.libre2ej.Text = "(1 digito)";
            // 
            // libre1ej
            // 
            this.libre1ej.AutoSize = true;
            this.libre1ej.Location = new System.Drawing.Point(699, 137);
            this.libre1ej.Name = "libre1ej";
            this.libre1ej.Size = new System.Drawing.Size(52, 13);
            this.libre1ej.TabIndex = 161;
            this.libre1ej.Text = "(2 digitos)";
            // 
            // identificadorej
            // 
            this.identificadorej.AutoSize = true;
            this.identificadorej.Location = new System.Drawing.Point(698, 352);
            this.identificadorej.Name = "identificadorej";
            this.identificadorej.Size = new System.Drawing.Size(64, 13);
            this.identificadorej.TabIndex = 158;
            this.identificadorej.Text = "(0000-9999)";
            // 
            // numeroej
            // 
            this.numeroej.AutoSize = true;
            this.numeroej.Location = new System.Drawing.Point(698, 316);
            this.numeroej.Name = "numeroej";
            this.numeroej.Size = new System.Drawing.Size(64, 13);
            this.numeroej.TabIndex = 157;
            this.numeroej.Text = "(0000-9999)";
            // 
            // pesoej
            // 
            this.pesoej.AutoSize = true;
            this.pesoej.Location = new System.Drawing.Point(698, 242);
            this.pesoej.Name = "pesoej";
            this.pesoej.Size = new System.Drawing.Size(116, 13);
            this.pesoej.TabIndex = 156;
            this.pesoej.Text = "(4 enteros 3 decimales)";
            // 
            // pvpej
            // 
            this.pvpej.AutoSize = true;
            this.pvpej.Location = new System.Drawing.Point(698, 210);
            this.pvpej.Name = "pvpej";
            this.pvpej.Size = new System.Drawing.Size(116, 13);
            this.pvpej.TabIndex = 155;
            this.pvpej.Text = "(3 enteros 2 decimales)";
            // 
            // unidadesej
            // 
            this.unidadesej.AutoSize = true;
            this.unidadesej.Location = new System.Drawing.Point(698, 177);
            this.unidadesej.Name = "unidadesej";
            this.unidadesej.Size = new System.Drawing.Size(52, 13);
            this.unidadesej.TabIndex = 154;
            this.unidadesej.Text = "(000-999)";
            // 
            // fechafabricacionej
            // 
            this.fechafabricacionej.AutoSize = true;
            this.fechafabricacionej.Location = new System.Drawing.Point(290, 345);
            this.fechafabricacionej.Name = "fechafabricacionej";
            this.fechafabricacionej.Size = new System.Drawing.Size(53, 13);
            this.fechafabricacionej.TabIndex = 153;
            this.fechafabricacionej.Text = "(aammdd)";
            // 
            // tipoej
            // 
            this.tipoej.AutoSize = true;
            this.tipoej.Location = new System.Drawing.Point(290, 301);
            this.tipoej.Name = "tipoej";
            this.tipoej.Size = new System.Drawing.Size(28, 13);
            this.tipoej.TabIndex = 152;
            this.tipoej.Text = "(0-9)";
            // 
            // diasej
            // 
            this.diasej.AutoSize = true;
            this.diasej.Location = new System.Drawing.Point(290, 265);
            this.diasej.Name = "diasej";
            this.diasej.Size = new System.Drawing.Size(46, 13);
            this.diasej.TabIndex = 151;
            this.diasej.Text = "(0,1,2,3)";
            // 
            // fechacaducidadej
            // 
            this.fechacaducidadej.AutoSize = true;
            this.fechacaducidadej.Location = new System.Drawing.Point(290, 228);
            this.fechacaducidadej.Name = "fechacaducidadej";
            this.fechacaducidadej.Size = new System.Drawing.Size(53, 13);
            this.fechacaducidadej.TabIndex = 150;
            this.fechacaducidadej.Text = "(aammdd)";
            // 
            // destinoej
            // 
            this.destinoej.AutoSize = true;
            this.destinoej.Location = new System.Drawing.Point(290, 188);
            this.destinoej.Name = "destinoej";
            this.destinoej.Size = new System.Drawing.Size(28, 13);
            this.destinoej.TabIndex = 149;
            this.destinoej.Text = "(0-9)";
            // 
            // codigoej
            // 
            this.codigoej.AutoSize = true;
            this.codigoej.Location = new System.Drawing.Point(290, 147);
            this.codigoej.Name = "codigoej";
            this.codigoej.Size = new System.Drawing.Size(100, 13);
            this.codigoej.TabIndex = 148;
            this.codigoej.Text = "(0000000-9999999)";
            // 
            // identificador
            // 
            this.identificador.AutoSize = true;
            this.identificador.Location = new System.Drawing.Point(403, 352);
            this.identificador.Name = "identificador";
            this.identificador.Size = new System.Drawing.Size(148, 13);
            this.identificador.TabIndex = 147;
            this.identificador.Text = "Identificador de etiquetadora :";
            // 
            // identificadortxt
            // 
            this.identificadortxt.Location = new System.Drawing.Point(577, 349);
            this.identificadortxt.MaxLength = 4;
            this.identificadortxt.Name = "identificadortxt";
            this.identificadortxt.ReadOnly = true;
            this.identificadortxt.Size = new System.Drawing.Size(105, 20);
            this.identificadortxt.TabIndex = 146;
            // 
            // numerotxt
            // 
            this.numerotxt.Location = new System.Drawing.Point(577, 313);
            this.numerotxt.MaxLength = 4;
            this.numerotxt.Name = "numerotxt";
            this.numerotxt.ReadOnly = true;
            this.numerotxt.Size = new System.Drawing.Size(105, 20);
            this.numerotxt.TabIndex = 145;
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.Location = new System.Drawing.Point(466, 315);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(85, 13);
            this.numero.TabIndex = 144;
            this.numero.Text = "Número de lote :";
            // 
            // libre2txt
            // 
            this.libre2txt.Location = new System.Drawing.Point(574, 278);
            this.libre2txt.MaxLength = 1;
            this.libre2txt.Name = "libre2txt";
            this.libre2txt.ReadOnly = true;
            this.libre2txt.Size = new System.Drawing.Size(108, 20);
            this.libre2txt.TabIndex = 143;
            // 
            // libre2
            // 
            this.libre2.AutoSize = true;
            this.libre2.Location = new System.Drawing.Point(474, 279);
            this.libre2.Name = "libre2";
            this.libre2.Size = new System.Drawing.Size(77, 13);
            this.libre2.TabIndex = 142;
            this.libre2.Text = "Campo libre 2 :";
            // 
            // pesotxt
            // 
            this.pesotxt.Location = new System.Drawing.Point(572, 239);
            this.pesotxt.MaxLength = 7;
            this.pesotxt.Name = "pesotxt";
            this.pesotxt.ReadOnly = true;
            this.pesotxt.Size = new System.Drawing.Size(113, 20);
            this.pesotxt.TabIndex = 141;
            // 
            // peso
            // 
            this.peso.AutoSize = true;
            this.peso.Location = new System.Drawing.Point(491, 242);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(60, 13);
            this.peso.TabIndex = 140;
            this.peso.Text = "Peso caja :";
            // 
            // pvptxt
            // 
            this.pvptxt.Location = new System.Drawing.Point(571, 207);
            this.pvptxt.MaxLength = 5;
            this.pvptxt.Name = "pvptxt";
            this.pvptxt.ReadOnly = true;
            this.pvptxt.Size = new System.Drawing.Size(115, 20);
            this.pvptxt.TabIndex = 139;
            // 
            // pvp
            // 
            this.pvp.AutoSize = true;
            this.pvp.Location = new System.Drawing.Point(517, 205);
            this.pvp.Name = "pvp";
            this.pvp.Size = new System.Drawing.Size(34, 13);
            this.pvp.TabIndex = 138;
            this.pvp.Text = "PVP :";
            // 
            // unidadestxt
            // 
            this.unidadestxt.Location = new System.Drawing.Point(572, 174);
            this.unidadestxt.MaxLength = 3;
            this.unidadestxt.Name = "unidadestxt";
            this.unidadestxt.ReadOnly = true;
            this.unidadestxt.Size = new System.Drawing.Size(111, 20);
            this.unidadestxt.TabIndex = 137;
            // 
            // unidades
            // 
            this.unidades.AutoSize = true;
            this.unidades.Location = new System.Drawing.Point(452, 172);
            this.unidades.Name = "unidades";
            this.unidades.Size = new System.Drawing.Size(99, 13);
            this.unidades.TabIndex = 136;
            this.unidades.Text = "Unidades por caja :";
            // 
            // libre1
            // 
            this.libre1.AutoSize = true;
            this.libre1.Location = new System.Drawing.Point(474, 140);
            this.libre1.Name = "libre1";
            this.libre1.Size = new System.Drawing.Size(77, 13);
            this.libre1.TabIndex = 135;
            this.libre1.Text = "Campo libre 1 :";
            // 
            // libre1txt
            // 
            this.libre1txt.Location = new System.Drawing.Point(570, 137);
            this.libre1txt.MaxLength = 2;
            this.libre1txt.Name = "libre1txt";
            this.libre1txt.ReadOnly = true;
            this.libre1txt.Size = new System.Drawing.Size(114, 20);
            this.libre1txt.TabIndex = 134;
            // 
            // fechafabricaciontxt
            // 
            this.fechafabricaciontxt.Location = new System.Drawing.Point(163, 338);
            this.fechafabricaciontxt.MaxLength = 6;
            this.fechafabricaciontxt.Name = "fechafabricaciontxt";
            this.fechafabricaciontxt.ReadOnly = true;
            this.fechafabricaciontxt.Size = new System.Drawing.Size(116, 20);
            this.fechafabricaciontxt.TabIndex = 133;
            // 
            // fechafabricacion
            // 
            this.fechafabricacion.AutoSize = true;
            this.fechafabricacion.Location = new System.Drawing.Point(30, 341);
            this.fechafabricacion.Name = "fechafabricacion";
            this.fechafabricacion.Size = new System.Drawing.Size(113, 13);
            this.fechafabricacion.TabIndex = 132;
            this.fechafabricacion.Text = "Fecha de fabricación :";
            // 
            // tipotxt
            // 
            this.tipotxt.Location = new System.Drawing.Point(162, 298);
            this.tipotxt.MaxLength = 1;
            this.tipotxt.Name = "tipotxt";
            this.tipotxt.ReadOnly = true;
            this.tipotxt.Size = new System.Drawing.Size(118, 20);
            this.tipotxt.TabIndex = 131;
            // 
            // tipo
            // 
            this.tipo.AutoSize = true;
            this.tipo.Location = new System.Drawing.Point(49, 301);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(94, 13);
            this.tipo.TabIndex = 130;
            this.tipo.Text = "Tipo de producto :";
            // 
            // diastxt
            // 
            this.diastxt.Location = new System.Drawing.Point(162, 262);
            this.diastxt.MaxLength = 1;
            this.diastxt.Name = "diastxt";
            this.diastxt.ReadOnly = true;
            this.diastxt.Size = new System.Drawing.Size(119, 20);
            this.diastxt.TabIndex = 129;
            // 
            // dias
            // 
            this.dias.AutoSize = true;
            this.dias.Location = new System.Drawing.Point(2, 265);
            this.dias.Name = "dias";
            this.dias.Size = new System.Drawing.Size(141, 13);
            this.dias.TabIndex = 128;
            this.dias.Text = "Días de más de caducidad :";
            // 
            // fechacaducidadtxt
            // 
            this.fechacaducidadtxt.Location = new System.Drawing.Point(163, 225);
            this.fechacaducidadtxt.MaxLength = 6;
            this.fechacaducidadtxt.Name = "fechacaducidadtxt";
            this.fechacaducidadtxt.ReadOnly = true;
            this.fechacaducidadtxt.Size = new System.Drawing.Size(118, 20);
            this.fechacaducidadtxt.TabIndex = 127;
            // 
            // fechacaducidad
            // 
            this.fechacaducidad.AutoSize = true;
            this.fechacaducidad.Location = new System.Drawing.Point(32, 228);
            this.fechacaducidad.Name = "fechacaducidad";
            this.fechacaducidad.Size = new System.Drawing.Size(111, 13);
            this.fechacaducidad.TabIndex = 126;
            this.fechacaducidad.Text = "Fecha de caducidad :";
            // 
            // destinotxt
            // 
            this.destinotxt.Location = new System.Drawing.Point(162, 185);
            this.destinotxt.MaxLength = 1;
            this.destinotxt.Name = "destinotxt";
            this.destinotxt.ReadOnly = true;
            this.destinotxt.Size = new System.Drawing.Size(119, 20);
            this.destinotxt.TabIndex = 125;
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Location = new System.Drawing.Point(45, 147);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(98, 13);
            this.Codigo.TabIndex = 122;
            this.Codigo.Text = "Código de articulo :";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // destino
            // 
            this.destino.AutoSize = true;
            this.destino.Location = new System.Drawing.Point(53, 188);
            this.destino.Name = "destino";
            this.destino.Size = new System.Drawing.Size(90, 13);
            this.destino.TabIndex = 124;
            this.destino.Text = "Destino de caja : ";
            // 
            // codigotxt
            // 
            this.codigotxt.Location = new System.Drawing.Point(162, 144);
            this.codigotxt.MaxLength = 7;
            this.codigotxt.Name = "codigotxt";
            this.codigotxt.ReadOnly = true;
            this.codigotxt.Size = new System.Drawing.Size(122, 20);
            this.codigotxt.TabIndex = 123;
            // 
            // arhivoToolStripMenuItem
            // 
            this.arhivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearLogToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.arhivoToolStripMenuItem.Name = "arhivoToolStripMenuItem";
            this.arhivoToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.arhivoToolStripMenuItem.Text = "Archivo";
            // 
            // crearLogToolStripMenuItem
            // 
            this.crearLogToolStripMenuItem.Name = "crearLogToolStripMenuItem";
            this.crearLogToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.crearLogToolStripMenuItem.Text = "Crear log...";
            this.crearLogToolStripMenuItem.Click += new System.EventHandler(this.crearLogToolStripMenuItem_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
            this.menuStrip1.TabIndex = 175;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // contador_txt
            // 
            this.contador_txt.AutoSize = true;
            this.contador_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contador_txt.Location = new System.Drawing.Point(8, 475);
            this.contador_txt.Name = "contador_txt";
            this.contador_txt.Size = new System.Drawing.Size(162, 20);
            this.contador_txt.TabIndex = 180;
            this.contador_txt.Text = "Nº de TAG leido:  0";
            // 
            // Logo
            // 
            this.Logo.Image = global::Properties.Resources.Logo3;
            this.Logo.Location = new System.Drawing.Point(504, 36);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(310, 75);
            this.Logo.TabIndex = 165;
            this.Logo.TabStop = false;
            // 
            // leer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(841, 533);
            this.Controls.Add(this.contador_txt);
            this.Controls.Add(this.leerbtn);
            this.Controls.Add(this.logtxt);
            this.Controls.Add(this.modobtn);
            this.Controls.Add(this.modotxt);
            this.Controls.Add(this.lecturatag);
            this.Controls.Add(this.comprobaciontxt);
            this.Controls.Add(this.Recibido);
            this.Controls.Add(this.cleuzetxt3);
            this.Controls.Add(this.cleuzetxt2);
            this.Controls.Add(this.cleuzetxt1);
            this.Controls.Add(this.confirmaciontxt);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Titulotxt);
            this.Controls.Add(this.botonsalir);
            this.Controls.Add(this.libre2ej);
            this.Controls.Add(this.libre1ej);
            this.Controls.Add(this.identificadorej);
            this.Controls.Add(this.numeroej);
            this.Controls.Add(this.pesoej);
            this.Controls.Add(this.pvpej);
            this.Controls.Add(this.unidadesej);
            this.Controls.Add(this.fechafabricacionej);
            this.Controls.Add(this.tipoej);
            this.Controls.Add(this.diasej);
            this.Controls.Add(this.fechacaducidadej);
            this.Controls.Add(this.destinoej);
            this.Controls.Add(this.codigoej);
            this.Controls.Add(this.identificador);
            this.Controls.Add(this.identificadortxt);
            this.Controls.Add(this.numerotxt);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.libre2txt);
            this.Controls.Add(this.libre2);
            this.Controls.Add(this.pesotxt);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.pvptxt);
            this.Controls.Add(this.pvp);
            this.Controls.Add(this.unidadestxt);
            this.Controls.Add(this.unidades);
            this.Controls.Add(this.libre1);
            this.Controls.Add(this.libre1txt);
            this.Controls.Add(this.fechafabricaciontxt);
            this.Controls.Add(this.fechafabricacion);
            this.Controls.Add(this.tipotxt);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.diastxt);
            this.Controls.Add(this.dias);
            this.Controls.Add(this.fechacaducidadtxt);
            this.Controls.Add(this.fechacaducidad);
            this.Controls.Add(this.destinotxt);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.destino);
            this.Controls.Add(this.codigotxt);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "leer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAG Proveedores soft v2.4.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CAGProveedores_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.grabar_FormClosed);
            this.Load += new System.EventHandler(this.leer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		public leer(string puertocom, int puertobaud, int nbit, string sbit, string paridad, bool sound)
		{
			this.InitializeComponent();
			this.puertoscom = SerialPort.GetPortNames();
			this.serialPort1.PortName = puertocom;
			this.serialPort1.BaudRate = puertobaud;
			if (nbit == 8)
			{
				this.serialPort1.DataBits = 8;
			}
			else
			{
				if (nbit == 7)
				{
					this.serialPort1.DataBits = 7;
				}
			}
			if (sbit == "One")
			{
				this.serialPort1.StopBits = StopBits.One;
			}
			else
			{
				if (sbit == "Two")
				{
					this.serialPort1.StopBits = StopBits.Two;
				}
			}
			if (paridad == "None")
			{
				this.serialPort1.Parity = Parity.None;
			}
			else
			{
				if (paridad == "Odd")
				{
					this.serialPort1.Parity = Parity.Odd;
				}
				else
				{
					if (paridad == "Even")
					{
						this.serialPort1.Parity = Parity.Even;
					}
				}
			}
			this.serialPort1.Open();
			Form.ActiveForm.Visible = false;
			this.sonido = sound;
			if (!this.sonido)
			{
				this.desactivarSonidoToolStripMenuItem.Text = "Activar sonido";
			}
			int bytesToRead = this.serialPort1.BytesToRead;
			byte[] array = new byte[bytesToRead];
			array = Encoding.Default.GetBytes(string.Concat(new object[]
			{
				Convert.ToChar(2),
				"C0000715012FF220384012C000006000501000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000",
				Convert.ToChar(13),
				Convert.ToChar(10)
			}));
			this.serialPort1.Write(array, 0, array.Length);
		}
		private void leertag(object sender, EventArgs e)
		{
			int bytesToRead = this.serialPort1.BytesToRead;
			byte[] buffer = new byte[bytesToRead];
			char[] array = new char[10];
			array[0] = Convert.ToChar(2);
			array[1] = '+';
			array[2] = Convert.ToChar(13);
			array[3] = Convert.ToChar(10);
			array[4] = Convert.ToChar(0);
			buffer = Encoding.Default.GetBytes(array);
			this.serialPort1.Write(buffer, 0, array.Length);
		}
		private void desleertag(object sender, EventArgs e)
		{
			int bytesToRead = this.serialPort1.BytesToRead;
			byte[] buffer = new byte[bytesToRead];
			char[] array = new char[10];
			array[0] = Convert.ToChar(2);
			array[1] = '-';
			array[2] = Convert.ToChar(13);
			array[3] = Convert.ToChar(10);
			array[4] = Convert.ToChar(0);
			buffer = Encoding.Default.GetBytes(array);
			this.serialPort1.Write(buffer, 0, array.Length);
		}
		private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			int num = -1;
			int num2 = -1;
			int bytesToRead = this.serialPort1.BytesToRead;
			byte[] array = new byte[bytesToRead];
			if (this.inicio != 0)
			{
				if (this.leido[this.buffleido] != 10)
				{
					num = this.buffleido;
				}
			}
			this.serialPort1.Read(array, 0, bytesToRead);
			this.bits = Convert.ToInt32(bytesToRead);
			do
			{
				num++;
				num2++;
				this.leido[num] = Convert.ToInt32(array[num2]);
			}
			while (this.bits != num2 + 1);
			this.buffleido = num;
			this.inicio = 1;
			if (this.leido[num] == 10)
			{
				this.Recibido.Invoke(new EventHandler(this.mostrar));
			}
		}
		private void confirmar(object sender, EventArgs e)
		{
			int num = -1;
			int num2 = 1;
			do
			{
				num++;
				if (this.tagleido[num] != (int)this.envio[num + 7])
				{
					num2 = 0;
				}
			}
			while (num != 47 & num2 != 0);
		}
		private void mostrar(object sender, EventArgs e)
		{
			int num = -1;
			do
			{
				num++;
				this.Recibido.Text = this.Recibido.Text + string.Format("{0}", (char)this.leido[num]);
			}
			while (num != this.buffleido);
			if (this.comprobar == 1)
			{
				if (this.leido[1] == 24)
				{
					if (this.sonido)
					{
						this.soundPlayer.SoundLocation = Directory.GetCurrentDirectory() + "\\alerta.wav";
						this.soundPlayer.Play();
					}
					this.confirmaciontxt.ForeColor = Color.Red;
					this.confirmaciontxt.Text = "              TAG NO LEIDO";
					this.comprobar = 0;
				}
				else
				{
					num = 5;
					this.auto = 0;
					this.x = -1;
					this.lecturatag.Text = "";
					do
					{
						num++;
						this.x++;
						this.lecturatag.Text = this.lecturatag.Text + string.Format("{0}", (char)this.leido[num]);
						if (this.leido[num] != 13 & this.leido[num] != 10)
						{
							this.tagleido[this.x] = this.leido[num];
						}
					}
					while (num != this.buffleido);
					this.contador++;
					this.contador_txt.Text = "Nº de TAG leido:  " + Convert.ToString(this.contador);
					if (this.sonido)
					{
						this.soundPlayer.SoundLocation = Directory.GetCurrentDirectory() + "\\beep.wav";
						this.soundPlayer.Play();
					}
					this.confirmaciontxt.ForeColor = Color.Green;
					this.confirmaciontxt.Text = "              TAG leido";
					this.comprobar = 0;
					if (this.logactivo == 1)
					{
						using (StreamWriter streamWriter = new StreamWriter(this.log, true))
						{
							streamWriter.Write(Convert.ToString(this.contador) + " - ");
							streamWriter.WriteLine(DateTime.Now.ToString());
							streamWriter.WriteLine("TAG leido");
							streamWriter.WriteLine(this.lecturatag.Text);
						}
					}
					char[] array = new char[10];
					num = -2;
					array[0] = (char)this.leido[7];
					this.destinotxt.Text = string.Format("{0}", array[0]);
					do
					{
						num += 2;
						array[num] = (char)this.leido[12 - num];
						array[num + 1] = (char)this.leido[13 - num];
					}
					while (num != 4);
					array[6] = (char)this.leido[6];
					this.codigotxt.Text = "";
					num = -1;
					do
					{
						num++;
						this.codigotxt.Text = this.codigotxt.Text + string.Format("{0}", array[num]);
					}
					while (num != 6);
					array[0] = (char)this.leido[14];
					this.diastxt.Text = string.Format("{0}", array[0]);
					array[0] = (char)this.leido[15];
					this.tipotxt.Text = string.Format("{0}", array[0]);
					num = -2;
					do
					{
						num += 2;
						array[num] = (char)this.leido[20 - num];
						array[num + 1] = (char)this.leido[21 - num];
					}
					while (num != 4);
					this.fechacaducidadtxt.Text = "";
					num = -1;
					do
					{
						num++;
						this.fechacaducidadtxt.Text = this.fechacaducidadtxt.Text + string.Format("{0}", array[num]);
					}
					while (num != 5);
					array[0] = (char)this.leido[22];
					array[1] = (char)this.leido[23];
					this.libre1txt.Text = "";
					num = -1;
					do
					{
						num++;
						this.libre1txt.Text = this.libre1txt.Text + string.Format("{0}", array[num]);
					}
					while (num != 1);
					num = -2;
					do
					{
						num += 2;
						array[num] = (char)this.leido[28 - num];
						array[num + 1] = (char)this.leido[29 - num];
					}
					while (num != 4);
					this.fechafabricaciontxt.Text = "";
					num = -1;
					do
					{
						num++;
						this.fechafabricaciontxt.Text = this.fechafabricaciontxt.Text + string.Format("{0}", array[num]);
					}
					while (num != 5);
					num = -1;
					array[0] = (char)this.leido[35];
					do
					{
						num += 2;
						array[num] = (char)this.leido[33 - num];
						array[num + 1] = (char)this.leido[34 - num];
					}
					while (num != 3);
					this.pvptxt.Text = "";
					num = -1;
					do
					{
						num++;
						this.pvptxt.Text = this.pvptxt.Text + string.Format("{0}", array[num]);
					}
					while (num != 4);
					array[0] = (char)this.leido[36];
					array[1] = (char)this.leido[37];
					array[2] = (char)this.leido[34];
					this.unidadestxt.Text = "";
					num = -1;
					do
					{
						num++;
						this.unidadestxt.Text = this.unidadestxt.Text + string.Format("{0}", array[num]);
					}
					while (num != 2);
					array[0] = (char)this.leido[39];
					this.libre2txt.Text = string.Format("{0}", array[0]);
					num = -2;
					do
					{
						num += 2;
						array[num] = (char)this.leido[44 - num];
						array[num + 1] = (char)this.leido[45 - num];
					}
					while (num != 4);
					array[6] = (char)this.leido[38];
					this.pesotxt.Text = "";
					num = -1;
					do
					{
						num++;
						this.pesotxt.Text = this.pesotxt.Text + string.Format("{0}", array[num]);
					}
					while (num != 6);
					num = -2;
					do
					{
						num += 2;
						array[num] = (char)this.leido[52 - num];
						array[num + 1] = (char)this.leido[53 - num];
					}
					while (num != 2);
					this.numerotxt.Text = "";
					num = -1;
					do
					{
						num++;
						this.numerotxt.Text = this.numerotxt.Text + string.Format("{0}", array[num]);
					}
					while (num != 3);
					num = -2;
					do
					{
						num += 2;
						array[num] = (char)this.leido[48 - num];
						array[num + 1] = (char)this.leido[49 - num];
					}
					while (num != 2);
					this.identificadortxt.Text = "";
					num = -1;
					do
					{
						num++;
						this.identificadortxt.Text = this.identificadortxt.Text + string.Format("{0}", array[num]);
					}
					while (num != 3);
				}
			}
			else
			{
				if (this.modo == 1 & this.auto == 0)
				{
					if (this.leido[1] == 48 & this.leido[2] == 48 & this.leido[3] == 48 & this.leido[4] == 48 & this.leido[5] == 52)
					{
						this.auxauto = 1;
					}
					if (this.leido[this.buffleido] == 10 & this.auxauto == 1)
					{
						this.auto = 1;
						this.auxauto = 0;
						this.comprobar = 1;
						this.confirmaciontxt.ForeColor = Color.Black;
						this.confirmaciontxt.Text = "Esperando lectura de TAG";
						base.Invoke(new EventHandler(this.leertag));
					}
				}
				else
				{
					if (((this.leido[1] == 48 & this.leido[2] == 48 & this.leido[3] == 48 & this.leido[4] == 48 & this.leido[5] == 52 & this.grabadook == 1) || this.finallectura == 1) & this.auxcomplect == 1)
					{
						num = 5;
						if (this.finallectura == 1)
						{
							num = -1;
						}
						do
						{
							num++;
							this.x++;
							this.lecturatag.Text = this.lecturatag.Text + string.Format("{0}", (char)this.leido[num]);
							if (this.leido[num] != 13 & this.leido[num] != 10)
							{
								this.tagleido[this.x] = this.leido[num];
							}
						}
						while (num != this.buffleido);
						this.finallectura = 1;
						this.grabadook = 0;
						if (this.leido[this.buffleido] == 10)
						{
							this.auto = 0;
							this.auxcomplect = 0;
							base.Invoke(new EventHandler(this.confirmar));
						}
					}
				}
			}
		}
		private void CAGProveedores_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.serialPort1.Close();
		}
		private void botoneditar_Click(object sender, EventArgs e)
		{
			int num = 0;
			if (this.edicion == 0)
			{
				this.codigotxt.ReadOnly = false;
				this.destinotxt.ReadOnly = false;
				this.fechacaducidadtxt.ReadOnly = false;
				this.diastxt.ReadOnly = false;
				this.tipotxt.ReadOnly = false;
				this.fechafabricaciontxt.ReadOnly = false;
				this.libre1txt.ReadOnly = false;
				this.unidadestxt.ReadOnly = false;
				this.pvptxt.ReadOnly = false;
				this.pesotxt.ReadOnly = false;
				this.libre2txt.ReadOnly = false;
				this.numerotxt.ReadOnly = false;
				this.identificadortxt.ReadOnly = false;
				this.modobtn.Enabled = false;
				this.modotxt.Visible = false;
				this.edicion = 1;
				this.codigotxt.Focus();
			}
			else
			{
				if (this.codigotxt.TextLength < 7)
				{
					num = 1;
					this.comprobaciontxt.Text = "Longitud Codigo de articulo incorrecta";
				}
				if (this.destinotxt.TextLength < 1)
				{
					num = 1;
					this.comprobaciontxt.Text = "Longitud Destino caja incorrecta";
				}
				if (this.fechacaducidadtxt.TextLength < 6)
				{
					num = 1;
					this.comprobaciontxt.Text = "Longitud Fecha de caducidad incorrecta";
				}
				if (this.diastxt.TextLength < 1)
				{
					num = 1;
					this.comprobaciontxt.Text = "Longitud Días de más de caducidad incorrecta";
				}
				if (this.tipotxt.TextLength < 1)
				{
					num = 1;
					this.comprobaciontxt.Text = "Longitud Tipo de producto incorrecta";
				}
				if (this.fechafabricaciontxt.TextLength < 6)
				{
					num = 1;
					this.comprobaciontxt.Text = "Longitud Fecha de fabricación incorrecta";
				}
				if (this.libre1txt.TextLength < 2)
				{
					num = 1;
					this.comprobaciontxt.Text = "Longitud Campo libre 1 incorrecta";
				}
				if (this.unidadestxt.TextLength < 3)
				{
					num = 1;
					this.comprobaciontxt.Text = "Longitud Unidades por caja incorrecta";
				}
				if (this.pvptxt.TextLength < 5)
				{
					num = 1;
					this.comprobaciontxt.Text = "Longitud PVP incorrecta";
				}
				if (this.pesotxt.TextLength < 7)
				{
					num = 1;
					this.comprobaciontxt.Text = "Longitud Peso caja incorrecta";
				}
				if (this.libre2txt.TextLength < 1)
				{
					num = 1;
					this.comprobaciontxt.Text = "Longitud Campo libre 2 incorrecta";
				}
				if (this.numerotxt.TextLength < 4)
				{
					num = 1;
					this.comprobaciontxt.Text = "Longitud Número de lote incorrecta";
				}
				if (this.identificadortxt.TextLength < 4)
				{
					num = 1;
					this.comprobaciontxt.Text = "Longitud Identificador de etiquetas incorrecta";
				}
				if (num == 0)
				{
					this.comprobaciontxt.Text = "";
					this.codigotxt.ReadOnly = true;
					this.destinotxt.ReadOnly = true;
					this.fechacaducidadtxt.ReadOnly = true;
					this.diastxt.ReadOnly = true;
					this.tipotxt.ReadOnly = true;
					this.fechafabricaciontxt.ReadOnly = true;
					this.libre1txt.ReadOnly = true;
					this.unidadestxt.ReadOnly = true;
					this.pvptxt.ReadOnly = true;
					this.pesotxt.ReadOnly = true;
					this.libre2txt.ReadOnly = true;
					this.numerotxt.ReadOnly = true;
					this.identificadortxt.ReadOnly = true;
					this.modobtn.Enabled = true;
					this.modotxt.Visible = true;
					this.edicion = 0;
				}
			}
		}
		private void botonsalir_Click(object sender, EventArgs e)
		{
			this.serialPort1.Close();
			CAGProveedores cAGProveedores = new CAGProveedores();
			cAGProveedores.Show();
			base.Close();
		}
		private void modobtn_Click(object sender, EventArgs e)
		{
			if (this.modo == 0)
			{
				this.modo = 1;
				this.modotxt.Text = "Modo Automático activado";
				this.modobtn.Text = "Cambiar a Manual";
				this.leerbtn.Enabled = false;
			}
			else
			{
				this.modo = 0;
				this.modotxt.Text = "Modo Manual activado";
				this.modobtn.Text = "Cambiar a Automático";
				this.leerbtn.Enabled = true;
			}
		}
		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.serialPort1.Close();
			Form.ActiveForm.Visible = true;
			base.Close();
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
				this.serialPort1.Open();
			}
		}
		private void leerbtn_Click(object sender, EventArgs e)
		{
         
            this.comprobar = 1;
			this.confirmaciontxt.ForeColor = Color.Black;
			this.confirmaciontxt.Text = "Esperando lectura de TAG";
			base.Invoke(new EventHandler(this.leertag));
		}
		private void crearLogToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.crearLogToolStripMenuItem.Text == "Crear log...")
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Filter = "Archivo Log|*.log";
				saveFileDialog.Title = "Crear fichero log";
				saveFileDialog.ShowDialog();
				if (saveFileDialog.FileName != "")
				{
					FileStream fileStream = (FileStream)saveFileDialog.OpenFile();
					this.log = fileStream.Name;
					fileStream.Close();
					this.logactivo = 1;
					this.logtxt.Visible = true;
					this.crearLogToolStripMenuItem.Text = "Detener registro log";
				}
			}
			else
			{
				this.crearLogToolStripMenuItem.Text = "Crear log...";
				this.logactivo = 0;
				this.logtxt.Visible = false;
			}
		}
		private void grabar_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.serialPort1.Close();
			CAGProveedores cAGProveedores = new CAGProveedores();
			cAGProveedores.Show();
			base.Close();
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

        private void leer_Load(object sender, EventArgs e)
        {

        }
	}
}
