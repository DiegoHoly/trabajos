using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_COMPLEJIDAD
{
    public class NodoGenerico<T> where T : IComparable<T>
    {
        private T dato;
        private NodoGenerico<T> siguiente;


        public T get_Dato()
        {
            return dato;
        }
        public void set_Dato(T entrada)
        {

            dato = entrada;
        }

        public NodoGenerico<T> get_Nodo_Siguiente()
        {
            return siguiente;
        }
        public void set_Nodo_Siguiente(NodoGenerico<T> entrada)
        {
            siguiente = entrada;
        }
    }
}
