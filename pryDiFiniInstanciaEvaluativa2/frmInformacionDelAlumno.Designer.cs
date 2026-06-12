namespace pryDiFiniInstanciaEvaluativa2
{
    partial class frmInformacionDelAlumno
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
            this.lblInformacionDelAlumno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInformacionDelAlumno
            // 
            this.lblInformacionDelAlumno.AutoSize = true;
            this.lblInformacionDelAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacionDelAlumno.Location = new System.Drawing.Point(12, 9);
            this.lblInformacionDelAlumno.Name = "lblInformacionDelAlumno";
            this.lblInformacionDelAlumno.Size = new System.Drawing.Size(298, 96);
            this.lblInformacionDelAlumno.TabIndex = 1;
            this.lblInformacionDelAlumno.Text = "Analista de Sistemas\r\nLaboratorio de Programación 2\r\n1º Instancia Evaluativa \r\n47" +
    "350879 - Di Fini Zaira";
            // 
            // frmInformacionDelAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 114);
            this.Controls.Add(this.lblInformacionDelAlumno);
            this.Name = "frmInformacionDelAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacion Del Alumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformacionDelAlumno;
    }
}