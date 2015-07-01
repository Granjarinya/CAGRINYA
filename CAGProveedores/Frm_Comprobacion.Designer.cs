namespace CAGProveedores
{
    partial class Frm_Comprobacion
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TAGGRABADOtxt = new System.Windows.Forms.Label();
            this.PALETCOMPLETOtxt = new System.Windows.Forms.Label();
            this.TAGNOGRABADOtxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TAGGRABADOtxt
            // 
            this.TAGGRABADOtxt.AutoSize = true;
            this.TAGGRABADOtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAGGRABADOtxt.Location = new System.Drawing.Point(118, 293);
            this.TAGGRABADOtxt.Name = "TAGGRABADOtxt";
            this.TAGGRABADOtxt.Size = new System.Drawing.Size(1127, 73);
            this.TAGGRABADOtxt.TabIndex = 0;
            this.TAGGRABADOtxt.Text = "TAG GRABADO CORRECTAMENTE";
            this.TAGGRABADOtxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TAGGRABADOtxt.Visible = false;
            // 
            // PALETCOMPLETOtxt
            // 
            this.PALETCOMPLETOtxt.AutoSize = true;
            this.PALETCOMPLETOtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PALETCOMPLETOtxt.Location = new System.Drawing.Point(393, 293);
            this.PALETCOMPLETOtxt.Name = "PALETCOMPLETOtxt";
            this.PALETCOMPLETOtxt.Size = new System.Drawing.Size(627, 73);
            this.PALETCOMPLETOtxt.TabIndex = 1;
            this.PALETCOMPLETOtxt.Text = "PALET COMPLETO";
            this.PALETCOMPLETOtxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PALETCOMPLETOtxt.Visible = false;
            // 
            // TAGNOGRABADOtxt
            // 
            this.TAGNOGRABADOtxt.AutoSize = true;
            this.TAGNOGRABADOtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAGNOGRABADOtxt.Location = new System.Drawing.Point(373, 293);
            this.TAGNOGRABADOtxt.Name = "TAGNOGRABADOtxt";
            this.TAGNOGRABADOtxt.Size = new System.Drawing.Size(647, 73);
            this.TAGNOGRABADOtxt.TabIndex = 2;
            this.TAGNOGRABADOtxt.Text = "TAG NO GRABADO ";
            this.TAGNOGRABADOtxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TAGNOGRABADOtxt.Visible = false;
            // 
            // Frm_Comprobacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 519);
            this.Controls.Add(this.TAGNOGRABADOtxt);
            this.Controls.Add(this.PALETCOMPLETOtxt);
            this.Controls.Add(this.TAGGRABADOtxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Comprobacion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Comprobacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TAGGRABADOtxt;
        private System.Windows.Forms.Label PALETCOMPLETOtxt;
        private System.Windows.Forms.Label TAGNOGRABADOtxt;
    }
}