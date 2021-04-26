using System;

namespace trifenix.courses.utils.model
{
    public class ProfesorClase {
        public DateTime Inicio { get; set; }

        public DateTime? Fin { get; set; }

        public bool Activo => Inicio < DateTime.Now && Fin > DateTime.Now;

        public Persona Profesor { get; set; }



    }
}
