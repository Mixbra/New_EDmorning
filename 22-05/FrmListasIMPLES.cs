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
    public partial class FrmListasIMPLES: Form
    {
        clases.ListaSimple ls = new clases.ListaSimple();

        public FrmListasIMPLES()
        {
            InitializeComponent();
        }

        private void listNumeros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void btrInsertar_Click(object sender, EventArgs e)
        {
            listNumeros.Items.Clear();
                ls.insertar(int.Parse(txtNumero.Text));
            ls.mostrar(listNumeros);
            txtNumero.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            ls.eliminar(int.Parse(txtNumero.Text));
            listNumeros.Items.Clear();
            ls.mostrar(listNumeros);
            txtNumero.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ls.ordenar();
            listNumeros.Items.Clear();
            ls.mostrar(listNumeros);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(ls.Buscar(int.Parse(txtNumero.Text)) == true)
            {
                MessageBox.Show("EL NUMERO SI EXISTE EN LA LISTA :) ");
            }else
            
               MessageBox.Show("EL NUMERO NO EXISTE EN LA LISTA :( ");
            

        }
    }
}
