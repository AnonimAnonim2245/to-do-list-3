using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CoreML;
using Example3.Messages;
using Example3.Models;
using Example3.View;
using Example3.ViewModels;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Common;
using static System.Net.Mime.MediaTypeNames;

namespace Example3.ViewModel
{
    [QueryProperty("Text", "Text")]

    public partial class EditItemViewModel : BaseViewModel, IQueryAttributable
    {

        [ObservableProperty]
        string text;
        [ObservableProperty]
        ToDoModel todo = new();

        public EditItemViewModel()
        {

        }
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            Todo = query["ToDo"] as ToDoModel;
        }

        [RelayCommand]

        async Task Delete()
        {
            WeakReferenceMessenger.Default.Send(new DeleteItemMessage(Text));
            await Shell.Current.GoToAsync(nameof(MainPage));
        }
         [RelayCommand]
        private void MoveToFirstTab()
        {
            Shell.Current.CurrentItem = Shell.Current.Items[0].Items[0];
        }
    }


}