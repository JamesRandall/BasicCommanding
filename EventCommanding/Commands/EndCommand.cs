using System;
using System.Windows.Input;
using EventCommanding.ViewModels;

namespace EventCommanding.Commands
{
    public class EndCommand : ICommand
    {
        private readonly BasicViewModel _model;

        public EndCommand(BasicViewModel model)
        {
            _model = model;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _model.Message = "Move pointer over";
        }

        public event EventHandler CanExecuteChanged;
    }
}
