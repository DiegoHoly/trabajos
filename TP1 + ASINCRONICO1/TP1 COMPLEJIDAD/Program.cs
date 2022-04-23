using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_COMPLEJIDAD
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ArbolGeneral<int> nodoraiz = new ArbolGeneral<int>(0);
            //ArbolGeneral<int> nodo1 = new ArbolGeneral<int>(1);
            //ArbolGeneral<int> nodo2 = new ArbolGeneral<int>(2);
            //ArbolGeneral<int> nodo3 = new ArbolGeneral<int>(3);
            //ArbolGeneral<int> nodo4 = new ArbolGeneral<int>(4);
            //ArbolGeneral<int> nodo5 = new ArbolGeneral<int>(5);
            //ArbolGeneral<int> nodo6 = new ArbolGeneral<int>(6);

            //nodoraiz.agregarHijo(nodo1);
            //nodoraiz.agregarHijo(nodo2);
            //nodo1.agregarHijo(nodo3);
            //nodo1.agregarHijo(nodo4);
            //nodo4.agregarHijo(nodo5);




            //---------------Lista Generica test ---------------------------


            ListaEnlazadaGenerica<int> lista = new ListaEnlazadaGenerica<int>();




            lista.agregarInicio(10);
            lista.agregarFinal(22);
            lista.agregarFinal(100);

            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine(lista.elemento(i));
            }
            Console.ReadKey();


            lista.reemplazarEn(0, 1000);

            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine(lista.elemento(i));
            }
            Console.ReadKey();


            //*----------------------- test cola generica-----*//

            //ColaGenerica<int> cola = new ColaGenerica<int>();

            //cola.Encolar(1);
            //cola.Encolar(2);
            //cola.Encolar(3);

            ////tope

            ////for (int i = 0; i <= 2; i++)
            ////{
            ////    Console.WriteLine(cola.tope());
            ////}
            ////Console.ReadKey();

            ////desencolar/esvacia

            //for (int i = 0; i <= 2; i++)
            //{
            //    Console.WriteLine(cola.desencolar());
            //}

            //Console.WriteLine(cola.esVacia());
            //Console.ReadKey();

            //cola.Encolar(10);
            //cola.Encolar(20);
            //cola.Encolar(30);
            //Console.WriteLine(cola.esVacia());
            //Console.ReadKey();

            //for (int i = 0; i <= 2; i++)
            //{
            //    Console.WriteLine(cola.desencolar());
            //}
            //Console.ReadKey();





            //*----------------------- test pila generica-----*//

            //PilaGenerica<int> pila = new PilaGenerica<int>();

            //pila.Apilar(1);
            //pila.Apilar(3);
            //pila.Apilar(2);




            //Console.WriteLine(pila.Desapilar());
            //Console.WriteLine(pila.Desapilar());
            //Console.WriteLine(pila.Desapilar());

            //Console.ReadKey();

            //pila.Apilar(19);
            //pila.Apilar(3);
            //pila.Apilar(22);




            //Console.WriteLine(pila.Desapilar());
            //Console.WriteLine(pila.Desapilar());
            //Console.WriteLine(pila.Desapilar());



            //Console.ReadKey();


            //Console.WriteLine(pila.tope());

            //Console.ReadKey();



        }
    }
}
