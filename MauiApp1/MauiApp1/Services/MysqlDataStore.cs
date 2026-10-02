using MauiApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MauiApp1.Services
{
    internal class MysqlDataStore
    {
        public List<Car> CarList = new List<Car>();
        public List<Booking> BookingList = new List<Booking>();

        public async Task<List<Car>> GetAllCar()
        {
            HttpClient client = new HttpClient();
            String response = await client.GetStringAsync("http://localhost:5041/api/cars");
            return JsonConvert.DeserializeObject<List<Car>>(response);

        }
        public async Task AddCar(Car car)
        {
            CarList.Add(car);
            HttpClient client = new HttpClient();
            var jsonContent = JsonConvert.SerializeObject(car);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var apiUrl = "http://localhost:5041/api/cars";
            var response = await client.PostAsync(apiUrl, content);
            

        }
        public async Task DeleteCar(Car car)
        {
            CarList.Remove(car);
            HttpClient client = new HttpClient();
            var apiUrl = "http://localhost:5041/api/cars"+"/"+car.Id;
            var response = await client.DeleteAsync(apiUrl);
            
        }
        public async Task UpdateCar(Car car)
        {
            for(int i = 0; i < CarList.Count; i++)
            {
                if (CarList[i].Id == car.Id)
                {
                    CarList[i] = car;
                }
            }
            
            HttpClient client = new HttpClient();
            var jsonContent = JsonConvert.SerializeObject(car);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var apiUrl = "http://localhost:5041/api/cars"+"/"+car.Id;
            var response = await client.PutAsync(apiUrl, content);
            
        }

        public async Task<List<Booking>> GetAllBooking()
        {
            HttpClient client = new HttpClient();
            String response = await client.GetStringAsync("http://localhost:5041/api/booking");
            return JsonConvert.DeserializeObject<List<Booking>>(response);

        }
    }
}
