using VideoExplicativoAspNet.Models;
using System.ComponentModel.DataAnnotations;
using System; 
using System.Linq;
using Microsoft.Extensions.Logging;
using VideoExplicativoAspNet.Data; 

namespace VideoExplicativoAspNet.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            if (!context.Departamentos.Any())
            {
                var departamentos = new Departamento[]
                {
                    new Departamento { Nombre = "IT" },
                    new Departamento { Nombre = "Desarrollo" },
                    new Departamento { Nombre = "Diseño" },
                    new Departamento { Nombre = "Marketing" }
                };
                context.Departamentos.AddRange(departamentos);
                context.SaveChanges();
            }

            if (!context.Empleados.Any())
            {
                var empleados = new Empleado[]
                {
                    new Empleado { Nombre = "Zoila Baca", DepartamentoId = 1 },
                    new Empleado { Nombre = "Aquiles C", DepartamentoId = 2 },
                    new Empleado { Nombre = "Johnny Melas", DepartamentoId = 3 }
                };
                context.Empleados.AddRange(empleados);
                context.SaveChanges();
            }

            if (!context.Gastos.Any())
            {
                var gastos = new Gasto[]
                {
                    new Gasto { Fecha = new DateTime(2024, 11, 16), Descripcion = "UPS", Monto = 60, EmpleadoId = 1, DepartamentoId = 1 },
                    new Gasto { Fecha = new DateTime(2024, 11, 22), Descripcion = "Monitor secundario", Monto = 250, EmpleadoId = 3, DepartamentoId = 2 },
                    new Gasto { Fecha = new DateTime(2024, 11, 23), Descripcion = "Rollup", Monto = 60, EmpleadoId = 3, DepartamentoId = 3 },
                    new Gasto { Fecha = new DateTime(2024, 11, 25), Descripcion = "UPS", Monto = 60, EmpleadoId = 1, DepartamentoId = 1 }
                };
                context.Gastos.AddRange(gastos);
                context.SaveChanges();
            }
        }
    }
}
