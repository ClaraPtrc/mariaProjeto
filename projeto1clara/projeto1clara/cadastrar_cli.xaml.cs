using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace projeto1clara
{
    /// <summary>
    /// Lógica interna para cadastrar_cli.xaml
    /// </summary>
    public partial class cadastrar_cli : Window
    {
        public cadastrar_cli()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void bt_cadastrar_Click(object sender, RoutedEventArgs e)
        {
            string nome = txt_nome.Text;
            string senha = pw_usu.Password.ToString();
            string senha2 = pw_usu2.Password.ToString();

            if(senha==senha2)
              {
                MessageBox.Show("SUCESSO AO CRIAR CONTA.", "informação", MessageBoxButton.OK, MessageBoxImage.Information);
                calculadora calculadora = new calculadora();
                calculadora.Show();
            }
            else
            {
                MessageBox.Show("ERRO AO CRIAR CONTA.", "ERRO", MessageBoxButton.OK, MessageBoxImage.Error);
                pw_usu.Clear();
                pw_usu2.Clear();
                pw_usu.Focus();
            }
        }
    }
}
