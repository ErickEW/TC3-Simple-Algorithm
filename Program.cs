using System;

namespace Simple_algorithm
{
    class Program
    {
   static void Main(string[] args)
        {
            int Num;

            Console.WriteLine("Inserta un numero");

            Num = Convert.ToInt32(Console.ReadLine());

            System.Console.Write(Num);

            for (int i = 1; i <= Num; i ++)
            {
              System.Console.Write(" i, ");
            }

            Console.WriteLine(Num);

        }
    }
}
//To do : Que se muestren los numeros entre los 2 numeros que insertamos