using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos_de_ordenamiento
{
    public partial class OrdenSelec : Form
    {
        private string datoInicioForm2;
        public OrdenSelec(string datosAnteriores)
        {
            InitializeComponent();
            lblDatosAnt.Text = datosAnteriores;
            if (lblDatosAnt.Text.EndsWith(","))
            {
                lblDatosAnt.Text = lblDatosAnt.Text.TrimEnd(',');
            }
        }
        public string LimiteForm3
        {
            get { return lblCapi.Text; }
            set { lblCapi.Text = value; }
        }



        public void SetCantDatosForm3(string cantDatos)
        {
            lblCantDatos.Text = cantDatos;
        }

        public void SetDatoInicioForm2(string datoInicioForm2)
        {
            this.datoInicioForm2 = datoInicioForm2;
            lblInicio2.Text = datoInicioForm2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFIFO_Click(object sender, EventArgs e)
        {
            FIFO fifoForm = new FIFO(lblDatosAnt.Text, lblInicio2.Text, lblCantDatos.Text, lblCapi.Text);
            fifoForm.Show();
        }

        private void btnSSTF_Click(object sender, EventArgs e)
        {
            SSTF SSTFForm = new SSTF(lblDatosAnt.Text, lblInicio2.Text, lblCantDatos.Text, lblCapi.Text);
            SSTFForm.Show();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            SCAN SCANForm = new SCAN(lblDatosAnt.Text, lblInicio2.Text, lblCantDatos.Text, lblCapi.Text);
            SCANForm.Show();
        }

        private void btnCSCAN_Click(object sender, EventArgs e)
        {
            CSCAN CSCANForm = new CSCAN(lblDatosAnt.Text, lblInicio2.Text, lblCantDatos.Text, lblCapi.Text);
            CSCANForm.Show();
        }

        private void btnLOOK_Click(object sender, EventArgs e)
        {
            LOOK LOOKForm = new LOOK(lblDatosAnt.Text, lblInicio2.Text, lblCantDatos.Text, lblCapi.Text);
            LOOKForm.Show();
        }

        private void btnCLOOK_Click(object sender, EventArgs e)
        {
            CLOOK CLOOKForm = new CLOOK(lblDatosAnt.Text, lblInicio2.Text, lblCantDatos.Text, lblCapi.Text);
            CLOOKForm.Show();
        }
    }
}
