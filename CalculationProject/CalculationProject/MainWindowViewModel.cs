using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CalculationProject
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public ICommand _addCommand { get; set; }

        public MainWindowViewModel()
        {
            _addCommand = new AddCommand(this);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
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
