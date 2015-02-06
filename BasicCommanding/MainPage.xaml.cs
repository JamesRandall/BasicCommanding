using Windows.UI.Xaml.Controls;
using BasicCommanding.Commands;
using BasicCommanding.ViewModels;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace BasicCommanding
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {   
            this.InitializeComponent();
            BasicViewModel basicViewModel = new BasicViewModel
            {
                Message = "Hello World"
            };
            basicViewModel.UpdateMessageCommand = new UpdateMessageCommand(basicViewModel);
            DataContext = basicViewModel;
        }
    }
}
