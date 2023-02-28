
namespace Presentacion
{
    partial class frmArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticulos));
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.lblCriterios = new System.Windows.Forms.Label();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.lblCampos = new System.Windows.Forms.Label();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.grpBusquedaAvanzada = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grpArticulo = new System.Windows.Forms.GroupBox();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.grpCategoria = new System.Windows.Forms.GroupBox();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.grpMarca = new System.Windows.Forms.GroupBox();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.grpBusquedaAvanzada.SuspendLayout();
            this.grpArticulo.SuspendLayout();
            this.grpCategoria.SuspendLayout();
            this.grpMarca.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 254);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(664, 329);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellClick);
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.BackColor = System.Drawing.Color.Transparent;
            this.pbxArticulo.Location = new System.Drawing.Point(724, 254);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(320, 329);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 1;
            this.pbxArticulo.TabStop = false;
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(519, 33);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(171, 20);
            this.txtFiltroAvanzado.TabIndex = 13;
            // 
            // lblCriterios
            // 
            this.lblCriterios.AutoSize = true;
            this.lblCriterios.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCriterios.Location = new System.Drawing.Point(220, 38);
            this.lblCriterios.Name = "lblCriterios";
            this.lblCriterios.Size = new System.Drawing.Size(42, 13);
            this.lblCriterios.TabIndex = 12;
            this.lblCriterios.Text = "Criterio:";
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(267, 35);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(121, 21);
            this.cboCriterio.TabIndex = 15;
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(60, 37);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(121, 21);
            this.cboCampo.TabIndex = 17;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampos_SelectedIndexChanged);
            // 
            // lblCampos
            // 
            this.lblCampos.AutoSize = true;
            this.lblCampos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCampos.Location = new System.Drawing.Point(13, 40);
            this.lblCampos.Name = "lblCampos";
            this.lblCampos.Size = new System.Drawing.Size(43, 13);
            this.lblCampos.TabIndex = 16;
            this.lblCampos.Text = "Campo:";
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(430, 38);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(83, 13);
            this.lblFiltroAvanzado.TabIndex = 18;
            this.lblFiltroAvanzado.Text = "Filtro Avanzado:";
            // 
            // grpBusquedaAvanzada
            // 
            this.grpBusquedaAvanzada.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpBusquedaAvanzada.BackgroundImage")));
            this.grpBusquedaAvanzada.Controls.Add(this.btnLimpiar);
            this.grpBusquedaAvanzada.Controls.Add(this.btnBuscar);
            this.grpBusquedaAvanzada.Controls.Add(this.cboCampo);
            this.grpBusquedaAvanzada.Controls.Add(this.lblFiltroAvanzado);
            this.grpBusquedaAvanzada.Controls.Add(this.lblCriterios);
            this.grpBusquedaAvanzada.Controls.Add(this.txtFiltroAvanzado);
            this.grpBusquedaAvanzada.Controls.Add(this.lblCampos);
            this.grpBusquedaAvanzada.Controls.Add(this.cboCriterio);
            this.grpBusquedaAvanzada.ForeColor = System.Drawing.SystemColors.Control;
            this.grpBusquedaAvanzada.Location = new System.Drawing.Point(26, 126);
            this.grpBusquedaAvanzada.Name = "grpBusquedaAvanzada";
            this.grpBusquedaAvanzada.Size = new System.Drawing.Size(859, 99);
            this.grpBusquedaAvanzada.TabIndex = 19;
            this.grpBusquedaAvanzada.TabStop = false;
            this.grpBusquedaAvanzada.Text = "Busqueda Avanzada";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpiar.Location = new System.Drawing.Point(727, 60);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(84, 23);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.Location = new System.Drawing.Point(727, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 23);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminar.Location = new System.Drawing.Point(248, 35);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModificar.Location = new System.Drawing.Point(156, 35);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 21;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.Location = new System.Drawing.Point(59, 35);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grpArticulo
            // 
            this.grpArticulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpArticulo.BackgroundImage")));
            this.grpArticulo.Controls.Add(this.btnAgregar);
            this.grpArticulo.Controls.Add(this.btnEliminar);
            this.grpArticulo.Controls.Add(this.btnModificar);
            this.grpArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpArticulo.ForeColor = System.Drawing.SystemColors.Control;
            this.grpArticulo.Location = new System.Drawing.Point(26, 37);
            this.grpArticulo.Name = "grpArticulo";
            this.grpArticulo.Size = new System.Drawing.Size(408, 83);
            this.grpArticulo.TabIndex = 23;
            this.grpArticulo.TabStop = false;
            this.grpArticulo.Text = "Articulo";
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.Location = new System.Drawing.Point(862, 589);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnVerDetalle.TabIndex = 24;
            this.btnVerDetalle.Text = "Ver detalle";
            this.btnVerDetalle.UseVisualStyleBackColor = true;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // grpCategoria
            // 
            this.grpCategoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpCategoria.BackgroundImage")));
            this.grpCategoria.Controls.Add(this.btnEliminarCategoria);
            this.grpCategoria.Controls.Add(this.btnAgregarCategoria);
            this.grpCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpCategoria.ForeColor = System.Drawing.SystemColors.Control;
            this.grpCategoria.Location = new System.Drawing.Point(753, 39);
            this.grpCategoria.Name = "grpCategoria";
            this.grpCategoria.Size = new System.Drawing.Size(200, 81);
            this.grpCategoria.TabIndex = 25;
            this.grpCategoria.TabStop = false;
            this.grpCategoria.Text = "Categoria";
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(109, 32);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCategoria.TabIndex = 3;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(6, 32);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCategoria.TabIndex = 2;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // grpMarca
            // 
            this.grpMarca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpMarca.BackgroundImage")));
            this.grpMarca.Controls.Add(this.btnEliminarMarca);
            this.grpMarca.Controls.Add(this.btnAgregarMarca);
            this.grpMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpMarca.ForeColor = System.Drawing.SystemColors.Control;
            this.grpMarca.Location = new System.Drawing.Point(500, 39);
            this.grpMarca.Name = "grpMarca";
            this.grpMarca.Size = new System.Drawing.Size(200, 81);
            this.grpMarca.TabIndex = 26;
            this.grpMarca.TabStop = false;
            this.grpMarca.Text = "Marca";
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarMarca.Location = new System.Drawing.Point(110, 32);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarMarca.TabIndex = 1;
            this.btnEliminarMarca.Text = "Eliminar";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarMarca.Location = new System.Drawing.Point(9, 32);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarMarca.TabIndex = 0;
            this.btnAgregarMarca.Text = "Agregar";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1074, 642);
            this.Controls.Add(this.grpMarca);
            this.Controls.Add(this.grpCategoria);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.grpArticulo);
            this.Controls.Add(this.grpBusquedaAvanzada);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.grpBusquedaAvanzada.ResumeLayout(false);
            this.grpBusquedaAvanzada.PerformLayout();
            this.grpArticulo.ResumeLayout(false);
            this.grpCategoria.ResumeLayout(false);
            this.grpMarca.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Label lblCriterios;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.Label lblCampos;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.GroupBox grpBusquedaAvanzada;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox grpArticulo;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.GroupBox grpCategoria;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.GroupBox grpMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnAgregarMarca;
    }
}

