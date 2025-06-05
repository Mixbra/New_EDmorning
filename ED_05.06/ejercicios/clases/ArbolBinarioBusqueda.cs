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
        public NodoAB Buscar(NodoAB Actual, int numero)
        {
            if (Actual == null) return null;

            if (numero == Actual.numero) return Actual;
            else if(numero < Actual.numero)
                return Buscar(Actual.izquierdo, numero);
            
            else 
                return Buscar(Actual.derecho, numero);
        }
        public NodoAB Eliminar(NodoAB actual, int num)
        {

            if (actual == null) return null;


            if (num < actual.numero)
                return Eliminar(actual.izquierdo, num);

            else if(num > actual.numero)
                return Eliminar(actual.derecho, num);

            else { 
              if(actual.izquierdo == null)return actual.derecho;
              if (actual.derecho == null) return actual.izquierdo;

              NodoAB sucesor = minimo(actual.derecho);

              actual.numero = sucesor.numero;
              actual.derecho = Eliminar(actual.derecho, sucesor.numero);
            }
            return actual;
        }
        public NodoAB minimo(NodoAB actual)
        { 
        while(actual.izquierdo != null)
                actual = actual.izquierdo;
        return actual;
        }
    }
}
