namespace DDSIC.Catalogos
{
    partial class CuentaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuentaForm));
            this.label5 = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.cbxSaldo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreCta = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CANCELAR = new System.Windows.Forms.Button();
            this.GUARDAR = new System.Windows.Forms.Button();
            this.cbxMayor = new DevComponents.DotNetBar.Controls.ComboTree();
            this.COD_CTA = new DevComponents.AdvTree.ColumnHeader();
            this.NOMBRE = new DevComponents.AdvTree.ColumnHeader();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "TIPO CUENTA:";
            // 
            // cbxTipo
            // 
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(142, 180);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(199, 21);
            this.cbxTipo.TabIndex = 26;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(142, 145);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(199, 21);
            this.cbxCategoria.TabIndex = 24;
            // 
            // cbxSaldo
            // 
            this.cbxSaldo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSaldo.FormattingEnabled = true;
            this.cbxSaldo.Location = new System.Drawing.Point(142, 216);
            this.cbxSaldo.Name = "cbxSaldo";
            this.cbxSaldo.Size = new System.Drawing.Size(199, 21);
            this.cbxSaldo.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "SALDO:";
            // 
            // txtNombreCta
            // 
            this.txtNombreCta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreCta.Location = new System.Drawing.Point(142, 58);
            this.txtNombreCta.MaxLength = 100;
            this.txtNombreCta.Multiline = true;
            this.txtNombreCta.Name = "txtNombreCta";
            this.txtNombreCta.Size = new System.Drawing.Size(199, 39);
            this.txtNombreCta.TabIndex = 18;
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Location = new System.Drawing.Point(142, 21);
            this.txtCodigo.MaxLength = 15;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(199, 20);
            this.txtCodigo.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "CTA. MAYOR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "CATEGORIA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "NOMBRE CTA.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "CODIGO:";
            // 
            // CANCELAR
            // 
            this.CANCELAR.Image = ((System.Drawing.Image)(resources.GetObject("CANCELAR.Image")));
            this.CANCELAR.Location = new System.Drawing.Point(226, 283);
            this.CANCELAR.Name = "CANCELAR";
            this.CANCELAR.Size = new System.Drawing.Size(128, 40);
            this.CANCELAR.TabIndex = 51;
            this.CANCELAR.Text = "CANCELAR";
            this.CANCELAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CANCELAR.UseVisualStyleBackColor = true;
            this.CANCELAR.Click += new System.EventHandler(this.CANCELAR_Click);
            // 
            // GUARDAR
            // 
            this.GUARDAR.Image = ((System.Drawing.Image)(resources.GetObject("GUARDAR.Image")));
            this.GUARDAR.Location = new System.Drawing.Point(28, 283);
            this.GUARDAR.Name = "GUARDAR";
            this.GUARDAR.Size = new System.Drawing.Size(128, 40);
            this.GUARDAR.TabIndex = 50;
            this.GUARDAR.Text = "GUARDAR";
            this.GUARDAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GUARDAR.UseVisualStyleBackColor = true;
            this.GUARDAR.Click += new System.EventHandler(this.GUARDAR_Click);
            // 
            // cbxMayor
            // 
            this.cbxMayor.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.cbxMayor.BackgroundStyle.Class = "TextBoxBorder";
            this.cbxMayor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxMayor.ButtonDropDown.Visible = true;
            this.cbxMayor.Columns.Add(this.COD_CTA);
            this.cbxMayor.Columns.Add(this.NOMBRE);
            this.cbxMayor.DropDownWidth = 320;
            this.cbxMayor.Location = new System.Drawing.Point(142, 106);
            this.cbxMayor.Name = "cbxMayor";
            this.cbxMayor.SelectionBoxStyle = DevComponents.AdvTree.eSelectionStyle.FullRowSelect;
            this.cbxMayor.Size = new System.Drawing.Size(199, 23);
            this.cbxMayor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxMayor.TabIndex = 52;
            // 
            // COD_CTA
            // 
            this.COD_CTA.ColumnName = "COD_CTA";
            this.COD_CTA.DataFieldName = "COD_CTA";
            this.COD_CTA.MaxInputLength = 15;
            this.COD_CTA.Name = "COD_CTA";
            this.COD_CTA.Text = "CODIGO";
            this.COD_CTA.Width.Absolute = 60;
            // 
            // NOMBRE
            // 
            this.NOMBRE.ColumnName = "NOMBRE";
            this.NOMBRE.DataFieldName = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Text = "CUENTA";
            this.NOMBRE.Width.Absolute = 240;
            // 
            // CuentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(380, 335);
            this.Controls.Add(this.cbxMayor);
            this.Controls.Add(this.CANCELAR);
            this.Controls.Add(this.GUARDAR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxSaldo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombreCta);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CuentaForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CUENTA";
            this.Load += new System.EventHandler(this.CuentaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.ComboBox cbxSaldo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreCta;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CANCELAR;
        private System.Windows.Forms.Button GUARDAR;
        private DevComponents.DotNetBar.Controls.ComboTree cbxMayor;
        private DevComponents.AdvTree.ColumnHeader COD_CTA;
        private DevComponents.AdvTree.ColumnHeader NOMBRE;
    }
}