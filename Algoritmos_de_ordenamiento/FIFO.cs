using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Algoritmos_de_ordenamiento
{
    public partial class FIFO : Form
    {
        private string datosFIFO;
        private bool btnAgregarLayout = false;
        public FIFO(string datos, string valorLblInicio2, string valorLblCantDatos, string valorLblCapacidad)
        {
            InitializeComponent();
            MostrarDatosEnRichTextBox(datos);
            lbldatosant.Text = valorLblInicio2;
            lblCantDatos.Text = valorLblCantDatos;
            lblCapacidad.Text = valorLblCapacidad;
            
        }
       
        private void MostrarDatosEnRichTextBox(string datos)
        {
            if (datos.EndsWith(","))
            {
                datos = datos.TrimEnd(',');
            }

            string[] numeros = datos.Split(',');

            richTextBoxFIFO.Clear();

            foreach (string numero in numeros)
            {
                richTextBoxFIFO.AppendText(numero + Environment.NewLine);
            }
        }

        private void btnOUT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAGREGAR_Click_1(object sender, EventArgs e)
        {
            if (!btnAgregarLayout)
            {
                if (!string.IsNullOrEmpty(richTextBoxFIFO.Text))
                {
                    string[] lineas = richTextBoxFIFO.Lines;

                    for (int i = 0; i < lineas.Length; i++)
                    {
                        if (!string.IsNullOrWhiteSpace(lineas[i]))
                        {
                            tbl_FIFO.Rows.Add(lineas[i].Trim());

                            if (i == 0)
                            {
                                int valorAnterior = Convert.ToInt32(lbldatosant.Text);
                                int valorActual = Convert.ToInt32(lineas[i].Trim());
                                int diferencia = Math.Abs(valorActual - valorAnterior);

                                tbl_FIFO.Rows[i].Cells[1].Value = diferencia.ToString();
                            }
                            else if (i > 0)
                            {
                                int valorAnterior = Convert.ToInt32(tbl_FIFO.Rows[i - 1].Cells[0].Value);
                                int valorActual = Convert.ToInt32(lineas[i].Trim());
                                int diferencia = Math.Abs(valorActual - valorAnterior);

                                tbl_FIFO.Rows[i].Cells[1].Value = diferencia.ToString();
                            }
                        }
                    }

                    ConfigurarZedGraph();

                    // Calcular la suma de la segunda columna
                    int suma = 0;
                    foreach (DataGridViewRow row in tbl_FIFO.Rows)
                    {
                        if (row.Cells[1].Value != null)
                        {
                            suma += Convert.ToInt32(row.Cells[1].Value);
                        }
                    }

                    // Obtener el valor del label lbl_CantDatos
                    int cantDatos = Convert.ToInt32(lblCantDatos.Text);

                    // Calcular el promedio
                    if (cantDatos > 0)
                    {
                        double promedio = (double)suma / cantDatos;

                        // Mostrar el resultado en el label lblPROM
                        lblPROM.Text = $"Promedio: {promedio.ToString("F2")}";
                    }
                    else
                    {
                        lblPROM.Text = "No se puede calcular el promedio. lbl_CantDatos es 0.";
                    }

                    // Deshabilitar el botón btnAGREGAR
                    btnAGREGAR.Enabled = false;

                    // Actualizar la variable de diseño del botón
                    btnAgregarLayout = true;
                }
                else
                {
                    MessageBox.Show("El RichTextBox está vacío. Agregue datos primero.");
                }
            }
        }
         private void ConfigurarZedGraph()
        {
            // Obtener el valor de la capacidad y la cantidad de datos
            int capacidad = Convert.ToInt32(lblCapacidad.Text);
            int cantDatos = Convert.ToInt32(lblCantDatos.Text);

            // Limpiar paneles anteriores si los hay
            zedG_FIFO.GraphPane.CurveList.Clear();

            // Configurar título y ejes
            zedG_FIFO.GraphPane.Title.Text = "ORDENAMIENTO FIFO";
            zedG_FIFO.GraphPane.XAxis.Title.Text = "PASOS";
            zedG_FIFO.GraphPane.YAxis.Title.Text = "Posicion del cabezal";

            // Configurar intervalo y máximo para el eje Y
            zedG_FIFO.GraphPane.YAxis.Scale.Max = capacidad;
            zedG_FIFO.GraphPane.YAxis.Scale.Min = 0;
            zedG_FIFO.GraphPane.YAxis.Scale.MajorStep = 10;

            // Configurar intervalo y máximo para el eje X
            zedG_FIFO.GraphPane.XAxis.Scale.Max = cantDatos;
            zedG_FIFO.GraphPane.XAxis.Scale.Min = 0;
            zedG_FIFO.GraphPane.XAxis.Scale.MajorStep = 1;

            // Refrescar el control ZedGraph
            zedG_FIFO.AxisChange();
            zedG_FIFO.Invalidate();

            PointPairList pointList = new PointPairList();
            int valorInicial = Convert.ToInt32(lbldatosant.Text);
            pointList.Add(0, valorInicial);

            for (int i = 0; i < tbl_FIFO.Rows.Count; i++)
            {
                if (tbl_FIFO.Rows[i].Cells[0].Value != null)
                {
                    int valorDato = Convert.ToInt32(tbl_FIFO.Rows[i].Cells[0].Value);

                    // Agregar punto al PointPairList
                    pointList.Add(i + 1, valorDato); // Sumar 1 para empezar desde el primer intervalo del eje X
                }
            }

            // Crear una curva para los puntos y agregarla al ZedGraph
            LineItem myCurve = zedG_FIFO.GraphPane.AddCurve("FIFO", pointList, Color.Blue, SymbolType.Circle);

            // Personalizar la apariencia de los puntos
            myCurve.Symbol.Fill = new Fill(Color.Blue);
            myCurve.Symbol.Size = 8;

            // Refrescar el control ZedGraph
            zedG_FIFO.AxisChange();
            zedG_FIFO.Invalidate();
        }
    }
}
