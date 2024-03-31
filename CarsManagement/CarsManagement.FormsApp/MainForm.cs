using CarsManagement.Data;
using CarsManagement.Services;
using CarsManagement.Services.Enums;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace CarsManagement.FormsApp
{
    public partial class MainForm : Form
    {
        AppDbContext context = new AppDbContext();
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarsForm carsForm = new CarsForm(context);
            carsForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManufacturersForm manForm = new ManufacturersForm(context);
            manForm.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                CarsService service = new CarsService(context);
                string[] result = null;
                if (radioButton1.Checked)
                {
                    result = service.Search(CarsSearchBy.Model, txtSearch.Text);
                }
                else if (radioButton2.Checked)
                {
                    result = service.Search(CarsSearchBy.Color, txtSearch.Text);
                }
                listBox1.Items.Clear();
                if (result.Length != 0)
                {
                    listBox1.Items.AddRange(result);
                }
                else
                {
                    listBox1.Items.Add("Items not found!");
                }
            }
            else
            {
                errorProvider1.SetError(txtSearch, "Needs to contain a text");

            }
        }
    }
}
