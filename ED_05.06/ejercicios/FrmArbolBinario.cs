using ejercicios.clases;
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
    public partial class FrmArbolBinario: Form
    {
        clases.ArbolBinario AB = new clases.ArbolBinario();
        NodoAB raiz;
        NodoAB seleccionado;

        public object TextNumero { get; private set; }

        public FrmArbolBinario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnApilar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textNumero.Text, out int num))
            {
                raiz = AB.insertar(null, num);
                treeView1.Nodes.Clear();
                AB.mostrar(raiz, treeView1, null);
                treeView1.ExpandAll();
               textNumero.Clear();
            }
            else MessageBox.Show("Ingrese un número válido");
            
               
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            seleccionado = (NodoAB)e.Node.Tag;
        }

        private void btnDesapilar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textNumero.Text, out int num))
            {
                if (seleccionado != null)
                {
                    if(RadioIzquierda.Checked == true )seleccionado.izquierdo = AB.insertar(seleccionado.izquierdo, num);
                    if(RadioDerecha.Checked == true) seleccionado.derecho = AB.insertar(seleccionado.derecho, num);

                    treeView1.Nodes.Clear();
                    AB.mostrar(raiz, treeView1, null);
                    treeView1.ExpandAll();
                    textNumero.Clear();
                }
                else MessageBox.Show("Seleccione un número");
            }   }

        private void button1_Click(object sender, EventArgs e)
        {
            int altura = AB.altura(raiz);
            MessageBox.Show("Altura: " + altura);

        }
    }
}
