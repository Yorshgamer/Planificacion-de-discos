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
    public partial class SCAN : Form
    {
        private string datosSCAN;
        private bool btnAgregarLayout = false;
        public string PromedioFIFO
        {
            get { return lblPROM.Text; }
            set { lblPROM.Text = value; }
        }
        public SCAN(string datos, string valorLblInicio2, string valorLblCantDatos, string valorLblCapacidad)
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

            richTextBoxSCAN.Clear();

            foreach (string numero in numeros)
            {
                richTextBoxSCAN.AppendText(numero + Environment.NewLine);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            PromedioFIFO = lblPROM.Text;
            this.Close();
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
{
            if (!btnAgregarLayout)
            {
                if (!string.IsNullOrEmpty(richTextBoxSCAN.Text))
                {
                    List<int> datos = richTextBoxSCAN.Lines
                        .Where(linea => !string.IsNullOrWhiteSpace(linea))
                        .Select(linea => Convert.ToInt32(linea.Trim()))
                        .ToList();

                    // Agregar el valor de lblCapacidad
                    datos.Add(Convert.ToInt32(lblCapacidad.Text));

                    // Ordenar de manera ascendente
                    datos.Sort();

                    // Encontrar el índice del valor bajo más cercano a lbldatosant
                    int index = datos.FindIndex(valor => valor >= Convert.ToInt32(lbldatosant.Text));

                    // Crear una nueva lista con los datos ordenados de manera descendente
                    List<int> datosDescendentes = new List<int>();

                    // Agregar los valores mayores o iguales a lbldatosant en orden descendente
                    for (int i = index; i < datos.Count; i++)
                    {
                        datosDescendentes.Add(datos[i]);
                    }

                    // Agregar los valores menores que lbldatosant en orden descendente
                    for (int i = index - 1; i >= 0; i--)
                    {
                        datosDescendentes.Add(datos[i]);
                    }

                    // Mostrar datos en DataGridView
                    MostrarDatosEnDataGridView(datosDescendentes);

                    ConfigurarZedGraph();

                    // Calcular la suma de la segunda columna
                    int suma = datosDescendentes.Sum();

                    // Obtener el valor del label lbl_CantDatos
                    int cantDatos = datosDescendentes.Count;

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

        private void MostrarDatosEnDataGridView(List<int> datos)
        {
            tbl_SCAN.Rows.Clear();

            for (int i = 0; i < datos.Count; i++)
            {
                if (i == 0)
                {
                    // Para la primera fila, usa el valor absoluto de la resta entre datos[i] y lbldatosant
                    tbl_SCAN.Rows.Add(datos[i], Math.Abs(datos[i] - Convert.ToInt32(lbldatosant.Text)));
                }
                else
                {
                    int valorAnterior = datos[i - 1];
                    tbl_SCAN.Rows.Add(datos[i], Math.Abs(valorAnterior - datos[i]));
                }
            }
        }

        private void ConfigurarZedGraph()
        {
            // Obtener el valor de la capacidad y la cantidad de datos
            int capacidad = Convert.ToInt32(lblCapacidad.Text);
            int cantDatos = Convert.ToInt32(lblCantDatos.Text);

            // Limpiar paneles anteriores si los hay
            zedG_SCAN.GraphPane.CurveList.Clear();

            // Configurar título y ejes
            zedG_SCAN.GraphPane.Title.Text = "ORDENAMIENTO SCAN";
            zedG_SCAN.GraphPane.XAxis.Title.Text = "PASOS";
            zedG_SCAN.GraphPane.YAxis.Title.Text = "Posicion del cabezal";

            // Configurar intervalo y máximo para el eje Y
            zedG_SCAN.GraphPane.YAxis.Scale.Max = capacidad;
            zedG_SCAN.GraphPane.YAxis.Scale.Min = 0;
            zedG_SCAN.GraphPane.YAxis.Scale.MajorStep = 10;

            // Configurar intervalo y máximo para el eje X
            zedG_SCAN.GraphPane.XAxis.Scale.Max = cantDatos+1;
            zedG_SCAN.GraphPane.XAxis.Scale.Min = 0;
            zedG_SCAN.GraphPane.XAxis.Scale.MajorStep = 1;

            // Refrescar el control ZedGraph
            zedG_SCAN.AxisChange();
            zedG_SCAN.Invalidate();

            PointPairList pointList = new PointPairList();
            int valorInicial = Convert.ToInt32(lbldatosant.Text);
            pointList.Add(0, valorInicial);

            for (int i = 0; i < tbl_SCAN.Rows.Count; i++)
            {
                if (tbl_SCAN.Rows[i].Cells[0].Value != null)
                {
                    int valorDato = Convert.ToInt32(tbl_SCAN.Rows[i].Cells[0].Value);

                    // Agregar punto al PointPairList
                    pointList.Add(i + 1, valorDato); // Sumar 1 para empezar desde el primer intervalo del eje X
                }
            }

            // Crear una curva para los puntos y agregarla al ZedGraph
            LineItem myCurve = zedG_SCAN.GraphPane.AddCurve("FIFO", pointList, Color.Blue, SymbolType.Circle);

            // Personalizar la apariencia de los puntos
            myCurve.Symbol.Fill = new Fill(Color.Blue);
            myCurve.Symbol.Size = 8;

            // Refrescar el control ZedGraph
            zedG_SCAN.AxisChange();
            zedG_SCAN.Invalidate();
        }
    }
}