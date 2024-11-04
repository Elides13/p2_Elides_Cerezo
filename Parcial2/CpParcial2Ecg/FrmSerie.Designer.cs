namespace CpParcial2Ecg
{
    partial class FrmSerie
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
            this.components = new System.ComponentModel.Container();
            this.erpPrecioVenta = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpUnidadMedida = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpCodigo = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.erpSaldo = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.nudEpisodio = new System.Windows.Forms.NumericUpDown();
            this.lblFechaEstreno = new System.Windows.Forms.Label();
            this.lblEpisodio = new System.Windows.Forms.Label();
            this.txtSinopsis = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblSinopsis = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbxLista = new System.Windows.Forms.GroupBox();
            this.dgvSerie = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dtpFechaEstreno = new System.Windows.Forms.DateTimePicker();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtDirector = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.erpPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpUnidadMedida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpSaldo)).BeginInit();
            this.gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEpisodio)).BeginInit();
            this.gbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerie)).BeginInit();
            this.pnlAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // erpPrecioVenta
            // 
            this.erpPrecioVenta.ContainerControl = this;
            // 
            // erpUnidadMedida
            // 
            this.erpUnidadMedida.ContainerControl = this;
            // 
            // erpDescripcion
            // 
            this.erpDescripcion.ContainerControl = this;
            // 
            // erpCodigo
            // 
            this.erpCodigo.ContainerControl = this;
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(743, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(92, 39);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // erpSaldo
            // 
            this.erpSaldo.ContainerControl = this;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(707, 80);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 39);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(600, 80);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 39);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.txtDirector);
            this.gbxDatos.Controls.Add(this.dtpFechaEstreno);
            this.gbxDatos.Controls.Add(this.btnCancelar);
            this.gbxDatos.Controls.Add(this.btnGuardar);
            this.gbxDatos.Controls.Add(this.nudEpisodio);
            this.gbxDatos.Controls.Add(this.lblFechaEstreno);
            this.gbxDatos.Controls.Add(this.lblEpisodio);
            this.gbxDatos.Controls.Add(this.txtSinopsis);
            this.gbxDatos.Controls.Add(this.txtTitulo);
            this.gbxDatos.Controls.Add(this.lblDirector);
            this.gbxDatos.Controls.Add(this.lblSinopsis);
            this.gbxDatos.Controls.Add(this.lblTitulo);
            this.gbxDatos.Location = new System.Drawing.Point(16, 311);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(819, 123);
            this.gbxDatos.TabIndex = 13;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos";
            // 
            // nudEpisodio
            // 
            this.nudEpisodio.Location = new System.Drawing.Point(528, 28);
            this.nudEpisodio.Name = "nudEpisodio";
            this.nudEpisodio.Size = new System.Drawing.Size(120, 20);
            this.nudEpisodio.TabIndex = 8;
            // 
            // lblFechaEstreno
            // 
            this.lblFechaEstreno.AutoSize = true;
            this.lblFechaEstreno.Location = new System.Drawing.Point(408, 58);
            this.lblFechaEstreno.Name = "lblFechaEstreno";
            this.lblFechaEstreno.Size = new System.Drawing.Size(94, 13);
            this.lblFechaEstreno.TabIndex = 7;
            this.lblFechaEstreno.Text = "Fecha de Estreno:";
            // 
            // lblEpisodio
            // 
            this.lblEpisodio.AutoSize = true;
            this.lblEpisodio.Location = new System.Drawing.Point(408, 30);
            this.lblEpisodio.Name = "lblEpisodio";
            this.lblEpisodio.Size = new System.Drawing.Size(50, 13);
            this.lblEpisodio.TabIndex = 6;
            this.lblEpisodio.Text = "Episodio:";
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.Location = new System.Drawing.Point(155, 55);
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(194, 20);
            this.txtSinopsis.TabIndex = 4;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(155, 27);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(194, 20);
            this.txtTitulo.TabIndex = 3;
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(15, 86);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(47, 13);
            this.lblDirector.TabIndex = 2;
            this.lblDirector.Text = "Director:";
            // 
            // lblSinopsis
            // 
            this.lblSinopsis.AutoSize = true;
            this.lblSinopsis.Location = new System.Drawing.Point(15, 58);
            this.lblSinopsis.Name = "lblSinopsis";
            this.lblSinopsis.Size = new System.Drawing.Size(49, 13);
            this.lblSinopsis.TabIndex = 1;
            this.lblSinopsis.Text = "Sinopsis:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(15, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(38, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título:";
            // 
            // gbxLista
            // 
            this.gbxLista.Controls.Add(this.dgvSerie);
            this.gbxLista.Location = new System.Drawing.Point(16, 93);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Size = new System.Drawing.Size(815, 162);
            this.gbxLista.TabIndex = 11;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Lista de Series";
            // 
            // dgvSerie
            // 
            this.dgvSerie.AllowUserToAddRows = false;
            this.dgvSerie.AllowUserToDeleteRows = false;
            this.dgvSerie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSerie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSerie.Location = new System.Drawing.Point(6, 23);
            this.dgvSerie.Name = "dgvSerie";
            this.dgvSerie.ReadOnly = true;
            this.dgvSerie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSerie.Size = new System.Drawing.Size(803, 133);
            this.dgvSerie.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(243, 56);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(494, 20);
            this.txtBuscar.TabIndex = 9;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(168, 62);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(40, 13);
            this.lblBusqueda.TabIndex = 8;
            this.lblBusqueda.Text = "Buscar";
            // 
            // lblSerie
            // 
            this.lblSerie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(11, 17);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(820, 32);
            this.lblSerie.TabIndex = 7;
            this.lblSerie.Text = "Series";
            this.lblSerie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnCerrar);
            this.pnlAcciones.Controls.Add(this.btnEliminar);
            this.pnlAcciones.Controls.Add(this.btnEditar);
            this.pnlAcciones.Controls.Add(this.btnNuevo);
            this.pnlAcciones.Location = new System.Drawing.Point(16, 262);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(819, 43);
            this.pnlAcciones.TabIndex = 12;
            // 
            // btnCerrar
            // 
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(501, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(90, 39);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(397, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 39);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(303, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 39);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // dtpFechaEstreno
            // 
            this.dtpFechaEstreno.Enabled = false;
            this.dtpFechaEstreno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEstreno.Location = new System.Drawing.Point(528, 58);
            this.dtpFechaEstreno.Name = "dtpFechaEstreno";
            this.dtpFechaEstreno.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEstreno.TabIndex = 13;
            this.dtpFechaEstreno.Value = new System.DateTime(2024, 11, 4, 14, 41, 22, 0);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::CpParcial2Ecg.Properties.Resources._new;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(205, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(92, 39);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(155, 86);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(194, 20);
            this.txtDirector.TabIndex = 14;
            // 
            // FrmSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(190)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.gbxLista);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.lblSerie);
            this.Controls.Add(this.pnlAcciones);
            this.Name = "FrmSerie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSerie";
            ((System.ComponentModel.ISupportInitialize)(this.erpPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpUnidadMedida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpSaldo)).EndInit();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEpisodio)).EndInit();
            this.gbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerie)).EndInit();
            this.pnlAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider erpPrecioVenta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.NumericUpDown nudEpisodio;
        private System.Windows.Forms.Label lblFechaEstreno;
        private System.Windows.Forms.Label lblEpisodio;
        private System.Windows.Forms.TextBox txtSinopsis;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblSinopsis;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.DataGridView dgvSerie;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ErrorProvider erpUnidadMedida;
        private System.Windows.Forms.ErrorProvider erpDescripcion;
        private System.Windows.Forms.ErrorProvider erpCodigo;
        private System.Windows.Forms.ErrorProvider erpSaldo;
        private System.Windows.Forms.DateTimePicker dtpFechaEstreno;
        private System.Windows.Forms.TextBox txtDirector;
    }
}

