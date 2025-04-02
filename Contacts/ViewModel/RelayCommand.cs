using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Contacts.ViewModel;
public class RelayCommand: ICommand
{
    /// <summary>
    /// Действие, выполняемое командой.
    /// </summary>
    private readonly Action<object> _execute;

    /// <summary>
    ///  Условие, определяющее, может ли команда выполняться.
    /// </summary>
    private readonly Predicate<object> _canExecute;

    /// <summary>
    /// Инициализирует новый экземпляр команды с делегированием действий.
    /// </summary>
    /// <param name="execute">Действие, которое выполняет команда.</param>
    /// <param name="canExecute">Предикат, определяющий, можно ли выполнить команду.</param>
    public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
    {
        _execute = execute ?? throw new ArgumentNullException(nameof(execute));
        _canExecute = canExecute;
    }

    /// <summary>
    /// Событие, уведомляющее об изменении возможности выполнения команды.
    /// </summary>
    public event EventHandler CanExecuteChanged
    {
        add => CommandManager.RequerySuggested += value;
        remove => CommandManager.RequerySuggested -= value;
    }

    /// <summary>
    /// Определяет, может ли команда быть выполнена в текущий момент.
    /// </summary>
    /// <param name="parameter">Параметр, передаваемый в команду.</param>
    /// <returns>Возвращает true, если команда может быть выполнена, иначе false.</returns>
    public bool CanExecute(object parameter)
    {
        return _canExecute == null || _canExecute(parameter);
    }

    /// <summary>
    /// Выполняет команду, вызывая связанное действие.
    /// </summary>
    /// <param name="parameter">Параметр команды</param>
    public void Execute(object parameter)
    {
        _execute(parameter);
    }
}

