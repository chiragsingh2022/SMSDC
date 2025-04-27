using SMSDC.Swagger.Smsdc;

using System.Collections.ObjectModel;

namespace SMSDC.ViewModel
{
    public class StudentPageViewModel : ViewModelBase
    {
        private ObservableCollection<Student> _StudentPageData;
        public ObservableCollection<Student> StudentPageData
        {
            get => _StudentPageData;
            set => SetProperty(ref _StudentPageData, value);
        }

        private Student _selectedItem;
        public Student SelectedItem
        {
            get => _selectedItem;
            set => SetProperty(ref _selectedItem, value);
        }
    }
}
