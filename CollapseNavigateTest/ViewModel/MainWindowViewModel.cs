using CollapseNavigateTest.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CollapseNavigateTest.ViewModel
{
    class MainWindowViewModel : BaseViewModel
    {
        private BaseViewModel _selectedViewModel = new DashBoardViewModel();

        public BaseViewModel SelectedViewModel
        {
            get { return _selectedViewModel; }
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }

        public ICommand SelectViewCommand
        {
            get;
            set;
        }

        public MainWindowViewModel()
        {
            SelectViewCommand = new SelectViewCommand(this);
        }
    }
}
