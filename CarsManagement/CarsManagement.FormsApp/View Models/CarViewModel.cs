using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsManagement.FormsApp.View_Models
{
    public class CarViewModel
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }
}
