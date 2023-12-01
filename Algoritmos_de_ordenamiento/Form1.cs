using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Algoritmos_de_ordenamiento
{
    
    public partial class Principal : Form
    {
        private string limit_txt;
        private string CantDatos;
        public Principal()
        {
            InitializeComponent();
            txtLimite.KeyPress += TextBox_KeyPress;
            txtCantDatos.KeyPress += TextBox_KeyPress;
            txtInicio.KeyPress += TextBox_KeyPress;
           
            btnSiguiente1.Enabled = false;

            // Agregar manejadores de eventos TextChanged para cada TextBox
            txtLimite.TextChanged += Txt_TextChanged;
            txtCantDatos.TextChanged += Txt_TextChanged;
            txtInicio.TextChanged += Txt_TextChanged;
        }
        private void Txt_TextChanged(object sender, EventArgs e)
        {
            // Habilitar el botón solo si todos los TextBox contienen datos
            btnSiguiente1.Enabled = !string.IsNullOrEmpty(txtLimite.Text) &&
                                    !string.IsNullOrEmpty(txtCantDatos.Text) &&
                                    !string.IsNullOrEmpty(txtInicio.Text);
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números y teclas de control (por ejemplo, retroceso)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSiguiente1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLimite.Text) || string.IsNullOrEmpty(txtCantDatos.Text) || string.IsNullOrEmpty(txtInicio.Text))
            {
                // Mostrar un cuadro de diálogo si falta algún dato
                MessageBox.Show("Debe proporcionar datos en todos los campos antes de continuar.", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  // No continuar si falta algún dato
            }
            if (int.Parse(txtInicio.Text) > int.Parse(txtLimite.Text))
            {
                MessageBox.Show("El valor del cabezal 'Inicio' no puede ser mayor que el valor del 'Límite'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // No continuar si hay un error
            }
            limit_txt = txtLimite.Text;
            CantDatos = txtCantDatos.Text;
            string inicio = txtInicio.Text;

            // Abre el Form2
            IngresoDatos form2 = new IngresoDatos(limit_txt, CantDatos, inicio);
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
