using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CryptoCoin.Caliburn.Extensions
{
    public class RelayExtension : ICommand
    {
        protected Action Action { get; set; }
        protected Task _tAction { get; set; }
        protected Action<string> sAction { get; set; }
        protected Action<bool> bAction { get; set; }
        protected Action<int> iAction { get; set; }
        protected Func<int, Task> itAction { get; set; }
        protected Task itActionWithoutReturn { get; set; }

        protected Func<int, bool> boolAction { get; set; }
        protected Func<bool> CanActionExecute { get; set; }

        public RelayExtension(Action _Action) : this(_Action, null)
        {
            Action = _Action;
        }

        public RelayExtension(Action _Action, Func<bool> _CanActionExecute)
        {
            if (_Action == null)
                throw new ArgumentNullException("Action invoked cannot be null. Please review your parameters");
            if (_CanActionExecute == null)
                throw new ArgumentNullException("Can Action invoked cannot be null. Please review your parameters");

            Action = _Action;
            CanActionExecute = _CanActionExecute;
        }
        public RelayExtension(Action<string> _sAction, Func<bool> _CanActionExecute)
        {
            if (_sAction == null)
                throw new ArgumentNullException("Action invoked cannot be null. Please review your parameters");
            if (_CanActionExecute == null)
                throw new ArgumentNullException("Can Action invoked cannot be null. Please review your parameters");

            sAction = _sAction;
            CanActionExecute = _CanActionExecute;
        }

        public RelayExtension(Action<bool> _bAction, Func<bool> _CanActionExecute)
        {
            if (_bAction == null)
                throw new ArgumentNullException("Action invoked cannot be null. Please review your parameters");
            if (_CanActionExecute == null)
                throw new ArgumentNullException("Can Action invoked cannot be null. Please review your parameters");

            bAction = _bAction;
            CanActionExecute = _CanActionExecute;
        }

        public RelayExtension(Action<int> _iAction, Func<bool> _CanActionExecute, string vm)
        {
            if (_iAction == null)
                throw new ArgumentNullException("Action invoked cannot be null. Please review your parameters");
            if (_CanActionExecute == null)
                throw new ArgumentNullException("Can Action invoked cannot be null. Please review your parameters");

            iAction = _iAction;
            CanActionExecute = _CanActionExecute;
        }

        public RelayExtension(Func<int, Task> _itAction, Func<bool> _CanActionExecute)
        {
            if (_itAction == null)
                throw new ArgumentNullException("Action invoked cannot be null. Please review your parameters");
            if (_CanActionExecute == null)
                throw new ArgumentNullException("Can Action invoked cannot be null. Please review your parameters");

            itAction = _itAction;
            CanActionExecute = _CanActionExecute;
        }

        public RelayExtension(Func<int, bool> _boolAction, Func<bool> _CanActionExecute)
        {
            if (_boolAction == null)
                throw new ArgumentNullException("Action invoked cannot be null. Please review your parameters");
            if (_CanActionExecute == null)
                throw new ArgumentNullException("Can Action invoked cannot be null. Please review your parameters");

            boolAction = _boolAction;
            CanActionExecute = _CanActionExecute;
        }

        public RelayExtension(Task _itAction, Func<bool> _CanActionExecute)
        {
            if (_itAction == null)
                throw new ArgumentNullException("Action invoked cannot be null. Please review your parameters");
            if (_CanActionExecute == null)
                throw new ArgumentNullException("Can Action invoked cannot be null. Please review your parameters");

            itActionWithoutReturn = _itAction;
            CanActionExecute = _CanActionExecute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (CanActionExecute != null)
                CanActionExecute.Invoke();

            return true;
        }

        public async void Execute(object parameter)
        {
            if (Action != null)
                Action.Invoke();
            else if (sAction != null)
                sAction.Invoke((string)parameter);
            else if (iAction != null)
                iAction.Invoke((int)Convert.ToInt64(parameter));
            else if (itAction != null)
                await itAction.Invoke((int)Convert.ToInt64(parameter));
            else if (boolAction != null)
                boolAction.Invoke((int)Convert.ToInt64(parameter));
            else if (bAction != null)
                bAction.Invoke((bool)parameter);
        }

        public void RaiseCanExecuteChanged()
        {
            var handler = CanExecuteChanged;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }
    }
}
