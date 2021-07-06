using System;

namespace estruturas
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new Pilha();
            x.empilha(1);
            x.empilha(10);
            x.empilha(100);
            Console.WriteLine(x.desempilha());
            Console.WriteLine(x.desempilha());
            Console.WriteLine(x.desempilha());
        }
    }
}
