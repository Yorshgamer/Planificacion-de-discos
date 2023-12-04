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
    public partial class SSTF : Form
    {
        private string datosSSTF;
        private bool btnAgregarLayout = false;
        public string PromedioFIFO
        {
            get { return lblPROM.Text; }
            set { lblPROM.Text = value; }
        }
        public SSTF(string datos, string valorLblInicio2, string valorLblCantDatos, string valorLblCapacidad)
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

            richTextBoxSSTF.Clear();

            foreach (string numero in numeros)
            {
                richTextBoxSSTF.AppendText(numero + Environment.NewLine);
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
                if (!string.IsNullOrEmpty(richTextBoxSSTF.Text))
                {
                    // Obtener los datos del richTextBoxSSTF y convertirlos a enteros
                    List<int> datos = richTextBoxSSTF.Lines
                        .Where(linea => !string.IsNullOrWhiteSpace(linea))
                        .Select(linea => Convert.ToInt32(linea.Trim()))
                        .ToList();

                    // Lista para almacenar los datos ordenados según el algoritmo SSTF
                    List<int> datosOrdenados = new List<int>();

                    // Valor inicial es el valor en lbldatosant
                    int valorActual = Convert.ToInt32(lbldatosant.Text);

                    // Copiar el valor actual antes de ordenar los datos
                    int valorInicial = valorActual;

                    // Mientras haya datos por procesar
                    while (datos.Count > 0)
                    {
                        // Ordenar los datos restantes por distancia al valor actual
                        datos.Sort((a, b) => Math.Abs(a - valorActual).CompareTo(Math.Abs(b - valorActual)));

                        // Tomar el dato más cercano y agregarlo a la lista ordenada
                        int siguienteDato = datos[0];
                        datosOrdenados.Add(siguienteDato);

                        // Actualizar el valor actual al dato recién seleccionado
                        valorActual = siguienteDato;

                        // Quitar el dato seleccionado de la lista de datos restantes
                        datos.Remove(siguienteDato);
                    }

                    // Limpiar la tabla antes de agregar los nuevos datos
                    tbl_SSTF.Rows.Clear();

                    // Agregar los datos ordenados a la tabla
                    for (int i = 0; i < datosOrdenados.Count; i++)
                    {
                        int dato = datosOrdenados[i];
                        int diferencia;

                        if (i == 0)
                        {
                            // Para la primera fila, calcula la diferencia absoluta entre valorInicial y el primer dato
                            diferencia = Math.Abs(valorInicial - dato);
                        }
                        else
                        {
                            // Para las filas siguientes, calcula la diferencia absoluta entre el dato actual y el dato anterior
                            diferencia = Math.Abs(datosOrdenados[i - 1] - dato);
                        }

                        tbl_SSTF.Rows.Add(dato, diferencia.ToString());
                    }

                    ConfigurarZedGraph();

                    // Calcular la suma de la segunda columna
                    int suma = 0;
                    foreach (DataGridViewRow row in tbl_SSTF.Rows)
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
            zedG_SSTF.GraphPane.CurveList.Clear();

            // Configurar título y ejes
            zedG_SSTF.GraphPane.Title.Text = "ORDENAMIENTO SSTF";
            zedG_SSTF.GraphPane.XAxis.Title.Text = "PASOS";
            zedG_SSTF.GraphPane.YAxis.Title.Text = "Posicion del cabezal";

            // Configurar intervalo y máximo para el eje Y
            zedG_SSTF.GraphPane.YAxis.Scale.Max = capacidad;
            zedG_SSTF.GraphPane.YAxis.Scale.Min = 0;
            zedG_SSTF.GraphPane.YAxis.Scale.MajorStep = 10;

            // Configurar intervalo y máximo para el eje X
            zedG_SSTF.GraphPane.XAxis.Scale.Max = cantDatos;
            zedG_SSTF.GraphPane.XAxis.Scale.Min = 0;
            zedG_SSTF.GraphPane.XAxis.Scale.MajorStep = 1;

            // Refrescar el control ZedGraph
            zedG_SSTF.AxisChange();
            zedG_SSTF.Invalidate();

            PointPairList pointList = new PointPairList();
            int valorInicial = Convert.ToInt32(lbldatosant.Text);
            pointList.Add(0, valorInicial);

            for (int i = 0; i < tbl_SSTF.Rows.Count; i++)
            {
                if (tbl_SSTF.Rows[i].Cells[0].Value != null)
                {
                    int valorDato = Convert.ToInt32(tbl_SSTF.Rows[i].Cells[0].Value);

                    // Agregar punto al PointPairList
                    pointList.Add(i + 1, valorDato); // Sumar 1 para empezar desde el primer intervalo del eje X
                }
            }

            // Crear una curva para los puntos y agregarla al ZedGraph
            LineItem myCurve = zedG_SSTF.GraphPane.AddCurve("SSTF", pointList, Color.Blue, SymbolType.Circle);

            // Personalizar la apariencia de los puntos
            myCurve.Symbol.Fill = new Fill(Color.Blue);
            myCurve.Symbol.Size = 8;

            // Refrescar el control ZedGraph
            zedG_SSTF.AxisChange();
            zedG_SSTF.Invalidate();
        }
    }
}
