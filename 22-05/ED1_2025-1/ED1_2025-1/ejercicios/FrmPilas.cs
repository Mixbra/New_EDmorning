using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios
{
    public partial class FrmPilas: Form
    {
        clases.Pila p = new clases.Pila();
        public FrmPilas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            p.Push(textNombre.Text);
            listDatos.Items.Clear();
            p.mostrar(listDatos);
            textNombre.Clear();
            textNombre.Focus();
        }

        private void btnDesapilar_Click(object sender, EventArgs e)
        {
            string nom = p.Pop();

            if (nom != null)
            {
                MessageBox.Show($"{nom} Desapilado correctamente! ");
                listDatos.Items.Clear();
                p.mostrar(listDatos);
                textNombre.Focus();
            }
            else
                MessageBox.Show("Pila vacía!");
        }

        private void btnVistazo_Click(object sender, EventArgs e)
        {
            string nom = p.Peek();
            if (nom != null)
            {
                MessageBox.Show($"Cima: {nom}! ");
                textNombre.Focus();
            }
            else
                MessageBox.Show("Pila vacía!");
        }

        private void btnCantidaddeElementos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cantidad: " + p.Count());
            textNombre.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            p.Clear();
            textNombre.Focus();
            listDatos.Items.Clear();
            MessageBox.Show("Pila limpia!");
        }
    }
}
