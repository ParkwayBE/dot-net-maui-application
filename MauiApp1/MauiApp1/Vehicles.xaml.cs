using MauiApp1.Model;
using MauiApp1.Services;
using Microsoft.Maui.Controls;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Xml.Linq;
//using Windows.Devices.Midi;

//using static Android.Content.ClipData;

namespace MauiApp1;

public partial class VehiclesPage : ContentPage
{
    MysqlDataStore ds = new MysqlDataStore();

    public VehiclesPage()
    {
        InitializeComponent();
        LoadVehicles();
    }
    private async void LoadVehicles()
    {
        ds.CarList.Clear();
        ds.CarList = await ds.GetAllCar();
        myCarsListView.ItemsSource = ds.CarList;




    }
    private void OnAddItemClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AddVehicle());

    }

    private void OnCarSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem is Car selectedCar)
        {
            // Navigate to the detail page with the selected car
            Navigation.PushAsync(new VehicleDetails(selectedCar));
        }

        // Reset the selected item
        myCarsListView.SelectedItem = null;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        LoadVehicles() ;
      
    }
}



