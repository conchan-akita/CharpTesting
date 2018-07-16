using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CalculationProject
{
    public class AddCommand : ICommand
    {
        public MainWindowViewModel _mainWindowViewModel;
        public AddCommand(MainWindowViewModel mainWindowViewModel)
        {
            _mainWindowViewModel = mainWindowViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            // TODO: Impl.
            return true;
            //throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            _mainWindowViewModel.Z = _mainWindowViewModel.X + _mainWindowViewModel.Y;
            _mainWindowViewModel.OnPropertyChanged("Z");
            //throw new NotImplementedException();
        }
    }
}
