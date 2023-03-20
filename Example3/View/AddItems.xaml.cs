using Example3.ViewModel;

namespace Example3.View;

public partial class AddItems : ContentPage
{
    public AddItems()
	{
		InitializeComponent();
		BindingContext = new AddTabViewModel();
    }
    public AddItems(MainViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}