using MauiApp1.Model;
using MauiApp1.Services;

namespace MauiApp1;

public partial class AddBooking : ContentPage
{
    List<Car> cars = new List<Car>();
    MysqlDataStore ds = new MysqlDataStore();  
	public AddBooking()
	{
		InitializeComponent();
        LoadVehicles();
	}

    private async void SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    private async void OnAddItemClicked(object sender, EventArgs e)
    {
        
    }
    private async void LoadVehicles()
    {
        cars = await ds.GetAllCar();

        // Set the ItemsSource property to the collection of cars
        

        // Optionally, you can also set the DisplayMemberPath to specify the property to display in the Picker
        
    }
}