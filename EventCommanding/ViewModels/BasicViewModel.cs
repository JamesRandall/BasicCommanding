using System.Windows.Input;

namespace EventCommanding.ViewModels
{
    public class BasicViewModel : BindableBase
    {
        public ICommand StartCommand { get; set; }
        public ICommand EndCommand { get; set; }

        private string _message;

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }
    }
}
