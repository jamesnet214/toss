using System;
using System.Windows.Input;

namespace Toss.Local.Command
{
    internal class TossCommand<T> : ICommand
    {
        private Action<T> execute;

        public event EventHandler? CanExecuteChanged;

        public TossCommand(Action<T> _execute)
        {
            execute = _execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            execute?.Invoke((T)parameter);
        }
    }
}
