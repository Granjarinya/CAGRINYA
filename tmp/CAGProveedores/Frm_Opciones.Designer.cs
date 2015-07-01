namespace CAGProveedores
{
    partial class Frm_Opciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Guardar_btn = new System.Windows.Forms.Button();
            this.tiempo_lbl = new System.Windows.Forms.Label();
            this.Tiempo_textBox = new System.Windows.Forms.TextBox();
            this.ruta_texbox = new System.Windows.Forms.TextBox();
            this.rutalbl = new System.Windows.Forms.Label();
            this.log_check = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Guardar_btn
            // 
            this.Guardar_btn.Location = new System.Drawing.Point(182, 97);
            this.Guardar_btn.Name = "Guardar_btn";
            this.Guardar_btn.Size = new System.Drawing.Size(51, 23);
            this.Guardar_btn.TabIndex = 6;
            this.Guardar_btn.Text = "Grabar";
            this.Guardar_btn.UseVisualStyleBackColor = true;
            this.Guardar_btn.Click += new System.EventHandler(this.Guardar_btn_Click);
            // 
            // tiempo_lbl
            // 
            this.tiempo_lbl.AutoSize = true;
            this.tiempo_lbl.Location = new System.Drawing.Point(12, 32);
            this.tiempo_lbl.Name = "tiempo_lbl";
            this.tiempo_lbl.Size = new System.Drawing.Size(45, 13);
            this.tiempo_lbl.TabIndex = 1;
            this.tiempo_lbl.Text = "Tiempo:";
            // 
            // Tiempo_textBox
            // 
            this.Tiempo_textBox.Location = new System.Drawing.Point(76, 29);
            this.Tiempo_textBox.Name = "Tiempo_textBox";
            this.Tiempo_textBox.Size = new System.Drawing.Size(100, 20);
            this.Tiempo_textBox.TabIndex = 2;
            this.Tiempo_textBox.Text = "3";
            this.Tiempo_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tiempo_textBox_KeyDown);
            // 
            // ruta_texbox
            // 
            this.ruta_texbox.Location = new System.Drawing.Point(76, 55);
            this.ruta_texbox.Name = "ruta_texbox";
            this.ruta_texbox.Size = new System.Drawing.Size(100, 20);
            this.ruta_texbox.TabIndex = 4;
            this.ruta_texbox.Text = "3";
            // 
            // rutalbl
            // 
            this.rutalbl.AutoSize = true;
            this.rutalbl.Location = new System.Drawing.Point(12, 58);
            this.rutalbl.Name = "rutalbl";
            this.rutalbl.Size = new System.Drawing.Size(54, 13);
            this.rutalbl.TabIndex = 3;
            this.rutalbl.Text = "Ruta Log:";
            // 
            // log_check
            // 
            this.log_check.AutoSize = true;
            this.log_check.Location = new System.Drawing.Point(182, 58);
            this.log_check.Name = "log_check";
            this.log_check.Size = new System.Drawing.Size(56, 17);
            this.log_check.TabIndex = 5;
            this.log_check.Text = "Activo";
            this.log_check.UseVisualStyleBackColor = true;
            // 
            // Frm_Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 132);
            this.Controls.Add(this.log_check);
            this.Controls.Add(this.ruta_texbox);
            this.Controls.Add(this.rutalbl);
            this.Controls.Add(this.Tiempo_textBox);
            this.Controls.Add(this.tiempo_lbl);
            this.Controls.Add(this.Guardar_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Frm_Opciones";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guardar_btn;
        private System.Windows.Forms.Label tiempo_lbl;
        private System.Windows.Forms.TextBox Tiempo_textBox;
        private System.Windows.Forms.TextBox ruta_texbox;
        private System.Windows.Forms.Label rutalbl;
        private System.Windows.Forms.CheckBox log_check;
    }
}