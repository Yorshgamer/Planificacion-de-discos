namespace Algoritmos_de_ordenamiento
{
    partial class SCAN
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
            this.zedG_SCAN = new ZedGraph.ZedGraphControl();
            this.lblPROM = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCantDatos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbldatosant = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.richTextBoxSCAN = new System.Windows.Forms.RichTextBox();
            this.tbl_SCAN = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Numero_de_Pista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_pist_atravesadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_SCAN)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(17, 35);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(44, 16);
            this.lblCapacidad.TabIndex = 25;
            this.lblCapacidad.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Capacidad del disco:";
            // 
            // zedG_SCAN
            // 
            this.zedG_SCAN.Location = new System.Drawing.Point(705, 16);
            this.zedG_SCAN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedG_SCAN.Name = "zedG_SCAN";
            this.zedG_SCAN.ScrollGrace = 0D;
            this.zedG_SCAN.ScrollMaxX = 0D;
            this.zedG_SCAN.ScrollMaxY = 0D;
            this.zedG_SCAN.ScrollMaxY2 = 0D;
            this.zedG_SCAN.ScrollMinX = 0D;
            this.zedG_SCAN.ScrollMinY = 0D;
            this.zedG_SCAN.ScrollMinY2 = 0D;
            this.zedG_SCAN.Size = new System.Drawing.Size(774, 402);
            this.zedG_SCAN.TabIndex = 23;
            // 
            // lblPROM
            // 
            this.lblPROM.AutoSize = true;
            this.lblPROM.Location = new System.Drawing.Point(530, 306);
            this.lblPROM.Name = "lblPROM";
            this.lblPROM.Size = new System.Drawing.Size(44, 16);
            this.lblPROM.TabIndex = 22;
            this.lblPROM.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "LONGITUD MEDIA DE BUSQUEDA:";
            // 
            // lblCantDatos
            // 
            this.lblCantDatos.AutoSize = true;
            this.lblCantDatos.Location = new System.Drawing.Point(14, 77);
            this.lblCantDatos.Name = "lblCantDatos";
            this.lblCantDatos.Size = new System.Drawing.Size(44, 16);
            this.lblCantDatos.TabIndex = 20;
            this.lblCantDatos.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Numero de datos:";
            // 
            // lbldatosant
            // 
            this.lbldatosant.AutoSize = true;
            this.lbldatosant.Location = new System.Drawing.Point(396, 36);
            this.lbldatosant.Name = "lbldatosant";
            this.lbldatosant.Size = new System.Drawing.Size(44, 16);
            this.lbldatosant.TabIndex = 18;
            this.lbldatosant.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "INICIO DEL CABEZAL:";
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Location = new System.Drawing.Point(141, 166);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(99, 41);
            this.btnAGREGAR.TabIndex = 16;
            this.btnAGREGAR.Text = "AGREGAR";
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // richTextBoxSCAN
            // 
            this.richTextBoxSCAN.Location = new System.Drawing.Point(14, 108);
            this.richTextBoxSCAN.Name = "richTextBoxSCAN";
            this.richTextBoxSCAN.Size = new System.Drawing.Size(111, 284);
            this.richTextBoxSCAN.TabIndex = 15;
            this.richTextBoxSCAN.Text = "";
            // 
            // tbl_SCAN
            // 
            this.tbl_SCAN.AllowDrop = true;
            this.tbl_SCAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_SCAN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero_de_Pista,
            this.num_pist_atravesadas});
            this.tbl_SCAN.Location = new System.Drawing.Point(255, 55);
            this.tbl_SCAN.Name = "tbl_SCAN";
            this.tbl_SCAN.RowHeadersWidth = 51;
            this.tbl_SCAN.RowTemplate.Height = 24;
            this.tbl_SCAN.Size = new System.Drawing.Size(400, 233);
            this.tbl_SCAN.TabIndex = 14;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(14, 398);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 41);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Numero_de_Pista
            // 
            this.Numero_de_Pista.HeaderText = "Proxima Pista";
            this.Numero_de_Pista.MinimumWidth = 6;
            this.Numero_de_Pista.Name = "Numero_de_Pista";
            this.Numero_de_Pista.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Numero_de_Pista.Width = 125;
            // 
            // num_pist_atravesadas
            // 
            this.num_pist_atravesadas.HeaderText = "Numero de Pistas Atravesadas";
            this.num_pist_atravesadas.MinimumWidth = 6;
            this.num_pist_atravesadas.Name = "num_pist_atravesadas";
            this.num_pist_atravesadas.Width = 125;
            // 
            // SCAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 450);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.zedG_SCAN);
            this.Controls.Add(this.lblPROM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCantDatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbldatosant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.richTextBoxSCAN);
            this.Controls.Add(this.tbl_SCAN);
            this.Controls.Add(this.btnSalir);
            this.Name = "SCAN";
            this.Text = "SCAN";
            ((System.ComponentModel.ISupportInitialize)(this.tbl_SCAN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label label4;
        private ZedGraph.ZedGraphControl zedG_SCAN;
        private System.Windows.Forms.Label lblPROM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCantDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbldatosant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.RichTextBox richTextBoxSCAN;
        private System.Windows.Forms.DataGridView tbl_SCAN;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_de_Pista;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_pist_atravesadas;
    }
}