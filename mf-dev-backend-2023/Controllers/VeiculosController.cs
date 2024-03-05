using mf_dev_backend_2023.Models;
using Microsoft.AspNetCore.Mvc;


namespace mf_dev_backend_2023.Controllers
{

    public class VeiculosController : Controller
    {
        private readonly AppDbContext _context;

        public VeiculosController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Veiculos.ToListAsync();

            return View(dados);
        }
    }
}
