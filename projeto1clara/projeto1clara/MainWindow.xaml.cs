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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace projeto1clara
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string nome=txt_nomeUsu.Text;
            string senha = txt_senhaUsu.Password.ToString();

            if(senha=="123"&& nome=="maria linda")
             {
                MessageBox.Show("SUCESSO AO ACESSAR CONTA.", "informação", MessageBoxButton.OK, MessageBoxImage.Information);
               calculadora calculadora = new calculadora();
                calculadora.Show();

            }
            else
            {
                MessageBox.Show("tente novamente, senha ou usuario errados", "ERRO", MessageBoxButton.OK, MessageBoxImage.Error);
                txt_senhaUsu.Clear();
                txt_nomeUsu.Clear();
                txt_nomeUsu.Focus();
           }
            

        }

        private void bt_cancelarUsu_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void bt_cadastrar_Click(object sender, RoutedEventArgs e)
        {
            cadastrar_cli cadastrar_Cli = new cadastrar_cli();
            cadastrar_Cli.Show();
        }
    }
}
