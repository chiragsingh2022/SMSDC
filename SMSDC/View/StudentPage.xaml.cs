using SMSDC.Dialog;
using SMSDC.Swagger.Smsdc;
using SMSDC.ViewModel;

using System;
using System.Collections.ObjectModel;

using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SMSDC.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class StudentPage : Page
    {
        public StudentPageViewModel ViewModel => (StudentPageViewModel)DataContext;
        public StudentPage()
        {
            this.InitializeComponent();
            DataContext = new StudentPageViewModel();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            ViewModel.StudentPageData = new ObservableCollection<Student>(await new Client().StudentAllAsync());
            base.OnNavigatedTo(e);
        }

        private async void ListView_RightTapped(object sender, Windows.UI.Xaml.Input.RightTappedRoutedEventArgs e)
        {
            ListViewItem listViewItem = (e.OriginalSource as FrameworkElement)?.DataContext as ListViewItem;

            if (listViewItem != null)
            {
                // Select the item that was right-tapped
                MyListView.SelectedItem = listViewItem.Content;
            }
            var dialog = new MessageDialog("Do you want to delete the selected student ?", "Delete student");
            dialog.Commands.Add(new UICommand("Yes", null, true));
            dialog.Commands.Add(new UICommand("No", null, false));
            dialog.CancelCommandIndex = (uint)dialog.Commands.Count - 1;
            var shouldCloseApp = (await dialog.ShowAsync()).Id as bool?;
            if (shouldCloseApp == true)
            {
                if (ViewModel.SelectedItem != null)
                {
                    await new Client().StudentDELETEAsync(ViewModel.SelectedItem.Id);
                }
                else
                {
                    var dialogg = new MessageDialog("Please select a student to delete");
                    await dialogg.ShowAsync();
                }
                ViewModel.StudentPageData = new ObservableCollection<Student>(await new Client().StudentAllAsync());
            }
        }

        private async void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            await new AddBaStudent(true).ShowAsync();
            ViewModel.StudentPageData = new ObservableCollection<Student>(await new Client().StudentAllAsync());
        }
    }
}
