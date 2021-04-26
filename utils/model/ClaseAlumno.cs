using System;
using System.Collections.Generic;
using System.Linq;

namespace trifenix.courses.utils.model
{
    public class ClaseAlumno {
        public Sala Sala { get; set; }

        

        public Semestre Semestre { get; set; }

        public List<ProfesorClase> Profesores { get; set; } = new List<ProfesorClase>();

        public ProfesorClase ProfesorActivo => Profesores.Where(s => s.Inicio < DateTime.Now && s.Fin > DateTime.Now).FirstOrDefault();




    }
}
