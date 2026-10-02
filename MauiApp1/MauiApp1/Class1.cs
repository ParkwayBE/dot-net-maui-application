using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public class MyItem
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Booked { get; set; }

        // You can add more properties as needed

        // Constructor for convenience
        public MyItem(string id, string name, string booked)
        {
            ID = id;
            Name = name;
            Booked = booked;
        }
    }
}
