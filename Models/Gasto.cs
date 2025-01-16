using System; // para DateTime
using System.ComponentModel.DataAnnotations;

namespace VideoExplicativoAspNet.Models
{
    public class Gasto
    {
        [Key]
        public int GastoId { get; set; }
        
        [Required]
        public DateTime Fecha { get; set; }
        
        public string? Descripcion { get; set; }
        
        [Required]
        public decimal Monto { get; set; }

        // Relaciones
        public int? EmpleadoId { get; set; }
        public Empleado? Empleado { get; set; }
        
        public int? DepartamentoId { get; set; }
        public Departamento? Departamento { get; set; }
    }
}
