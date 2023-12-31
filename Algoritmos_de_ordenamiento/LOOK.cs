﻿using System;
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
    public partial class LOOK : Form
    {
        private string datosLOOK;
        private bool btnAgregarLayout = false;
        public string PromedioFIFO
        {
            get { return lblPROM.Text; }
            set { lblPROM.Text = value; }
        }
        public LOOK(string datos, string valorLblInicio2, string valorLblCantDatos, string valorLblCapacidad)
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

            richTextBoxLOOK.Clear();

            foreach (string numero in numeros)
            {
                richTextBoxLOOK.AppendText(numero + Environment.NewLine);
            }
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            if (!btnAgregarLayout)
            {
                if (!string.IsNullOrEmpty(richTextBoxLOOK.Text))
                {
                    string[] lineas = richTextBoxLOOK.Lines;

                    List<int> datosAscendentes = new List<int>();
                    List<int> datosDescendentes = new List<int>();

                    foreach (string linea in lineas)
                    {
                        if (!string.IsNullOrWhiteSpace(linea))
                        {
                            int valorDato = Convert.ToInt32(linea.Trim());

                            if (valorDato >= Convert.ToInt32(lbldatosant.Text))
                            {
                                datosAscendentes.Add(valorDato);
                            }
                            else
                            {
                                datosDescendentes.Add(valorDato);
                            }
                        }
                    }

                    // Ordenar datos ascendentes y descendentes
                    datosAscendentes.Sort();
                    datosDescendentes.Sort((a, b) => b.CompareTo(a));

                    tbl_LOOK.Rows.Clear(); // Limpiar filas existentes

                    // Agregar datos ascendentes a la tabla y calcular diferencias
                    int rowIndex = 0;
                    foreach (int datoAscendente in datosAscendentes)
                    {
                        tbl_LOOK.Rows.Add(datoAscendente, ""); // Agregar dato a la primera columna y dejar la segunda columna en blanco

                        if (rowIndex == 0)
                        {
                            int valorAnterior = Convert.ToInt32(lbldatosant.Text);
                            int valorActual = datoAscendente;
                            int diferencia = Math.Abs(valorActual - valorAnterior);

                            tbl_LOOK.Rows[rowIndex].Cells[1].Value = diferencia.ToString();
                        }
                        else
                        {
                            int valorAnterior = Convert.ToInt32(tbl_LOOK.Rows[rowIndex - 1].Cells[0].Value);
                            int valorActual = datoAscendente;
                            int diferencia = Math.Abs(valorActual - valorAnterior);

                            tbl_LOOK.Rows[rowIndex].Cells[1].Value = diferencia.ToString();
                        }

                        rowIndex++;
                    }

                    // Agregar datos descendentes a la tabla y calcular diferencias
                    foreach (int datoDescendente in datosDescendentes)
                    {
                        tbl_LOOK.Rows.Add(datoDescendente, ""); // Agregar dato a la primera columna y dejar la segunda columna en blanco

                        int valorAnterior = Convert.ToInt32(tbl_LOOK.Rows[rowIndex - 1].Cells[0].Value);
                        int valorActual = datoDescendente;
                        int diferencia = Math.Abs(valorActual - valorAnterior);

                        tbl_LOOK.Rows[rowIndex].Cells[1].Value = diferencia.ToString();

                        rowIndex++;
                    }

                    ConfigurarZedGraph(); // Llamar a la función para actualizar el gráfico

                    // Calcular la suma de la segunda columna
                    int suma = 0;
                    foreach (DataGridViewRow row in tbl_LOOK.Rows)
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
            zedG_LOOK.GraphPane.CurveList.Clear();

            // Configurar título y ejes
            zedG_LOOK.GraphPane.Title.Text = "ORDENAMIENTO LOOK";
            zedG_LOOK.GraphPane.XAxis.Title.Text = "PASOS";
            zedG_LOOK.GraphPane.YAxis.Title.Text = "Posicion del cabezal";

            // Configurar intervalo y máximo para el eje Y
            zedG_LOOK.GraphPane.YAxis.Scale.Max = capacidad;
            zedG_LOOK.GraphPane.YAxis.Scale.Min = 0;
            zedG_LOOK.GraphPane.YAxis.Scale.MajorStep = 10;

            // Configurar intervalo y máximo para el eje X
            zedG_LOOK.GraphPane.XAxis.Scale.Max = cantDatos;
            zedG_LOOK.GraphPane.XAxis.Scale.Min = 0;
            zedG_LOOK.GraphPane.XAxis.Scale.MajorStep = 1;

            // Refrescar el control ZedGraph
            zedG_LOOK.AxisChange();
            zedG_LOOK.Invalidate();

            PointPairList pointList = new PointPairList();
            int valorInicial = Convert.ToInt32(lbldatosant.Text);
            pointList.Add(0, valorInicial);

            for (int i = 0; i < tbl_LOOK.Rows.Count; i++)
            {
                if (tbl_LOOK.Rows[i].Cells[0].Value != null)
                {
                    int valorDato = Convert.ToInt32(tbl_LOOK.Rows[i].Cells[0].Value);

                    // Agregar punto al PointPairList
                    pointList.Add(i + 1, valorDato); // Sumar 1 para empezar desde el primer intervalo del eje X
                }
            }

            // Crear una curva para los puntos y agregarla al ZedGraph
            LineItem myCurve = zedG_LOOK.GraphPane.AddCurve("LOOK", pointList, Color.Blue, SymbolType.Circle);

            // Personalizar la apariencia de los puntos
            myCurve.Symbol.Fill = new Fill(Color.Blue);
            myCurve.Symbol.Size = 8;

            // Refrescar el control ZedGraph
            zedG_LOOK.AxisChange();
            zedG_LOOK.Invalidate();
        }
    }
}
