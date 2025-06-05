using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios
{
    public partial class FrmCola: Form
    {
        clases.Cola c = new clases.Cola();
        public FrmCola()
        {
            InitializeComponent();
        }

        private void btnApilar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNombre.Text))
            {
                MessageBox.Show("No se permite nombres nulo o vacio");
            }
            else
            {
                listDatos.Items.Clear();
                c.Enqueue(textNombre.Text.Trim());
                c.mostrar(listDatos);
                textNombre.Clear();
                textNombre.Focus();

            }
        }

        private void btnDesapilar_Click(object sender, EventArgs e)
        {
            string nom = c.dequeue();
            if (nom != null)
            {
                MessageBox.Show($"{nom} atendido!");
                listDatos.Items.Clear();
                c.mostrar(listDatos);
                textNombre.Focus();
            }
            else
            {
                MessageBox.Show("Cola vacia");
            }

        }

        private void btnVistazo_Click(object sender, EventArgs e)
        {
            string nom = c.Peek();
            if (nom != null) MessageBox.Show($"Pimero en la cola: {nom} ");
            else MessageBox.Show("Cola vacia");
        }

        private void btnCantidaddeElementos_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Cantidad : {c.Count()}");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            c.Clear();
            listDatos.Items.Clear();
            MessageBox.Show("Se limpiaron los datos!");
        }
    }
}
