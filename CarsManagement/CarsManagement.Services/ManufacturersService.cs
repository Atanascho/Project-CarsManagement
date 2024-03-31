using CarsManagement.Data;
using CarsManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsManagement.Services
{
    public class ManufacturersService
    {
        private AppDbContext context = new AppDbContext();

        public ManufacturersService()
        {
            context = new AppDbContext();
        }
        public ManufacturersService(AppDbContext context)
        {
            this.context = context;
        }

        // метод за добавяне на производители
        public int Add(Manufacturer manufacturer)
        {
            if (string.IsNullOrWhiteSpace(manufacturer.BrandName))
            {
                throw new ArgumentException("Invalid brand name!");
            }
            if (context.Cars.Any(x => x.Model == manufacturer.BrandName))
            {
                throw new ArgumentException("Model brand exist!");
            }
            context.Add(manufacturer);
            context.SaveChanges();
            return manufacturer.ID;
        }

        // метод за получаване на идентификационния номер на производителя, ако съществува
        public Manufacturer? GetManufacturerByID(int id)
        {
            return context.Manufacturers.Find(id);
        }

        // метод отпечатване на производители
        public List<Manufacturer> GetManufacturer(int page = 1, int itemsPerPage = 10, bool ascSort = true)
        {
            IQueryable<Manufacturer> result = null;

            if (ascSort)
            {
                result = context.Manufacturers.OrderBy(x => x.BrandName);
            }
            else
            {
                result = context.Manufacturers.OrderByDescending(x => x.BrandName);
            }

            return result
                .Skip((page - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .ToList();
        }

        // метод за връщане на броя на производители
        public int GetManufacturersCount()
        {
            return context.Manufacturers.Count();
        }

        //метод за преработване на производители
        public int EditManufacturer(Manufacturer manufacturer)
        {
            Manufacturer? editManufacturer = this.GetManufacturerByID(manufacturer.ID);
            if (manufacturer == null)
            {
                throw new ArgumentException("Manufacturer not found!");
            }
            if (string.IsNullOrWhiteSpace(manufacturer.BrandName))
            {
                throw new ArgumentException("Invalid name!");
            }
            context.Manufacturers.Update(manufacturer);
            context.SaveChanges();
            return manufacturer.ID;
        }
        public int EditManufacturerCars(Manufacturer manufacturer)
        {
            context.Manufacturers.Update(manufacturer);
            context.SaveChanges();
            return manufacturer.ID;
        }
        // метод за изтриване на производители по идентификационния номер
        public int DeleteManufacturer(int id)
        {
            Manufacturer? manufacturer = context.Manufacturers.Find(id);
            if (manufacturer == null)
            {
                throw new ArgumentException("Manufacturer not found!");
            }
            context.Manufacturers.Remove(manufacturer);
            context.SaveChanges();
            return id;
        }

        // метод за добавяне на кола към производител
        public int AddModelToManufacturer(int id, Car car)
        {
            Manufacturer? manufacturer = context.Manufacturers.Find(id);
            if (manufacturer == null)
            {
                throw new ArgumentException("Manufacturer not found!");
            }
            manufacturer.Cars.Add(car);
            context.Manufacturers.Update(manufacturer);
            context.SaveChanges();
            return id;
        }
    }
}
