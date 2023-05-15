using Escola.Modules;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Escola
{
    public partial class Alunos : Form
    {
        bool checkdesc = false;
        BindingList<Estudante> lst = new();
        Estudante novo = new();
        string cam = "C:/Users/micro/Documents/EscolaSave/AlunosSave.txt";
        BindingList<Turma> lst3 = new();
        string cam3 = "C:/Users/micro/Documents/EscolaSave/TurmaSave.txt";
        public Alunos()
        {
            InitializeComponent();
        }
        private void Alunos_Load(object sender, EventArgs e)
        {
            string aux_txt = "";
            string aux_txt3 = "";
            try
            {
                aux_txt = File.ReadAllText(cam);
            }
            catch (Exception ex) { }
            try
            {
                aux_txt3 = File.ReadAllText(cam3);
            }
            catch (Exception ex) { }
            if (aux_txt.Length > 0)
            {
                lst = JsonSerializer.Deserialize<BindingList<Estudante>>(aux_txt);
                dgrid_alunos.DataSource = lst;
            }
            if (aux_txt3.Length > 0)
            {
                lst3 = JsonSerializer.Deserialize<BindingList<Turma>>(aux_txt3);
            }
            foreach (var item in lst3)
            {
                txt_turma.Items.Add(item.Nome);
            }
            dgrid_alunos.ClearSelection();
            txt_dnasc.MaxDate = DateTime.Now.Date.AddYears(-1);
            txt_dnasc.Value = txt_dnasc.MaxDate;
            dgrid_alunos.ClearSelection();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            bool desccheck = false;
            novo.Data_de_Nascimento = txt_dnasc.Value;
            novo.Turma = txt_turma.Text;
            novo.Email = txt_email.Text;
            novo.Género = txt_genero.Text;
            novo.Morada = txt_end.Text;
            novo.Telefone = txt_tel.Text;
            string[] nomes = txt_ncomp.Text.Split(' ');

            if (dgrid_alunos.SelectedCells.Count < 1)
            {
                if (txt_ncomp.Text != "")
                {
                    if (txt_email.Text.Contains('@'))
                    {
                        if (txt_email.Text.Contains('.'))
                        {
                            if (MessageBox.Show("Deseja adicionar as informações inseridas?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
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
                        if(txt_email.Text.Contains('.'))
                        {
                            if (MessageBox.Show("Deseja editar as informações inseridas?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                int num = dgrid_alunos.CurrentCell.RowIndex;
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
                                lst[num].Turma = txt_turma.Text;
                                lst[num].Email = txt_email.Text;
                                lst[num].Género = txt_genero.Text;
                                lst[num].Morada = txt_end.Text;
                                lst[num].Telefone = txt_tel.Text;
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
            if (desccheck == false)
            {
                desc_Click(sender, e);
            }
        }


        private void serial()
        {
            string serialaux = JsonSerializer.Serialize(lst);
            File.WriteAllText(cam, serialaux);
            string aux_txt = File.ReadAllText(cam);
            lst = JsonSerializer.Deserialize<BindingList<Estudante>>(aux_txt);
            dgrid_alunos.DataSource = lst;
        }
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void desc_Click(object sender, EventArgs e)
        {
            dgrid_alunos.ClearSelection();
            txt_ncomp.Text = string.Empty;
            txt_dnasc.Value = txt_dnasc.MaxDate.AddMinutes(-5);
            txt_genero.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_tel.Text = string.Empty;
            txt_end.Text = string.Empty;
            txt_turma.Text = string.Empty;
        }

        public void remover_Click(object sender, EventArgs e)
        {
            if(checkdesc == false)
            {
                if (dgrid_alunos.CurrentRow != null)
                {
                    if (MessageBox.Show("Deseja remover as informações selecionadas?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        lst.RemoveAt(dgrid_alunos.CurrentRow.Index);
                        txt_ncomp.Text = string.Empty;
                        txt_dnasc.Value = txt_dnasc.MaxDate;
                        txt_genero.Text = string.Empty;
                        txt_email.Text = string.Empty;
                        txt_tel.Text = string.Empty;
                        txt_end.Text = string.Empty;
                        txt_turma.Text = string.Empty;

                    }
                }
            }
            dgrid_alunos.ClearSelection();
            serial();
        }

        private void txt_ncomp_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgrid_alunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int num = dgrid_alunos.CurrentRow.Index;
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
            txt_turma.Text = lst[num].Turma;

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            if(txt_email.Text.Contains('@') == false)
            {
                txt_emailerr.Text = "O email está incorreto, por favor tente inseri-lo novamente";
            }
            else
            {
                if(txt_email.Text.Contains('.') == false)
                {
                    txt_emailerr.Text = "O email está incorreto, por favor tente inseri-lo novamente";
                }
                else
                {
                    txt_emailerr.Text = string.Empty;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void search_nome_TextChanged(object sender, EventArgs e)
        {
            var auxsearch = search_nome.Text;
            dgrid_alunos.DataSource = null;
            if (search_nome.Text != "")
            {
                dgrid_alunos.DataSource = lst.Where(x => x.Turma.Contains(auxsearch)).ToList();
            }
            else
            {
                dgrid_alunos.DataSource = lst;
            }
        }
    }
}