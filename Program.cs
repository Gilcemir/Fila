using System;

using MyQueue;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {


            Fila minhaFila = new Fila();

            minhaFila.StackUp(1);
            minhaFila.StackUp(2);
            minhaFila.StackUp(3);
            minhaFila.StackUp(3);
            minhaFila.StackUp(3);
            minhaFila.StackUp(3);
            minhaFila.StackUp(3);

            Console.WriteLine(minhaFila.Unstack());
            Console.WriteLine(minhaFila.Unstack());
            Console.WriteLine(minhaFila.Unstack());
            Console.WriteLine(minhaFila.Unstack());
            Console.WriteLine(minhaFila.Unstack());
            Console.WriteLine(minhaFila.Unstack());
            Console.WriteLine(minhaFila.Unstack());
            Console.WriteLine(minhaFila.Unstack());
        }
    }
}