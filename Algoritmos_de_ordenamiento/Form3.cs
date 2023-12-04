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

            // Mostrar el formulario FIFO
            fifoForm.Show();

            // Esperar hasta que el formulario FIFO se cierre
            fifoForm.FormClosed += (s, args) =>
            {
                // Acceder a la propiedad PromedioFIFO del formulario FIFO y asignarla a lblFIFOPROM
                lblFIFOPROM.Text = fifoForm.PromedioFIFO;
            };
        }

        private void btnSSTF_Click(object sender, EventArgs e)
        {
            SSTF SSTFForm = new SSTF(lblDatosAnt.Text, lblInicio2.Text, lblCantDatos.Text, lblCapi.Text);
            SSTFForm.Show();
            SSTFForm.FormClosed += (s, args) =>
            {
                // Acceder a la propiedad PromedioFIFO del formulario FIFO y asignarla a lblFIFOPROM
                lblSSTFPROM.Text = SSTFForm.PromedioFIFO;
            };
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            SCAN SCANForm = new SCAN(lblDatosAnt.Text, lblInicio2.Text, lblCantDatos.Text, lblCapi.Text);
            SCANForm.Show();
            SCANForm.FormClosed += (s, args) =>
            {
                // Acceder a la propiedad PromedioFIFO del formulario FIFO y asignarla a lblFIFOPROM
                lblSCANPROM.Text = SCANForm.PromedioFIFO;
            };
        }

        private void btnCSCAN_Click(object sender, EventArgs e)
        {
            CSCAN CSCANForm = new CSCAN(lblDatosAnt.Text, lblInicio2.Text, lblCantDatos.Text, lblCapi.Text);
            CSCANForm.Show();
            CSCANForm.FormClosed += (s, args) =>
            {
                // Acceder a la propiedad PromedioFIFO del formulario FIFO y asignarla a lblFIFOPROM
                lblCSCANPROM.Text = CSCANForm.PromedioFIFO;
            };
        }

        private void btnLOOK_Click(object sender, EventArgs e)
        {
            LOOK LOOKForm = new LOOK(lblDatosAnt.Text, lblInicio2.Text, lblCantDatos.Text, lblCapi.Text);
            LOOKForm.Show();
            LOOKForm.FormClosed += (s, args) =>
            {
                // Acceder a la propiedad PromedioFIFO del formulario FIFO y asignarla a lblFIFOPROM
                lblLOOKPROM.Text = LOOKForm.PromedioFIFO;
            };
        }

        private void btnCLOOK_Click(object sender, EventArgs e)
        {
            CLOOK CLOOKForm = new CLOOK(lblDatosAnt.Text, lblInicio2.Text, lblCantDatos.Text, lblCapi.Text);
            CLOOKForm.Show();
            CLOOKForm.FormClosed += (s, args) =>
            {
                // Acceder a la propiedad PromedioFIFO del formulario FIFO y asignarla a lblFIFOPROM
                lblCLOOKPROM.Text = CLOOKForm.PromedioFIFO;
            };
        }


        private double ObtenerPromedio(string texto)
        {
            // Analizar el texto del lbl para obtener el valor del promedio
            string[] partes = texto.Split(':');
            if (partes.Length == 2)
            {
                double promedio;
                if (double.TryParse(partes[1].Trim(), out promedio))
                {
                    return promedio;
                }
            }
            return double.MaxValue; // Retornar un valor alto en caso de error
        }

        private void btnMejor_Click_1(object sender, EventArgs e)
        {
            // Obtener los valores de los lbl de promedio
            double promedioFIFO = ObtenerPromedio(lblFIFOPROM.Text);
            double promedioSCAN = ObtenerPromedio(lblSCANPROM.Text);
            double promedioLOOK = ObtenerPromedio(lblLOOKPROM.Text);
            double promedioCLOOK = ObtenerPromedio(lblCLOOKPROM.Text);
            double promedioSSTF = ObtenerPromedio(lblSSTFPROM.Text);
            double promedioCSCAN = ObtenerPromedio(lblCSCANPROM.Text);

            // Encontrar el algoritmo con el menor promedio
            double menorPromedio = Math.Min(promedioFIFO, Math.Min(promedioSCAN, Math.Min(promedioLOOK, Math.Min(promedioCLOOK, Math.Min(promedioSSTF, promedioCSCAN)))));

            // Asignar el texto al lblMEJOR
            if (menorPromedio == promedioFIFO)
            {
                lblMEJOR.Text = "El mejor algoritmo de planificación es: FIFO con un promedio de: " + promedioFIFO;
            }
            else if (menorPromedio == promedioSCAN)
            {
                lblMEJOR.Text = "El mejor algoritmo de planificación es: SCAN con un promedio de: " + promedioSCAN;
            }
            else if (menorPromedio == promedioLOOK)
            {
                lblMEJOR.Text = "El mejor algoritmo de planificación es: LOOK con un promedio de: " + promedioLOOK;
            }
            else if (menorPromedio == promedioCLOOK)
            {
                lblMEJOR.Text = "El mejor algoritmo de planificación es: CLOOK con un promedio de: " + promedioCLOOK;
            }
            else if (menorPromedio == promedioSSTF)
            {
                lblMEJOR.Text = "El mejor algoritmo de planificación es: SSTF con un promedio de: " + promedioSSTF;
            }
            else if (menorPromedio == promedioCSCAN)
            {
                lblMEJOR.Text = "El mejor algoritmo de planificación es: CSCAN con un promedio de: " + promedioCSCAN;
            }
        }
    }
}
