namespace pryDiFiniInstanciaEvaluativa2
{
    partial class frmGestionDeRubros
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lnkInformacionDelAlumno = new System.Windows.Forms.LinkLabel();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblTotalValorStock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCantidadArticulosListados = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbRubros = new System.Windows.Forms.ComboBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.prtDocumento = new System.Drawing.Printing.PrintDocument();
            this.prtVentana = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkInformacionDelAlumno
            // 
            this.lnkInformacionDelAlumno.AutoSize = true;
            this.lnkInformacionDelAlumno.Location = new System.Drawing.Point(12, 425);
            this.lnkInformacionDelAlumno.Name = "lnkInformacionDelAlumno";
            this.lnkInformacionDelAlumno.Size = new System.Drawing.Size(116, 13);
            this.lnkInformacionDelAlumno.TabIndex = 21;
            this.lnkInformacionDelAlumno.TabStop = true;
            this.lnkInformacionDelAlumno.Text = "Informacion del alumno";
            this.lnkInformacionDelAlumno.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkInformacionDelAlumno_LinkClicked);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(171, 359);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 20;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(9, 359);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(90, 359);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 18;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblTotalValorStock
            // 
            this.lblTotalValorStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalValorStock.Location = new System.Drawing.Point(437, 352);
            this.lblTotalValorStock.Name = "lblTotalValorStock";
            this.lblTotalValorStock.Size = new System.Drawing.Size(122, 27);
            this.lblTotalValorStock.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Total:";
            // 
            // lblCantidadArticulosListados
            // 
            this.lblCantidadArticulosListados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadArticulosListados.Location = new System.Drawing.Point(437, 314);
            this.lblCantidadArticulosListados.Name = "lblCantidadArticulosListados";
            this.lblCantidadArticulosListados.Size = new System.Drawing.Size(122, 27);
            this.lblCantidadArticulosListados.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cantidad de articulos listados:";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvArticulos.Location = new System.Drawing.Point(15, 45);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.Size = new System.Drawing.Size(544, 266);
            this.dgvArticulos.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripcion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Costo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Stock";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ValorStock";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // cmbRubros
            // 
            this.cmbRubros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRubros.FormattingEnabled = true;
            this.cmbRubros.Location = new System.Drawing.Point(90, 6);
            this.cmbRubros.Name = "cmbRubros";
            this.cmbRubros.Size = new System.Drawing.Size(171, 21);
            this.cmbRubros.TabIndex = 12;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(12, 9);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(72, 13);
            this.lable1.TabIndex = 11;
            this.lable1.Text = "Elige un rubro";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(252, 359);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 22;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // prtDocumento
            // 
            this.prtDocumento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtDocumento_PrintPage);
            // 
            // prtVentana
            // 
            this.prtVentana.UseEXDialog = true;
            // 
            // frmGestionDeRubros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lnkInformacionDelAlumno);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lblTotalValorStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCantidadArticulosListados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.cmbRubros);
            this.Controls.Add(this.lable1);
            this.Name = "frmGestionDeRubros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de rubros";
            this.Load += new System.EventHandler(this.frmGestionDeRubros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkInformacionDelAlumno;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblTotalValorStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCantidadArticulosListados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox cmbRubros;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Drawing.Printing.PrintDocument prtDocumento;
        private System.Windows.Forms.PrintDialog prtVentana;
    }
}

