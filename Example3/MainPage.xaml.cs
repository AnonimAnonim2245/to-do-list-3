
using Example3.ViewModel;

namespace Example3;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
    

}

