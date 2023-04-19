using SMSDC.Dialog;
using SMSDC.Swagger.Smsdc;
using SMSDC.ViewModel;

using System;
using System.Collections.ObjectModel;

using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SMSDC.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BaPage : Page
    {
        public BaPageViewModel ViewModel => (BaPageViewModel)DataContext;
        public BaPage()
        {
            this.InitializeComponent();
            DataContext = new BaPageViewModel();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            ViewModel.BaPageData = new ObservableCollection<Ba>(await new Client().BaAllAsync());
            base.OnNavigatedTo(e);
        }

        private async void ListView_RightTapped(object sender, Windows.UI.Xaml.Input.RightTappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("Do you want to delete the selected student ?", "Delete student");
            dialog.Commands.Add(new UICommand("No", null, false));
            dialog.Commands.Add(new UICommand("Yes", null, true));
            dialog.CancelCommandIndex = (uint)dialog.Commands.Count - 1;
            var shouldCloseApp = (await dialog.ShowAsync()).Id as bool?;
            if (shouldCloseApp == true)
            {
                if (ViewModel.SelectedItem != null)
                {
                    await new Client().BaDELETEAsync(ViewModel.SelectedItem.Id);
                }
                else
                {
                    var dialogg = new MessageDialog("Please select a student to delete");
                    await dialogg.ShowAsync();
                }
                ViewModel.BaPageData = new ObservableCollection<Ba>(await new Client().BaAllAsync());
            }
        }

        private async void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            await new AddBaStudent(true).ShowAsync();
            ViewModel.BaPageData = new ObservableCollection<Ba>(await new Client().BaAllAsync());
        }
    }
}
