using ejercicios.clases;
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
    public partial class FrmArbolBinarioBusqueda : Form
    {
        ArbolBinarioBusqueda ab = new ArbolBinarioBusqueda();
        NodoAB raiz;
        public FrmArbolBinarioBusqueda()
        {
            InitializeComponent();
        }

        private void btnInsertarRaiz_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textNumero.Text, out int num))
            {
                if (raiz == null) raiz = ab.insertar(raiz, num);
                else ab.insertar(raiz, num);
                treeView1.Nodes.Clear();
                ab.mostrar(raiz, treeView1, null);
                treeView1.ExpandAll();
                textNumero.Clear();
            }
            else
            {
                MessageBox.Show("SOLO SE PERMITEN NÚMEROS ENTEROS....");
            }
        }
        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            PreOrden.Clear();
            InOrden.Clear();
            PostOrden.Clear();

            ab.preOrden(raiz, PreOrden);
            ab.inOrden(raiz, InOrden);
            ab.postOrden(raiz, PostOrden);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Buscarbtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textNumero.Text, out int num))
            {
                if (ab.Buscar(raiz, num) != null)

                    MessageBox.Show($"El número {num} se encuentra en el árbol.");

                else

                    MessageBox.Show($"El número {num} no existe ");

            }
            else

                MessageBox.Show("SOLO SE PERMITEN NÚMEROS ENTEROS....");
        }

        private void Eliminarbtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textNumero.Text, out int num))
            {
                if (ab.Buscar(raiz, num) == null)
                {
                    MessageBox.Show($"El número {num} no existe ");


                }
                else
                {
                    raiz = ab.Eliminar(raiz, num);
                    treeView1.Nodes.Clear();
                    ab.mostrar(raiz, treeView1, null);
                    treeView1.ExpandAll();
                    textNumero.Clear();
                }

            }
            else

                MessageBox.Show("SOLO SE PERMITEN NÚMEROS ENTEROS....");
        }
    }
    
}
