using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{Id=1, BrandId=1, ColorId=5, ModelYear=2015, DailyPrice=600, Description="Wolksvagen Polo"},
                new Car{Id=2, BrandId=2, ColorId=4, ModelYear=2018, DailyPrice=500, Description="Fiat Egea"},
                new Car{Id=3, BrandId=3, ColorId=3, ModelYear=2020, DailyPrice=800, Description="Ford Focus"},
                new Car{Id=4, BrandId=4, ColorId=2, ModelYear=2012, DailyPrice=400, Description="Dacia Sandero"},
                new Car{Id=5, BrandId=2, ColorId=1, ModelYear=2006, DailyPrice=350, Description="Fiat Egea"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
