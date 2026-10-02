namespace MauiApp1;
using MauiApp1.Model;
using MauiApp1.Services;

public partial class VehicleDetails : ContentPage
{
    MysqlDataStore ds = new MysqlDataStore();
    Car car;
    
	public VehicleDetails(Car selectedCar)
	{
		InitializeComponent();
		Title = selectedCar.Name;
        car = selectedCar;
        
    }

    private async void OnButtonDeleteClicked(object sender, EventArgs e)
    {
        await ds.DeleteCar(car);
        Navigation.PopAsync();
    }

    private void OnButtonEditClicked(object sender, EventArgs e)
    {
        vehicleName.IsVisible = !vehicleName.IsVisible;
        infoLabel.IsVisible = !infoLabel.IsVisible;
        SaveName.IsVisible = true;
    }
    private async void OnButtonSaveClicked(object sender, EventArgs e)
    {
       if(vehicleName.Text.Length < 2)
       {
            infoLabelnew.IsVisible = true;
            return;
       }
       else
       {
            
            Car newCar = new Car();
            newCar = car;
            newCar.Name = vehicleName.Text;

            await ds.UpdateCar(car);
            
            Navigation.PopAsync();
        }
    }

}
