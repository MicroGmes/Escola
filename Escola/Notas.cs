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
    public partial class Notas : Form
    {
        bool checkdesc = false;
        BindingList<Nota> lst = new BindingList<Nota>();
        string cam = "C:/Users/micro/Documents/EscolaSave/NotasSave.txt";
        BindingList<Professor> lst2 = new();
        string cam2 = "C:/Users/micro/Documents/EscolaSave/ProfessoresSave.txt";
        BindingList<Disciplina> lst3 = new();
        string cam3 = "C:/Users/micro/Documents/EscolaSave/DisciplinaSave.txt";
        BindingList<Estudante> lst4 = new();
        string cam4 = "C:/Users/micro/Documents/EscolaSave/AlunosSave.txt";
        public Notas()
        {
            InitializeComponent();
        }
        private void Notas_Load(object sender, EventArgs e)
        {
            txt_data.MaxDate = DateTime.Now.Date.AddYears(-18);
            txt_data.MinDate = txt_data.MinDate.AddYears(-100);
            txt_data.Value = txt_data.MaxDate;
            string aux_txt = "";
            string aux_txt2 = "";
            string aux_txt3 = "";
            string aux_txt4 = "";
            try
            {
                aux_txt = File.ReadAllText(cam);
            }
            catch (Exception ex) { }
            try
            {
                aux_txt2 = File.ReadAllText(cam2);
            }catch (Exception ex) { }
            try
            {
                aux_txt3 = File.ReadAllText(cam3);
            }
            catch (Exception ex) { }
            try
            {
                aux_txt4 = File.ReadAllText(cam4);
            }
            catch (Exception ex) { }
            if (aux_txt.Length > 0)
            {
                lst = JsonSerializer.Deserialize<BindingList<Nota>>(aux_txt);
                dgrid_notas.DataSource = lst;
            }
            if (aux_txt2.Length > 0)
            {
                lst2 = JsonSerializer.Deserialize<BindingList<Professor>>(aux_txt2);
                foreach (var item in lst2)
                {
                    txt_prof.Items.Add(item.Apelido);
                }
            }
            if (aux_txt3.Length > 0)
            {
                lst3 = JsonSerializer.Deserialize<BindingList<Disciplina>>(aux_txt3);
                foreach (var item in lst3)
                {
                    txt_disc.Items.Add(item.Nome);
                }
            }
            if (aux_txt4.Length > 0)
            {
                string nome;
                lst4 = JsonSerializer.Deserialize<BindingList<Estudante>>(aux_txt4);
                foreach (var item in lst4)
                {
                    nome = item.Primeiro_nome + ' ' + item.Apelido;
                    txt_aluno.Items.Add(nome);
                }
            }
            dgrid_notas.ClearSelection();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void se_Click(object sender, EventArgs e)
        {
            Nota novo = new();
            novo.Aluno = txt_aluno.Text;
            novo.Professor = txt_prof.Text;
            novo.Disciplina = txt_disc.Text;
            novo.Data = txt_data.Value;
            novo.Valor = Convert.ToInt32(txt_valor.Value);
            if (dgrid_notas.SelectedCells.Count < 1)
            {
                if (txt_aluno.Text != "")
                {
                    if (MessageBox.Show("Deseja adicionar as informações inseridas?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        lst.Add(novo);
                    }
                }
            }
            else
            {
                if (txt_aluno.Text != "")
                {
                    if (MessageBox.Show("Deseja editar as informações inseridas?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int num = dgrid_notas.CurrentCell.RowIndex;
                        lst[num].Valor = Convert.ToInt32(txt_valor.Value);
                        lst[num].Aluno = txt_aluno.Text;
                        lst[num].Disciplina = txt_disc.Text;
                        lst[num].Data = txt_data.Value;
                        lst[num].Professor = txt_prof.Text;

                    }
                }
            }

            serial();
            desc_Click(sender, e);

        }



        public void check()
        {
            checkdesc = true;
        }

        private void desc_Click(object sender, EventArgs e)
        {
            txt_aluno.Text = string.Empty;
            txt_data.Value = txt_data.MaxDate;
            txt_disc.Text = string.Empty;
            txt_prof.Text = string.Empty;
            txt_valor.Value = txt_valor.Minimum;
            dgrid_notas.ClearSelection();
            check();
        }

        public void serial()
        {
            string serialaux = JsonSerializer.Serialize(lst);
            File.WriteAllText(cam, serialaux);
            string aux_txt = File.ReadAllText(cam);
            lst = JsonSerializer.Deserialize<BindingList<Nota>>(aux_txt);
            dgrid_notas.DataSource = lst;
        }

        private void remover_Click(object sender, EventArgs e)
        {
            if (checkdesc == false)
            {
                if (dgrid_notas.CurrentRow != null)
                {
                    if (MessageBox.Show("Deseja remover as informações selecionadas?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        lst.RemoveAt(dgrid_notas.CurrentRow.Index);
                        txt_aluno.Text = string.Empty;
                        txt_data.Value = txt_data.MaxDate;
                        txt_disc.Text = string.Empty;
                        txt_prof.Text = string.Empty;
                        txt_valor.Text = string.Empty;

                    }
                }
            }
            serial();
            dgrid_notas.ClearSelection();
        }

        private void dgrid_notas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int num = dgrid_notas.CurrentRow.Index;
            txt_valor.Value = Convert.ToInt32(lst[num].Valor);
            txt_aluno.Text = lst[num].Aluno;
            txt_disc.Text = lst[num].Disciplina;
            txt_prof.Text = lst[num].Professor;
            txt_data.Value = lst[num].Data.Value;
        }

        private void search_nome_TextChanged(object sender, EventArgs e)
        {
            var auxsearch = search_nome.Text;
            dgrid_notas.DataSource = null;
            if (search_nome.Text != "")
            {
                dgrid_notas.DataSource = lst.Where(x => x.Aluno.Contains(auxsearch)).ToList();
            }
            else
            {
                dgrid_notas.DataSource = lst;
            }
        }
    }
}
