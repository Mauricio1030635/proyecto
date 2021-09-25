using System;
using System.Collections.Generic;

#nullable disable

namespace educationProject.Models
{
    public partial class Acudiente
    {
        public Acudiente()
        {
            Estudiantes = new HashSet<Estudiante>();
        }

        public int IdAcudiente { get; set; }
        public string NombreAcudiente { get; set; }
        public string ApellidoAcudiente { get; set; }
        public string TelefonoAcudiente { get; set; }
        public string DireccionAcudiente { get; set; }

        public virtual ICollection<Estudiante> Estudiantes { get; set; }
    }
}
