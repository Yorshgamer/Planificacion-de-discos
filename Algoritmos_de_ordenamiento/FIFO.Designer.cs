namespace Algoritmos_de_ordenamiento
{
    partial class FIFO
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
            this.tbl_FIFO = new System.Windows.Forms.DataGridView();
            this.Numero_de_Pista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_pist_atravesadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBoxFIFO = new System.Windows.Forms.RichTextBox();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldatosant = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCantDatos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPROM = new System.Windows.Forms.Label();
            this.zedG_FIFO = new ZedGraph.ZedGraphControl();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_FIFO)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOUT
            // 
            this.btnOUT.Location = new System.Drawing.Point(31, 405);
            this.btnOUT.Name = "btnOUT";
            this.btnOUT.Size = new System.Drawing.Size(94, 41);
            this.btnOUT.TabIndex = 0;
            this.btnOUT.Text = "SALIR";
            this.btnOUT.UseVisualStyleBackColor = true;
            this.btnOUT.Click += new System.EventHandler(this.btnOUT_Click);
            // 
            // tbl_FIFO
            // 
            this.tbl_FIFO.AllowDrop = true;
            this.tbl_FIFO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_FIFO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero_de_Pista,
            this.num_pist_atravesadas});
            this.tbl_FIFO.Location = new System.Drawing.Point(272, 62);
            this.tbl_FIFO.Name = "tbl_FIFO";
            this.tbl_FIFO.RowHeadersWidth = 51;
            this.tbl_FIFO.RowTemplate.Height = 24;
            this.tbl_FIFO.Size = new System.Drawing.Size(400, 233);
            this.tbl_FIFO.TabIndex = 1;
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
            // richTextBoxFIFO
            // 
            this.richTextBoxFIFO.Location = new System.Drawing.Point(31, 115);
            this.richTextBoxFIFO.Name = "richTextBoxFIFO";
            this.richTextBoxFIFO.Size = new System.Drawing.Size(111, 284);
            this.richTextBoxFIFO.TabIndex = 2;
            this.richTextBoxFIFO.Text = "";
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Location = new System.Drawing.Point(158, 173);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(99, 41);
            this.btnAGREGAR.TabIndex = 3;
            this.btnAGREGAR.Text = "AGREGAR";
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "INICIO DEL CABEZAL:";
            // 
            // lbldatosant
            // 
            this.lbldatosant.AutoSize = true;
            this.lbldatosant.Location = new System.Drawing.Point(413, 43);
            this.lbldatosant.Name = "lbldatosant";
            this.lbldatosant.Size = new System.Drawing.Size(44, 16);
            this.lbldatosant.TabIndex = 5;
            this.lbldatosant.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numero de datos:";
            // 
            // lblCantDatos
            // 
            this.lblCantDatos.AutoSize = true;
            this.lblCantDatos.Location = new System.Drawing.Point(31, 84);
            this.lblCantDatos.Name = "lblCantDatos";
            this.lblCantDatos.Size = new System.Drawing.Size(44, 16);
            this.lblCantDatos.TabIndex = 7;
            this.lblCantDatos.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "LONGITUD MEDIA DE BUSQUEDA:";
            // 
            // lblPROM
            // 
            this.lblPROM.AutoSize = true;
            this.lblPROM.Location = new System.Drawing.Point(547, 313);
            this.lblPROM.Name = "lblPROM";
            this.lblPROM.Size = new System.Drawing.Size(44, 16);
            this.lblPROM.TabIndex = 9;
            this.lblPROM.Text = "label4";
            // 
            // zedG_FIFO
            // 
            this.zedG_FIFO.Location = new System.Drawing.Point(722, 23);
            this.zedG_FIFO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedG_FIFO.Name = "zedG_FIFO";
            this.zedG_FIFO.ScrollGrace = 0D;
            this.zedG_FIFO.ScrollMaxX = 0D;
            this.zedG_FIFO.ScrollMaxY = 0D;
            this.zedG_FIFO.ScrollMaxY2 = 0D;
            this.zedG_FIFO.ScrollMinX = 0D;
            this.zedG_FIFO.ScrollMinY = 0D;
            this.zedG_FIFO.ScrollMinY2 = 0D;
            this.zedG_FIFO.Size = new System.Drawing.Size(774, 402);
            this.zedG_FIFO.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Capacidad del disco:";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(34, 42);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(44, 16);
            this.lblCapacidad.TabIndex = 12;
            this.lblCapacidad.Text = "label5";
            // 
            // FIFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 458);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.zedG_FIFO);
            this.Controls.Add(this.lblPROM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCantDatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbldatosant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.richTextBoxFIFO);
            this.Controls.Add(this.tbl_FIFO);
            this.Controls.Add(this.btnOUT);
            this.Name = "FIFO";
            this.Text = "FIFO";
            ((System.ComponentModel.ISupportInitialize)(this.tbl_FIFO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOUT;
        private System.Windows.Forms.DataGridView tbl_FIFO;
        private System.Windows.Forms.RichTextBox richTextBoxFIFO;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldatosant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_de_Pista;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_pist_atravesadas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCantDatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPROM;
        private ZedGraph.ZedGraphControl zedG_FIFO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCapacidad;
    }
}