using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    public class Nodo
    {
        public double Valor { get; set; }
        public List<Nodo> NodosHijos { get; set; } = new List<Nodo>();
    }
    class Program
    {
        static void Main(string[] args)
        {

            var nodo3 = new Nodo { Valor = 55.2f };
            var nodo4 = new Nodo { Valor = -7f };
            var nodo5 = new Nodo { Valor = 3.1e2 };
            var nodo6 = new Nodo { Valor = -7f };


            var nodo1 = new Nodo { Valor = 15.2f };
            nodo1.NodosHijos.Add(nodo3);
            nodo1.NodosHijos.Add(nodo4);

            var nodo2 = new Nodo { Valor = -7f };
            nodo2.NodosHijos.Add(nodo5);
            nodo2.NodosHijos.Add(nodo6);

            Nodo arbol = new Nodo { Valor = 10.5f };
            arbol.NodosHijos.Add(nodo1);
            arbol.NodosHijos.Add(nodo2);

            Console.WriteLine(Navegar(arbol));

            string[] languages = { "Lisp", "ICI", "C#", "Angular", "F#" };
            var result = string.Join(string.Empty, languages.Reverse().Select(s => s[0]));
            Console.WriteLine(result);
        }
        static double Navegar(Nodo nodo)
        {
            if (!nodo.NodosHijos.Any())
            {
                return nodo.Valor;
            }
            var valores = new List<double> { nodo.Valor };

            foreach (var item in nodo.NodosHijos)
            {
                valores.Add(Navegar(item));
            }
            return valores.Max();
        }
    }
}
