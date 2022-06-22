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
            this.changerTaille(+8);
        }

        private void DiminuerTaille_Click(object sender, RoutedEventArgs e)
        {
            this.changerTaille(-8);
            //rtbMessage.FontSize -= 2;
        }
        private void changerTaille(int quantite)
        {
            if (rtbMessage.Selection != null)
            {
                if (rtbMessage.Selection.IsEmpty)
                {
                    if (rtbMessage.Selection.Start.Paragraph == null)
                    {
                        Paragraph p = new Paragraph();
                        p.FontSize = quantite;
                        rtbMessage.Document.Blocks.Add(p);
                    }
                    else
                    {
                        TextPointer posCurseur = rtbMessage.CaretPosition;
                        Block blocCourant = rtbMessage.Document.Blocks.Where
                            (x => x.ContentStart.CompareTo(posCurseur) == -1 && 
                                  x.ContentEnd.CompareTo(posCurseur) == 1).FirstOrDefault();
                        if (blocCourant != null)
                        {
                            Paragraph paragrapheCourant = blocCourant as Paragraph;
                            Run newRun = new Run();
                            newRun.FontSize = quantite;
                            paragrapheCourant.Inlines.Add(newRun);
                            rtbMessage.CaretPosition = newRun.ElementStart;
                        }
                    }
                }
                else 
                {
                    TextRange sequence = new TextRange(rtbMessage.Selection.Start, rtbMessage.Selection.End);
                    var tailleCourante = sequence.GetPropertyValue(RichTextBox.FontSizeProperty);
                    if(tailleCourante != DependencyProperty.UnsetValue)
                        sequence.ApplyPropertyValue(TextElement.FontSizeProperty,(double) tailleCourante + quantite);
                }
            }
        }

        private void rtbMessage_SelectionChanged(object sender, RoutedEventArgs e)
        {
            object temp = rtbMessage.Selection.GetPropertyValue(Inline.FontWeightProperty);
            mniGras.IsChecked = (temp != null) && (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontWeights.Bold));
            temp = rtbMessage.Selection.GetPropertyValue(Inline.FontStyleProperty);
            mniItalique.IsChecked = (temp != null) && (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontStyles.Italic));
        }
    }
}
