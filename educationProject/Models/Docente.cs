using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace educationProject.Models
{
    public partial class Docente
    {
        public Docente()
        {
            Grupos = new HashSet<Grupo>();
        }

        [Key]
        public int IdDocente { get; set; }

        [Required(ErrorMessage ="Este campo es requerido")]
        [DisplayName("Cedula")]
        public int CedulaDocente { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [DisplayName("Nombre Docente ")]
        public string NombreDocente { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [DisplayName("Apellido Docente")]
        public string ApellidoDocente { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [DisplayName("Telefono Docente ")]
        public string TelefonoDocente { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [DisplayName("Direccion Docente ")]
        public string DireccionDocente { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [DisplayName("Nivel Educativo ")]
        public string NivelEducativo { get; set; }

        public virtual ICollection<Grupo> Grupos { get; set; }
    }
}
