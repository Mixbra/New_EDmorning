using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios.clases
{
    class NodoAB
    {
        public int numero { get; set; }
        public NodoAB izquierdo { get; set; }
        public NodoAB derecho { get; set; }
       

        public NodoAB(int num)
        {
            numero = num;
            izquierdo = null;
            derecho = null;
        }
    }
}
