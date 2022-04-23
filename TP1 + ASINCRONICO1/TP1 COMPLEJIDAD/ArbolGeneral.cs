using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_COMPLEJIDAD
{
	public class ArbolGeneral<T>
	{
		
		private T dato;
		private List<ArbolGeneral<T>> hijos = new List<ArbolGeneral<T>>();
		private static int datoglobal;

		public ArbolGeneral(T dato) {
			this.dato = dato;
		}
	
		public T getDatoRaiz() {
			return this.dato;
		}
	
		public List<ArbolGeneral<T>> getHijos() {
			return hijos;
		}
	
		public void agregarHijo(ArbolGeneral<T> hijo) {
			this.getHijos().Add(hijo);
		}
	
		public void eliminarHijo(ArbolGeneral<T> hijo) {
			this.getHijos().Remove(hijo);
		}
	
		public bool esHoja() {
			return this.getHijos().Count == 0;
		}
	
		public int altura()
		{

				int altura = 0;
				if (this.esHoja())
				{
					return 0;
				}
				else
				{
					foreach (ArbolGeneral<T> hijo in this.getHijos())
					{
						if (hijo.altura() > altura)
						{
							altura = hijo.altura();
						}
					}
				}
				return 1 + altura;
			
		}

		public void recorrer()
		{

			
				foreach (ArbolGeneral<T> hijo in this.getHijos())
				{
				  Console.WriteLine(hijo.getDatoRaiz());
				}
			

		}
		public int nivel(T dato) {
			return 0;
		}
		
	
	}
}
