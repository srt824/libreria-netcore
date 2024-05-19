using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace library_app.Models
{
    public class Book
    {

        public int BookId { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "No olvide cargar el título del libro!")]
        public string Title { get; set; }

        [Display(Name = "Año de publicación")]
        [Required(ErrorMessage = "No olvide cargar el año de publicación del libro!")]
        
        public int Published { get; set; }

        // El atributo Autor desde la perspectiva de la base de datos va a ser Foreign Key 
        // que luego coincidirá con la Primary Key de la tabla Autor
        // Esta es una forma de indicar la FK



        #region ForeingKey

        [Display(Name = "Nombre del Autor")]
        public int AuthorID { get; set; }   // foreing key es necesario el Id del Autor 
                                            // y a su vez el objeto Author

        [Display(Name = "Nombre del Autor")]
        [Required(ErrorMessage = "No olvide seleccionar el autor del libro!")]
        public virtual Author? Author { get; set; } // ? indica que el atributo puede ser opcional

        #endregion


    }
}
