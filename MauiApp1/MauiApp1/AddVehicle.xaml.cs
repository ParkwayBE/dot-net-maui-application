using MauiApp1.Model;
using MauiApp1.Services;

namespace MauiApp1;

public partial class AddVehicle : ContentPage
{
	MysqlDataStore ds = new MysqlDataStore();
	public AddVehicle()
	{
		InitializeComponent();
	}
	private async void OnAddItemClicked(object sender, EventArgs e)
	{
		if(nameEntry.Text.Length < 2)
		{

			return;
		}
		Car car = new Car();
		car.Name = nameEntry.Text;
		car.Booked = false;
		await ds.AddCar(car);
        Navigation.PopAsync();
    }
}