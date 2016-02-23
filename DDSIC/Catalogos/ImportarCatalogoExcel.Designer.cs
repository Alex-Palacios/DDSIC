namespace DDSIC.Catalogos
{
    partial class ImportarCatalogoExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportarCatalogoExcel));
            this.tblCATALOGO = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAYOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progreso = new System.Windows.Forms.ProgressBar();
            this.openFileCatalogo = new System.Windows.Forms.OpenFileDialog();
            this.saveFileCatalogoPlantilla = new System.Windows.Forms.SaveFileDialog();
            this.btnLIMPIAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.btnEXAMINAR = new System.Windows.Forms.Button();
            this.btnPlantilla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblCATALOGO)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblCATALOGO
            // 
            this.tblCATALOGO.AllowUserToAddRows = false;
            this.tblCATALOGO.AllowUserToDeleteRows = false;
            this.tblCATALOGO.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.tblCATALOGO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCATALOGO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.CUENTA,
            this.MAYOR,
            this.SALDO,
            this.CATEGORIA,
            this.TIPO});
            this.tblCATALOGO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCATALOGO.Location = new System.Drawing.Point(0, 0);
            this.tblCATALOGO.Name = "tblCATALOGO";
            this.tblCATALOGO.ReadOnly = true;
            this.tblCATALOGO.RowHeadersVisible = false;
            this.tblCATALOGO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblCATALOGO.Size = new System.Drawing.Size(769, 356);
            this.tblCATALOGO.TabIndex = 0;
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "CODIGO";
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            // 
            // CUENTA
            // 
            this.CUENTA.DataPropertyName = "CUENTA";
            this.CUENTA.HeaderText = "CUENTA";
            this.CUENTA.Name = "CUENTA";
            this.CUENTA.ReadOnly = true;
            this.CUENTA.Width = 200;
            // 
            // MAYOR
            // 
            this.MAYOR.DataPropertyName = "MAYOR";
            this.MAYOR.HeaderText = "MAYOR";
            this.MAYOR.Name = "MAYOR";
            this.MAYOR.ReadOnly = true;
            // 
            // SALDO
            // 
            this.SALDO.DataPropertyName = "SALDO";
            this.SALDO.HeaderText = "SALDO";
            this.SALDO.Name = "SALDO";
            this.SALDO.ReadOnly = true;
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.DataPropertyName = "CATEGORIA";
            this.CATEGORIA.HeaderText = "CATEGORIA";
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.ReadOnly = true;
            // 
            // TIPO
            // 
            this.TIPO.DataPropertyName = "TIPO";
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            this.TIPO.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tblCATALOGO);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 356);
            this.panel1.TabIndex = 1;
            // 
            // progreso
            // 
            this.progreso.Location = new System.Drawing.Point(226, 373);
            this.progreso.Name = "progreso";
            this.progreso.Size = new System.Drawing.Size(219, 23);
            this.progreso.TabIndex = 5;
            // 
            // openFileCatalogo
            // 
            this.openFileCatalogo.Filter = "Excel Worksheets|*.xls;*.xlsx";
            this.openFileCatalogo.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileCatalogo_FileOk);
            // 
            // btnLIMPIAR
            // 
            this.btnLIMPIAR.Image = ((System.Drawing.Image)(resources.GetObject("btnLIMPIAR.Image")));
            this.btnLIMPIAR.Location = new System.Drawing.Point(470, 364);
            this.btnLIMPIAR.Name = "btnLIMPIAR";
            this.btnLIMPIAR.Size = new System.Drawing.Size(75, 44);
            this.btnLIMPIAR.TabIndex = 6;
            this.btnLIMPIAR.UseVisualStyleBackColor = true;
            this.btnLIMPIAR.Click += new System.EventHandler(this.LIMPIAR);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Image = global::DDSIC.Properties.Resources.Save_32x32;
            this.btnGUARDAR.Location = new System.Drawing.Point(649, 364);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(75, 44);
            this.btnGUARDAR.TabIndex = 3;
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // btnEXAMINAR
            // 
            this.btnEXAMINAR.Image = ((System.Drawing.Image)(resources.GetObject("btnEXAMINAR.Image")));
            this.btnEXAMINAR.Location = new System.Drawing.Point(122, 364);
            this.btnEXAMINAR.Name = "btnEXAMINAR";
            this.btnEXAMINAR.Size = new System.Drawing.Size(73, 44);
            this.btnEXAMINAR.TabIndex = 2;
            this.btnEXAMINAR.UseVisualStyleBackColor = true;
            this.btnEXAMINAR.Click += new System.EventHandler(this.EXAMINAR);
            // 
            // btnPlantilla
            // 
            this.btnPlantilla.Image = ((System.Drawing.Image)(resources.GetObject("btnPlantilla.Image")));
            this.btnPlantilla.Location = new System.Drawing.Point(12, 364);
            this.btnPlantilla.Name = "btnPlantilla";
            this.btnPlantilla.Size = new System.Drawing.Size(75, 44);
            this.btnPlantilla.TabIndex = 7;
            this.btnPlantilla.UseVisualStyleBackColor = true;
            this.btnPlantilla.Click += new System.EventHandler(this.btnPLANTILLA_Click);
            // 
            // ImportarCatalogoExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(773, 431);
            this.Controls.Add(this.btnPlantilla);
            this.Controls.Add(this.btnLIMPIAR);
            this.Controls.Add(this.progreso);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.btnEXAMINAR);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ImportarCatalogoExcel";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "IMPORTAR CATALOGO DE CUENTAS";
            this.Load += new System.EventHandler(this.ImportarCatalogoExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCATALOGO)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tblCATALOGO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEXAMINAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.ProgressBar progreso;
        private System.Windows.Forms.OpenFileDialog openFileCatalogo;
        private System.Windows.Forms.Button btnLIMPIAR;
        private System.Windows.Forms.SaveFileDialog saveFileCatalogoPlantilla;
        private System.Windows.Forms.Button btnPlantilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAYOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
    }
}