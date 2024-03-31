namespace CarsManagement.Tests
{
    using Microsoft.EntityFrameworkCore;
    using Moq;
    using NUnit.Framework;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore.ChangeTracking;
    using System.Linq.Expressions;
    using CarsManagement.Data.Models;
    using CarsManagement.Services;
    using CarsManagement.Data;

    public class Tests
    {
        private List<Car> carList = new List<Car>();
        private IQueryable<Car> dbTable = null;
        private CarsService service = null;
        private Mock<AppDbContext> mockContext = null;
        private Mock<DbSet<Car>> mockSet = null;

        [SetUp]
        public void Setup()
        {
            // ?????????????? ?? ??????? ? ???????
            carList = new List<Car>();
            for (int i = 1; i <= 5; i++)
            {
                carList.Add(new Car() { ID = i, Model = $"Model {i}" });
            }

            // ?????????? ?? ??????? ? IQueryable
            dbTable = carList.AsQueryable();

            // ??????????? (Mocking) ?? DbSet<Ganre>
            mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(dbTable.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(dbTable.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(dbTable.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(() => carList.GetEnumerator());

            // ??????????? ?? ?????? Add
            mockSet.Setup(m => m.Add(It.IsAny<Car>())).Callback<Car>(car => carList.Add(car));

            // ?????????????? ? ????????? ?? ???????????? ????????
            mockContext = new Mock<AppDbContext>();
            mockContext.Setup(p => p.Cars).Returns(mockSet.Object);

            // ?? ? ????? ?? ?? ????????? ??????? Any, ??? ???? LINQ ?????????? ?? ??????? ????? ???????????? DbSet

            // ??????????? ?? SaveChanges
            mockContext.Setup(m => m.SaveChanges()).Returns(1);

            // ?????????????? ?? ??????? ? ???????????? ????????
            service = new CarsService(mockContext.Object);
        }



        [Test]
        public void GetGanresCountTest()
        {
            // Arrange
            var expected = carList.Count;

            // Act
            var actual = service.GetCarsCount();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void AddGanreWithInvalidNameTest()
        {
            // Arrange
            // Act


            var ex = Assert.Throws<ArgumentException>(() => service.Add(new Car() { Model = "" }));

            // Assert
            Assert.AreEqual(ex.Message, "Invalid car name!");
        }

        [Test]
        public void AddGanreWithSameNameTest()
        {
            // Arrange
            // Act


            var ex = Assert.Throws<ArgumentException>(() => service.Add(new Car() { Model = "Car 1" }));

            // Assert
            Assert.AreEqual(ex.Message, "Car already exist!");
        }

        [Test]
        public void GetGanreByNameTest()
        {
            // Arrange
            var expected = carList[0];

            // Act
            var actual = service.GetCarsByName("Car 1");

            // Assert
            Assert.That(actual.Model, Is.EqualTo(expected.Model));
        }

        [Test]
        public void GetAllGanreTest()
        {
            // Arrange
            var expected = carList.Count;

            // Act
            var actual = service.GetAllCars();

            // Assert
            Assert.That(actual.Count, Is.EqualTo(expected));
        }

        [Test]
        public void GetGanresIdTest()
        {
            // Arrange
            var expected = new int[] { 1, 2, 3, 4, 5 };

            // Act
            var actual = service.GetCarsId();

            // Assert
            Assert.That(actual, Is.EquivalentTo(expected)); 
        }

    }
}