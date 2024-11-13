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
            var cadastroEscola = new EscolaCadastro();
            cadastroEscola.Show();
        }

        private void AbrirListagemEscola_Click(object sender, RoutedEventArgs e)
        {
            var listagemEscola = new EscolaListagem();
            listagemEscola.Show();
        }
    }
}
