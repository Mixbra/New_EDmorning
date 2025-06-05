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
    public partial class FrmABB3: Form
    {

        ArbolBinarioBusqueda3 ab = new ArbolBinarioBusqueda3 ();
        NodoAB raiz;
        public FrmABB3()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
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

        private void BuscarMinimo_Click(object sender, EventArgs e)
        {
            if (raiz != null)
                MessageBox.Show("Minimo: " + ab.minimo(raiz));
            else
                MessageBox.Show("Arbol vacío");
        }

        private void btnMaximo_Click(object sender, EventArgs e)
        {
            if (raiz != null)
                MessageBox.Show("Maximo: " + ab.maximo(raiz));
            else
                MessageBox.Show("Arbol vacío");
        }

        private void btnBalanceado_Click(object sender, EventArgs e)
        {
            
            if (raiz != null)
            {
                if (ab.balanceo(raiz) != -1) MessageBox.Show("El arbol esta balanceado ");
                else
                    MessageBox.Show("El arbol no esta balanceado ");
            }
            else MessageBox.Show("Arbol vacío");
        }

        private void btnSumaHojas_Click(object sender, EventArgs e)
        {
            txtSuma.Clear();
            int suma = ab.sumahojas(raiz);

            if (raiz != null)
                txtSuma.Text = suma.ToString();
            else
                MessageBox.Show("Arbol vacío");
            
        }
    }
}
