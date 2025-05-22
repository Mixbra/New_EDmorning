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
    public partial class FrmArbolBinarioBusqueda: Form
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
          private void btnRecorrido_Click(object sender, EventArgs e)
                {
                    PreOrden.Clear();
                    InOrden.Clear();
                    PostOrden.Clear();

               ab.preOrden(raiz, PreOrden);
               ab.inOrden(raiz, InOrden);
               ab.postOrden(raiz, PostOrden);
        }



























        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
