using Escola.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola
{
    public partial class Disciplinas : Form
    {
        public Disciplinas()
        {
            InitializeComponent();
        }
        bool checkdesc = false;
        BindingList<Disciplina> lst = new();
        Disciplina novo = new();
        string cam = "C:/Users/micro/Documents/EscolaSave/DisciplinaSave.txt";

        private void button1_Click(object sender, EventArgs e)
        {
            novo.Nome = txt_disc.Text;

            if (dgrid_disc.SelectedCells.Count < 1)
            {
                if (txt_disc.Text != "")
                {
                    if (MessageBox.Show("Deseja adicionar as informações inseridas?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        novo.Nome = txt_disc.Text;
                        lst.Add(novo);
                    }
                }
            }
            else
            {
                if (txt_disc.Text != "")
                {
                    if (MessageBox.Show("Deseja editar as informações inseridas?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int num = dgrid_disc.CurrentCell.RowIndex;
                        lst[num].Nome = txt_disc.Text;
                    }
                }
            }
            txt_disc.Text = string.Empty;
            serial();
            dgrid_disc.ClearSelection();
        }

        private void Disciplinas_Load(object sender, EventArgs e)
        {
            string aux_txt = "";
            try
            {
                aux_txt = File.ReadAllText(cam);
            }
            catch (Exception ex) { }
            if (aux_txt.Length > 0)
            {
                lst = JsonSerializer.Deserialize<BindingList<Disciplina>>(aux_txt);
                dgrid_disc.DataSource = lst;
            }
            dgrid_disc.ClearSelection();
        }
        private void serial()
        {
            string serialaux = JsonSerializer.Serialize(lst);
            File.WriteAllText(cam, serialaux);
            string aux_txt = File.ReadAllText(cam);
            lst = JsonSerializer.Deserialize<BindingList<Disciplina>>(aux_txt);
            dgrid_disc.DataSource = lst;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            dgrid_disc.ClearSelection();
            txt_disc.Text = string.Empty;
            check();
        }

        private void remover_Click(object sender, EventArgs e)
        {
            if (dgrid_disc.CurrentRow != null)
            {
                if (MessageBox.Show("Deseja remover as informações selecionadas?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lst.RemoveAt(dgrid_disc.CurrentRow.Index);
                    txt_disc.Text = string.Empty;
                }
            }
            serial();
        }

        private void dgrid_disc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int num = dgrid_disc.CurrentRow.Index;
            txt_disc.Text = lst[num].Nome;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void remover_Click_1(object sender, EventArgs e)
        {
            if(checkdesc == false)
            {
                if (dgrid_disc.CurrentRow != null)
                {
                    if (MessageBox.Show("Deseja remover as informações selecionadas?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        lst.RemoveAt(dgrid_disc.CurrentRow.Index);
                        txt_disc.Text = string.Empty;

                    }
                }
            }
            serial();
            dgrid_disc.ClearSelection();
        }
        public void check()
        {
            checkdesc = true;
        }
    }
}
