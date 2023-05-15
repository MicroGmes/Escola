using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Modules
{
    public class Professor
    {
        public string? Primeiro_nome { get; set; }
        public string? Nome_do_meio { get; set; }
        public string? Apelido { get; set; }
        public int? Idade { get; set; }
        public string? Género { get; set; }
        public string? Email { get; set; }


        public string? Morada { get; set; }
        public string? Telefone { get; set; }
        private DateTime? date;
        public DateTime? Data_de_Nascimento
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
                if(date != null)
                {
                    TimeSpan tempoaux = (DateTime.Now - date.Value.Date);
                    DateTime tempoaux2 = new DateTime(tempoaux.Ticks);
                    int tempoaux3 = tempoaux2.Year;
                    Idade = tempoaux3 - 1;
                }


            }
        }
        private List<string> vvv { get; set; }
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
        public List<string>? Turma
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
                            if (Turmas != null)
                            {
                                Turmas += ", " + item;
                            }
                            else
                            {
                                Turmas = item;
                            }
                        }
                    }
                }
            }
        }
        public string? Disciplinas { get; set; }
        public string? Turmas { get; set; }
    }
}
