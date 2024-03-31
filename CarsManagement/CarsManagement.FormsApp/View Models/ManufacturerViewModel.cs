using CarsManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsManagement.FormsApp.View_Models
{
    public class ManufacturerViewModel
    {
        public int ID { get; set; }
        public string BrandName { get; set; }
        public int Year { get; set; }
        public string Cars { get; set; }

    }
}
