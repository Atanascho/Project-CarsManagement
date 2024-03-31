using CarsManagement.Data;
using CarsManagement.Data.Models;
using CarsManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsManagement.FormsApp
{
    public partial class ManufacturerCarsForm : Form
    {
        CarsService carsService;
        ManufacturersService manufacturersService;
        Manufacturer currentManufacturer;
        public ManufacturerCarsForm(CarsService carsService, ManufacturersService manufacturersService, int manufacturerID)
        {
            InitializeComponent();
            this.carsService = carsService;
            this.manufacturersService = manufacturersService;
            currentManufacturer = manufacturersService.GetManufacturerByID(manufacturerID);
        }

        private void ManufacturerCarsForm_Load(object sender, EventArgs e)
        {
            lblName.Text = currentManufacturer.BrandName;
            lblYear.Text = currentManufacturer.Year.ToString();
            checkedListBox1.Items.AddRange(carsService.GetAllCars());
            LoadBookGanres();
        }
        private void LoadBookGanres()
        {
            List<string> manufacturerCars = currentManufacturer.Cars.Select(x => x.Model).ToList();

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (manufacturerCars.Any(x => x == checkedListBox1.Items[i].ToString()))
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
            }
        }

        private void btnUpdateCars_Click(object sender, EventArgs e)
        {
            currentManufacturer.Cars.Clear();
            manufacturersService.EditManufacturerCars(currentManufacturer);
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                string carName = checkedListBox1.CheckedItems[i].ToString();
                currentManufacturer.Cars.Add(new Car() { Model = carsService.GetCarsByName(carName).ToString()}); // ako neshto pomosht
            }
            manufacturersService.EditManufacturerCars(currentManufacturer);

            MessageBox.Show("Manufacturer is updated!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
