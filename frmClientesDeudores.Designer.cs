namespace pryRGiovannettiArchivo
{
    partial class frmClientesDeudores
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
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblCantidadClientes = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.grbListado = new System.Windows.Forms.GroupBox();
            this.dgvClientesDeudores = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPromDeuda = new System.Windows.Forms.Label();
            this.grbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesDeudores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPromedio
            // 
            this.lblPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedio.Location = new System.Drawing.Point(351, 373);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(103, 22);
            this.lblPromedio.TabIndex = 14;
            // 
            // lblCantidadClientes
            // 
            this.lblCantidadClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadClientes.Location = new System.Drawing.Point(351, 334);
            this.lblCantidadClientes.Name = "lblCantidadClientes";
            this.lblCantidadClientes.Size = new System.Drawing.Size(103, 22);
            this.lblCantidadClientes.TabIndex = 13;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(351, 299);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(103, 22);
            this.lblTotal.TabIndex = 12;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(220, 341);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(125, 15);
            this.lblCantidad.TabIndex = 11;
            this.lblCantidad.Text = "Cantidad De Clientes:";
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.AutoSize = true;
            this.lblTotalDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeuda.Location = new System.Drawing.Point(220, 306);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(96, 15);
            this.lblTotalDeuda.TabIndex = 10;
            this.lblTotalDeuda.Text = "Total De Deuda:";
            // 
            // grbListado
            // 
            this.grbListado.Controls.Add(this.lblPromedio);
            this.grbListado.Controls.Add(this.dgvClientesDeudores);
            this.grbListado.Controls.Add(this.lblCantidadClientes);
            this.grbListado.Controls.Add(this.lblPromDeuda);
            this.grbListado.Controls.Add(this.lblTotal);
            this.grbListado.Controls.Add(this.lblTotalDeuda);
            this.grbListado.Controls.Add(this.lblCantidad);
            this.grbListado.Location = new System.Drawing.Point(12, 12);
            this.grbListado.Name = "grbListado";
            this.grbListado.Size = new System.Drawing.Size(469, 408);
            this.grbListado.TabIndex = 9;
            this.grbListado.TabStop = false;
            this.grbListado.Text = "Consulta de datos";
            // 
            // dgvClientesDeudores
            // 
            this.dgvClientesDeudores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesDeudores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.ColDeuda,
            this.ColLimite});
            this.dgvClientesDeudores.Location = new System.Drawing.Point(6, 19);
            this.dgvClientesDeudores.Name = "dgvClientesDeudores";
            this.dgvClientesDeudores.Size = new System.Drawing.Size(448, 250);
            this.dgvClientesDeudores.TabIndex = 0;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // ColDeuda
            // 
            this.ColDeuda.HeaderText = "Deuda";
            this.ColDeuda.Name = "ColDeuda";
            // 
            // ColLimite
            // 
            this.ColLimite.HeaderText = "Limite de crédito";
            this.ColLimite.Name = "ColLimite";
            // 
            // lblPromDeuda
            // 
            this.lblPromDeuda.AutoSize = true;
            this.lblPromDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromDeuda.Location = new System.Drawing.Point(220, 380);
            this.lblPromDeuda.Name = "lblPromDeuda";
            this.lblPromDeuda.Size = new System.Drawing.Size(123, 15);
            this.lblPromDeuda.TabIndex = 3;
            this.lblPromDeuda.Text = "Promedio De Deuda:";
            // 
            // frmClientesDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 437);
            this.Controls.Add(this.grbListado);
            this.Name = "frmClientesDeudores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes Deudores";
            this.Load += new System.EventHandler(this.frmClientesDeudores_Load);
            this.grbListado.ResumeLayout(false);
            this.grbListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesDeudores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblCantidadClientes;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.GroupBox grbListado;
        private System.Windows.Forms.DataGridView dgvClientesDeudores;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDeuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLimite;
        private System.Windows.Forms.Label lblPromDeuda;
    }
}