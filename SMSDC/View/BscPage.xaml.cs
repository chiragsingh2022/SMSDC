using SMSDC.ViewModel;

using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SMSDC.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BscPage : Page
    {
        public BscPageViewModel ViewModel => (BscPageViewModel)DataContext;
        public BscPage()
        {
            this.InitializeComponent();
            DataContext = new BscPageViewModel();
        }
    }
}
