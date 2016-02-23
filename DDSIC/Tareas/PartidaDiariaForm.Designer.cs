namespace DDSIC.Tareas
{
    partial class PartidaDiariaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartidaDiariaForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuVentana = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnAnular = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.btnAyuda = new System.Windows.Forms.ToolStripButton();
            this.grPartida = new System.Windows.Forms.GroupBox();
            this.txtCODTRANS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ckIGNORAR = new System.Windows.Forms.CheckBox();
            this.txtNUMPARTIDA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tblMOVIMIENTOS = new System.Windows.Forms.DataGridView();
            this.ckBLOQUEAR = new System.Windows.Forms.CheckBox();
            this.txtCONCEPTO = new System.Windows.Forms.TextBox();
            this.btnDeleteMov = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtREFERENCIA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddMov = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.datePartida = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMontoDebe = new System.Windows.Forms.Label();
            this.lbMontoHaber = new System.Windows.Forms.Label();
            this.lbBalance = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtPARTIDA_LOAD = new System.Windows.Forms.TextBox();
            this.NUMERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_CTA = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEBE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HABER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuVentana.SuspendLayout();
            this.grPartida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMOVIMIENTOS)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVentana
            // 
            this.menuVentana.AutoSize = false;
            this.menuVentana.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnCancelar,
            this.toolStripSeparator1,
            this.btnEditar,
            this.btnAnular,
            this.btnEliminar,
            this.toolStripSeparator,
            this.btnAyuda});
            this.menuVentana.Location = new System.Drawing.Point(0, 0);
            this.menuVentana.Name = "menuVentana";
            this.menuVentana.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuVentana.Size = new System.Drawing.Size(815, 25);
            this.menuVentana.TabIndex = 9;
            this.menuVentana.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevo.Image = global::DDSIC.Properties.Resources._new;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(23, 22);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.ToolTipText = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.NUEVO);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = global::DDSIC.Properties.Resources.icon_save;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(23, 22);
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.ToolTipText = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.GUARDAR);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = global::DDSIC.Properties.Resources.cancel_16;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.ToolTipText = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.CANCELAR);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // btnAnular
            // 
            this.btnAnular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAnular.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular.Image")));
            this.btnAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(23, 22);
            this.btnAnular.ToolTipText = "Anular";
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
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAyuda
            // 
            this.btnAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAyuda.Image = global::DDSIC.Properties.Resources.help;
            this.btnAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(23, 22);
            this.btnAyuda.Text = "Ay&uda";
            // 
            // grPartida
            // 
            this.grPartida.Controls.Add(this.txtCODTRANS);
            this.grPartida.Controls.Add(this.label6);
            this.grPartida.Controls.Add(this.ckIGNORAR);
            this.grPartida.Controls.Add(this.txtNUMPARTIDA);
            this.grPartida.Controls.Add(this.label10);
            this.grPartida.Controls.Add(this.tblMOVIMIENTOS);
            this.grPartida.Controls.Add(this.ckBLOQUEAR);
            this.grPartida.Controls.Add(this.txtCONCEPTO);
            this.grPartida.Controls.Add(this.btnDeleteMov);
            this.grPartida.Controls.Add(this.label5);
            this.grPartida.Controls.Add(this.txtREFERENCIA);
            this.grPartida.Controls.Add(this.label2);
            this.grPartida.Controls.Add(this.btnAddMov);
            this.grPartida.Controls.Add(this.label1);
            this.grPartida.Controls.Add(this.datePartida);
            this.grPartida.Location = new System.Drawing.Point(12, 53);
            this.grPartida.Name = "grPartida";
            this.grPartida.Size = new System.Drawing.Size(791, 393);
            this.grPartida.TabIndex = 10;
            this.grPartida.TabStop = false;
            // 
            // txtCODTRANS
            // 
            this.txtCODTRANS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCODTRANS.Location = new System.Drawing.Point(620, 53);
            this.txtCODTRANS.MaxLength = 20;
            this.txtCODTRANS.Name = "txtCODTRANS";
            this.txtCODTRANS.ReadOnly = true;
            this.txtCODTRANS.Size = new System.Drawing.Size(123, 20);
            this.txtCODTRANS.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(529, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "COD TRANS";
            // 
            // ckIGNORAR
            // 
            this.ckIGNORAR.AutoSize = true;
            this.ckIGNORAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckIGNORAR.Location = new System.Drawing.Point(6, 370);
            this.ckIGNORAR.Name = "ckIGNORAR";
            this.ckIGNORAR.Size = new System.Drawing.Size(223, 17);
            this.ckIGNORAR.TabIndex = 25;
            this.ckIGNORAR.Text = "IGNORAR MOVIMIENTOS VACIOS";
            this.ckIGNORAR.UseVisualStyleBackColor = true;
            // 
            // txtNUMPARTIDA
            // 
            this.txtNUMPARTIDA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNUMPARTIDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNUMPARTIDA.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtNUMPARTIDA.Location = new System.Drawing.Point(620, 17);
            this.txtNUMPARTIDA.MaxLength = 20;
            this.txtNUMPARTIDA.Name = "txtNUMPARTIDA";
            this.txtNUMPARTIDA.ReadOnly = true;
            this.txtNUMPARTIDA.Size = new System.Drawing.Size(123, 26);
            this.txtNUMPARTIDA.TabIndex = 9;
            this.txtNUMPARTIDA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(479, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "PARTIDA N°";
            // 
            // tblMOVIMIENTOS
            // 
            this.tblMOVIMIENTOS.AllowUserToAddRows = false;
            this.tblMOVIMIENTOS.AllowUserToDeleteRows = false;
            this.tblMOVIMIENTOS.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.tblMOVIMIENTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblMOVIMIENTOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUMERO,
            this.COD_CTA,
            this.DESCRIPCION,
            this.DEBE,
            this.HABER});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblMOVIMIENTOS.DefaultCellStyle = dataGridViewCellStyle4;
            this.tblMOVIMIENTOS.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tblMOVIMIENTOS.Location = new System.Drawing.Point(6, 149);
            this.tblMOVIMIENTOS.MultiSelect = false;
            this.tblMOVIMIENTOS.Name = "tblMOVIMIENTOS";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblMOVIMIENTOS.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tblMOVIMIENTOS.RowHeadersVisible = false;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.tblMOVIMIENTOS.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.tblMOVIMIENTOS.Size = new System.Drawing.Size(736, 210);
            this.tblMOVIMIENTOS.TabIndex = 23;
            this.tblMOVIMIENTOS.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.tblMOVIMIENTOS_CellBeginEdit);
            this.tblMOVIMIENTOS.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblMOVIMIENTOS_CellEndEdit);
            this.tblMOVIMIENTOS.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tblMOVIMIENTOS_CellFormatting);
            this.tblMOVIMIENTOS.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.tblMOVIMIENTOS_CellPainting);
            this.tblMOVIMIENTOS.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.tblMOVIMIENTOS_CellValidating);
            // 
            // ckBLOQUEAR
            // 
            this.ckBLOQUEAR.AutoSize = true;
            this.ckBLOQUEAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBLOQUEAR.Location = new System.Drawing.Point(649, 106);
            this.ckBLOQUEAR.Name = "ckBLOQUEAR";
            this.ckBLOQUEAR.Size = new System.Drawing.Size(93, 17);
            this.ckBLOQUEAR.TabIndex = 7;
            this.ckBLOQUEAR.Text = "BLOQUEAR";
            this.ckBLOQUEAR.UseVisualStyleBackColor = true;
            // 
            // txtCONCEPTO
            // 
            this.txtCONCEPTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCONCEPTO.Location = new System.Drawing.Point(129, 104);
            this.txtCONCEPTO.MaxLength = 100;
            this.txtCONCEPTO.Multiline = true;
            this.txtCONCEPTO.Name = "txtCONCEPTO";
            this.txtCONCEPTO.Size = new System.Drawing.Size(315, 39);
            this.txtCONCEPTO.TabIndex = 5;
            // 
            // btnDeleteMov
            // 
            this.btnDeleteMov.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteMov.Image")));
            this.btnDeleteMov.Location = new System.Drawing.Point(748, 199);
            this.btnDeleteMov.Name = "btnDeleteMov";
            this.btnDeleteMov.Size = new System.Drawing.Size(37, 25);
            this.btnDeleteMov.TabIndex = 18;
            this.btnDeleteMov.UseVisualStyleBackColor = true;
            this.btnDeleteMov.Click += new System.EventHandler(this.removeItemPartida);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CONCEPTO";
            // 
            // txtREFERENCIA
            // 
            this.txtREFERENCIA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtREFERENCIA.Location = new System.Drawing.Point(129, 68);
            this.txtREFERENCIA.MaxLength = 20;
            this.txtREFERENCIA.Name = "txtREFERENCIA";
            this.txtREFERENCIA.Size = new System.Drawing.Size(123, 20);
            this.txtREFERENCIA.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "REFERENCIA";
            // 
            // btnAddMov
            // 
            this.btnAddMov.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMov.Image")));
            this.btnAddMov.Location = new System.Drawing.Point(748, 168);
            this.btnAddMov.Name = "btnAddMov";
            this.btnAddMov.Size = new System.Drawing.Size(37, 25);
            this.btnAddMov.TabIndex = 14;
            this.btnAddMov.UseVisualStyleBackColor = true;
            this.btnAddMov.Click += new System.EventHandler(this.addItemPartida);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "FECHA";
            // 
            // datePartida
            // 
            this.datePartida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePartida.Location = new System.Drawing.Point(129, 35);
            this.datePartida.Name = "datePartida";
            this.datePartida.Size = new System.Drawing.Size(108, 20);
            this.datePartida.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(505, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "TOTAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(478, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "BALANCE";
            // 
            // lbMontoDebe
            // 
            this.lbMontoDebe.AutoSize = true;
            this.lbMontoDebe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMontoDebe.Location = new System.Drawing.Point(591, 458);
            this.lbMontoDebe.Name = "lbMontoDebe";
            this.lbMontoDebe.Size = new System.Drawing.Size(44, 20);
            this.lbMontoDebe.TabIndex = 19;
            this.lbMontoDebe.Text = "0.00";
            // 
            // lbMontoHaber
            // 
            this.lbMontoHaber.AutoSize = true;
            this.lbMontoHaber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMontoHaber.Location = new System.Drawing.Point(690, 458);
            this.lbMontoHaber.Name = "lbMontoHaber";
            this.lbMontoHaber.Size = new System.Drawing.Size(44, 20);
            this.lbMontoHaber.TabIndex = 20;
            this.lbMontoHaber.Text = "0.00";
            // 
            // lbBalance
            // 
            this.lbBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalance.Location = new System.Drawing.Point(591, 484);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(153, 20);
            this.lbBalance.TabIndex = 21;
            this.lbBalance.Text = "0.00";
            this.lbBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Image = global::DDSIC.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(662, 32);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(39, 23);
            this.btnBack.TabIndex = 16;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BACK);
            // 
            // btnNext
            // 
            this.btnNext.Image = global::DDSIC.Properties.Resources.next;
            this.btnNext.Location = new System.Drawing.Point(758, 32);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(39, 23);
            this.btnNext.TabIndex = 15;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.NEXT);
            // 
            // txtPARTIDA_LOAD
            // 
            this.txtPARTIDA_LOAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPARTIDA_LOAD.Location = new System.Drawing.Point(707, 32);
            this.txtPARTIDA_LOAD.Name = "txtPARTIDA_LOAD";
            this.txtPARTIDA_LOAD.Size = new System.Drawing.Size(47, 23);
            this.txtPARTIDA_LOAD.TabIndex = 24;
            this.txtPARTIDA_LOAD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPARTIDA_LOAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPARTIDA_LOAD_KeyPress);
            // 
            // NUMERO
            // 
            this.NUMERO.DataPropertyName = "#";
            this.NUMERO.HeaderText = "#";
            this.NUMERO.Name = "NUMERO";
            this.NUMERO.Width = 30;
            // 
            // COD_CTA
            // 
            this.COD_CTA.DataPropertyName = "COD_CTA";
            this.COD_CTA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.COD_CTA.HeaderText = "CUENTA";
            this.COD_CTA.Name = "COD_CTA";
            this.COD_CTA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.DataPropertyName = "DESCRIPCION";
            dataGridViewCellStyle1.NullValue = null;
            this.DESCRIPCION.DefaultCellStyle = dataGridViewCellStyle1;
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.MaxInputLength = 100;
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DESCRIPCION.Width = 400;
            // 
            // DEBE
            // 
            this.DEBE.DataPropertyName = "DEBE";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0.00";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.DEBE.DefaultCellStyle = dataGridViewCellStyle2;
            this.DEBE.HeaderText = "DEBE";
            this.DEBE.Name = "DEBE";
            this.DEBE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // HABER
            // 
            this.HABER.DataPropertyName = "HABER";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "0.00";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.HABER.DefaultCellStyle = dataGridViewCellStyle3;
            this.HABER.HeaderText = "HABER";
            this.HABER.Name = "HABER";
            this.HABER.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PartidaDiariaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(815, 519);
            this.Controls.Add(this.txtPARTIDA_LOAD);
            this.Controls.Add(this.lbBalance);
            this.Controls.Add(this.lbMontoHaber);
            this.Controls.Add(this.lbMontoDebe);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grPartida);
            this.Controls.Add(this.menuVentana);
            this.MaximizeBox = false;
            this.Name = "PartidaDiariaForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Registro de Partida Diaria";
            this.Load += new System.EventHandler(this.PartidaDiaria_Load);
            this.menuVentana.ResumeLayout(false);
            this.menuVentana.PerformLayout();
            this.grPartida.ResumeLayout(false);
            this.grPartida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMOVIMIENTOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menuVentana;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton btnAyuda;
        private System.Windows.Forms.GroupBox grPartida;
        private System.Windows.Forms.TextBox txtCONCEPTO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtREFERENCIA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePartida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddMov;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnDeleteMov;
        private System.Windows.Forms.Label lbMontoDebe;
        private System.Windows.Forms.Label lbMontoHaber;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.CheckBox ckBLOQUEAR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView tblMOVIMIENTOS;
        private System.Windows.Forms.CheckBox ckIGNORAR;
        private System.Windows.Forms.TextBox txtNUMPARTIDA;
        private System.Windows.Forms.TextBox txtCODTRANS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripButton btnAnular;
        private System.Windows.Forms.TextBox txtPARTIDA_LOAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO;
        private System.Windows.Forms.DataGridViewComboBoxColumn COD_CTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEBE;
        private System.Windows.Forms.DataGridViewTextBoxColumn HABER;
    }
}