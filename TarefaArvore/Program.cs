using System;

namespace TarefaArvore
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = new int[6] { 3, 2, 1, 6, 0, 5 };
            int[] lista2 = new int[7] { 7, 5, 13, 9, 1, 6, 4 };


            Arvore arvore = new();
            Arvore arvore2 = new();

            arvore.CriarArvore(lista);
            arvore2.CriarArvore(lista2);

            Console.WriteLine("Árvore 1: ");
            arvore.MostrarArvore();

            Console.WriteLine("\n \nÁrvore 2: ");
            arvore2.MostrarArvore();

        }
    }
}
