using System;
using System.Collections.Generic;

#nullable disable

namespace educationProject.Models
{
    public partial class Estudiante
    {
        public Estudiante()
        {
            Grupos = new HashSet<Grupo>();
        }

        public int IdEstudiante { get; set; }
        public int? IdAcudiente { get; set; }
        public int TiEstudiante { get; set; }
        public string NombreEstudiante { get; set; }
        public string ApellidoEstudiante { get; set; }
        public string TelefonoEstudiante { get; set; }
        public string DireccionEstudiante { get; set; }
        public byte Edad { get; set; }

        public virtual Acudiente IdAcudienteNavigation { get; set; }
        public virtual ICollection<Grupo> Grupos { get; set; }
    }
}
