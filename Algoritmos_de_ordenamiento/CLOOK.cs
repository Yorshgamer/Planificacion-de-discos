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
    public partial class CLOOK : Form
    {
        private string datosLOOK;
        private bool btnAgregarLayout = false;
        public string PromedioFIFO
        {
            get { return lblPROM.Text; }
            set { lblPROM.Text = value; }
        }
        public CLOOK(string datos, string valorLblInicio2, string valorLblCantDatos, string valorLblCapacidad)
        {
            InitializeComponent();
            MostrarDatosEnRichTextBox(datos);
            lbldatosant.Text = valorLblInicio2;
            lblCantDatos.Text = valorLblCantDatos;
            lblCapacidad.Text = valorLblCapacidad;
        }

        private void btnOUT_Click(object sender, EventArgs e)
        {
            PromedioFIFO = lblPROM.Text;
            this.Close();
        }

        private void MostrarDatosEnRichTextBox(string datos)
        {
            if (datos.EndsWith(","))
            {
                datos = datos.TrimEnd(',');
            }

            string[] numeros = datos.Split(',');

            richTextBoxCLOOK.Clear();

            foreach (string numero in numeros)
            {
                richTextBoxCLOOK.AppendText(numero + Environment.NewLine);
            }
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            if (!btnAgregarLayout)
            {
                if (!string.IsNullOrEmpty(richTextBoxCLOOK.Text))
                {
                    string[] lineas = richTextBoxCLOOK.Lines;

                    List<int> datosOrdenados = new List<int>();

                    foreach (string linea in lineas)
                    {
                        if (!string.IsNullOrWhiteSpace(linea))
                        {
                            int valorDato = Convert.ToInt32(linea.Trim());
                            datosOrdenados.Add(valorDato);
                        }
                    }

                    // Ordenar datos ascendentes según su relación con lbldatosant
                    datosOrdenados.Sort((a, b) =>
                    {
                        if (a >= Convert.ToInt32(lbldatosant.Text) && b >= Convert.ToInt32(lbldatosant.Text))
                            return a.CompareTo(b); // Ambos son mayores o iguales, ordenar normalmente ascendente
                        else if (a < Convert.ToInt32(lbldatosant.Text) && b < Convert.ToInt32(lbldatosant.Text))
                            return a.CompareTo(b); // Ambos son menores, ordenar normalmente ascendente
                        else
                            return a >= Convert.ToInt32(lbldatosant.Text) ? -1 : 1; // Ordenar según la relación con lbldatosant
                    });

                    tbl_CLOOK.Rows.Clear(); // Limpiar filas existentes

                    // Agregar datos ordenados a la tabla y calcular diferencias
                    int rowIndex = 0;
                    foreach (int datoOrdenado in datosOrdenados)
                    {
                        tbl_CLOOK.Rows.Add(datoOrdenado, ""); // Agregar dato a la primera columna y dejar la segunda columna en blanco

                        if (rowIndex == 0)
                        {
                            int valorAnterior = Convert.ToInt32(lbldatosant.Text);
                            int valorActual = datoOrdenado;
                            int diferencia = Math.Abs(valorActual - valorAnterior);

                            tbl_CLOOK.Rows[rowIndex].Cells[1].Value = diferencia.ToString();
                        }
                        else
                        {
                            int valorAnterior = Convert.ToInt32(tbl_CLOOK.Rows[rowIndex - 1].Cells[0].Value);
                            int valorActual = datoOrdenado;
                            int diferencia = Math.Abs(valorActual - valorAnterior);

                            tbl_CLOOK.Rows[rowIndex].Cells[1].Value = diferencia.ToString();
                        }

                        rowIndex++;
                    }

                    ConfigurarZedGraph(); // Llamar a la función para actualizar el gráfico

                    // Calcular la suma de la segunda columna
                    int suma = 0;
                    foreach (DataGridViewRow row in tbl_CLOOK.Rows)
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
            zedG_CLOOK.GraphPane.CurveList.Clear();

            // Configurar título y ejes
            zedG_CLOOK.GraphPane.Title.Text = "ORDENAMIENTO CLOOK";
            zedG_CLOOK.GraphPane.XAxis.Title.Text = "PASOS";
            zedG_CLOOK.GraphPane.YAxis.Title.Text = "Posicion del cabezal";

            // Configurar intervalo y máximo para el eje Y
            zedG_CLOOK.GraphPane.YAxis.Scale.Max = capacidad;
            zedG_CLOOK.GraphPane.YAxis.Scale.Min = 0;
            zedG_CLOOK.GraphPane.YAxis.Scale.MajorStep = 10;

            // Configurar intervalo y máximo para el eje X
            zedG_CLOOK.GraphPane.XAxis.Scale.Max = cantDatos;
            zedG_CLOOK.GraphPane.XAxis.Scale.Min = 0;
            zedG_CLOOK.GraphPane.XAxis.Scale.MajorStep = 1;

            // Refrescar el control ZedGraph
            zedG_CLOOK.AxisChange();
            zedG_CLOOK.Invalidate();

            PointPairList pointList = new PointPairList();
            int valorInicial = Convert.ToInt32(lbldatosant.Text);
            pointList.Add(0, valorInicial);

            for (int i = 0; i < tbl_CLOOK.Rows.Count; i++)
            {
                if (tbl_CLOOK.Rows[i].Cells[0].Value != null)
                {
                    int valorDato = Convert.ToInt32(tbl_CLOOK.Rows[i].Cells[0].Value);

                    // Agregar punto al PointPairList
                    pointList.Add(i + 1, valorDato); // Sumar 1 para empezar desde el primer intervalo del eje X
                }
            }

            // Crear una curva para los puntos y agregarla al ZedGraph
            LineItem myCurve = zedG_CLOOK.GraphPane.AddCurve("CLOOK", pointList, Color.Blue, SymbolType.Circle);

            // Personalizar la apariencia de los puntos
            myCurve.Symbol.Fill = new Fill(Color.Blue);
            myCurve.Symbol.Size = 8;

            // Refrescar el control ZedGraph
            zedG_CLOOK.AxisChange();
            zedG_CLOOK.Invalidate();
        }
    }
}
