namespace CarsManagement.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Manufacturer
    {
        private int iD;
        private string brandName;
        private int year;

        //Свойство за идентификационен номер
        public int ID
        {
            get { return iD; }
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("ID can't be less or equal to zero!");
                iD = value;
            }
        }

        //Свойство за име на производител с максимална дължина от 100 символа
        [MaxLength(100)]
        public string BrandName
        {
            get { return brandName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Brand name is invalid!");

                brandName = value;
            }
        }

        //Свойсвто година
        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1803)
                    throw new ArgumentException("The first car brand is made 1803. The year can't be less than this");

                year = value;
            }
        }

        //Колекция на всичките модели, които производителя притежава
        public virtual ICollection<Car> Cars { get; set; } = new HashSet<Car>();
    }
}
