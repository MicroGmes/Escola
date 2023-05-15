namespace Escola
{
    public partial class Menu : Form
    {




        public Menu()
        {
            InitializeComponent();
        }

        private void Alunos_Click_1(object sender, EventArgs e)
        {
            Alunos alunos = new Alunos();
            alunos.Show();
        }

        private void Professores_Click(object sender, EventArgs e)
        {
            Professo prof = new();
            prof.Show();
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Disciplinas disc = new Disciplinas();
            disc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Notas n = new Notas();
            n.Show();
        }

        private void Turmas_Click(object sender, EventArgs e)
        {
            Turmas t = new Turmas();
            t.Show();
        }
    }
}