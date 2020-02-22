using System;
using System.Collections.Generic;

namespace Lista
{
    class Lista
    {
        public string Nombre;
        public void Imprimir()
        {
            Console.WriteLine(Nombre);
        }
        public Lista(string n)
        {
            Nombre=n;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Lista NP= new Lista("Spider-Man");
            NP.Nombre="Spider-Man";
            List<Lista> Nombres= new List<Lista>();
            Nombres.Add(NP);
            Nombres.Add(new Lista("Easy A"));
            Nombres.Add(new Lista("Rápido y Furioso"));
            Nombres.Add(new Lista("John Wick"));
            Nombres.Add(new Lista("Kick-Ass"));

            //Ciclo
            foreach(Lista i in Nombres)
            {
                i.Imprimir();
            }
        
        }
    }
}
