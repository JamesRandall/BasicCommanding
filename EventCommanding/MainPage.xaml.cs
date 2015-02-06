using Windows.UI.Xaml.Controls;
using EventCommanding.Commands;
using EventCommanding.ViewModels;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace EventCommanding
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            BasicViewModel model = new BasicViewModel
            {
                Message = "Move pointer over!"
            };
            model.StartCommand = new StartCommand(model);
            model.EndCommand = new EndCommand(model);
            DataContext = model;
        }
    }
}
