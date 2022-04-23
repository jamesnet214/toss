using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TossBinding.Local.Foundation
{
    public class HeartCommand<T> : ICommand
    {
        private Action<T> _execute;

        public event EventHandler CanExecuteChanged;

        public HeartCommand(Action<T> execute)
        {
            _execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute.Invoke((T)parameter);
        }
    }
}
