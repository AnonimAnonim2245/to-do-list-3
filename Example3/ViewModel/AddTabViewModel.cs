using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Example3.Messages;
using Example3.View;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Common;
using static System.Net.Mime.MediaTypeNames;

namespace Example3.ViewModel
{
    [QueryProperty("Text", "Text")]

    public partial class AddTabViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;
        [RelayCommand]

        async Task Add()
        {
            WeakReferenceMessenger.Default.Send(new AddItemMessage(Text));
            await Shell.Current.GoToAsync(nameof(MainPage));

        }
        [RelayCommand]
        private void MoveToFirstTab()
        {
            Shell.Current.CurrentItem = Shell.Current.Items[0].Items[0];
        }
    }


}
