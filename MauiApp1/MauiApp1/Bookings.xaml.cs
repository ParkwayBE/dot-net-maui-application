using MauiApp1.Services;

namespace MauiApp1;

public partial class Bookings : ContentPage
{
    MysqlDataStore ds = new MysqlDataStore();
	public Bookings()
	{
		InitializeComponent();
        LoadBookings();
	}
    private async void LoadBookings()
    {
        ds.BookingList.Clear();
        ds.BookingList = await ds.GetAllBooking();
        myBookingsListView.ItemsSource = ds.BookingList;




    }
    private void OnAddItemClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AddBooking());

    }

    private void OnBookingSelected(object sender, SelectedItemChangedEventArgs e)
    {
        //if (e.SelectedItem is Car selectedCar)
       // {
            // Navigate to the detail page with the selected car
            //Navigation.PushAsync(new VehicleDetails(selectedCar));
       //}

        // Reset the selected item
       // myCarsListView.SelectedItem = null;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        LoadBookings();

    }
}