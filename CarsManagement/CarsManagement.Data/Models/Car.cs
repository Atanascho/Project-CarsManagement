namespace CarsManagement.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    //Клас Car
    public class Car
    {
        private int iD;
        private string model;
        private string color;
        private int horsePower;
        private int year;

        //Свойство за идентификационен номер
        public int ID
        {
            get { return iD; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("ID can't be less or equal to zero!");
                iD = value;
            }
        }
        //Свойство за име на модел с максимална дължина от 100 символа
        [MaxLength(100)]
        public string Model
        {
            get { return model; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Model name is invalid!");
                model = value;
            }
        }

        //Свойсвто година
        public int Year
        {
            get { return year; }
            set
            {
                if (value <= 1803)
                    throw new ArgumentException("Year is invalid!");
                year = value;
            }
        }
        // Свойство цвят
        public string? Color
        {
            get { return color; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Color is invalid!");
                color = value;
            }
        }
        // Свойство за конски сили
        public int HorsePower
        {
            get { return horsePower; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Horse power is invalid!");
                horsePower = value;
            }
        }
    }
}
