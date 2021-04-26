using System.Collections.Generic;

namespace trifenix.courses.utils.model
{
    public class Persona {

        public List<Persona> Hijos { get; set; } = new List<Persona>();

        public string Rut { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

    }
}
