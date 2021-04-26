using System;
using System.Linq;
using System.Collections.Generic;

namespace trifenix.courses.utils
{
    public class Validador
    {
        public static double ValidaNota(string input)
        {
            double validatedInput = NumberInput(input);
            if ((validatedInput) > 7 || (validatedInput) < 1)
            {
                throw new Exception("Las notas no son correctas");

            }

            return validatedInput;
        }
        public static double ValidaPorcentaje(string input)
        {
            var validatedInput = NumberInput(input);
            if ((validatedInput) > 100 || (validatedInput) < 1)
            {
                throw new Exception("Los porcentajes no son correctos");

            }

            return validatedInput;

        }
        public static double NumberInput(string entrada)
        {
            var dbl = double.Parse(entrada);
            return dbl;
        }

    }
}
