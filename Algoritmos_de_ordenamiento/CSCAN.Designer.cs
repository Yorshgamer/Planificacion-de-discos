namespace Algoritmos_de_ordenamiento
{
    partial class CSCAN
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
            this.btnOUT = new System.Windows.Forms.Button();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.zedG_CSCAN = new ZedGraph.ZedGraphControl();
            this.lblPROM = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCantDatos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbldatosant = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.richTextBoxCSCAN = new System.Windows.Forms.RichTextBox();
            this.tbl_CSCAN = new System.Windows.Forms.DataGridView();
            this.Numero_de_Pista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_pist_atravesadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_CSCAN)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOUT
            // 
            this.btnOUT.Location = new System.Drawing.Point(12, 400);
            this.btnOUT.Name = "btnOUT";
            this.btnOUT.Size = new System.Drawing.Size(75, 23);
            this.btnOUT.TabIndex = 0;
            this.btnOUT.Text = "SALIR";
            this.btnOUT.UseVisualStyleBackColor = true;
            this.btnOUT.Click += new System.EventHandler(this.btnOUT_Click);
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(11, 28);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(44, 16);
            this.lblCapacidad.TabIndex = 37;
            this.lblCapacidad.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Capacidad del disco:";
            // 
            // zedG_CSCAN
            // 
            this.zedG_CSCAN.Location = new System.Drawing.Point(699, 9);
            this.zedG_CSCAN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedG_CSCAN.Name = "zedG_CSCAN";
            this.zedG_CSCAN.ScrollGrace = 0D;
            this.zedG_CSCAN.ScrollMaxX = 0D;
            this.zedG_CSCAN.ScrollMaxY = 0D;
            this.zedG_CSCAN.ScrollMaxY2 = 0D;
            this.zedG_CSCAN.ScrollMinX = 0D;
            this.zedG_CSCAN.ScrollMinY = 0D;
            this.zedG_CSCAN.ScrollMinY2 = 0D;
            this.zedG_CSCAN.Size = new System.Drawing.Size(774, 402);
            this.zedG_CSCAN.TabIndex = 35;
            // 
            // lblPROM
            // 
            this.lblPROM.AutoSize = true;
            this.lblPROM.Location = new System.Drawing.Point(524, 299);
            this.lblPROM.Name = "lblPROM";
            this.lblPROM.Size = new System.Drawing.Size(44, 16);
            this.lblPROM.TabIndex = 34;
            this.lblPROM.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "LONGITUD MEDIA DE BUSQUEDA:";
            // 
            // lblCantDatos
            // 
            this.lblCantDatos.AutoSize = true;
            this.lblCantDatos.Location = new System.Drawing.Point(8, 70);
            this.lblCantDatos.Name = "lblCantDatos";
            this.lblCantDatos.Size = new System.Drawing.Size(44, 16);
            this.lblCantDatos.TabIndex = 32;
            this.lblCantDatos.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Numero de datos:";
            // 
            // lbldatosant
            // 
            this.lbldatosant.AutoSize = true;
            this.lbldatosant.Location = new System.Drawing.Point(390, 29);
            this.lbldatosant.Name = "lbldatosant";
            this.lbldatosant.Size = new System.Drawing.Size(44, 16);
            this.lbldatosant.TabIndex = 30;
            this.lbldatosant.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "INICIO DEL CABEZAL:";
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Location = new System.Drawing.Point(135, 159);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(99, 41);
            this.btnAGREGAR.TabIndex = 28;
            this.btnAGREGAR.Text = "AGREGAR";
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // richTextBoxCSCAN
            // 
            this.richTextBoxCSCAN.Location = new System.Drawing.Point(8, 101);
            this.richTextBoxCSCAN.Name = "richTextBoxCSCAN";
            this.richTextBoxCSCAN.Size = new System.Drawing.Size(111, 284);
            this.richTextBoxCSCAN.TabIndex = 27;
            this.richTextBoxCSCAN.Text = "";
            // 
            // tbl_CSCAN
            // 
            this.tbl_CSCAN.AllowDrop = true;
            this.tbl_CSCAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_CSCAN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero_de_Pista,
            this.num_pist_atravesadas});
            this.tbl_CSCAN.Location = new System.Drawing.Point(249, 48);
            this.tbl_CSCAN.Name = "tbl_CSCAN";
            this.tbl_CSCAN.RowHeadersWidth = 51;
            this.tbl_CSCAN.RowTemplate.Height = 24;
            this.tbl_CSCAN.Size = new System.Drawing.Size(400, 233);
            this.tbl_CSCAN.TabIndex = 26;
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
            // CSCAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 450);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.zedG_CSCAN);
            this.Controls.Add(this.lblPROM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCantDatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbldatosant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.richTextBoxCSCAN);
            this.Controls.Add(this.tbl_CSCAN);
            this.Controls.Add(this.btnOUT);
            this.Name = "CSCAN";
            this.Text = "CSCAN";
            ((System.ComponentModel.ISupportInitialize)(this.tbl_CSCAN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOUT;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label label4;
        private ZedGraph.ZedGraphControl zedG_CSCAN;
        private System.Windows.Forms.Label lblPROM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCantDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbldatosant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.RichTextBox richTextBoxCSCAN;
        private System.Windows.Forms.DataGridView tbl_CSCAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_de_Pista;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_pist_atravesadas;
    }
}