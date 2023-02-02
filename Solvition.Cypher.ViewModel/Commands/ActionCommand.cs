using System.Windows.Input;

namespace Solvition.Cypher.ViewModel.Commands
{
    internal class ActionCommand : ICommand
    {
        private readonly Action _action;
        private readonly Func<bool>? _canExecute;

        public ActionCommand(Action action, Func<bool>? canExecute = null)
        {
            _action = action;
            _canExecute = canExecute;
        }

        public bool CanExecute(object? parameter)
        {
            if (_canExecute != null)
            {
                return _canExecute();
            }
            return true;
        }

        public void Execute(object? parameter)
        {
            _action();
        }

        public event EventHandler? CanExecuteChanged;
    }
}
