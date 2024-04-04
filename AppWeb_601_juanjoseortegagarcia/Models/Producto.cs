using System.ComponentModel.DataAnnotations;
namespace AppWeb_601_juanjoseortegagarcia.Models
{
    public class Producto
    {
        [Key]
        public int id { get; set; }
        [Required (ErrorMessage ="la descripcion es obliogatoria")]
        public string Description { get; set; }
        [Required (ErrorMessage ="el preccio es obligatorio")]
        public int precio { get; set; }
        public int cantidad { get; set; }
    }

}
