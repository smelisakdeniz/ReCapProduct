using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMermory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {CarId=1,ColorId=2,BrandId=3,ModelYear=2020, DailyPrice=475000, Description="Mercedes A200" },
                new Car {CarId=2,ColorId=2,BrandId=3,ModelYear=2020, DailyPrice=680000, Description="Mercedes C200 4MATIC" },
                new Car {CarId=3,ColorId=2,BrandId=3,ModelYear=2020, DailyPrice=116800, Description="Mercedes GLC" },
                new Car {CarId=4,ColorId=2,BrandId=3,ModelYear=2020, DailyPrice=5386400, Description="Mercedes Mercedes-AMG GT R Coupé" },

            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => car.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
