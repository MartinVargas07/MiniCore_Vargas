using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System;               // Para DateTime
using System.Linq;         // Para .Where, .Select, etc.
using VideoExplicativoAspNet.Data;    // Para AppDbContext
using VideoExplicativoAspNet.Models;  // Para Gasto, Empleado, etc.


namespace VideoExplicativoAspNet.Controllers
{
    public class GastosController : Controller
    {
        private readonly AppDbContext _context;

        public GastosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Gastos/Index
        public IActionResult Index(DateTime? fechaIni, DateTime? fechaFin)
        {
            // Si no hay fechas, poner valores por defecto
            fechaIni ??= new DateTime(2024, 1, 1);
            fechaFin ??= DateTime.Now.AddYears(1); // ejemplo

            // Filtrar la lista de gastos por rango de fecha
            var gastosFiltrados = _context.Gastos
                .Include(g => g.Departamento)
                .Where(g => g.Fecha >= fechaIni && g.Fecha <= fechaFin)
                .ToList();

            // Calcular total por departamento
            // Agrupar por Departamento y sumar Monto
            var totalesPorDepartamento = gastosFiltrados
                .GroupBy(g => g.Departamento != null ? g.Departamento.Nombre : "SinDept")
                .Select(grp => new 
                {
                    Departamento = grp.Key,
                    Total = grp.Sum(x => x.Monto)
                }).ToList();

            // Enviar los datos a la vista
            ViewBag.FechaIni = fechaIni.Value.ToString("yyyy-MM-dd");
            ViewBag.FechaFin = fechaFin.Value.ToString("yyyy-MM-dd");
            ViewBag.TotalesPorDepartamento = totalesPorDepartamento;

            return View(gastosFiltrados);
        }
    }
}
