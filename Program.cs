using System;

using MyQueue;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {


            Fila minhaFila = new Fila();

           // minhaFila.print();
            minhaFila.StackUp(1);
            minhaFila.StackUp(2);
            minhaFila.StackUp(3);
            minhaFila.StackUp(3);
            minhaFila.StackUp(3);
            minhaFila.StackUp(3);
            minhaFila.StackUp(3);
            minhaFila.print();
            /*
            Console.WriteLine(minhaFila.Unstack());
            Console.WriteLine(minhaFila.Unstack());
            Console.WriteLine(minhaFila.Unstack());
            Console.WriteLine(minhaFila.Unstack());
            Console.WriteLine(minhaFila.Unstack());
            Console.WriteLine(minhaFila.Unstack());
            Console.WriteLine(minhaFila.Unstack());
            Console.WriteLine(minhaFila.Unstack());
            */
        }
    }
}