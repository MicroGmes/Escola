using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Modules
{
    internal class Nota
    {
        public int? Valor { get; set; }
        public DateTime? Data { get; set; }
        public string? Disciplina { get; set; }
        public string? Aluno { get; set; }
        public string? Professor { get; set; }
    }
}
