using SMSDC.Swagger.Smsdc;

using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Windows.UI.Xaml.Controls;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238
namespace SMSDC.Dialog
{
    public partial class AddBaStudent : ContentDialog
    {

        private bool _isNew;
        public bool IsNew
        {
            get => _isNew;
            set => SetProperty(ref _isNew, value);
        }

        private Student _addNewBaStudents;
        public Student AddNewBaStudents
        {
            get => _addNewBaStudents;
            set => SetProperty(ref _addNewBaStudents, value);
        }
        public AddBaStudent(bool isNew)
        {
            this.InitializeComponent();
            IsNew = isNew;
            AddNewBaStudents = new Student();

        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args) => Hide();

        private async void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            if (AddNewBaStudents != null)
            {
                await new Client().StudentPOSTAsync(AddNewBaStudents);
            }
        }

        #region INotifyProperty
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }

            storage = value;
            RaisePropertyChanged(propertyName);
            return true;
        }
        #endregion
    }
}
