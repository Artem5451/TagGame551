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
  
    public partial class Menu : Window
    {
        public Menu() : this(null) { }
        private MainWindow mainWindow;

        public Menu(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;   
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new MainWindow(); 
            newForm.Show(); 
            this.Close();
        }
       
       



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            mainWindow.ModelWinComplite();
        }
        private void OpenMenu()
        {
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var newForm = new Prav();
            newForm.Show();
            this.Close();
        }
    }
}
