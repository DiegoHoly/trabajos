using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_COMPLEJIDAD
{
    public abstract class ListaGenerica<T>
    {
            void comenzar() { }
            void proximo() { }
            void  Fin() { }
            void elemento(int posicion) { }
            void agregarEn(T elem, int pos) { }
            void agregarInicio(T elem) { }
            void agregarFinal(T elem) { }
            void eliminar(T elem) { }
            void eliminarEn(int pos) { }
            void incluye(T elem) { }
            void esVacia() { }
            void tamanio() { }
            void reemplazarEn(int pos, T elem) { }
            void clonar() { }

    }

public  class ListaEnlazadaGenerica<T>: ListaGenerica<T> where T : IComparable<T>
    {
        private NodoGenerico<T> inicio;
        private NodoGenerico<T> actual;
        private NodoGenerico<T> fin;
        private int tamaño = -1;

        //prepara para iterar la lista
        public void comenzar()
        {
            actual = inicio;

        }
        // devuelve el nodo actual y deja cargada la variable actual
        //con el proximo nodo
        public T proximo ()
        {
            T aux = actual.get_Dato();

            
            actual = actual.get_Nodo_Siguiente();
            
            return aux;
        }
        //determina si se llego al final de la lista
        public bool Fin()
        {
            if (fin == actual)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // devuelve el elemento de la posicion indicada 
        public T elemento (int posicion )
        {
            posicion = posicion - 1;
            comenzar();

         
            for (int i = 0; i <= posicion; i++)
            {
                proximo();

            }

            //tamaño--;
            return actual.get_Dato();
  
        }
        //Agrega el elemento en la posición indicada y retorna true si pudo agregar
        //y false; si no pudo agregar.
        public void agregarEn(T elem, int posicion) 
        {
            posicion = posicion - 1;
            comenzar();

            for (int i = 0; i <= posicion; i++)
            {
                proximo();
            }

            actual.set_Dato(elem);
            tamaño++;


        }
        //Agrega al inicio de la lista
        public void agregarInicio(T elem)
        {
            
            NodoGenerico<T> nuevo = new NodoGenerico<T>();
            nuevo.set_Dato(elem);
            if (esVacia())
            {
                
                inicio = nuevo;              
                fin = inicio;
                tamaño++;
            }
           
            else
            {
                nuevo.set_Nodo_Siguiente(inicio);
                inicio = nuevo;
                tamaño++;

            }
            
        }
        //Agrega al final de la lista
        public void agregarFinal(T elem) 
        {
            NodoGenerico<T> nuevo = new NodoGenerico<T>();
            nuevo.set_Dato(elem);
            if (esVacia())
            {

                fin = nuevo;              
                inicio = nuevo;
                tamaño++;
            }

            else
            {
                fin.set_Nodo_Siguiente(nuevo);
                fin = fin.get_Nodo_Siguiente();
                tamaño++;


            }
        }
        //Elimina elem de la lista y 
        //retorna true si lo pudo hacer y false si no lo encuentra
        public bool  eliminar(T elem)
        {
            comenzar();
            
            NodoGenerico<T> aux = new NodoGenerico<T>();
            bool encontrado = false;
            int posicion = 0;
           

            //encuentra coincidencia de elemento entrante con el de la lista
            //actualiza la variable " encontrado" a true
            //atrapa en "aux " el nodo siguiente del nodo que se va a borrar
            for (int i = 0; i <= tamaño; i++)
            {
                int atrapar = actual.get_Dato().CompareTo(elem);

                if (atrapar == 0)
                {
                    
                    encontrado = true;
                    posicion = i;
                    aux = actual.get_Nodo_Siguiente();
                }
                proximo();

            }

            //sino encontro coincidencia de elemento "encontrado" quedara falso
            //y freno el metodo returnando falso

            if (encontrado == false)
            {
                return false;
            }
            

            if(posicion == 0)
            {
                inicio = aux;

                comenzar();


                while (actual.get_Nodo_Siguiente() == null)
                {

                    proximo();
                }

                fin = actual;
                tamaño--;
                return encontrado;
            }

            comenzar();

            // me situo en el nodo anterior al que va a ser borrado
            for (int i = 0; i <= tamaño; i++)
            {
                if (i == posicion-1)
                {
                    actual.set_Nodo_Siguiente(aux);
                    break;
                   
                }
                
                proximo();
            }


            tamaño--;
            return encontrado;





        }
        //Elimina el elemento de la
        //posición indicada y retorna true si lo pudo
        //eliminar y false en caso contrario

        public bool  eliminarEn(int direccion_elemento_a_borrar) 
        {
            comenzar();

            NodoGenerico<T> aux = new NodoGenerico<T>();
            bool encontrado = false;
            int posicion = 0;


            //encuentra la posicion  donde esta el elemento buscado 
            //actualiza la variable " encontrado" a true
            //atrapa en "aux " el nodo siguiente del nodo que se va a borrar
            for (int i = 0; i <= tamaño; i++)
            {
                

                if (i == direccion_elemento_a_borrar)
                {

                    encontrado = true;
                    posicion = i;
                    aux = actual.get_Nodo_Siguiente();
                }
                proximo();

            }

            //sino encontro coincidencia de elemento "encontrado" quedara falso
            //y freno el metodo returnando falso

            if (encontrado == false)
            {
                return false;
            }


            if (posicion == 0)
            {
                inicio = aux;

                comenzar();


                while (actual.get_Nodo_Siguiente() == null)
                {

                    proximo();
                }

                fin = actual;
                tamaño--;
                return encontrado;
            }

            comenzar();

            // me situo en el nodo anterior al que va a ser borrado
            for (int i = 0; i <= tamaño; i++)
            {
                if (i == posicion - 1)
                {
                    actual.set_Nodo_Siguiente(aux);
                    break;

                }

                proximo();
            }


            tamaño--;
            return encontrado;

        }
        //Retorna true si elem está
        //contenido en la lista, false en caso contrario.

        public bool  incluye(T elem)
        {

            bool encontrado = false;
            comenzar();
            for (int i = 0; i <= tamaño; i++)
            {
                int atrapar = actual.get_Dato().CompareTo(elem);

                if (atrapar == 0)
                {

                    encontrado = true;
                    
                }
                proximo();

            }
            return encontrado;
        }


        //Retorna true si la lista está vacía,false en caso contrario.
        public bool esVacia() 
        { 
            if ( inicio == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        
        
        }

        //Retorna la longitud de la lista.
        public int  tamanio() 
        {
            return tamaño;
        }

        //Reemplazar el valor 
        //de la posición indicada y retorna true si lo pudo
        //reemplazar.


        public bool  reemplazarEn(int direccion_elemento_a_remplazar, T elem) 
        {

            comenzar();

            NodoGenerico<T> aux = new NodoGenerico<T>();
            bool encontrado = false;
            int posicion = 0;


            //encuentra la posicion  donde esta el elemento buscado 
            //actualiza la variable " encontrado" a true
            //atrapa en "aux " el nodo siguiente del nodo que se va a remplazar
            for (int i = 0; i <= tamaño; i++)
            {


                if (i == direccion_elemento_a_remplazar)
                {

                    encontrado = true;
                    posicion = i;
                    aux.set_Dato( elem);
                }

                proximo();

            }

            //sino encontro coincidencia de elemento "encontrado" quedara falso
            //y freno el metodo returnando falso

            if (encontrado == false)
            {
                return false;
            }


            

            comenzar();

            // me situo en el nodo y remplazado
            for (int i = 0; i <= tamaño; i++)
            {
                if (i == posicion )
                {
                    actual.set_Dato(aux.get_Dato());
                    break;

                }

                proximo();
            }


            
            return encontrado;

        }
       
        //Crea una copia de la lista genérica y la 
        //retorna.
        public NodoGenerico<T> clonar() 
        {
            return inicio;
        
        }

        

        //------------------------------------------------------------------------------//
        
}

}
