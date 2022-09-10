using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimple19100179
{
    public class ClaseListaSimpleDesordenada<Tipo> where Tipo: IEquatable<Tipo>
    {
		private ClaseNodo<Tipo> _nodoInicial;

		private ClaseNodo<Tipo> NodoInicial
		{
			get { return _nodoInicial; }
			set { _nodoInicial = value; }
		}
		public ClaseListaSimpleDesordenada()
		{
			NodoInicial = null;
		}
		public bool Vacia
		{
			get
			{
				return NodoInicial == null;
			}
		}
		public IEnumerator<Tipo> GetEnumerator()
		{
			if (Vacia) yield break;
			ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
			nodoActual = NodoInicial;
			do
			{
				yield return nodoActual.ObjetoConDatos;
				nodoActual = nodoActual.Siguiente;
			} while (nodoActual != null);
			yield break;
		}

		public void AgregarNodo(Tipo objeto)
		{
			if (Vacia)
			{
				ClaseNodo<Tipo> nuevoNodo = new ClaseNodo<Tipo>();
				nuevoNodo.ObjetoConDatos = objeto;
				nuevoNodo.Siguiente = null;
				NodoInicial = nuevoNodo;
			}
			else
			{
				ClaseNodo<Tipo> nodoActual, nodoAnterior = new ClaseNodo<Tipo>();
				nodoActual = NodoInicial;
				nodoAnterior = NodoInicial;
				do
				{
					if (objeto.Equals(nodoActual.ObjetoConDatos))
					{
						throw new Exception("No se permiten objetos duplicados.");
					}
					else
					{
						nodoAnterior = nodoActual;
						nodoActual = nodoActual.Siguiente;
					}
				} while (nodoActual != null);
                ClaseNodo<Tipo> nuevoNodo = new ClaseNodo<Tipo>();
                nuevoNodo.ObjetoConDatos = objeto;
                nuevoNodo.Siguiente = null;
				nodoAnterior.Siguiente = nuevoNodo;
            }
		}
		public Tipo BuscarNodo(Tipo objeto)
		{
			if (Vacia)
			{
				throw new Exception("La coleccion se encuentra vacia.");
			}
			else
			{
				ClaseNodo<Tipo> nodoActual, nodoAnterior = new ClaseNodo<Tipo>();
				nodoActual = NodoInicial;
				do
				{
					if (objeto.Equals(nodoActual.ObjetoConDatos))
					{
						return nodoActual.ObjetoConDatos;
					}
					else
					{
						nodoActual = nodoActual.Siguiente;
					}
				} while (nodoActual != null);
				throw new Exception("El elemento ingresado no se encuentra en la coleccion.");
			}
		}
		public Tipo EliminarNodo(Tipo objeto)
		{
			if (Vacia)
			{
				throw new Exception("No hay elemento a eliminar en una lista vacia.");
			}
			else
			{
				ClaseNodo<Tipo> nodoActual, nodoAnterior, nodoEliminado = new ClaseNodo<Tipo>();
				nodoActual = NodoInicial;
				nodoAnterior = NodoInicial;
				do
				{
					if(objeto.Equals(nodoActual.ObjetoConDatos))
					{
						if(nodoActual == NodoInicial)
						{
							nodoEliminado = nodoActual;
							NodoInicial = nodoActual.Siguiente;
							nodoActual = default;
							return nodoEliminado.ObjetoConDatos;
						}
						else
						{
							nodoEliminado = nodoActual;
							nodoAnterior.Siguiente = nodoActual.Siguiente;
							nodoActual = default;
							return nodoEliminado.ObjetoConDatos;
						}
					}
					else
					{
                        nodoAnterior = nodoActual;
                        nodoActual = nodoActual.Siguiente;
                    }
					
				} while (nodoActual != null)
;				throw new Exception("Dato a eliminar no localizado.\nNo existe el dato ingresado.");
			}

		}
		public void Vaciar()
		{
			if (Vacia)
			{
				throw new Exception("No se puede vaciar la lista debido a que no tiene datos.");
			}
			else
			{
                ClaseNodo<Tipo> nodoActual, nodoAnterior = new ClaseNodo<Tipo>();
                nodoActual = NodoInicial;
                do
                {
					nodoAnterior = nodoActual;
					nodoActual = nodoActual.Siguiente;
					nodoAnterior = default;
                    
                } while (nodoActual != null);
				NodoInicial = null;
                
            }
		}
	}
}
