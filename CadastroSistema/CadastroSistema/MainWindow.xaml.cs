using System.Windows;

namespace CadastroSistema
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AbrirCadastroEscola_Click(object sender, RoutedEventArgs e)
        {
            var escolaCadastro = new EscolaCadastro();
            escolaCadastro.Show();
        }

        private void AbrirListagemEscola_Click(object sender, RoutedEventArgs e)
        {
            var escolaListagem = new EscolaListagem();
            escolaListagem.Show();
        }

        private void AbrirCadastroCurso_Click(object sender, RoutedEventArgs e)
        {
            var cursoCadastro = new CursoCadastro();
            cursoCadastro.Show();
        }

        private void AbrirListagemCurso_Click(object sender, RoutedEventArgs e)
        {
            var cursoListagem = new CursoListagem();
            cursoListagem.Show();
        }

        private void AbrirCadastroAluno_Click(object sender, RoutedEventArgs e)
        {
            var alunoCadastro = new AlunoCadastro();
            alunoCadastro.Show();
        }

        private void AbrirListagemAluno_Click(object sender, RoutedEventArgs e)
        {
            var alunoListagem = new AlunoListagem();
            alunoListagem.Show();
        }
    }
}
