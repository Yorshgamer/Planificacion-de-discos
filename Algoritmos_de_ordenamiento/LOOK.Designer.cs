namespace Algoritmos_de_ordenamiento
{
    partial class LOOK
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
            this.zedG_LOOK = new ZedGraph.ZedGraphControl();
            this.lblPROM = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCantDatos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbldatosant = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.richTextBoxLOOK = new System.Windows.Forms.RichTextBox();
            this.tbl_LOOK = new System.Windows.Forms.DataGridView();
            this.Numero_de_Pista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_pist_atravesadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_LOOK)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOUT
            // 
            this.btnOUT.Location = new System.Drawing.Point(23, 406);
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
            this.lblCapacidad.Location = new System.Drawing.Point(14, 29);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(44, 16);
            this.lblCapacidad.TabIndex = 49;
            this.lblCapacidad.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Capacidad del disco:";
            // 
            // zedG_LOOK
            // 
            this.zedG_LOOK.Location = new System.Drawing.Point(702, 10);
            this.zedG_LOOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedG_LOOK.Name = "zedG_LOOK";
            this.zedG_LOOK.ScrollGrace = 0D;
            this.zedG_LOOK.ScrollMaxX = 0D;
            this.zedG_LOOK.ScrollMaxY = 0D;
            this.zedG_LOOK.ScrollMaxY2 = 0D;
            this.zedG_LOOK.ScrollMinX = 0D;
            this.zedG_LOOK.ScrollMinY = 0D;
            this.zedG_LOOK.ScrollMinY2 = 0D;
            this.zedG_LOOK.Size = new System.Drawing.Size(774, 402);
            this.zedG_LOOK.TabIndex = 47;
            // 
            // lblPROM
            // 
            this.lblPROM.AutoSize = true;
            this.lblPROM.Location = new System.Drawing.Point(527, 300);
            this.lblPROM.Name = "lblPROM";
            this.lblPROM.Size = new System.Drawing.Size(44, 16);
            this.lblPROM.TabIndex = 46;
            this.lblPROM.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "LONGITUD MEDIA DE BUSQUEDA:";
            // 
            // lblCantDatos
            // 
            this.lblCantDatos.AutoSize = true;
            this.lblCantDatos.Location = new System.Drawing.Point(11, 71);
            this.lblCantDatos.Name = "lblCantDatos";
            this.lblCantDatos.Size = new System.Drawing.Size(44, 16);
            this.lblCantDatos.TabIndex = 44;
            this.lblCantDatos.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Numero de datos:";
            // 
            // lbldatosant
            // 
            this.lbldatosant.AutoSize = true;
            this.lbldatosant.Location = new System.Drawing.Point(393, 30);
            this.lbldatosant.Name = "lbldatosant";
            this.lbldatosant.Size = new System.Drawing.Size(44, 16);
            this.lbldatosant.TabIndex = 42;
            this.lbldatosant.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "INICIO DEL CABEZAL:";
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Location = new System.Drawing.Point(138, 160);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(99, 41);
            this.btnAGREGAR.TabIndex = 40;
            this.btnAGREGAR.Text = "AGREGAR";
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // richTextBoxLOOK
            // 
            this.richTextBoxLOOK.Location = new System.Drawing.Point(11, 102);
            this.richTextBoxLOOK.Name = "richTextBoxLOOK";
            this.richTextBoxLOOK.Size = new System.Drawing.Size(111, 284);
            this.richTextBoxLOOK.TabIndex = 39;
            this.richTextBoxLOOK.Text = "";
            // 
            // tbl_LOOK
            // 
            this.tbl_LOOK.AllowDrop = true;
            this.tbl_LOOK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_LOOK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero_de_Pista,
            this.num_pist_atravesadas});
            this.tbl_LOOK.Location = new System.Drawing.Point(252, 49);
            this.tbl_LOOK.Name = "tbl_LOOK";
            this.tbl_LOOK.RowHeadersWidth = 51;
            this.tbl_LOOK.RowTemplate.Height = 24;
            this.tbl_LOOK.Size = new System.Drawing.Size(400, 233);
            this.tbl_LOOK.TabIndex = 38;
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
            // LOOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 450);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.zedG_LOOK);
            this.Controls.Add(this.lblPROM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCantDatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbldatosant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.richTextBoxLOOK);
            this.Controls.Add(this.tbl_LOOK);
            this.Controls.Add(this.btnOUT);
            this.Name = "LOOK";
            this.Text = "LOOK";
            ((System.ComponentModel.ISupportInitialize)(this.tbl_LOOK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOUT;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label label4;
        private ZedGraph.ZedGraphControl zedG_LOOK;
        private System.Windows.Forms.Label lblPROM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCantDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbldatosant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.RichTextBox richTextBoxLOOK;
        private System.Windows.Forms.DataGridView tbl_LOOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_de_Pista;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_pist_atravesadas;
    }
}