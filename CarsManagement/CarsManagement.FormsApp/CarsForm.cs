namespace CarsManagement.FormsApp
{
    using CarsManagement.Data;
    using CarsManagement.Data.Models;
    using CarsManagement.Services;
    using System;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;
    public partial class CarsForm : Form
    {
        CarsService service;

        //Pagination variables
        private int currentPage = 1;
        private int itemsPerPage = 10;
        private int pageCount = 0;
        private int totalItems = 0;
        private bool ascSort = true;

        public CarsForm(AppDbContext context)
        {
            InitializeComponent();
            service = new CarsService(context);
        }

        // метод за показване на програмния интерфейс при зареждане на програмата
        private void CarsForm_Load(object sender, EventArgs e)
        {
            btnAction.Text = rbAdd.Text;
            rbAdd.Checked = true;
            rbDelete.Enabled = false;
            rbUpdate.Enabled = false;

            rbAsc.Checked = true;
            comboBox1.SelectedText = itemsPerPage.ToString();

            UpdatePagination();
            LoadGanres();
        }

        // метод за отпечатване на жанровете
        private void LoadGanres()
        {
            listBox1.Items.Clear();
            string[] cars = service.GetCars(currentPage, itemsPerPage, ascSort)
                .Select(x => $"{x.ID} - {x.Model} - {x.Color} - {x.HorsePower} - {x.Year}")
                .ToArray();
            listBox1.Items.AddRange(cars);
            lblCurrentPage.Text = $"{currentPage}/{pageCount}";
        }

        // метод за обновяване на страницирането
        private void UpdatePagination()
        {
            totalItems = service.GetCarsCount();
            pageCount = (int)Math.Ceiling((double)totalItems / itemsPerPage);
        }

        // метод за изпълнение на функцията, която маркирания бутон предлага при натискане на бутона
        private void btnAction_Click(object sender, EventArgs e)
        {
            try
            {
                // Add ganre
                if (rbAdd.Checked)
                {
                    Car car = new Car() { Model = txtModel.Text, Color = txtColor.Text, HorsePower = int.Parse(txtHP.Text), Year = int.Parse(txtYear.Text) };
                    int id = service.Add(car);
                    MessageBox.Show($"Car with id: {id} is added!");
                }
                // Edit ganre
                else if (rbUpdate.Checked)
                {
                    int id = int.Parse(txtID.Text);
                    string name = txtModel.Text;
                    string color = txtColor.Text;
                    int hp = int.Parse(txtHP.Text);
                    int year = int.Parse(txtYear.Text);
                    service.EditModel(id, name, color, hp, year);
                    MessageBox.Show($"Car with id: {id} is updated!");
                }
                // Delete ganre
                else if (rbDelete.Checked)
                {
                    int id = int.Parse(txtID.Text);
                    service.DeleteCar(id);
                    MessageBox.Show($"Car with id: {id} is deleted.");
                }
                txtID.Text = string.Empty;
                txtModel.Text = string.Empty;

                RadioCheckedFalse();
                UpdatePagination();
                LoadGanres();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // метод за задаване на всички радиобутони като невалидни
        private void RadioCheckedFalse()
        {
            //Remove radio selection
            rbAdd.Checked = false;
            rbDelete.Checked = false;
            rbUpdate.Checked = false;
        }

        // метод за прелистване към предишна страница
        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if ((currentPage - 1) > 0)
            {
                currentPage--;
            }
            else
            {
                currentPage = pageCount;
            }
            LoadGanres();
        }

        // метод за прелистване към следваща страница
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage + 1 <= pageCount)
            {
                currentPage++;
            }
            else
            {
                currentPage = 1;
            }
            LoadGanres();
        }

        // метод за отпечатване на обектите по азбучен ред
        private void rbAsc_CheckedChanged(object sender, EventArgs e)
        {
            ascSort = true;
            LoadGanres();
        }

        // метод за отпечатване на обектите по обратен азбучен ред
        private void rbDesc_CheckedChanged(object sender, EventArgs e)
        {
            ascSort = false;
            LoadGanres();
        }

        // метод за избиране на броя на предметите за страница
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemsPerPage = int.Parse(comboBox1.Text);
            currentPage = 1;
            UpdatePagination();
            LoadGanres();
        }

        // метод за запълване на textbox-овете с параметрите на обекта
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] info = listBox1.Text.Split(" - ");
            txtID.Text = info[0];
            txtModel.Text = info[1];
            txtColor.Text = info[2];
            txtHP.Text = info[3];
            txtYear.Text = info[4];

            rbUpdate.Enabled = true;
            rbDelete.Enabled = true;

            RadioCheckedFalse();

            btnAction.Enabled = false;
        }

        private void rbAdd_CheckedChanged(object sender, EventArgs e)
        {
            btnAction.Enabled = true;
            btnAction.Text = rbAdd.Text;
            txtID.Text = string.Empty;
            txtModel.Text = string.Empty;
            txtColor.Text = string.Empty;
            txtHP.Text = string.Empty;
            txtYear.Text = string.Empty;

            rbUpdate.Enabled = false;
            rbDelete.Enabled = false;
        }

        private void rbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            btnAction.Enabled = true;
            btnAction.Text = rbUpdate.Text;
        }

        private void rbDelete_CheckedChanged(object sender, EventArgs e)
        {
            btnAction.Enabled = true;
            btnAction.Text = rbDelete.Text;
        }
    }
}
