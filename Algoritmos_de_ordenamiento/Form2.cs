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
    public partial class IngresoDatos : Form
    {
        private string limit_txt;
        private string CantDatos;
        private string inicio;
        private int contador = 1;
        private int limite;
        private int clicsBtnInsertar = 0;
        public string LimiteTxt
        {
            get { return limit_txt; }
            set { limit_txt = value; }
        }
        public string CantDatosTxt
        {
            get { return CantDatos; }
            set {   CantDatos = value; }
        }
        public int LimiteActual
        {
            get { return int.Parse(lblLimite.Text); }
        }

        public int CantDatosActual
        {
            get { return int.Parse(lblCantDatos.Text); }
        }

        public IngresoDatos(string Limite, string Cantidad, string Inicio)
        {
            InitializeComponent();
            limit_txt = Limite;
            CantDatos = Cantidad;
            inicio = Inicio;
            lblLimite.Text = limit_txt;
            lblCantDatos.Text = CantDatos;
            lblInicio.Text = inicio;
            txtDato.KeyPress += TxtDato_KeyPress;
            button2.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtDato_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números y teclas de control (por ejemplo, retroceso)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            if (clicsBtnInsertar < CantDatosActual)
            {
                string DatoIngresado = txtDato.Text;

                // Verificar que el valor dentro de txtDato sea un número, mayor o igual a 0
                if (int.TryParse(txtDato.Text, out int valorDato) && valorDato >= 0 && valorDato <= LimiteActual)
                {
                    rtxtDatos.AppendText($"{DatoIngresado},");
                    rtxtDatosMostrar.AppendText($"{contador}.-  {DatoIngresado}\n");
                    contador++;
                    lblNum.Text = contador.ToString();
                    txtDato.Clear();

                    clicsBtnInsertar++; // Incrementar el contador de clics
                }
                else
                {
                    // Mostrar un cuadro de diálogo si el valor no es válido
                    MessageBox.Show($"El valor ingresado debe ser un número mayor o igual a 0 y menor o igual a {LimiteActual}.", "Valor no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDato.Clear();
                }
            }
            else
            {
                // Mostrar un cuadro de diálogo si se ha alcanzado la cantidad máxima de clics
                MessageBox.Show($"Se ha alcanzado la cantidad máxima de inserciones ({CantDatosActual}).", "Límite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (clicsBtnInsertar >= CantDatosActual)
            {
                button2.Enabled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string datosIngresados = rtxtDatos.Text;

            // Crear e mostrar el Form3 con los datos
            OrdenSelec form3 = new OrdenSelec(datosIngresados);
            form3.SetDatoInicioForm2(lblInicio.Text);
            form3.SetCantDatosForm3(lblCantDatos.Text);
            form3.LimiteForm3 = lblLimite.Text;
            form3.Show();
        }
    }
}
