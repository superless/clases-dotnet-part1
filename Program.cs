using System;


namespace HelloWorld
{
    class Program
    {
        // este es mi comentario !!!!!
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa de notas de jorge seba y ale!");
            Console.ReadLine();
            var notaIndex = 1;
            while (notaIndex < 4)
            {

                bool inputCorrect;
                do
                {
                    inputCorrect = true;
                    Console.WriteLine($"Ingrese nota {notaIndex}");
                    var input = Console.ReadLine();

                    try
                    {
                        var validatedInput = NumberInput(input);
                        if (double.Parse(validatedInput) > 7 || double.Parse(validatedInput) < 1)
                        {
                            Console.WriteLine("La nota debe estar entre 1 y 7");
                            inputCorrect = false;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("El numero ingresado no es válido");
                        inputCorrect = false;
                    }
                } while (!inputCorrect);
                notaIndex++;
            }

            Console.WriteLine($"Programa Terminado");
            Console.ReadLine();
        }

        static string NumberInput(string entrada) {
            var dbl = double.Parse(entrada);
            return dbl.ToString();

        }

        


    }

    
}
