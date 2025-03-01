using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisMed.Models.Entities
{
    public class Medico
    {
        public int Id { get; set; }
        public string Crm { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
    } 
}