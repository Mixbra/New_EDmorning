using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios.clases
{
    class ArbolBinarioBusqueda
    {
        public NodoAB insertar(NodoAB actual, int num)
        {
            NodoAB nuevo = new NodoAB(num);

            if (actual == null)
            {
                return nuevo;
            }
            if (num < actual.numero)
            {
                actual.izquierdo = insertar(actual.izquierdo, num);
            }
            else if (num > actual.numero)
            {
                actual.derecho = insertar(actual.derecho, num);
            }
            else
            {
                MessageBox.Show("No se permiten duplicados");
            }
            return actual;
        }
        public void mostrar(NodoAB actual, TreeView tree, TreeNode tallo)
        {
            if (actual == null)
            {
                return;
            }
            TreeNode cabeRaiz = new TreeNode(actual.numero.ToString());
            if (tallo == null)
            {
                tree.Nodes.Add(cabeRaiz);
            }
            else
            {
                tallo.Nodes.Add(cabeRaiz);
            }
            mostrar(actual.izquierdo, tree, cabeRaiz);
            mostrar(actual.derecho, tree, cabeRaiz);


        }
        public void preOrden(NodoAB actual, TextBox text)
        {
            if (actual == null) return;
            text.Text += actual.numero.ToString() + " ";
            preOrden(actual.izquierdo, text);
            preOrden(actual.derecho, text);
        }
        public void inOrden(NodoAB actual, TextBox text)
        {
            if (actual == null) return;
            inOrden(actual.izquierdo, text);
            text.Text += actual.numero.ToString() + " ";
            inOrden(actual.derecho, text);
        }
        public void postOrden(NodoAB actual, TextBox text)
        {
            if (actual == null) return;
            postOrden(actual.izquierdo, text);
            postOrden(actual.derecho, text);
            text.Text += actual.numero.ToString() + " ";


        }
    }
}
