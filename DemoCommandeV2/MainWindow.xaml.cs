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

namespace DemoCommandeV2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public SaluerCommande SaluerCommande { get; set; }
        public MainWindow()
        {
            SaluerCommande = new SaluerCommande();
            InitializeComponent();
            this.DataContext = this;
        }

        //private void tester(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show($"Bonjour {Prenom} {Nom}");
        //}
    }
}
