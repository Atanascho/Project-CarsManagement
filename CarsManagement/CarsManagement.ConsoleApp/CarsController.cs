namespace CarsManagement.ConsoleApp
{
    using CarsManagement.Data.Models;
    using CarsManagement.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    //Клас CarsController който извършва всички функционалности
    public class CarsController
    {
        private CarsService carsService = new CarsService();

        private int currentPage = 1;
        private int itemsPerPage = 10;
        private int pageCount = 0;
        private int totalItems = 0;
        private bool ascSort = true;

        public void Action()
        {
            UpdatePagination();
            while (true)
            {
                Console.Clear();
                try
                {
                    PrintGanres();

                    Console.WriteLine("[A]dd; [P]revious; [N]ext; [E]dit; [D]elete; [S]ort; [I]tems per page");

                    string cmd = GetCmd();

                    switch (cmd)
                    {
                        case "A":
                        case "ADD":
                            AddAction();
                            break;
                        case "P":
                        case "PREVIOUS":
                            PreviousAction();
                            return;
                        case "N":
                        case "NEXT":
                            NextAction();
                            break;
                        case "E":
                        case "EDIT":
                            EditAction();
                            break;
                        case "D":
                        case "DELETE":
                            DeleteAction();
                            break;
                        case "S":
                        case "Sort":
                            SortAction();
                            break;
                        case "I":
                        case "Items":
                            ChangePaginationAction();
                            break;
                        default:
                            throw new InvalidOperationException("Invalid command!");
                    }
                }
                catch (Exception ex)
                {
                    ExceptionAction(ex);
                }
            }
        }

        //Метод за отпечатване на exception-и
        private static void ExceptionAction(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Метод за сменяне на Items per page
        private void ChangePaginationAction()
        {
            Console.Write("Enter items per page: ");
            itemsPerPage = int.Parse(Console.ReadLine());
            Console.WriteLine($"Items per page is set to {itemsPerPage}!");
            Thread.Sleep(2000);
            UpdatePagination();
        }

        //метод за сортиране
        private void SortAction()
        {
            ascSort = !ascSort;
        }

        // метод за триене на коли
        private void DeleteAction()
        {
            Console.Write("Enter id: ");
            int deleteId = int.Parse(Console.ReadLine());
            carsService.DeleteCar(deleteId);
            Console.WriteLine($"Car with id {deleteId} is deleted!");
            Thread.Sleep(2000);
            UpdatePagination();
        }

        // метод за преработване на коли
        private void EditAction()
        {
            Console.Write("Enter car id: ");
            int editId = int.Parse(Console.ReadLine());
            Console.Write("Enter name: ");
            string newName = Console.ReadLine();
            Console.Write("Enter color: ");
            string color = Console.ReadLine();
            Console.Write("Enter horse power: ");
            int hp = int.Parse(Console.ReadLine());
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            carsService.EditModel(editId, newName, color, hp, year);
            Console.WriteLine($"Car with id {editId} is updated!");
            Thread.Sleep(2000);
        }

        // метод за прелистване на следваша страница
        private void NextAction()
        {
            if ((currentPage + 1) <= pageCount) { currentPage++; }
            else { currentPage = 1; }
        }

        // метод за прелистване на предишната страница
        private void PreviousAction()
        {
            if ((currentPage - 1) > 0) { currentPage--; }
            else { currentPage = pageCount; }
        }

        // метод за добавяне на модели
        private void AddAction()
        {
            Console.Write("Enter car name: ");
            string name = Console.ReadLine();
            Console.Write("Enter car color: ");
            string color = Console.ReadLine();
            Console.Write("Enter car horse power: ");
            int hp = int.Parse(Console.ReadLine());
            Console.Write("Enter car year: ");
            int year = int.Parse(Console.ReadLine());

            int id = carsService.Add(new Car() { Model = name, Color = color, HorsePower = hp, Year = year });
            Console.WriteLine($"Car with id {id} and model {name} is created!");
            Thread.Sleep(2000);
            UpdatePagination();
        }

        // метод за четене на въведена от конзолата команда
        private static string GetCmd()
        {
            Console.Write("Enter command: ");
            string cmd = Console.ReadLine().ToUpper();
            return cmd;
        }

        // метод за обновяване на страницирането
        private void UpdatePagination()
        {
            totalItems = carsService.GetCarsCount();
            pageCount = (int)Math.Ceiling((double)totalItems / itemsPerPage);
        }

        // метод за отпечатване на жанровете
        private void PrintGanres()
        {
            List<Car> carList = carsService.GetCars(currentPage, itemsPerPage, ascSort);
            string head = $"| {"Id",4} | {"Name",10} |";

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"{new string('-', head.Length)}");
            Console.WriteLine(head);
            Console.WriteLine($"|{new string('-', head.Length - 2)}|");
            foreach (var g in carList)
            {
                Console.WriteLine($"| {g.ID,4} | {string.Join("", g.Model.Take(10)),10} |");
            }
            Console.WriteLine($"{new string('-', head.Length)}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{currentPage}/{pageCount}, ganres count: {totalItems}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
