using System;
using System.Collections.Generic;

#nullable disable

namespace educationProject.Models
{
    public partial class Grupo
    {
        public int IdGrupo { get; set; }
        public int IdEstudiante { get; set; }
        public string NombreGrupo { get; set; }
        public int IdDocente { get; set; }

        public virtual Docente IdDocenteNavigation { get; set; }
        public virtual Estudiante IdEstudianteNavigation { get; set; }
    }
}
