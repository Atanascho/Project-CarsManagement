using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CarsManagement.Data.Models
{
    [PrimaryKey(nameof(ManufacturerID), nameof(CarID))]
    public class ManufacturerCars
    {
        public int CarID { get; set; }

        public virtual Car Car { get; set; }

        public int ManufacturerID { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }
    }
}
