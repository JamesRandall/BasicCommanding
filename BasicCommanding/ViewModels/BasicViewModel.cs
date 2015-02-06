using System.Windows.Input;

namespace BasicCommanding.ViewModels
{
    public class BasicViewModel : BindableBase
    {
        public ICommand UpdateMessageCommand { get; set; }

        private string _message;

        public string Message
        {
            get {  return _message;}
            set { SetProperty(ref _message, value); }
        }
    }
}
