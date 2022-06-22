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

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ActiverGras_Checked(object sender, RoutedEventArgs e)
        {
            if (this.IsInitialized)
                tbMessage.FontWeight = FontWeights.Bold;
        }

        private void DesactiverGras_Unchecked(object sender, RoutedEventArgs e)
        {
            tbMessage.FontWeight = FontWeights.Normal;
        }

        private void ActiverItalique_Checked(object sender, RoutedEventArgs e)
        {
            tbMessage.FontStyle = FontStyles.Italic;
        }

        private void DesactiverItalique_Unchecked(object sender, RoutedEventArgs e)
        {
            tbMessage.FontStyle = FontStyles.Normal;
        }

        private void AugmenterTaille_Click(object sender, RoutedEventArgs e)
        {
            tbMessage.FontSize += 2;
        }

        private void DiminuerTaille_Click(object sender, RoutedEventArgs e)
        {
            tbMessage.FontSize -= 2;
        }
    }
}
