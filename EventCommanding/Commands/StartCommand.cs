using System;
using System.Windows.Input;
using EventCommanding.ViewModels;

namespace EventCommanding.Commands
{
    public class StartCommand : ICommand
    {
        private readonly BasicViewModel _model;

        public StartCommand(BasicViewModel model)
        {
            _model = model;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _model.Message = "Move pointer out";
        }

        public event EventHandler CanExecuteChanged;
    }
}
