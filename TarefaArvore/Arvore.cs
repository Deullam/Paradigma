using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefaArvore
{
    public class Arvore
    {
        public int Raiz { get; set; }
        public List<int> GalhoEsquerda { get; set; }
        public List<int> GalhoDireita { get; set; }


        public Arvore()
        {
            Raiz = 0;
            GalhoEsquerda = new List<int>();
            GalhoDireita = new List<int>();
        }

        /** Método utilizado para criar a estrutura da Arvore conforme array */
        public void CriarArvore(int[] lista)
        {
            int MaiorValor = 0;
            int indice = 0;
            foreach (var numero in lista)
            {
                if (numero > MaiorValor)
                {
                    MaiorValor = numero;
                    indice = Array.IndexOf(lista, numero);
                }
            }
            Raiz = MaiorValor;

            for (int i = 0; i < indice; i++)
            {
                GalhoEsquerda.Add(lista[i]);
            }
            GalhoEsquerda.Sort();
            GalhoEsquerda.Reverse();
           
            indice++;
            for (int i = indice; i < lista.Length; i++)
            {
                GalhoDireita.Add(lista[i]);
            }
            GalhoDireita.Sort();
            GalhoDireita.Reverse();
        }

        /** Metodo para mostrar a Arvore no console*/
        public void MostrarArvore()
        {
            Console.WriteLine("Raiz: " + Raiz);
            Console.Write("Galho esquerda: ");
            foreach (var numero in GalhoEsquerda)
            {
                Console.Write(" " + numero);
            }

            Console.Write("\nGalho direita: ");
            foreach (var numero in GalhoDireita)
            {
                Console.Write(" " + numero);
            }
        }
    }
}
