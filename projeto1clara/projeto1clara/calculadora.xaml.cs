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
    /// Lógica interna para calculadora.xaml
    /// </summary>
    public partial class calculadora : Window
    {
        public calculadora()
        {
            InitializeComponent();
        }
       

        private void bt_adição_Click(object sender, RoutedEventArgs e)
        {
            double n1 = Convert.ToDouble(txt_n1.Text);
            double n2 = Convert.ToDouble(txt_n2.Text);
            
            double resultado = n1 + n2;
            txt_result.Text = resultado.ToString();
          

        }

        private void bt_divisão_Click(object sender, RoutedEventArgs e)
        {
            double n1 = Convert.ToDouble(txt_n1.Text);
            double n2 = Convert.ToDouble(txt_n2.Text);

            double resultado = n1 / n2;
            txt_result.Text = resultado.ToString();
        }

        private void bt_subtração_Click(object sender, RoutedEventArgs e)
        {
            double n1 = Convert.ToDouble(txt_n1.Text);
            double n2 = Convert.ToDouble(txt_n2.Text);

            double resultado = n1 - n2;
            txt_result.Text = resultado.ToString();
        }

        private void bt__multiplicação_Click(object sender, RoutedEventArgs e)
        {
            double n1 = Convert.ToDouble(txt_n1.Text);
            double n2 = Convert.ToDouble(txt_n2.Text);

            double resultado = n1 * n2;
            txt_result.Text = resultado.ToString();
        }

        private void bt_voltar_Click(object sender, RoutedEventArgs e)
        {
           txt_n1.Clear();
           txt_n2.Clear(); 
           txt_result.Clear();
           txt_n1.Focus();
        }
    }
}
