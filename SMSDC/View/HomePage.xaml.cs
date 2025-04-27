using SMSDC.ViewModel;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SMSDC.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        public HomePageViewModel ViewModel => (HomePageViewModel)DataContext;
        public HomePage()
        {
            this.InitializeComponent();
            DataContext = new HomePageViewModel();
        }

        //protected override void OnNevigatedTo(NavigationEventArgs e)
        //{

        //    base.OnNavigatedTo(e);
        //}

        private void BscButton_ClickAsync(object sender, RoutedEventArgs e) => Frame.Navigate(typeof(View.BscPage));

        private void SettingBtn_ClickAsync(object sender, RoutedEventArgs e) => Frame.Navigate(typeof(View.SettingPage));

        private void BaBtn_ClickAsync(object sender, RoutedEventArgs e) => Frame.Navigate(typeof(View.StudentPage));
    }
}
