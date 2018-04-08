using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Stopwatch
{
    public delegate void Task(object o);
    public delegate bool Condition(object o);
    public class RelayCommand : ICommand
    {
        private Task execute;
        private Condition canExecute;
        public RelayCommand(Task execute, Condition canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
            CommandManager.RequerySuggested += CommandManager_RequerySuggested;
        }

        void CommandManager_RequerySuggested(object sender, EventArgs e)
        {
            CanExecuteChanged(this, new EventArgs());
        }

        public bool CanExecute(object parameter)
        {
            return canExecute(parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
