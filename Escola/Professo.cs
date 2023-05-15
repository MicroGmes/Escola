using Escola.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola
{
    public partial class Professo : Form
    {
        public Professo()
        {
            InitializeComponent();
        }

        bool checkdesc = false;
        BindingList<Professor> lst = new();
        string cam = "C:/Users/micro/Documents/EscolaSave/ProfessoresSave.txt";
        BindingList<Disciplina> disclst = new();
        string cam2 = "C:/Users/micro/Documents/EscolaSave/DisciplinaSave.txt";
        BindingList<Turma> lst3 = new();
        string cam3 = "C:/Users/micro/Documents/EscolaSave/TurmaSave.txt";

        private void Professores_Load(object sender, EventArgs e)
        {
            txt_dnasc.MaxDate = DateTime.Now.Date.AddYears(-18);
            txt_dnasc.MinDate = txt_dnasc.MinDate.AddYears(-100);
            txt_dnasc.Value = txt_dnasc.MaxDate;
            string aux_txt = "";
            string aux_txt2 = "";
            string aux_txt3 = "";
            try
            {
                aux_txt = File.ReadAllText(cam);
            }
            catch (Exception ex) { }
            try
            {
                aux_txt2 = File.ReadAllText(cam2);
            }
            catch (Exception ex) { }
            try
            {
                aux_txt3 = File.ReadAllText(cam3);
            }
            catch (Exception ex) { }
            if (aux_txt.Length > 0)
            {
                lst = JsonSerializer.Deserialize<BindingList<Professor>>(aux_txt);
                dgrid_prof.DataSource = lst;
            }
            if (aux_txt2.Length > 0)
            {
                disclst = JsonSerializer.Deserialize<BindingList<Disciplina>>(aux_txt2);
            }
            if (aux_txt3.Length > 0)
            {
                lst3 = JsonSerializer.Deserialize<BindingList<Turma>>(aux_txt3);
                foreach (var item in lst3)
                {
                    txt_turmas.Items.Add(item.Nome);
                }
            }
            if (aux_txt2.Length > 0)
            {
                disclst = JsonSerializer.Deserialize<BindingList<Disciplina>>(aux_txt2);
                foreach (var item in disclst)
                {
                    txt_disc.Items.Add(item.Nome);
                }
            }
            dgrid_prof.ClearSelection();
            check();
        }


        private void serial()
        {
            string serialaux = JsonSerializer.Serialize(lst);
            File.WriteAllText(cam, serialaux);
            string aux_txt = File.ReadAllText(cam);
            lst = JsonSerializer.Deserialize<BindingList<Professor>>(aux_txt);
            dgrid_prof.DataSource = lst;
        }


        public void desc_Click(object sender, EventArgs e)
        {
            dgrid_prof.ClearSelection();
            txt_ncomp.Text = string.Empty;
            txt_dnasc.Value = txt_dnasc.MaxDate.AddMinutes(-5);
            txt_genero.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_tel.Text = string.Empty;
            txt_end.Text = string.Empty;
            txt_turmas.ClearSelected();
            txt_disc.ClearSelected();
            check();
            txt_emailerr.Text = string.Empty;
        }


        private void dgrid_prof_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int num = dgrid_prof.CurrentRow.Index;
            if (lst[num].Nome_do_meio == "")
            {
                txt_ncomp.Text = lst[num].Primeiro_nome + " " + lst[num].Apelido;
            }
            else
            {
                txt_ncomp.Text = lst[num].Primeiro_nome + lst[num].Nome_do_meio + lst[num].Apelido;
            }
            if (lst[num].Data_de_Nascimento != null)
            {
                txt_dnasc.Value = Convert.ToDateTime(lst[num].Data_de_Nascimento);
            }
            else
            {
                txt_dnasc.Value = txt_dnasc.MaxDate;
            }
            txt_email.Text = lst[num].Email;
            txt_end.Text = lst[num].Morada;
            txt_genero.Text = lst[num].Género;
            txt_tel.Text = lst[num].Telefone;
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            if (txt_email.Text.Contains('@') == false)
            {
                txt_emailerr.Text = "O email está incorreto, por favor tente inseri-lo novamente";
            }
            else
            {
                if (txt_email.Text.Contains('.') == false)
                {
                    txt_emailerr.Text = "O email está incorreto, por favor tente inseri-lo novamente";
                }
                else
                {
                    txt_emailerr.Text = string.Empty;
                }
            }
        }



        private void se_Click(object sender, EventArgs e)
        {
            bool desccheck = false;
            Professor novo = new();
            List<string> lstd = new List<string>();
            lstd.Clear();
            List<string> lstt = new List<string>();
            lstt.Clear();
            novo.Data_de_Nascimento = txt_dnasc.Value;
            novo.Email = txt_email.Text;
            novo.Género = txt_genero.Text;
            novo.Morada = txt_end.Text;
            novo.Telefone = txt_tel.Text;
            string[] nomes = txt_ncomp.Text.Split(' ');

            if (dgrid_prof.SelectedCells.Count < 1)
            {
                if (txt_ncomp.Text != "")
                {
                    if (txt_email.Text.Contains('@'))
                    {
                        if (txt_email.Text.Contains('.'))
                        {
                            if (MessageBox.Show("Deseja adicionar as informações inseridas?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                foreach (int item in txt_disc.CheckedIndices)
                                {
                                    lstd.Add(txt_disc.Items[item].ToString());
                                }
                                foreach (int item in txt_turmas.CheckedIndices)
                                {
                                    lstt.Add(txt_turmas.Items[item].ToString());
                                }
                                if (nomes.Count() >= 2)
                                {
                                    if (nomes.Count() >= 3)
                                    {
                                        novo.Primeiro_nome = nomes[0];
                                        novo.Apelido = nomes[nomes.Count() - 1];
                                        string nm = txt_ncomp.Text.Replace(nomes[0], "");
                                        nm = nm.Replace(nomes[nomes.Count() - 1], "");
                                        novo.Nome_do_meio = nm;
                                    }
                                    else
                                    {
                                        novo.Primeiro_nome = nomes[0];
                                        novo.Apelido = nomes[nomes.Count() - 1];
                                        novo.Nome_do_meio = "";
                                    }
                                }
                                else
                                {
                                    novo.Primeiro_nome = nomes[0];
                                    novo.Apelido = "";
                                    novo.Nome_do_meio = "";
                                }
                                novo.Disciplina = lstd;
                                novo.Turma = lstt;
                                lst.Add(novo);
                            }
                        }
                        else
                        {
                            MessageBox.Show("O Email está incorreto, por favor insire-o novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            desccheck = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("O Email está incorreto, por favor insire-o novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        desccheck = true;
                    }
                }

            }
            else
            {
                if (txt_ncomp.Text != "")
                {
                    if (txt_email.Text.Contains('@'))
                    {
                        if (txt_email.Text.Contains('.'))
                        {
                            if (MessageBox.Show("Deseja editar as informações inseridas?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                int num = dgrid_prof.CurrentCell.RowIndex;
                                if (nomes.Count() >= 2)
                                {
                                    if (nomes.Count() >= 3)
                                    {
                                        lst[num].Primeiro_nome = nomes[0];
                                        lst[num].Apelido = nomes[nomes.Count() - 1];
                                        string nm = txt_ncomp.Text.Replace(nomes[0], "");
                                        nm = nm.Replace(nomes[nomes.Count() - 1], "");
                                        lst[num].Nome_do_meio = nm;
                                    }
                                    else
                                    {
                                        lst[num].Primeiro_nome = nomes[0];
                                        lst[num].Apelido = nomes[nomes.Count() - 1];
                                        lst[num].Nome_do_meio = "";
                                    }
                                }
                                else
                                {
                                    lst[num].Primeiro_nome = nomes[0];
                                    lst[num].Apelido = "";
                                    lst[num].Nome_do_meio = "";
                                }
                                lst[num].Data_de_Nascimento = txt_dnasc.Value;
                                lst[num].Email = txt_email.Text;
                                lst[num].Género = txt_genero.Text;
                                lst[num].Morada = txt_end.Text;
                                lst[num].Telefone = txt_tel.Text;
                                if (lst[num].Turmas != null)
                                {
                                    lst[num].Turmas = null;
                                }

                                foreach (int item in txt_turmas.CheckedIndices)
                                {
                                    if (lst[num].Turmas == null)
                                    {
                                        lst[num].Turmas = txt_turmas.Items[item].ToString();
                                    }
                                    else
                                    {
                                        lst[num].Turmas += ", " + txt_turmas.Items[item].ToString();
                                    }
                                }
                                if (lst[num].Disciplinas != null)
                                {
                                    lst[num].Disciplinas = null;
                                }

                                foreach (int item in txt_disc.CheckedIndices)
                                {
                                    if (lst[num].Disciplinas == null)
                                    {
                                        lst[num].Disciplinas = txt_disc.Items[item].ToString();
                                    }
                                    else
                                    {
                                        lst[num].Disciplinas += ", " + txt_disc.Items[item].ToString();
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("O Email está incorreto, por favor insire-o novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            desccheck = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("O Email está incorreto, por favor insire-o novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        desccheck = true;
                    }
                }
            }
            serial();
            if(desccheck == false)
            {
                desc_Click(sender, e);
            }

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Close();
        }

        private void disciplinaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        public void check()
        {
            checkdesc = true;
        }

        private void search_nome_TextChanged(object sender, EventArgs e)
        {
            var auxsearch = search_nome.Text;
            dgrid_prof.DataSource = null;
            if(search_nome.Text != "")
            {
                dgrid_prof.DataSource = lst.Where(x => x.Apelido.Contains(auxsearch)).ToList();
            }
            else
            {
                dgrid_prof.DataSource = lst;
            }

        }

        private void remover_Click_1(object sender, EventArgs e)
        {
            if(checkdesc == false)
            {
                if (dgrid_prof.CurrentRow != null)
                {
                    if (MessageBox.Show("Deseja remover as informações selecionadas?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        lst.RemoveAt(dgrid_prof.CurrentRow.Index);
                        txt_ncomp.Text = string.Empty;
                        txt_dnasc.Value = txt_dnasc.MaxDate;
                        txt_genero.Text = string.Empty;
                        txt_email.Text = string.Empty;
                        txt_tel.Text = string.Empty;
                        txt_end.Text = string.Empty;
                        txt_turmas.ClearSelected();
                        txt_disc.Text = string.Empty;

                    }
                }
            }
            serial();
            dgrid_prof.ClearSelection();
        }
    }
}