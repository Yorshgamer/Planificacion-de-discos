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
    public partial class CSCAN : Form
    {
        private string datosCSCAN;
        private bool btnAgregarLayout = false;
        public string PromedioFIFO
        {
            get { return lblPROM.Text; }
            set { lblPROM.Text = value; }
        }
        public CSCAN(string datos, string valorLblInicio2, string valorLblCantDatos, string valorLblCapacidad)
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

            richTextBoxCSCAN.Clear();

            foreach (string numero in numeros)
            {
                richTextBoxCSCAN.AppendText(numero + Environment.NewLine);
            }
        }

        private void btnOUT_Click(object sender, EventArgs e)
        {
            PromedioFIFO = lblPROM.Text;
            this.Close();
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            if (!btnAgregarLayout)
            {
                if (!string.IsNullOrEmpty(richTextBoxCSCAN.Text))
                {
                    List<int> datos = richTextBoxCSCAN.Lines
                        .Where(linea => !string.IsNullOrWhiteSpace(linea))
                        .Select(linea => Convert.ToInt32(linea.Trim()))
                        .ToList();

                    // Agregar el valor de lblCapacidad
                    datos.Add(Convert.ToInt32(lblCapacidad.Text));

                    // Ordenar utilizando CSCAN
                    int cabeza = Convert.ToInt32(lbldatosant.Text);
                    int capacidad = Convert.ToInt32(lblCapacidad.Text);
                    List<int> datosCSCAN = OrdenarCSCAN(datos, capacidad);

                    // Mostrar datos en DataGridView
                    MostrarDatosEnDataGridView(datosCSCAN);

                    ConfigurarZedGraph();

                    // Calcular la suma de la segunda columna
                    int suma = datosCSCAN.Sum();

                    // Obtener el valor del label lbl_CantDatos
                    int cantDatos = datosCSCAN.Count;

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

        private List<int> OrdenarCSCAN(List<int> datos, int capacidad)
        {
            // Agregar el valor de lbldatosant a la lista
            datos.Add(Convert.ToInt32(lbldatosant.Text));

            List<int> ordenados = datos.OrderBy(d => d).ToList();

            // Obtener el índice de lbldatosant en la lista ordenada
            int index = ordenados.IndexOf(Convert.ToInt32(lbldatosant.Text));

            List<int> cscanOrdenados = new List<int>();

            // Moverse hacia la derecha desde lbldatosant hasta el final
            for (int i = index + 1; i < ordenados.Count; i++)
            {
                cscanOrdenados.Add(ordenados[i]);
            }

            // Volver al principio y continuar hacia la izquierda hasta lbldatosant
            for (int i = 0; i <= index; i++)
            {
                cscanOrdenados.Add(ordenados[i]);
            }

            // Si lbldatosant estaba al principio, agregar el valor de capacidad como tope
            if (index == 0)
            {
                cscanOrdenados.Add(capacidad);
            }

            return cscanOrdenados;
        }

        private void MostrarDatosEnDataGridView(List<int> datos)
        {
            tbl_CSCAN.Rows.Clear();

            for (int i = 0; i < datos.Count; i++)
            {
                if (i == 0)
                {
                    // Para la primera fila, usa el valor absoluto de la resta entre datos[i] y lbldatosant
                    tbl_CSCAN.Rows.Add(datos[i], Math.Abs(datos[i] - Convert.ToInt32(lbldatosant.Text)));
                }
                else
                {
                    int valorAnterior = datos[i - 1];
                    tbl_CSCAN.Rows.Add(datos[i], Math.Abs(valorAnterior - datos[i]));
                }
            }
        }

        private void ConfigurarZedGraph()
        {
            // Obtener el valor de la capacidad y la cantidad de datos
            int capacidad = Convert.ToInt32(lblCapacidad.Text);
            int cantDatos = Convert.ToInt32(lblCantDatos.Text);

            // Limpiar paneles anteriores si los hay
            zedG_CSCAN.GraphPane.CurveList.Clear();

            // Configurar título y ejes
            zedG_CSCAN.GraphPane.Title.Text = "ORDENAMIENTO CSCAN";
            zedG_CSCAN.GraphPane.XAxis.Title.Text = "PASOS";
            zedG_CSCAN.GraphPane.YAxis.Title.Text = "Posicion del cabezal";

            // Configurar intervalo y máximo para el eje Y
            zedG_CSCAN.GraphPane.YAxis.Scale.Max = capacidad;
            zedG_CSCAN.GraphPane.YAxis.Scale.Min = 0;
            zedG_CSCAN.GraphPane.YAxis.Scale.MajorStep = 10;

            // Configurar intervalo y máximo para el eje X
            zedG_CSCAN.GraphPane.XAxis.Scale.Max = cantDatos+2;
            zedG_CSCAN.GraphPane.XAxis.Scale.Min = 0;
            zedG_CSCAN.GraphPane.XAxis.Scale.MajorStep = 1;

            // Refrescar el control ZedGraph
            zedG_CSCAN.AxisChange();
            zedG_CSCAN.Invalidate();

            PointPairList pointList = new PointPairList();
            int valorInicial = Convert.ToInt32(lbldatosant.Text);
            pointList.Add(0, valorInicial);

            for (int i = 0; i < tbl_CSCAN.Rows.Count; i++)
            {
                if (tbl_CSCAN.Rows[i].Cells[0].Value != null)
                {
                    int valorDato = Convert.ToInt32(tbl_CSCAN.Rows[i].Cells[0].Value);

                    // Agregar punto al PointPairList
                    pointList.Add(i + 1, valorDato); // Sumar 1 para empezar desde el primer intervalo del eje X
                }
            }

            // Crear una curva para los puntos y agregarla al ZedGraph
            LineItem myCurve = zedG_CSCAN.GraphPane.AddCurve("CSCAN", pointList, Color.Blue, SymbolType.Circle);

            // Personalizar la apariencia de los puntos
            myCurve.Symbol.Fill = new Fill(Color.Blue);
            myCurve.Symbol.Size = 8;

            // Refrescar el control ZedGraph
            zedG_CSCAN.AxisChange();
            zedG_CSCAN.Invalidate();
        }
    }
}
