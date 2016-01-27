namespace DDSIC.Catalogos
{
    partial class CatalogoCuentaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogoCuentaForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuVentana = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.treeListCatalogo = new BrightIdeasSoftware.TreeListView();
            this.TreCodigo = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TreCuenta = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TreMayor = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TreTipo = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabCatalogo = new System.Windows.Forms.TabControl();
            this.pagTable = new System.Windows.Forms.TabPage();
            this.txtFiltroCodigo = new System.Windows.Forms.TextBox();
            this.lbTotalCuentas = new System.Windows.Forms.Label();
            this.tblCatalogo = new System.Windows.Forms.DataGridView();
            this.pagTreeTable = new System.Windows.Forms.TabPage();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnImportarExcel = new System.Windows.Forms.ToolStripButton();
            this.btnCambiarKEY = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnCambiarEstado = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnExportExcel = new System.Windows.Forms.ToolStripButton();
            this.btnAyuda = new System.Windows.Forms.ToolStripButton();
            this.COD_CTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAYOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLASE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTIVA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menuVentana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListCatalogo)).BeginInit();
            this.tabCatalogo.SuspendLayout();
            this.pagTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCatalogo)).BeginInit();
            this.pagTreeTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuVentana
            // 
            this.menuVentana.AutoSize = false;
            this.menuVentana.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnImportarExcel,
            this.toolStripSeparator1,
            this.btnCambiarKEY,
            this.btnEditar,
            this.btnCambiarEstado,
            this.btnEliminar,
            this.toolStripSeparator,
            this.btnExportExcel,
            this.btnAyuda});
            this.menuVentana.Location = new System.Drawing.Point(0, 0);
            this.menuVentana.Name = "menuVentana";
            this.menuVentana.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuVentana.Size = new System.Drawing.Size(882, 25);
            this.menuVentana.TabIndex = 0;
            this.menuVentana.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // treeListCatalogo
            // 
            this.treeListCatalogo.AllColumns.Add(this.TreCodigo);
            this.treeListCatalogo.AllColumns.Add(this.TreCuenta);
            this.treeListCatalogo.AllColumns.Add(this.TreMayor);
            this.treeListCatalogo.AllColumns.Add(this.TreTipo);
            this.treeListCatalogo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TreCodigo,
            this.TreCuenta,
            this.TreMayor,
            this.TreTipo});
            this.treeListCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListCatalogo.Location = new System.Drawing.Point(3, 3);
            this.treeListCatalogo.Name = "treeListCatalogo";
            this.treeListCatalogo.OwnerDraw = true;
            this.treeListCatalogo.ShowGroups = false;
            this.treeListCatalogo.Size = new System.Drawing.Size(755, 353);
            this.treeListCatalogo.TabIndex = 1;
            this.treeListCatalogo.UseCompatibleStateImageBehavior = false;
            this.treeListCatalogo.View = System.Windows.Forms.View.Details;
            this.treeListCatalogo.VirtualMode = true;
            // 
            // TreCodigo
            // 
            this.TreCodigo.AspectName = "Title";
            this.TreCodigo.Text = "CODIGO";
            this.TreCodigo.Width = 198;
            // 
            // TreCuenta
            // 
            this.TreCuenta.AspectName = "Artist";
            this.TreCuenta.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TreCuenta.Text = "CUENTA";
            this.TreCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TreCuenta.Width = 148;
            // 
            // TreMayor
            // 
            this.TreMayor.AspectName = "Album";
            this.TreMayor.AspectToStringFormat = "";
            this.TreMayor.AutoCompleteEditor = false;
            this.TreMayor.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TreMayor.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TreMayor.Text = "CUENTA MAYOR";
            this.TreMayor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TreMayor.Width = 143;
            // 
            // TreTipo
            // 
            this.TreTipo.AspectName = "SizeInBytes";
            this.TreTipo.Text = "TIPO CUENTA";
            this.TreTipo.Width = 85;
            // 
            // tabCatalogo
            // 
            this.tabCatalogo.Controls.Add(this.pagTable);
            this.tabCatalogo.Controls.Add(this.pagTreeTable);
            this.tabCatalogo.Location = new System.Drawing.Point(0, 28);
            this.tabCatalogo.Name = "tabCatalogo";
            this.tabCatalogo.SelectedIndex = 0;
            this.tabCatalogo.Size = new System.Drawing.Size(870, 385);
            this.tabCatalogo.TabIndex = 2;
            // 
            // pagTable
            // 
            this.pagTable.Controls.Add(this.txtFiltroCodigo);
            this.pagTable.Controls.Add(this.lbTotalCuentas);
            this.pagTable.Controls.Add(this.tblCatalogo);
            this.pagTable.Location = new System.Drawing.Point(4, 22);
            this.pagTable.Name = "pagTable";
            this.pagTable.Padding = new System.Windows.Forms.Padding(3);
            this.pagTable.Size = new System.Drawing.Size(862, 359);
            this.pagTable.TabIndex = 1;
            this.pagTable.Text = "Tabla";
            this.pagTable.UseVisualStyleBackColor = true;
            // 
            // txtFiltroCodigo
            // 
            this.txtFiltroCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltroCodigo.Location = new System.Drawing.Point(8, 3);
            this.txtFiltroCodigo.Name = "txtFiltroCodigo";
            this.txtFiltroCodigo.Size = new System.Drawing.Size(101, 20);
            this.txtFiltroCodigo.TabIndex = 16;
            this.txtFiltroCodigo.TextChanged += new System.EventHandler(this.txtFiltroCodigo_TextChanged);
            // 
            // lbTotalCuentas
            // 
            this.lbTotalCuentas.AutoSize = true;
            this.lbTotalCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCuentas.Location = new System.Drawing.Point(664, 6);
            this.lbTotalCuentas.Name = "lbTotalCuentas";
            this.lbTotalCuentas.Size = new System.Drawing.Size(76, 13);
            this.lbTotalCuentas.TabIndex = 15;
            this.lbTotalCuentas.Text = "0 CUENTAS";
            // 
            // tblCatalogo
            // 
            this.tblCatalogo.AllowUserToAddRows = false;
            this.tblCatalogo.AllowUserToDeleteRows = false;
            this.tblCatalogo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblCatalogo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblCatalogo.ColumnHeadersHeight = 21;
            this.tblCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblCatalogo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_CTA,
            this.NOMBRE,
            this.MAYOR,
            this.CATEGORIA,
            this.TIPO,
            this.SALDO,
            this.CLASE,
            this.ACTIVA});
            this.tblCatalogo.Location = new System.Drawing.Point(3, 25);
            this.tblCatalogo.MultiSelect = false;
            this.tblCatalogo.Name = "tblCatalogo";
            this.tblCatalogo.ReadOnly = true;
            this.tblCatalogo.RowHeadersVisible = false;
            this.tblCatalogo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tblCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblCatalogo.Size = new System.Drawing.Size(856, 331);
            this.tblCatalogo.TabIndex = 0;
            this.tblCatalogo.DataSourceChanged += new System.EventHandler(this.tblCatalogo_DataSourceChanged);
            this.tblCatalogo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblCatalogo_CellClick);
            this.tblCatalogo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tblCatalogo_CellFormatting);
            // 
            // pagTreeTable
            // 
            this.pagTreeTable.Controls.Add(this.treeListCatalogo);
            this.pagTreeTable.ImageKey = "(ninguno)";
            this.pagTreeTable.Location = new System.Drawing.Point(4, 22);
            this.pagTreeTable.Name = "pagTreeTable";
            this.pagTreeTable.Padding = new System.Windows.Forms.Padding(3);
            this.pagTreeTable.Size = new System.Drawing.Size(761, 359);
            this.pagTreeTable.TabIndex = 0;
            this.pagTreeTable.Text = "Arbol";
            this.pagTreeTable.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevo.Image = global::DDSIC.Properties.Resources._new;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(23, 22);
            this.btnNuevo.Text = "&Nueva Cuenta";
            this.btnNuevo.Click += new System.EventHandler(this.NUEVO);
            // 
            // btnImportarExcel
            // 
            this.btnImportarExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnImportarExcel.Image = global::DDSIC.Properties.Resources.ImportExcel32;
            this.btnImportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImportarExcel.Name = "btnImportarExcel";
            this.btnImportarExcel.Size = new System.Drawing.Size(23, 22);
            this.btnImportarExcel.Text = "Importar";
            this.btnImportarExcel.ToolTipText = "Importar desde Excel";
            this.btnImportarExcel.Click += new System.EventHandler(this.IMPORTAR_CATALOGO);
            // 
            // btnCambiarKEY
            // 
            this.btnCambiarKEY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCambiarKEY.Image = global::DDSIC.Properties.Resources.llave;
            this.btnCambiarKEY.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCambiarKEY.Name = "btnCambiarKEY";
            this.btnCambiarKEY.Size = new System.Drawing.Size(23, 22);
            this.btnCambiarKEY.Text = "Cambiar Codigo";
            this.btnCambiarKEY.ToolTipText = "Cambiar Codigo Cuenta";
            this.btnCambiarKEY.Click += new System.EventHandler(this.CHANGE_KEY);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::DDSIC.Properties.Resources.gtk_edit;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(23, 22);
            this.btnEditar.Text = "Editar";
            this.btnEditar.ToolTipText = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.EDITAR);
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCambiarEstado.Image = global::DDSIC.Properties.Resources.activar_desactivar;
            this.btnCambiarEstado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(23, 22);
            this.btnCambiarEstado.Text = "Activar/Desactivar";
            this.btnCambiarEstado.ToolTipText = "Activar/Desactivar";
            this.btnCambiarEstado.Click += new System.EventHandler(this.CHANGE_ESTADO);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = global::DDSIC.Properties.Resources.eliminar;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(23, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.ToolTipText = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.ELIMINAR);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Image")));
            this.btnExportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(23, 22);
            this.btnExportExcel.Text = "Exportar Excel";
            this.btnExportExcel.Click += new System.EventHandler(this.EXPORTAR);
            // 
            // btnAyuda
            // 
            this.btnAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAyuda.Image = global::DDSIC.Properties.Resources.help;
            this.btnAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(23, 22);
            this.btnAyuda.Text = "Ay&uda";
            this.btnAyuda.Click += new System.EventHandler(this.AYUDA);
            // 
            // COD_CTA
            // 
            this.COD_CTA.DataPropertyName = "COD_CTA";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.COD_CTA.DefaultCellStyle = dataGridViewCellStyle2;
            this.COD_CTA.FillWeight = 200F;
            this.COD_CTA.Frozen = true;
            this.COD_CTA.HeaderText = "CODIGO";
            this.COD_CTA.Name = "COD_CTA";
            this.COD_CTA.ReadOnly = true;
            this.COD_CTA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NOMBRE
            // 
            this.NOMBRE.DataPropertyName = "NOMBRE";
            this.NOMBRE.HeaderText = "CUENTA";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            this.NOMBRE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NOMBRE.Width = 250;
            // 
            // MAYOR
            // 
            this.MAYOR.DataPropertyName = "MAYOR";
            this.MAYOR.HeaderText = "MAYOR";
            this.MAYOR.Name = "MAYOR";
            this.MAYOR.ReadOnly = true;
            this.MAYOR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.DataPropertyName = "CATEGORIA";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.CATEGORIA.DefaultCellStyle = dataGridViewCellStyle3;
            this.CATEGORIA.HeaderText = "CATEGORIA";
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.ReadOnly = true;
            this.CATEGORIA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CATEGORIA.Width = 90;
            // 
            // TIPO
            // 
            this.TIPO.DataPropertyName = "TIPO";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.TIPO.DefaultCellStyle = dataGridViewCellStyle4;
            this.TIPO.HeaderText = "TIPO CTA.";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            this.TIPO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SALDO
            // 
            this.SALDO.DataPropertyName = "SALDO";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.SALDO.DefaultCellStyle = dataGridViewCellStyle5;
            this.SALDO.HeaderText = "SALDO";
            this.SALDO.Name = "SALDO";
            this.SALDO.ReadOnly = true;
            this.SALDO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SALDO.Width = 60;
            // 
            // CLASE
            // 
            this.CLASE.DataPropertyName = "CLASE";
            this.CLASE.HeaderText = "CLASE";
            this.CLASE.Name = "CLASE";
            this.CLASE.ReadOnly = true;
            // 
            // ACTIVA
            // 
            this.ACTIVA.DataPropertyName = "ACTIVA";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.NullValue = false;
            this.ACTIVA.DefaultCellStyle = dataGridViewCellStyle6;
            this.ACTIVA.HeaderText = "A";
            this.ACTIVA.Name = "ACTIVA";
            this.ACTIVA.ReadOnly = true;
            this.ACTIVA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ACTIVA.Width = 30;
            // 
            // CatalogoCuentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 410);
            this.Controls.Add(this.tabCatalogo);
            this.Controls.Add(this.menuVentana);
            this.Name = "CatalogoCuentaForm";
            this.Text = "Catalogo de Cuentas";
            this.Load += new System.EventHandler(this.CatalogoCuenta_Load);
            this.menuVentana.ResumeLayout(false);
            this.menuVentana.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListCatalogo)).EndInit();
            this.tabCatalogo.ResumeLayout(false);
            this.pagTable.ResumeLayout(false);
            this.pagTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCatalogo)).EndInit();
            this.pagTreeTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip menuVentana;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton btnCambiarKEY;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAyuda;
        private BrightIdeasSoftware.TreeListView treeListCatalogo;
        private BrightIdeasSoftware.OLVColumn TreCodigo;
        private BrightIdeasSoftware.OLVColumn TreCuenta;
        private BrightIdeasSoftware.OLVColumn TreMayor;
        private BrightIdeasSoftware.OLVColumn TreTipo;
        private System.Windows.Forms.TabControl tabCatalogo;
        private System.Windows.Forms.TabPage pagTreeTable;
        private System.Windows.Forms.TabPage pagTable;
        private System.Windows.Forms.DataGridView tblCatalogo;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnCambiarEstado;
        private System.Windows.Forms.ToolStripButton btnImportarExcel;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnExportExcel;
        private System.Windows.Forms.TextBox txtFiltroCodigo;
        private System.Windows.Forms.Label lbTotalCuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_CTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAYOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLASE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ACTIVA;
    }
}