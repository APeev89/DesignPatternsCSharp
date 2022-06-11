using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.BuilderPattern.Components
{
    public class CarBuilder : ICarBuilder
    {
        private Car car;

        public CarBuilder()
        {
            this.car = new Car();
        }
        public Car Car => this.car;

        public ICarBuilder HasId(int id)
        {
            this.car.Id = id;
            return this;
        }

        public ICarBuilder MakingBy(string make)
        {
            this.car.Make = make;
            return this; 
        }

        public ICarBuilder ModelType(string model)
        {
            this.car.Model = model;
            return this;
        }

        public ICarBuilder TotalPrice(decimal price)
        {
            this.car.Price = price;
            return this;
        }

        public ICarBuilder WithBodyStyle(string body)
        {
            this.car.BodyStyle = body;
            return this;
        }

        public ICarBuilder WithColor(string color)
        {
            this.car.Color = color;
            return this;
        }

        public ICarBuilder WithFuel(string fuel)
        {
            this.car.FuelType = fuel;
            return this;
        }

        public ICarBuilder WithSeats(int seats)
        {
            this.car.Seats = seats;
            return this;
        }

        public ICarBuilder WithTransmission(string transmission)
        {
            this.car.TransmissionType = transmission;
            return this;
        }
    }
}
