﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_COMPLEJIDAD
{
     class PilaGenerica<T> : ListaGenerica<T> where T : IComparable<T>
    {
		private NodoGenerico<T> inicio;
		private NodoGenerico<T> actual;
		private NodoGenerico<T> fin;
		private int tamaño = -1;

		public void Apilar(T elem)
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
		
		public T  Desapilar ()
		{

			// atrapo en una variable auxiliar el dato del nodo final
			NodoGenerico<T> aux = new NodoGenerico<T>();
			aux.set_Dato(fin.get_Dato());


			// posiciono actual en el nodo anterior al final con -2 en el tamaño
			comenzar();
			for (int i = 0; i <= tamaño-2; i++)
			{
				proximo();

			}

			fin = actual;


			if (tamaño == 0)
            {
				inicio = null;
            }

			tamaño--;
			return aux.get_Dato();
		}



		public T tope()
		{


			return fin.get_Dato();
		}

		public bool esVacia()
		{
			if (inicio == null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		private void comenzar()
		{
			actual = inicio;

		}
		private T proximo()
		{
			T aux = actual.get_Dato();


			actual = actual.get_Nodo_Siguiente();

			return aux;
		}
		private bool Fin()
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
	}
}

