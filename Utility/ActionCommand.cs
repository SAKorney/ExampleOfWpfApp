using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleWpf.Utility
{
    public class ActionCommand : ICommand
    {
        public ActionCommand(Action<object> command) : this (command, null)
        {    }

        public ActionCommand(Action<object> command, Predicate<object> canExecute)
        {
            _command = command;
            _canExecute = canExecute;
        }

        protected Action<object> _command;
        protected Predicate<object> _canExecute;

        public bool CanExecute(object parameter)
        {
            return _canExecute?.Invoke(parameter) ?? true;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            _command?.Invoke(parameter);
        }
    }
}
