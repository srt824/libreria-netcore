using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace library_app.Models
{
    public class Author
    {
        public int AuthorID { get; set; }

        [Display(Name = "Nombre del Autor")]
        [Required(ErrorMessage = "No olvide cargar nombre del autor!")]
        public string Name { get; set; }

        [Display(Name = "Apellido del Autor")]
        [Required(ErrorMessage = "No olvide cargar apellido del autor!")]
        public string LastName { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        [Required(ErrorMessage = "No olvide cargar la fecha de nacimiento del autor!")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Acerca del Autor...")]
        public string? Comment { get; set; }

    }
}
