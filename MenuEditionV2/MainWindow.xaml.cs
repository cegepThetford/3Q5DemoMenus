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

        private void AugmenterTaille_Click(object sender, RoutedEventArgs e)
        {
            tbMessage.FontSize += 2;
        }

        private void DiminuerTaille_Click(object sender, RoutedEventArgs e)
        {
            tbMessage.FontSize -= 2;
        }

        private void BasculerGras_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            tbMessage.FontWeight = tbMessage.FontWeight == FontWeights.Bold ? FontWeights.Normal : FontWeights.Bold;
            miGras.IsChecked = tbMessage.FontWeight == FontWeights.Bold;
        }

        private void BasculerItalique_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            tbMessage.FontStyle = tbMessage.FontStyle == FontStyles.Italic ? FontStyles.Normal : FontStyles.Italic;
            tgbItalique.IsChecked = tbMessage.FontStyle == FontStyles.Italic;
        }
    }
}
