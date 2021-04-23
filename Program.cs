using System;
using System.Collections.Generic;
using System.Linq;

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
            while (notaIndex < 3 )
            {
                bool inputCorrect;
                do
                {
                    inputCorrect = true;
                    Console.WriteLine($"Ingrese nota {notaIndex+1}");
                    var input = Console.ReadLine();
                

                    try
                    {
                        var validatedInput = NumberInput(input);
                        if (double.Parse(validatedInput) > 7 || double.Parse(validatedInput) < 1)
                        {
                            Console.WriteLine("La nota debe estar entre 1 y 7");
                            inputCorrect = false;
                        }

                        //obtenego numero validado, ingreso a lista
                        notas.Add(double.Parse(input));
                    }
                    catch
                    {
                        Console.WriteLine("El numero ingresado no es válido");
                        inputCorrect = false;
                    }
                } while (!inputCorrect);

                notaIndex++;
            }

            var porcentIndex = 0;
            while (porcentIndex < 3)
            {
                bool porcentCorrect;
                do
                {
                    porcentCorrect = true;
                    Console.WriteLine($"Ingrese porcentaje nota {porcentIndex+1}");
                    var input = Console.ReadLine();


                    try
                    {
                        var validatedInput = NumberInput(input);
                        if (int.Parse(validatedInput) > 100 || int.Parse(validatedInput) < 1)
                        {
                            Console.WriteLine($"El porcentaje debe estar entre 1 y 100");
                            porcentCorrect = false;
                        }
                        porcentajes.Add(double.Parse(input));

                        //Ya ingresadas las 3 notas, sumo y valido 
                        if(porcentajes.Count() == 3)
                        {
                            var total = porcentajes.Sum(x => x);
                            if(total != 100)
                            {
                                Console.WriteLine($"La suma de los porcentajes debe ser exactamente 100%, ingrese nuevamente");
                                porcentajes.Clear();
                                porcentIndex = 0;
                                porcentCorrect = false;

                            }
                          
                        }
                    }
                    catch
                    {
                        Console.WriteLine($"El porcentaje ingresado no es válido");
                        porcentCorrect = false;
                    }

                } while (!porcentCorrect);

                porcentIndex++;
            }
          
            double notaFinal = 0;
            for(int i = 0; i < 3; i++)
            {
                notaFinal = notaFinal+(notas[i] * (porcentajes[i]/100));
            }
            Console.WriteLine($"Nota final: {notaFinal}");
            
            Console.WriteLine($"Programa Terminado");
            Console.ReadLine();
        }

        static string NumberInput(string entrada) {
            var dbl = double.Parse(entrada);
            return dbl.ToString();
        }
    }

    
}
