using MauiApp1.Model;
using MauiApp1.Services;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        List<Model.Car> carList = new List<Model.Car>();
        MysqlDataStore ds = new MysqlDataStore();
        public MainPage()
        {

            InitializeComponent();
            

        }

       


        //private async void OnCounterClicked(object sender, EventArgs e)
        //{
        //    count++;

        //    if (count == 1)
        //        CounterBtn.Text = $"Clicked {count} time";
        //    else
        //        CounterBtn.Text = $"Clicked {count} times";

        //    SemanticScreenReader.Announce(CounterBtn.Text);
        //    
        //    carList = await ds.GetAllCar();

        //    foreach(var car in carList)
        //    {
        //        var label = new Label
        //        {
        //            Text = car.Name,
        //            FontSize= 20,
        //        };
        //        dynamicLabelsStackLayout.Children.Add(label);

        //    }
            

        //}
        private void OnButtonVehiclesClicked(object sender, EventArgs e)
        {
            // Navigate to another page here
            Navigation.PushAsync(new VehiclesPage());
        }
        private void OnButtonPlannerClicked(object sender, EventArgs e)
        {
            
            Navigation.PushAsync(new Planner());
        }
        private void OnButtonBookingsClicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new Bookings());
        }
    }
}