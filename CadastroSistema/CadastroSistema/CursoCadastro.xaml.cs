using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using CadastroSistema.Model;

namespace CadastroSistema
{
    public partial class CursoCadastro : Window
    {
        public CursoCadastro()
        {
            InitializeComponent();
        }

        private void SalvarCurso_Click(object sender, RoutedEventArgs e)
        {
            var curso = new Curso
            {
                Nome = txtNome.Text,
                Descricao = txtDescricao.Text,
                Coordenador = txtCoordenador.Text,
                Status = (cmbStatus.SelectedItem as ComboBoxItem)?.Content.ToString()
            };

            string linha = $"{curso.Nome};{curso.Descricao};{curso.Coordenador};{curso.Status}";
            File.AppendAllText("Cursos.txt", linha + Environment.NewLine);

            MessageBox.Show("Curso cadastrado com sucesso!");
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            txtCoordenador.Clear();
            cmbStatus.SelectedIndex = -1;
        }
    }
}
