using System;

namespace AppCons_test2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Ejemplo de los participantes de los pilares de la programación estructurada 
            //secuencias

            // int a;
            // a = 10;
            //  int b = 20;
            //   Console.WriteLine("La multiplicación de {0} x {1} es {2} ", a, b, (a * b));
            //    Console.WriteLine("Pulse una tecla para continuar...");
            // Console.ReadKey();//

            for (int x = 1; x <= 5; x++)

            {

                Console.WriteLine(x);

            }
            Console.ReadKey();

            {

                for (int x = 1; x <= 5; x++)
                {
                    for (int y = 1; y <= 5; y++)
                    {
                        Console.WriteLine("Hola Mundo");
                    }


                    Console.WriteLine();
                }

                Console.ReadKey();
            }

            {

                string nombre = "HolaMundo2";

                foreach (char palabra in nombre)
                {

                    Console.WriteLine(" " + palabra + " ");

                }

                Console.ReadKey();
            }
        }


    }
}