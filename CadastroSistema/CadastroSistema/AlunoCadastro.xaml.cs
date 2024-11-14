using System;
using System.IO;
using System.Windows;
using CadastroSistema.Model;

namespace CadastroSistema
{
    public partial class AlunoCadastro : Window
    {
        public AlunoCadastro()
        {
            InitializeComponent();
        }

        private void SalvarAluno_Click(object sender, RoutedEventArgs e)
        {
            var aluno = new Aluno
            {
                Nome = txtNome.Text,
                Cpf = txtCpf.Text,
                DataNascimento = dtpDataNascimento.SelectedDate ?? DateTime.MinValue,
                Telefone = txtTelefone.Text,
                Email = txtEmail.Text
            };

            string linha = $"{aluno.Nome};{aluno.Cpf};{aluno.DataNascimento:dd/MM/yyyy};{aluno.Telefone};{aluno.Email}";
            File.AppendAllText("Alunos.txt", linha + Environment.NewLine);

            MessageBox.Show("Aluno cadastrado com sucesso!");
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtCpf.Clear();
            dtpDataNascimento.SelectedDate = null;
            txtTelefone.Clear();
            txtEmail.Clear();
        }
    }
}
