using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisMed.ViewModels
{
    public class ListarMedicoViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Crm { get; set; } = string.Empty;
    }
}