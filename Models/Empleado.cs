using System; // para DateTime
using System.ComponentModel.DataAnnotations;

namespace VideoExplicativoAspNet.Models
{
    public class Empleado
    {
        [Key]
        public int EmpleadoId { get; set; }
        
        [Required]
        public string Nombre { get; set; }
        
        // Relación con Departamento (opcional, un empleado puede estar en uno)
        public int? DepartamentoId { get; set; }
        public Departamento? Departamento { get; set; }
    }
}
