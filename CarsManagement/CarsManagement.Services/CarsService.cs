namespace CarsManagement.Services
{
    using CarsManagement.Data;
    using CarsManagement.Data.Models;
    using CarsManagement.Services.Enums;
    using System;

    public class CarsService
    {
        // инстанциране на context от тип AppDbContext за да се осъществи връзка с база данни
        private AppDbContext context;

        public CarsService()
        {
            context = new AppDbContext();
        }
        public CarsService(AppDbContext context)
        {
            this.context = context;
        }

        // метод за добавяне на модели
        public int Add(Car car)
        {
            if (string.IsNullOrWhiteSpace(car.Model))
            {
                throw new ArgumentException("Invalid model model!");
            }
            if (context.Cars.Any(x => x.Model == car.Model))
            {
                throw new ArgumentException("Model already exist!");
            }
            context.Add(car);
            context.SaveChanges();
            return car.ID;
        }

        // метод за получаване на идентификационния номер на модела, ако съществува
        public Car? GetCarID(int id)
        {
            return context.Cars.Find(id);
        }
        public Car? GetCarsByName(string model)
        {
            return this.context.Cars.FirstOrDefault(x => x.Model == model);
        }

        // метод отпечатване на моделите
        public List<Car> GetCars(int page = 1, int itemsPerPage = 10, bool ascSort = true)
        {
            IQueryable<Car> result = null;

            if (ascSort)
            {
                result = context.Cars.OrderBy(x => x.Model);
            }
            else
            {
                result = context.Cars.OrderByDescending(x => x.Model);
            }

            return result
                .Skip((page - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .ToList();
        }

        // метод за връщане на броя на моделите
        public int GetCarsCount()
        {
            // POMOSHT
            return context.Cars.Count();
        }
        public int EditModel(int id, string name, string color, int hp, int year)
        {
            Car? car = context.Cars.Find(id);
            if (car == null)
            {
                throw new ArgumentException("Car not found!");
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Invalid model!");
            }
            car.Model = name;
            car.Color = color;
            car.HorsePower = hp;
            car.Year = year;
            context.Cars.Update(car);
            context.SaveChanges();
            return id;
        }

        // метод за изтриване на модел по идентификационния номер
        public int DeleteCar(int id)
        {
            Car? car = context.Cars.Find(id);
            if (car == null)
            {
                throw new ArgumentException("Car not found!");
            }
            context.Cars.Remove(car);
            context.SaveChanges();
            return id;
        }

        // метод за сменяне на цвета на колата
        public int ChangeCarColor(int id, string color)
        {
            Car? car = context.Cars.Find(id);
            if (car == null)
            {
                throw new ArgumentException("Car not found!");
            }
            if (string.IsNullOrWhiteSpace(color))
            {
                throw new ArgumentException("Invalid color!");
            }
            car.Color = color;
            context.Cars.Update(car);
            context.SaveChanges();
            return id;
        }

        // метод за модифициране на конските сили
        public int ModifyEngine(int id, int hp)
        {
            Car? car = context.Cars.Find(id);
            if (car == null)
            {
                throw new ArgumentException("Car not found!");
            }
            if (hp <= 0)
            {
                throw new ArgumentException("Invalid horse power!");
            }
            car.HorsePower = hp;
            context.Cars.Update(car);
            context.SaveChanges();
            return id;
        }

        public string[] Search(CarsSearchBy searchBy, string text)
        {
            IQueryable<Car> result = null;
            switch (searchBy)
            {
                case CarsSearchBy.Model:
                    result = context.Cars.Where(x => x.Model.Contains(text)).Take(10);
                    break;
                case CarsSearchBy.Color:
                    result = context.Cars.Where(x => x.Color.Contains(text)).Take(10);
                    break;
                default:
                    break;
            }
            return result.Select(b => $"{b.Model} - {b.Color} - {b.HorsePower} - {b.Year}").ToArray();
        }
        public List<int> GetCarsId()
        {
            return this.context.Cars.Select(x => x.ID).ToList();
        }
        public string[] GetAllCars()
        {
            return this.context.Cars.Select(x => x.Model).ToArray();
        }
    }
}
