using SMSDC.Swagger.Smsdc;

using System.Collections.ObjectModel;

namespace SMSDC.ViewModel
{
    public class BaPageViewModel : ViewModelBase
    {
        private ObservableCollection<Ba> _baPageData;
        public ObservableCollection<Ba> BaPageData
        {
            get => _baPageData;
            set => SetProperty(ref _baPageData, value);
        }

        private Ba _selectedItem;
        public Ba SelectedItem
        {
            get => _selectedItem;
            set => SetProperty(ref _selectedItem, value);
        }
    }
}
