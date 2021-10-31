using System;
using Aula_1.Exemplos;

namespace Aula_1
{
    class Program
    {
        static void Main()
        {
            var s = new Pilha();
            s.Empilha(1);
            s.Empilha(10);
            s.Empilha(100);
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
        }
    }
}
