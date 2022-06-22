using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DemoCommandeV2
{
    public class SaluerCommande : ICommand
    {
        public void Execute(object parameter)
        {
            MainWindow source = parameter as MainWindow;
            MessageBox.Show($"Bonjour {source.Prenom} {source.Nom}");
        }

        public bool CanExecute(object parameter)
        {
            MainWindow source = parameter as MainWindow;
            return source != null &&
                   !string.IsNullOrWhiteSpace(source.Prenom) &&
                   !string.IsNullOrWhiteSpace(source.Nom);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
