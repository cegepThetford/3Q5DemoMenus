using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DemoCommandes
{
    public class QuitterCommande : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            CheckBox permission = parameter as CheckBox;
            return permission.IsChecked.Value;
        }
        public void Execute(object parameter)
        {
            Application.Current.MainWindow.Close();
        }
    }
}
