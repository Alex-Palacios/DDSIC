namespace DDSIC.Tareas
{
    partial class ContabilizarTransForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContabilizarTransForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateDESDE = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateHASTA = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxSISTEMA = new System.Windows.Forms.ComboBox();
            this.tblTRANSACCIONES = new System.Windows.Forms.DataGridView();
            this.lbTOTAL = new System.Windows.Forms.Label();
            this.btnCARGAR = new System.Windows.Forms.Button();
            this.btnCONTABILIZAR = new System.Windows.Forms.Button();
            this.COD_TRANS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_SUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANSACCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REFERENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPreview = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbxSUCURSAL = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblTRANSACCIONES)).BeginInit();
            this.SuspendLayout();
            // 
            // dateDESDE
            // 
            this.dateDESDE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDESDE.Location = new System.Drawing.Point(369, 42);
            this.dateDESDE.Name = "dateDESDE";
            this.dateDESDE.Size = new System.Drawing.Size(121, 20);
            this.dateDESDE.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DESDE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(559, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "HASTA";
            // 
            // dateHASTA
            // 
            this.dateHASTA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateHASTA.Location = new System.Drawing.Point(535, 42);
            this.dateHASTA.Name = "dateHASTA";
            this.dateHASTA.Size = new System.Drawing.Size(121, 20);
            this.dateHASTA.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "SISTEMA";
            // 
            // cbxSISTEMA
            // 
            this.cbxSISTEMA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSISTEMA.FormattingEnabled = true;
            this.cbxSISTEMA.Location = new System.Drawing.Point(114, 22);
            this.cbxSISTEMA.Name = "cbxSISTEMA";
            this.cbxSISTEMA.Size = new System.Drawing.Size(121, 21);
            this.cbxSISTEMA.TabIndex = 5;
            this.cbxSISTEMA.SelectedIndexChanged += new System.EventHandler(this.cbxSISTEMA_SelectedIndexChanged);
            // 
            // tblTRANSACCIONES
            // 
            this.tblTRANSACCIONES.AllowUserToAddRows = false;
            this.tblTRANSACCIONES.AllowUserToDeleteRows = false;
            this.tblTRANSACCIONES.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.tblTRANSACCIONES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblTRANSACCIONES.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_TRANS,
            this.COD_SUC,
            this.TRANSACCION,
            this.FECHA,
            this.REFERENCIA,
            this.DESCRIPCION,
            this.TOTAL,
            this.btnPreview});
            this.tblTRANSACCIONES.Location = new System.Drawing.Point(26, 114);
            this.tblTRANSACCIONES.Name = "tblTRANSACCIONES";
            this.tblTRANSACCIONES.RowHeadersVisible = false;
            this.tblTRANSACCIONES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblTRANSACCIONES.Size = new System.Drawing.Size(936, 252);
            this.tblTRANSACCIONES.TabIndex = 7;
            this.tblTRANSACCIONES.DataSourceChanged += new System.EventHandler(this.tblTRANSACCIONES_DataSourceChanged);
            this.tblTRANSACCIONES.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblTRANSACCIONES_CellContentClick);
            this.tblTRANSACCIONES.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.tblTRANSACCIONES_CellPainting);
            // 
            // lbTOTAL
            // 
            this.lbTOTAL.AutoSize = true;
            this.lbTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTOTAL.Location = new System.Drawing.Point(54, 387);
            this.lbTOTAL.Name = "lbTOTAL";
            this.lbTOTAL.Size = new System.Drawing.Size(174, 20);
            this.lbTOTAL.TabIndex = 8;
            this.lbTOTAL.Text = "# TRANSACCIONES";
            // 
            // btnCARGAR
            // 
            this.btnCARGAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCARGAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCARGAR.Image")));
            this.btnCARGAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCARGAR.Location = new System.Drawing.Point(748, 32);
            this.btnCARGAR.Name = "btnCARGAR";
            this.btnCARGAR.Size = new System.Drawing.Size(214, 47);
            this.btnCARGAR.TabIndex = 9;
            this.btnCARGAR.Text = "CARGAR TRANSACCIONES";
            this.btnCARGAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCARGAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCARGAR.UseVisualStyleBackColor = true;
            this.btnCARGAR.Click += new System.EventHandler(this.TRANS_PENDIENTES);
            // 
            // btnCONTABILIZAR
            // 
            this.btnCONTABILIZAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCONTABILIZAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCONTABILIZAR.Image")));
            this.btnCONTABILIZAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCONTABILIZAR.Location = new System.Drawing.Point(817, 372);
            this.btnCONTABILIZAR.Name = "btnCONTABILIZAR";
            this.btnCONTABILIZAR.Size = new System.Drawing.Size(160, 47);
            this.btnCONTABILIZAR.TabIndex = 6;
            this.btnCONTABILIZAR.Text = "CONTABILIZAR";
            this.btnCONTABILIZAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCONTABILIZAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCONTABILIZAR.UseVisualStyleBackColor = true;
            // 
            // COD_TRANS
            // 
            this.COD_TRANS.DataPropertyName = "COD_TRANS";
            this.COD_TRANS.HeaderText = "COD TRANS";
            this.COD_TRANS.Name = "COD_TRANS";
            this.COD_TRANS.ReadOnly = true;
            this.COD_TRANS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.COD_TRANS.Width = 120;
            // 
            // COD_SUC
            // 
            this.COD_SUC.DataPropertyName = "COD_SUC";
            this.COD_SUC.HeaderText = "SUC";
            this.COD_SUC.Name = "COD_SUC";
            this.COD_SUC.ReadOnly = true;
            this.COD_SUC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.COD_SUC.Width = 60;
            // 
            // TRANSACCION
            // 
            this.TRANSACCION.DataPropertyName = "TRANSACCION";
            this.TRANSACCION.HeaderText = "TRANSACCION";
            this.TRANSACCION.Name = "TRANSACCION";
            this.TRANSACCION.ReadOnly = true;
            this.TRANSACCION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FECHA
            // 
            this.FECHA.DataPropertyName = "FECHA";
            dataGridViewCellStyle3.Format = "d";
            this.FECHA.DefaultCellStyle = dataGridViewCellStyle3;
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            this.FECHA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // REFERENCIA
            // 
            this.REFERENCIA.DataPropertyName = "REFERENCIA";
            this.REFERENCIA.HeaderText = "REFERENCIA";
            this.REFERENCIA.Name = "REFERENCIA";
            this.REFERENCIA.ReadOnly = true;
            this.REFERENCIA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.DataPropertyName = "DESCRIPCION";
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            this.DESCRIPCION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DESCRIPCION.Width = 300;
            // 
            // TOTAL
            // 
            this.TOTAL.DataPropertyName = "TOTAL";
            dataGridViewCellStyle4.Format = "C2";
            this.TOTAL.DefaultCellStyle = dataGridViewCellStyle4;
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            this.TOTAL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnPreview
            // 
            this.btnPreview.HeaderText = "";
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.ReadOnly = true;
            this.btnPreview.ToolTipText = "Preview de Partida";
            this.btnPreview.Width = 30;
            // 
            // cbxSUCURSAL
            // 
            this.cbxSUCURSAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSUCURSAL.FormattingEnabled = true;
            this.cbxSUCURSAL.Location = new System.Drawing.Point(113, 63);
            this.cbxSUCURSAL.Name = "cbxSUCURSAL";
            this.cbxSUCURSAL.Size = new System.Drawing.Size(201, 21);
            this.cbxSUCURSAL.TabIndex = 104;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(38, 66);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 103;
            this.label19.Text = "SUCURSAL";
            // 
            // ContabilizarTransForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(989, 431);
            this.Controls.Add(this.cbxSUCURSAL);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnCARGAR);
            this.Controls.Add(this.lbTOTAL);
            this.Controls.Add(this.tblTRANSACCIONES);
            this.Controls.Add(this.btnCONTABILIZAR);
            this.Controls.Add(this.cbxSISTEMA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateHASTA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateDESDE);
            this.MaximizeBox = false;
            this.Name = "ContabilizarTransForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CONTABILIZAR TRANSACCIONES";
            this.Load += new System.EventHandler(this.ContabilizarTransForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblTRANSACCIONES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateDESDE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateHASTA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxSISTEMA;
        private System.Windows.Forms.Button btnCONTABILIZAR;
        private System.Windows.Forms.DataGridView tblTRANSACCIONES;
        private System.Windows.Forms.Label lbTOTAL;
        private System.Windows.Forms.Button btnCARGAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_TRANS;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_SUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANSACCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn REFERENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewButtonColumn btnPreview;
        private System.Windows.Forms.ComboBox cbxSUCURSAL;
        private System.Windows.Forms.Label label19;
    }
}