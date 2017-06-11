//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Input;

//namespace BrzaNaplataPutarineApp.Helper
//{
//    //Standardna relaycommand klasa koja se reuse u MVVM
//    public class RelayCommand<T> : ICommand
//    {
//        private readonly Func<T, bool> _canExecuteMethod;
//        private readonly Action<T> _executeMethod;

//        #region Constructors

//        public RelayCommand(Action<T> executeMethod)
//            : this(executeMethod, null)
//        {
//        }

//        public RelayCommand(Action<T> executeMethod, Func<T, bool> canExecuteMethod)
//        {
//            _executeMethod = executeMethod;
//            _canExecuteMethod = canExecuteMethod;
//        }

//        #endregion Constructors

//        #region ICommand Members

//        public event EventHandler CanExecuteChanged;

//        bool ICommand.CanExecute(object parameter)
//        {
//            try
//            {
//                return CanExecute((T)parameter);
//            }
//            catch { return false; }
//        }

//        void ICommand.Execute(object parameter)
//        {
//            Execute((T)parameter);
//        }

//        #endregion ICommand Members

//        #region Public Methods

//        public bool CanExecute(T parameter)
//        {
//            return ((_canExecuteMethod == null) || _canExecuteMethod(parameter));
//        }

//        public void Execute(T parameter)
//        {
//            if (_executeMethod != null)
//            {
//                _executeMethod(parameter);
//            }
//        }

//        public void RaiseCanExecuteChanged()
//        {
//            OnCanExecuteChanged(EventArgs.Empty);
//        }

//        #endregion Public Methods

//        #region Protected Methods

//        protected virtual void OnCanExecuteChanged(EventArgs e)
//        {
//            var handler = CanExecuteChanged;
//            if (handler != null)
//            {
//                handler(this, e);
//            }
//        }

//        #endregion Protected Methods
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BrzaNaplataPutarineApp.Helper
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action<object> methodToExecute;
        private Predicate<object> canExecuteEvaluator;

        public RelayCommand(Action<object> methodToExecute, Predicate<object> canExecuteEvaluator)
        {
            this.methodToExecute = methodToExecute;
            this.canExecuteEvaluator = canExecuteEvaluator;
        }

        public RelayCommand(Action<object> methodToExecute) : this(methodToExecute, null)
        {
        }

        public bool CanExecute(object parameter)
        {
            if (this.canExecuteEvaluator == null)
            {
                return true;
            }
            else
            {
                bool result = this.canExecuteEvaluator.Invoke(parameter);
                return result;
            }
        }
        public void Execute(object parameter)
        {
            this.methodToExecute.Invoke(parameter);
        }
    }
}
