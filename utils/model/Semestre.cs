using System;
using System.Collections.Generic;

namespace trifenix.courses.utils.model
{
    public class Semestre {
        public DateTime Inicio { get; set; }

        public DateTime Termino { get; set; }

        public List<DateTime> Feriados { get; set; } = new List<DateTime>();

    }
}
