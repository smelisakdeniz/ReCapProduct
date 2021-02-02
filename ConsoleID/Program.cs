using Business.Concrete;
using DataAccess.Concrete.InMermory;
using System;

namespace ConsoleCar
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager (new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description + " : " + car.DailyPrice);
            }
            
        }
    }
}
