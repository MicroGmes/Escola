using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Modules
{
    internal class Turma
    {
        public string? Nome { get; set; }
        public int? Ano_Escolar { get; set; }
        public string? Diretor { get; set; }
        private List<string> vvv;
        public List<string>? Disciplina
        {
            get
            {
                return vvv;

            }

            set
            {
                List<string> v = value;
                if (v != null)
                {
                    foreach (var item in v)
                    {
                        if (item != null)
                        {
                            if (Disciplinas != null)
                            {
                                Disciplinas += ", " + item;
                            }
                            else
                            {
                                Disciplinas = item;
                            }
                        }
                    }
                }
            }
        }
        
        public string? Disciplinas { get; set; }


    }
}
