using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Hosting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios.clases
{
    class ArbolBinario
    {
        public NodoAB insertar(NodoAB actual, int num)
        {
            NodoAB nuevo = new NodoAB(num);

            if (actual == null)
            {
                return nuevo;
            }
            else if ((actual.izquierdo != null || actual.derecho == null) &&
                    (actual.izquierdo == null || actual.derecho != null))
            {
                MessageBox.Show("Nodo ocupado");
            }
            else if (actual.izquierdo == null) { actual.izquierdo = nuevo; }
            else actual.derecho = nuevo;
            { 
            return actual;
            }

        }
        public void mostrar(NodoAB actual, TreeView tree, TreeNode padre)
        {
            if (actual == null) return;
            TreeNode nuevo = new TreeNode(actual.numero.ToString());
            nuevo.Tag = actual;
            if (padre == null)
            {
                tree.Nodes.Add(nuevo);
            }
            else
            {
                padre.Nodes.Add(nuevo);
            }
            if (actual.izquierdo != null)
            {
                mostrar(actual.izquierdo, tree, nuevo);
            }
            if (actual.derecho != null)
            {
                mostrar(actual.derecho, tree, nuevo);
            }
        }
        public int altura(NodoAB actual) { 
        if(actual == null) return 0;
            int altIzquierda = altura(actual.izquierdo);
            int altDereha = altura(actual.derecho);
          return Math.Max(altIzquierda, altDereha) + 1;

        }


    }
}
