using System; // para DateTime
using System.ComponentModel.DataAnnotations;


namespace VideoExplicativoAspNet.Models
{
    public class Departamento
    {
        [Key]
        public int DepartamentoId { get; set; }
        
        [Required]
        public string Nombre { get; set; }
    }
}
