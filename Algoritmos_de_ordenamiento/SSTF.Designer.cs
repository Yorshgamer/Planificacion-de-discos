namespace Algoritmos_de_ordenamiento
{
    partial class SSTF
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
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCantDatos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.richTextBoxSSTF = new System.Windows.Forms.RichTextBox();
            this.btnOUT = new System.Windows.Forms.Button();
            this.lblPROM = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbldatosant = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_SSTF = new System.Windows.Forms.DataGridView();
            this.Numero_de_Pista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_pist_atravesadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zedG_SSTF = new ZedGraph.ZedGraphControl();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_SSTF)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(15, 28);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(44, 16);
            this.lblCapacidad.TabIndex = 16;
            this.lblCapacidad.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Capacidad del disco:";
            // 
            // lblCantDatos
            // 
            this.lblCantDatos.AutoSize = true;
            this.lblCantDatos.Location = new System.Drawing.Point(12, 70);
            this.lblCantDatos.Name = "lblCantDatos";
            this.lblCantDatos.Size = new System.Drawing.Size(44, 16);
            this.lblCantDatos.TabIndex = 14;
            this.lblCantDatos.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Numero de datos:";
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Location = new System.Drawing.Point(142, 162);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(99, 41);
            this.btnAGREGAR.TabIndex = 19;
            this.btnAGREGAR.Text = "AGREGAR";
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // richTextBoxSSTF
            // 
            this.richTextBoxSSTF.Location = new System.Drawing.Point(15, 104);
            this.richTextBoxSSTF.Name = "richTextBoxSSTF";
            this.richTextBoxSSTF.Size = new System.Drawing.Size(111, 284);
            this.richTextBoxSSTF.TabIndex = 18;
            this.richTextBoxSSTF.Text = "";
            // 
            // btnOUT
            // 
            this.btnOUT.Location = new System.Drawing.Point(15, 394);
            this.btnOUT.Name = "btnOUT";
            this.btnOUT.Size = new System.Drawing.Size(94, 41);
            this.btnOUT.TabIndex = 17;
            this.btnOUT.Text = "SALIR";
            this.btnOUT.UseVisualStyleBackColor = true;
            this.btnOUT.Click += new System.EventHandler(this.btnOUT_Click);
            // 
            // lblPROM
            // 
            this.lblPROM.AutoSize = true;
            this.lblPROM.Location = new System.Drawing.Point(522, 355);
            this.lblPROM.Name = "lblPROM";
            this.lblPROM.Size = new System.Drawing.Size(44, 16);
            this.lblPROM.TabIndex = 24;
            this.lblPROM.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "LONGITUD MEDIA DE BUSQUEDA:";
            // 
            // lbldatosant
            // 
            this.lbldatosant.AutoSize = true;
            this.lbldatosant.Location = new System.Drawing.Point(388, 85);
            this.lbldatosant.Name = "lbldatosant";
            this.lbldatosant.Size = new System.Drawing.Size(44, 16);
            this.lbldatosant.TabIndex = 22;
            this.lbldatosant.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "INICIO DEL CABEZAL:";
            // 
            // tbl_SSTF
            // 
            this.tbl_SSTF.AllowDrop = true;
            this.tbl_SSTF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_SSTF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero_de_Pista,
            this.num_pist_atravesadas});
            this.tbl_SSTF.Location = new System.Drawing.Point(247, 104);
            this.tbl_SSTF.Name = "tbl_SSTF";
            this.tbl_SSTF.RowHeadersWidth = 51;
            this.tbl_SSTF.RowTemplate.Height = 24;
            this.tbl_SSTF.Size = new System.Drawing.Size(400, 233);
            this.tbl_SSTF.TabIndex = 20;
            // 
            // Numero_de_Pista
            // 
            this.Numero_de_Pista.HeaderText = "Proxima Pista";
            this.Numero_de_Pista.MinimumWidth = 6;
            this.Numero_de_Pista.Name = "Numero_de_Pista";
            this.Numero_de_Pista.Width = 125;
            // 
            // num_pist_atravesadas
            // 
            this.num_pist_atravesadas.HeaderText = "Numero de Pistas Atravesadas";
            this.num_pist_atravesadas.MinimumWidth = 6;
            this.num_pist_atravesadas.Name = "num_pist_atravesadas";
            this.num_pist_atravesadas.Width = 125;
            // 
            // zedG_SSTF
            // 
            this.zedG_SSTF.Location = new System.Drawing.Point(674, 35);
            this.zedG_SSTF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedG_SSTF.Name = "zedG_SSTF";
            this.zedG_SSTF.ScrollGrace = 0D;
            this.zedG_SSTF.ScrollMaxX = 0D;
            this.zedG_SSTF.ScrollMaxY = 0D;
            this.zedG_SSTF.ScrollMaxY2 = 0D;
            this.zedG_SSTF.ScrollMinX = 0D;
            this.zedG_SSTF.ScrollMinY = 0D;
            this.zedG_SSTF.ScrollMinY2 = 0D;
            this.zedG_SSTF.Size = new System.Drawing.Size(774, 402);
            this.zedG_SSTF.TabIndex = 25;
            // 
            // SSTF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 450);
            this.Controls.Add(this.zedG_SSTF);
            this.Controls.Add(this.lblPROM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbldatosant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbl_SSTF);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.richTextBoxSSTF);
            this.Controls.Add(this.btnOUT);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCantDatos);
            this.Controls.Add(this.label2);
            this.Name = "SSTF";
            this.Text = "SSTF";
            ((System.ComponentModel.ISupportInitialize)(this.tbl_SSTF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCantDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.RichTextBox richTextBoxSSTF;
        private System.Windows.Forms.Button btnOUT;
        private System.Windows.Forms.Label lblPROM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbldatosant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tbl_SSTF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_de_Pista;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_pist_atravesadas;
        private ZedGraph.ZedGraphControl zedG_SSTF;
    }
}