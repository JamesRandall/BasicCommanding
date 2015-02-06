using System;
using System.Windows.Input;
using BasicCommanding.ViewModels;

namespace BasicCommanding.Commands
{
    class UpdateMessageCommand : ICommand
    {
        private readonly BasicViewModel _model;

        public UpdateMessageCommand(BasicViewModel model)
        {
            _model = model;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _model.Message = "Goodbye!";
        }

        public event EventHandler CanExecuteChanged;
    }
}
