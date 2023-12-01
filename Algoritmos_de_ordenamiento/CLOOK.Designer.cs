namespace Algoritmos_de_ordenamiento
{
    partial class CLOOK
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
            this.zedG_CLOOK = new ZedGraph.ZedGraphControl();
            this.lblPROM = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCantDatos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbldatosant = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.richTextBoxCLOOK = new System.Windows.Forms.RichTextBox();
            this.tbl_CLOOK = new System.Windows.Forms.DataGridView();
            this.Numero_de_Pista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_pist_atravesadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_CLOOK)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOUT
            // 
            this.btnOUT.Location = new System.Drawing.Point(12, 415);
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
            this.lblCapacidad.Location = new System.Drawing.Point(14, 32);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(44, 16);
            this.lblCapacidad.TabIndex = 61;
            this.lblCapacidad.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 60;
            this.label4.Text = "Capacidad del disco:";
            // 
            // zedG_CLOOK
            // 
            this.zedG_CLOOK.Location = new System.Drawing.Point(702, 13);
            this.zedG_CLOOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedG_CLOOK.Name = "zedG_CLOOK";
            this.zedG_CLOOK.ScrollGrace = 0D;
            this.zedG_CLOOK.ScrollMaxX = 0D;
            this.zedG_CLOOK.ScrollMaxY = 0D;
            this.zedG_CLOOK.ScrollMaxY2 = 0D;
            this.zedG_CLOOK.ScrollMinX = 0D;
            this.zedG_CLOOK.ScrollMinY = 0D;
            this.zedG_CLOOK.ScrollMinY2 = 0D;
            this.zedG_CLOOK.Size = new System.Drawing.Size(774, 402);
            this.zedG_CLOOK.TabIndex = 59;
            // 
            // lblPROM
            // 
            this.lblPROM.AutoSize = true;
            this.lblPROM.Location = new System.Drawing.Point(527, 303);
            this.lblPROM.Name = "lblPROM";
            this.lblPROM.Size = new System.Drawing.Size(44, 16);
            this.lblPROM.TabIndex = 58;
            this.lblPROM.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 16);
            this.label3.TabIndex = 57;
            this.label3.Text = "LONGITUD MEDIA DE BUSQUEDA:";
            // 
            // lblCantDatos
            // 
            this.lblCantDatos.AutoSize = true;
            this.lblCantDatos.Location = new System.Drawing.Point(11, 74);
            this.lblCantDatos.Name = "lblCantDatos";
            this.lblCantDatos.Size = new System.Drawing.Size(44, 16);
            this.lblCantDatos.TabIndex = 56;
            this.lblCantDatos.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "Numero de datos:";
            // 
            // lbldatosant
            // 
            this.lbldatosant.AutoSize = true;
            this.lbldatosant.Location = new System.Drawing.Point(393, 33);
            this.lbldatosant.Name = "lbldatosant";
            this.lbldatosant.Size = new System.Drawing.Size(44, 16);
            this.lbldatosant.TabIndex = 54;
            this.lbldatosant.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "INICIO DEL CABEZAL:";
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Location = new System.Drawing.Point(138, 163);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(99, 41);
            this.btnAGREGAR.TabIndex = 52;
            this.btnAGREGAR.Text = "AGREGAR";
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // richTextBoxCLOOK
            // 
            this.richTextBoxCLOOK.Location = new System.Drawing.Point(11, 105);
            this.richTextBoxCLOOK.Name = "richTextBoxCLOOK";
            this.richTextBoxCLOOK.Size = new System.Drawing.Size(111, 284);
            this.richTextBoxCLOOK.TabIndex = 51;
            this.richTextBoxCLOOK.Text = "";
            // 
            // tbl_CLOOK
            // 
            this.tbl_CLOOK.AllowDrop = true;
            this.tbl_CLOOK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_CLOOK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero_de_Pista,
            this.num_pist_atravesadas});
            this.tbl_CLOOK.Location = new System.Drawing.Point(252, 52);
            this.tbl_CLOOK.Name = "tbl_CLOOK";
            this.tbl_CLOOK.RowHeadersWidth = 51;
            this.tbl_CLOOK.RowTemplate.Height = 24;
            this.tbl_CLOOK.Size = new System.Drawing.Size(400, 233);
            this.tbl_CLOOK.TabIndex = 50;
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
            // CLOOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 450);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.zedG_CLOOK);
            this.Controls.Add(this.lblPROM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCantDatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbldatosant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.richTextBoxCLOOK);
            this.Controls.Add(this.tbl_CLOOK);
            this.Controls.Add(this.btnOUT);
            this.Name = "CLOOK";
            this.Text = "CLOOK";
            ((System.ComponentModel.ISupportInitialize)(this.tbl_CLOOK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOUT;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label label4;
        private ZedGraph.ZedGraphControl zedG_CLOOK;
        private System.Windows.Forms.Label lblPROM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCantDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbldatosant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.RichTextBox richTextBoxCLOOK;
        private System.Windows.Forms.DataGridView tbl_CLOOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_de_Pista;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_pist_atravesadas;
    }
}