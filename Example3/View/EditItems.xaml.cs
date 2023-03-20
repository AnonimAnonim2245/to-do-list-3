using Example3.ViewModel;
namespace Example3.View;

public partial class EditItems : ContentPage
{
 
    public EditItems(EditItemViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
   
}