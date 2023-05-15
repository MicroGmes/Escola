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
    public partial class Turmas : Form
    {
        public Turmas()
        {
            InitializeComponent();
        }

        bool checkdesc = false;
        BindingList<Disciplina> disclst = new();
        string camdisc = "C:/Users/micro/Documents/EscolaSave/DisciplinaSave.txt";
        BindingList<Turma> lst = new();
        string cam = "C:/Users/micro/Documents/EscolaSave/TurmaSave.txt";
        BindingList<Professor> proflist = new();
        string camprof = "C:/Users/micro/Documents/EscolaSave/ProfessoresSave.txt";


        private void Turmas_Load(object sender, EventArgs e)
        {
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
                aux_txt2= File.ReadAllText(camdisc);

            }
            catch (Exception ex) { }
            try
            {
                aux_txt3 = File.ReadAllText(camprof);

            }
            catch (Exception ex) { }
            if (aux_txt.Length > 0)
            {
                lst = JsonSerializer.Deserialize<BindingList<Turma>>(aux_txt);
                dgrid_turmas.DataSource = lst;
            }
            if (aux_txt2.Length > 0)
            {
                disclst = JsonSerializer.Deserialize<BindingList<Disciplina>>(aux_txt2);
                foreach (var item in disclst)
                {
                    txt_disc.Items.Add(item.Nome);
                }
            }
            if(aux_txt3.Length > 0)
            {
                proflist = JsonSerializer.Deserialize<BindingList<Professor>>(aux_txt3);
                foreach (var item in proflist)
                {

                    txt_dt.Items.Add(item.Apelido);
                }
            }
            dgrid_turmas.ClearSelection();
        }

        private void se_Click(object sender, EventArgs e)
        {
            Turma novo = new();
            List<string> lstd = new List<string>();
            lstd.Clear();
            novo.Nome = txt_nome.Text;
            novo.Ano_Escolar = Convert.ToInt32(txt_ano.Value);
            novo.Disciplina = lstd;
            novo.Diretor = txt_dt.Text;


            if (dgrid_turmas.SelectedCells.Count < 1)
            {
                if (txt_nome.Text != "")
                {
                    if (MessageBox.Show("Deseja adicionar as informações inseridas?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach(int item in txt_disc.CheckedIndices)
                        {
                            lstd.Add(txt_disc.Items[item].ToString());
                        }
                        novo.Disciplina = lstd;
                        novo.Nome = txt_nome.Text;
                        novo.Diretor = txt_dt.Text;
                        lst.Add(novo);
                    }
                }
            }
            else
            {
                if (txt_nome.Text != "")
                {
                    if (MessageBox.Show("Deseja editar as informações inseridas?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int num = dgrid_turmas.CurrentCell.RowIndex;
                        lst[num].Ano_Escolar = Convert.ToInt32(txt_ano.Value);
                        lst[num].Diretor = txt_dt.Text;
                        lst[num].Nome = txt_nome.Text;
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
            }

            serial();
            desc_Click(sender, e);

        }

        private void serial()
        {
            string serialaux = JsonSerializer.Serialize(lst);
            File.WriteAllText(cam, serialaux);
            string aux_txt = File.ReadAllText(cam);
            lst = JsonSerializer.Deserialize<BindingList<Turma>>(aux_txt);
            dgrid_turmas.DataSource = lst;
        }

        private void dgrid_disc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int num = dgrid_turmas.CurrentRow.Index;
            if(txt_ano.Value > -1)
            {
                txt_ano.Value = lst[num].Ano_Escolar.Value;
            }
            txt_dt.Text = lst[num].Diretor;
            txt_nome.Text = lst[num].Nome;
        }

        private void desc_Click(object sender, EventArgs e)
        {

            txt_ano.Text = string.Empty;
            txt_disc.ClearSelected();
            txt_dt.Text = string.Empty;
            txt_nome.Text = string.Empty;
            dgrid_turmas.ClearSelection();
            check();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void remover_Click(object sender, EventArgs e)
        {
            if(checkdesc == false)
            {
                if (dgrid_turmas.CurrentRow != null)
                {
                    if (MessageBox.Show("Deseja remover as informações selecionadas?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        lst.RemoveAt(dgrid_turmas.CurrentRow.Index);
                        desc_Click(sender, e);

                    }
                }
            }
            serial();
        }

        public void check()
        {
            checkdesc = true;
        }

        private void search_ano_TextChanged(object sender, EventArgs e)
        {
            var auxsearch = search_ano.Text;
            dgrid_turmas.DataSource = null;
            if (search_ano.Text != "")
            {
                dgrid_turmas.DataSource = lst.Where(x => x.Ano_Escolar.ToString().Contains(auxsearch)).ToList();
            }
            else
            {
                dgrid_turmas.DataSource = lst;
            }
        }
    }
}
