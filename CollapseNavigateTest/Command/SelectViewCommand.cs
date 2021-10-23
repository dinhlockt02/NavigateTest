using CollapseNavigateTest.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CollapseNavigateTest.Command
{
    class SelectViewCommand : ICommand
    {
        private MainWindowViewModel mainWindowViewModel;
        public SelectViewCommand(MainWindowViewModel mainWindowViewModel)
        {
            this.mainWindowViewModel = mainWindowViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Console.WriteLine(parameter.ToString());
        }
    }
}
