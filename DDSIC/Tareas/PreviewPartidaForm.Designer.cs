namespace DDSIC.Tareas
{
    partial class PreviewPartidaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grPartida = new System.Windows.Forms.GroupBox();
            this.lbBalance = new System.Windows.Forms.Label();
            this.lbMontoHaber = new System.Windows.Forms.Label();
            this.lbMontoDebe = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCODTRANS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNUMPARTIDA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tblMOVIMIENTOS = new System.Windows.Forms.DataGridView();
            this.NUMERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_CTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEBE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HABER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCONCEPTO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtREFERENCIA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datePartida = new System.Windows.Forms.DateTimePicker();
            this.grPartida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMOVIMIENTOS)).BeginInit();
            this.SuspendLayout();
            // 
            // grPartida
            // 
            this.grPartida.Controls.Add(this.lbBalance);
            this.grPartida.Controls.Add(this.lbMontoHaber);
            this.grPartida.Controls.Add(this.lbMontoDebe);
            this.grPartida.Controls.Add(this.label4);
            this.grPartida.Controls.Add(this.label3);
            this.grPartida.Controls.Add(this.txtCODTRANS);
            this.grPartida.Controls.Add(this.label6);
            this.grPartida.Controls.Add(this.txtNUMPARTIDA);
            this.grPartida.Controls.Add(this.label10);
            this.grPartida.Controls.Add(this.tblMOVIMIENTOS);
            this.grPartida.Controls.Add(this.txtCONCEPTO);
            this.grPartida.Controls.Add(this.label5);
            this.grPartida.Controls.Add(this.txtREFERENCIA);
            this.grPartida.Controls.Add(this.label2);
            this.grPartida.Controls.Add(this.label1);
            this.grPartida.Controls.Add(this.datePartida);
            this.grPartida.Location = new System.Drawing.Point(12, 1);
            this.grPartida.Name = "grPartida";
            this.grPartida.Size = new System.Drawing.Size(754, 425);
            this.grPartida.TabIndex = 22;
            this.grPartida.TabStop = false;
            // 
            // lbBalance
            // 
            this.lbBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalance.Location = new System.Drawing.Point(555, 398);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(153, 20);
            this.lbBalance.TabIndex = 32;
            this.lbBalance.Text = "0.00";
            this.lbBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMontoHaber
            // 
            this.lbMontoHaber.AutoSize = true;
            this.lbMontoHaber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMontoHaber.Location = new System.Drawing.Point(654, 372);
            this.lbMontoHaber.Name = "lbMontoHaber";
            this.lbMontoHaber.Size = new System.Drawing.Size(44, 20);
            this.lbMontoHaber.TabIndex = 31;
            this.lbMontoHaber.Text = "0.00";
            // 
            // lbMontoDebe
            // 
            this.lbMontoDebe.AutoSize = true;
            this.lbMontoDebe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMontoDebe.Location = new System.Drawing.Point(555, 372);
            this.lbMontoDebe.Name = "lbMontoDebe";
            this.lbMontoDebe.Size = new System.Drawing.Size(44, 20);
            this.lbMontoDebe.TabIndex = 30;
            this.lbMontoDebe.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "BALANCE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(469, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "TOTAL";
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
            this.label6.Location = new System.Drawing.Point(525, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "COD TRANS";
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
            this.tblMOVIMIENTOS.Location = new System.Drawing.Point(6, 132);
            this.tblMOVIMIENTOS.MultiSelect = false;
            this.tblMOVIMIENTOS.Name = "tblMOVIMIENTOS";
            this.tblMOVIMIENTOS.ReadOnly = true;
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
            this.tblMOVIMIENTOS.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tblMOVIMIENTOS_CellFormatting);
            // 
            // NUMERO
            // 
            this.NUMERO.DataPropertyName = "#";
            this.NUMERO.HeaderText = "#";
            this.NUMERO.Name = "NUMERO";
            this.NUMERO.ReadOnly = true;
            this.NUMERO.Width = 30;
            // 
            // COD_CTA
            // 
            this.COD_CTA.DataPropertyName = "COD_CTA";
            this.COD_CTA.HeaderText = "CUENTA";
            this.COD_CTA.Name = "COD_CTA";
            this.COD_CTA.ReadOnly = true;
            this.COD_CTA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.COD_CTA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.DataPropertyName = "DESCRIPCION";
            dataGridViewCellStyle1.NullValue = null;
            this.DESCRIPCION.DefaultCellStyle = dataGridViewCellStyle1;
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.MaxInputLength = 100;
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
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
            this.DEBE.ReadOnly = true;
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
            this.HABER.ReadOnly = true;
            this.HABER.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtCONCEPTO
            // 
            this.txtCONCEPTO.Location = new System.Drawing.Point(129, 87);
            this.txtCONCEPTO.MaxLength = 100;
            this.txtCONCEPTO.Multiline = true;
            this.txtCONCEPTO.Name = "txtCONCEPTO";
            this.txtCONCEPTO.ReadOnly = true;
            this.txtCONCEPTO.Size = new System.Drawing.Size(315, 39);
            this.txtCONCEPTO.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CONCEPTO";
            // 
            // txtREFERENCIA
            // 
            this.txtREFERENCIA.Location = new System.Drawing.Point(129, 61);
            this.txtREFERENCIA.MaxLength = 20;
            this.txtREFERENCIA.Name = "txtREFERENCIA";
            this.txtREFERENCIA.ReadOnly = true;
            this.txtREFERENCIA.Size = new System.Drawing.Size(123, 20);
            this.txtREFERENCIA.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "REFERENCIA";
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
            this.datePartida.Enabled = false;
            this.datePartida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePartida.Location = new System.Drawing.Point(129, 35);
            this.datePartida.Name = "datePartida";
            this.datePartida.Size = new System.Drawing.Size(108, 20);
            this.datePartida.TabIndex = 0;
            // 
            // PreviewPartidaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(775, 455);
            this.Controls.Add(this.grPartida);
            this.MaximizeBox = false;
            this.Name = "PreviewPartidaForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PREVIEW PARTIDA";
            this.Load += new System.EventHandler(this.PreviewPartidaForm_Load);
            this.grPartida.ResumeLayout(false);
            this.grPartida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMOVIMIENTOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grPartida;
        private System.Windows.Forms.TextBox txtCODTRANS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNUMPARTIDA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView tblMOVIMIENTOS;
        private System.Windows.Forms.TextBox txtCONCEPTO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtREFERENCIA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePartida;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label lbMontoHaber;
        private System.Windows.Forms.Label lbMontoDebe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_CTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEBE;
        private System.Windows.Forms.DataGridViewTextBoxColumn HABER;


    }
}