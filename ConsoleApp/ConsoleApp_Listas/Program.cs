using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> minhaLista = new List<int>();
            //Adicionar Elementos
            minhaLista.Add(10);
            minhaLista.Add(30);
            minhaLista.Add(50);
            minhaLista.Add(60);
            minhaLista.Add(80);

            minhaLista.Insert(2, 22);

            foreach (int item in minhaLista)
            {
                Console.WriteLine(item);
            }

            /*

            // Consultando propriedades
            Console.WriteLine(minhaLista.Capacity);
            Console.WriteLine(minhaLista.Count);


            //Percorrendo a lista com foreach()
            foreach(int item in minhaLista)
            {
                Console.WriteLine(item);
            }

            //Percorrendo a lista com for
            Console.WriteLine("percorrer a lista com for");
            for (int i =0;i<minhaLista.Count;i++)
            {
                Console.WriteLine(minhaLista[i]);
            }

            */

            List<int> outralista = new List<int>();

            outralista.Add(11);
            outralista.Add(12);
            outralista.Add(13);
            outralista.Add(14);
            outralista.Add(15);

            //minhaLista.AddRange(outralista);

            minhaLista.InsertRange(2, outralista);

            foreach(int item in minhaLista)
            {
                Console.WriteLine(item);
            }

            /*
            Console.ReadKey();

            minhaLista.Clear();

            foreach (int item in minhaLista)
            {
                Console.WriteLine(item);
            }

            */


            /*
            if(minhaLista.Contains(31))
            {
                Console.WriteLine("tem na lista");
            }
            else
            {
                Console.WriteLine("NÃO tem na lista");
            }
            */



            Console.ReadKey();
            

        }
    }
}
