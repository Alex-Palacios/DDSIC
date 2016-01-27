namespace DDSIC.Tareas
{
    partial class ConfirmarPartida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmarPartida));
            this.lbHABER = new System.Windows.Forms.Label();
            this.lbCONCEPTO = new System.Windows.Forms.Label();
            this.lbFECHA = new System.Windows.Forms.Label();
            this.lbNUMPARTIDA = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CANCELAR = new System.Windows.Forms.Button();
            this.GUARDAR = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbDEBE = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbREFERENCIA = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbHABER
            // 
            this.lbHABER.AutoSize = true;
            this.lbHABER.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHABER.ForeColor = System.Drawing.Color.Green;
            this.lbHABER.Location = new System.Drawing.Point(129, 211);
            this.lbHABER.Name = "lbHABER";
            this.lbHABER.Size = new System.Drawing.Size(49, 17);
            this.lbHABER.TabIndex = 86;
            this.lbHABER.Text = "$0.00";
            // 
            // lbCONCEPTO
            // 
            this.lbCONCEPTO.Location = new System.Drawing.Point(132, 117);
            this.lbCONCEPTO.Name = "lbCONCEPTO";
            this.lbCONCEPTO.Size = new System.Drawing.Size(168, 37);
            this.lbCONCEPTO.TabIndex = 81;
            this.lbCONCEPTO.Text = "concepto";
            // 
            // lbFECHA
            // 
            this.lbFECHA.AutoSize = true;
            this.lbFECHA.Location = new System.Drawing.Point(132, 53);
            this.lbFECHA.Name = "lbFECHA";
            this.lbFECHA.Size = new System.Drawing.Size(67, 13);
            this.lbFECHA.TabIndex = 80;
            this.lbFECHA.Text = "dd/MM/yyyy";
            // 
            // lbNUMPARTIDA
            // 
            this.lbNUMPARTIDA.AutoSize = true;
            this.lbNUMPARTIDA.ForeColor = System.Drawing.Color.Navy;
            this.lbNUMPARTIDA.Location = new System.Drawing.Point(132, 24);
            this.lbNUMPARTIDA.Name = "lbNUMPARTIDA";
            this.lbNUMPARTIDA.Size = new System.Drawing.Size(42, 13);
            this.lbNUMPARTIDA.TabIndex = 79;
            this.lbNUMPARTIDA.Text = "periodo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 74;
            this.label5.Text = "HABER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "CONCEPTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "FECHA";
            // 
            // CANCELAR
            // 
            this.CANCELAR.Image = ((System.Drawing.Image)(resources.GetObject("CANCELAR.Image")));
            this.CANCELAR.Location = new System.Drawing.Point(160, 268);
            this.CANCELAR.Name = "CANCELAR";
            this.CANCELAR.Size = new System.Drawing.Size(128, 40);
            this.CANCELAR.TabIndex = 70;
            this.CANCELAR.Text = "CANCELAR";
            this.CANCELAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CANCELAR.UseVisualStyleBackColor = true;
            this.CANCELAR.Click += new System.EventHandler(this.CANCELAR_Click);
            // 
            // GUARDAR
            // 
            this.GUARDAR.Image = ((System.Drawing.Image)(resources.GetObject("GUARDAR.Image")));
            this.GUARDAR.Location = new System.Drawing.Point(12, 268);
            this.GUARDAR.Name = "GUARDAR";
            this.GUARDAR.Size = new System.Drawing.Size(113, 40);
            this.GUARDAR.TabIndex = 69;
            this.GUARDAR.Text = "GUARDAR";
            this.GUARDAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GUARDAR.UseVisualStyleBackColor = true;
            this.GUARDAR.Click += new System.EventHandler(this.GUARDAR_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 88;
            this.label6.Text = "DEBE";
            // 
            // lbDEBE
            // 
            this.lbDEBE.AutoSize = true;
            this.lbDEBE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDEBE.ForeColor = System.Drawing.Color.Green;
            this.lbDEBE.Location = new System.Drawing.Point(129, 171);
            this.lbDEBE.Name = "lbDEBE";
            this.lbDEBE.Size = new System.Drawing.Size(49, 17);
            this.lbDEBE.TabIndex = 89;
            this.lbDEBE.Text = "$0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 91;
            this.label7.Text = "PARTIDA #";
            // 
            // lbREFERENCIA
            // 
            this.lbREFERENCIA.AutoSize = true;
            this.lbREFERENCIA.Location = new System.Drawing.Point(129, 85);
            this.lbREFERENCIA.Name = "lbREFERENCIA";
            this.lbREFERENCIA.Size = new System.Drawing.Size(38, 13);
            this.lbREFERENCIA.TabIndex = 94;
            this.lbREFERENCIA.Text = "cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 93;
            this.label8.Text = "REFERENCIA";
            // 
            // ConfirmarPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(312, 323);
            this.Controls.Add(this.lbREFERENCIA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbDEBE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbHABER);
            this.Controls.Add(this.lbCONCEPTO);
            this.Controls.Add(this.lbFECHA);
            this.Controls.Add(this.lbNUMPARTIDA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CANCELAR);
            this.Controls.Add(this.GUARDAR);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfirmarPartida";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PARTIDA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHABER;
        private System.Windows.Forms.Label lbCONCEPTO;
        private System.Windows.Forms.Label lbFECHA;
        private System.Windows.Forms.Label lbNUMPARTIDA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CANCELAR;
        private System.Windows.Forms.Button GUARDAR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbDEBE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbREFERENCIA;
        private System.Windows.Forms.Label label8;
    }
}