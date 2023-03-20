using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Example3.Models;
using Example3.Services;
using Example3.View;
using Example3.ViewModels;
using System.Collections.ObjectModel;

namespace Example3.ViewModel
{
    public partial class MainViewModel : BaseViewModel
    {
        [ObservableProperty]
        List<ToDoModel> toDolist;

        [ObservableProperty]
        ToDoModel todo;

        [ObservableProperty]
        ToDoModel toSaveOnDB;
       
        private readonly DbConnection _dbConnection;
        public MainViewModel(DbConnection dbConnection)
        {
            
            _dbConnection = dbConnection;
            toDolist = new List<ToDoModel>();
            toSaveOnDB = new ToDoModel(); // #added - instantiat mobelul 
            GetInitalDataCommand.Execute(null);
        }
        [RelayCommand]
        private async void GetInitalData()
        {
            ToDolist = await _dbConnection.GetItemsAsync();
        }

        [ObservableProperty]
        ObservableCollection<string> items;
        [ObservableProperty]
        string text;
        
        [RelayCommand]
        
        private async void GoToBasicNavigation()
        {
            await Shell.Current.GoToAsync(nameof(AddItems));
        }

        partial void OnTodoModel(ToDoModel value)
        {
            if (value == null) return;
            GoToMoreInfo();
        }
            [RelayCommand]
            private async void GoToMoreInfo()
            {
                var navigationParameter = new Dictionary<string, object>
                {
            { "Todo", Todo }
                };

                Todo = null;

                await Shell.Current.GoToAsync(nameof(EditItems), navigationParameter);
            }

            [RelayCommand]
            private async void SaveOnDb()
            {
                await _dbConnection.SaveItemAsync(ToSaveOnDB);
                Todolist = await _dbConnection.GetItemsAsync();
            }
            void Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
                return;
            Items.Add(Text);
            Text = string.Empty;
        }
       /* [RelayCommand]

        void Delete(string s)
        {
            if (Items.Contains(s))
            {
                Items.Remove(s);
            }
        }

        [RelayCommand]
        async Task Tap(string s)
        {
            await Shell.Current.GoToAsync(nameof(EditItems));
        }
        [RelayCommand]
        /*async void MoveToANewTab1()
        {
            await Shell.Current.GoToAsync(nameof(AddItems));
        }*/





        /* void Receive(DeleteItemMessage message)
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                Delete(message.Value);
            });
        }

        public void Receive(AddItemMessage message)
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                Add();
            });
        }
*/



    }
}


