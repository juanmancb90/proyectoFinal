using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApplication1.ViewModel
{
    public class RelayCommand : ICommand
    {
        #region Fields

        readonly Action<object> _execute;
        readonly Predicate<object> _canExecute;

        #endregion

        #region Constructors

        /// <summary> 
        /// Creates a new command that can always execute. 
        /// </summary> 
        /// <param name="execute">The execution logic.</param> 
        public RelayCommand(Action<object> execute)
            : this(execute, null)
        {
        }

        /// <summary> 
        /// Creates a new command. 
        /// </summary> 
        /// <param name="execute">The execution logic.</param> 
        /// <param name="canExecute">The execution status logic.</param> 
        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }

            _execute = execute;
            _canExecute = canExecute;
        }

        #endregion

        #region ICommand Members
        /// <summary>
        /// Método que indica si se peude ejecutar el comando
        /// </summary>
        /// <param name="parameter">objeto que hace el llamado</param>
        /// <returns>bool:true-> si pueden ejecutar el comando
        /// fasel-> si no se puede ejecutar el comando</returns>
        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        /// <summary>
        /// Evento que monitorea el cambio en las condiciones de ejecucion del evento
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Metodo que representa la ejecución del evento.
        /// </summary>
        /// <param name="parameter">Objeto que hizo la llamada</param>
        public void Execute(object parameter)
        {
            _execute(parameter);
        }
        #endregion
    }
}
