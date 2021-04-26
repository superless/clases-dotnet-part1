using System;
using System.Collections.Generic;
using System.Linq;
using trifenix.courses.utils;

namespace HelloWorld
{
    class Program
    {
        // este es mi comentario !!!!!
        // comentario del profesor

        static void Main(string[] args)
        {
            List<double> notas = new List<double>();
            List<double> porcentajes = new List<double>();

            Console.WriteLine("Bienvenido al programa de notas de jorge seba y ale!");
            Console.ReadLine();
            var notaIndex = 0;
            while (notaIndex < 3)
            {

                double inputValidated = 0;
                do
                {

                    Console.WriteLine($"Ingrese nota {notaIndex + 1}");
                    string input = Console.ReadLine();
                    try
                    {
                        inputValidated = Validador.ValidaNota(input);
                        //Console.WriteLine(inputValidated);
                        notas.Add(inputValidated);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);

                    }



                } while (inputValidated == 0);

                notaIndex++;
            }

            var porcentIndex = 0;
            while (porcentIndex < 3)
            {
                double inputValidated = 0;
                do
                {
                    Console.WriteLine($"Ingrese porcentaje {porcentIndex + 1}");
                    string input = Console.ReadLine();
                    try
                    {
                        inputValidated = Validador.ValidaPorcentaje(input);
                        porcentajes.Add(inputValidated);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);

                    }
                } while (inputValidated == 0);

                porcentIndex++;
            }

            double notaFinal = 0;
            for (int i = 0; i < 3; i++)
            {
                notaFinal = notaFinal + (notas[i] * (porcentajes[i] / 100));
            }
            Console.WriteLine($"Nota final: {notaFinal}");
            Console.WriteLine($"Numero de notas superior a 4: {notas.Where(x => x >= 4).Count()}");

            Console.WriteLine($"Programa Terminado");
            Console.ReadLine();
        }
    }


}

