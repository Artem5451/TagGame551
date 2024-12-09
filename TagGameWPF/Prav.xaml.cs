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

namespace TagGameWPF
{
    /// <summary>
    /// Логика взаимодействия для Prav.xaml
    /// </summary>
    public partial class Prav : Window
    {
        public Prav()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new Menu();
            newForm.Show();
            this.Close();
        }
    }
}
