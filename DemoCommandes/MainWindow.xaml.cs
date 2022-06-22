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

namespace DemoCommandes
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public QuitterCommande QuitterCommande { get; set; }
        public MainWindow()
        {
            QuitterCommande = new QuitterCommande();
            InitializeComponent();
            this.DataContext = this;
        }

        //private void Quitter_Executed(object sender, ExecutedRoutedEventArgs e)
        //{
        //    Application.Current.MainWindow.Close();
        //}

        //private void Quitter_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        //{
        //    e.CanExecute = chkPermission.IsChecked.Value;
        //}
    }
}
