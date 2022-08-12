using System;

namespace ProcessamentoDeDadosCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------------
            //------------Exemplo1
            //int x, y;
            //x = 5;
            //y = 2 * x;

            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //Console.ReadLine();

            //---------------------------------------------------------------------------
            //-----------Exemplo 2
            //int x;
            //double y;
            //x = 5;
            //y = 2 * x;

            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //Console.ReadLine();        

            //----------------------------------------------
            //---------- Exemplo 3
            //double b, B, h, area;
            //b = 6.0;
            //B = 8.0;
            //h = 5.0;

            //area = (b + B) / 2.0 * h;

            //Console.WriteLine(area);

            //Console.ReadLine();

            //----------------------------------------------
            //---------- Exemplo 4
            //int a, b;
            //double resultado;

            //a = 5;
            //b = 2;

            //resultado = (double) a / b;

            //Console.WriteLine(resultado);

            //Console.ReadLine();

            //----------------------------------------------
            //---------- Exemplo 5

            double a;
            int b;

            a = 5.0;
            b = (int) a; // não me importo com a perda do valor -- conversão explicita de um tipo para outro

            Console.WriteLine(b);

            Console.ReadLine();
        }
    }
}
