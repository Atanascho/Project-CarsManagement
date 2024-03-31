using CarsManagement.Data;
using CarsManagement.Data.Models;
using CarsManagement.FormsApp.View_Models;
using CarsManagement.Services;
using CarsManagement.Services.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace CarsManagement.FormsApp
{
    public partial class ManufacturersForm : Form
    {
        private ManufacturersService manufacturersService;
        private CarsService carsService;
        private int currentManufacturerId = -1;

        //Pagination variables
        private int currentPage = 1;
        private int itemsPerPage = 10;
        private int pageCount = 0;
        private int totalItems = 0;
        private bool ascSort = true;

        public ManufacturersForm(AppDbContext context)
        {
            InitializeComponent();
            carsService = new CarsService(context);
            manufacturersService = new ManufacturersService(context);
        }

        private void ManufacturersForm_Load_1(object sender, EventArgs e)
        {
            UpdatePagination();
            LoadBooks();

            cmbOrder.SelectedIndex = 0;
        }

        private void LoadBooks()
        {
            dataGridView1.DataSource = manufacturersService
                .GetManufacturer(currentPage, itemsPerPage, ascSort)
                .Select(x => new ManufacturerViewModel()
                {
                    ID = x.ID,
                    BrandName = x.BrandName,
                    Year = x.Year,
                    Cars = string.Join(", ", x.Cars.Select(x => x.Model)),
                })
                .ToList();

            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            lblPages.Text = $"{currentPage}/{pageCount}";
        }

        private void UpdatePagination()
        {
            totalItems = manufacturersService.GetManufacturersCount();
            pageCount = (int)Math.Ceiling((double)totalItems / itemsPerPage);
            lblCount.Text = totalItems.ToString();
            lblPages.Text = $"{currentPage}/{pageCount}";
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var item = dataGridView1.SelectedRows[0];
            currentManufacturerId = int.Parse(item.Cells[0].Value.ToString());
            txtName.Text = item.Cells[1].Value.ToString();
            dateTimePicker1.Value = new DateTime(int.Parse(item.Cells[2].Value.ToString()), 1, 1);
            rbUpdate.Checked = true;
        }

        private void rbAdd_CheckedChanged(object sender, EventArgs e)
        {
            btnAction.Text = "Add";
            ClearComponents();
        }

        private void rbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            btnAction.Text = "Update";
        }

        private void rbDelete_CheckedChanged(object sender, EventArgs e)
        {
            btnAction.Text = "Delete";
        }

        public void ClearComponents()
        {
            txtName.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ = cmbOrder.Text == "ASC" ? ascSort = true : ascSort = false;
            LoadBooks();
        }


        private void btnCars_Click(object sender, EventArgs e)
        {
            ManufacturerCarsForm form = new ManufacturerCarsForm(carsService, manufacturersService, currentManufacturerId);
            form.ShowDialog();
        }

        private void btnAction_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (rbAdd.Checked)
                {
                    Manufacturer manufacturer = new Manufacturer()
                    {
                        BrandName = txtName.Text,
                        Year = dateTimePicker1.Value.Year,
                    };
                    int id = manufacturersService.Add(manufacturer);
                    MessageBox.Show($"Manufacturer with id: {id} is added");
                }
                else if (rbDelete.Checked)
                {
                    if (currentManufacturerId != -1)
                    {
                        int id = manufacturersService.DeleteManufacturer(currentManufacturerId);
                        MessageBox.Show($"Manufacturer with id: {id} is deleted");
                    }
                    else
                    {
                        MessageBox.Show($"Please select a currentManufacturer!");
                    }
                }
                else if (rbUpdate.Checked)
                {
                    if (currentManufacturerId != -1)
                    {
                        Manufacturer manufacturer = manufacturersService.GetManufacturerByID(currentManufacturerId);
                        manufacturer.BrandName = txtName.Text;
                        manufacturer.Year = dateTimePicker1.Value.Year;
                        int id = manufacturersService.EditManufacturer(manufacturer);
                        MessageBox.Show($"Manufacturer with id: {id} is edited succesfully");
                    }
                    else
                    {
                        MessageBox.Show($"Please select a manufacturer!");
                    }

                }
                currentManufacturerId = -1;
                ClearComponents();
                UpdatePagination();
                LoadBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrevious_Click_1(object sender, EventArgs e)
        {
            if ((currentPage - 1) > 0)
            {
                currentPage--;
            }
            else
            {
                currentPage = pageCount;
            }
            LoadBooks();
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (currentPage + 1 <= pageCount)
            {
                currentPage++;
            }
            else
            {
                currentPage = 1;
            }
            LoadBooks();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            var item = dataGridView1.SelectedRows[0];
            currentManufacturerId = (int)item.Cells[1].Value;
            txtName.Text = item.Cells[2].Value.ToString();
            dateTimePicker1.Value = new DateTime(int.Parse(item.Cells[3].Value.ToString()),1,1);
            rbUpdate.Checked = true;
        }
    }
}
