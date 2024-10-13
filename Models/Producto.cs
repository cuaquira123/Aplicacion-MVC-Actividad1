using System.ComponentModel.DataAnnotations;

namespace mvcProgramacionWebII.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="El nombre es Obligatorio")]
        [Display(Name = "Nombre del producto")]
        public string? Name { get; set; }
        

        [Required(ErrorMessage = "La descripcion es obligatoria")]
        public string? Description { get; set; }
    }
}
