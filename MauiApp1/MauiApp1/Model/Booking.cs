using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Model
{
    class Booking
    {
        public int Id { get; set; }

        public int carId { get; set; }

        public Car? car { get; set; }
        public string driver { get; set; }

        public string start { get; set; }
        public string end { get; set; }
    }
}
