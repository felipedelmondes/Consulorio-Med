using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SisMed.Models.Contexts;
using SisMed.ViewModels;

namespace SisMed.Controllers
{
    
    public class MedicosController : Controller
    {        
        private readonly SisMedContext _context;

        public MedicosController(SisMedContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var medicos = _context.Medicos.Select(x => new ListarMedicoViewModel{
                Id = x.Id,
                Crm = x.Crm,
                Nome = x.Nome
            });


            return View(medicos);
        }

    }
}