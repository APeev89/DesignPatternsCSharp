using DesignPatternsCSharp.BuilderPattern.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.BuilderPattern
{
    public class BuilderPattern
    {
        ICarBuilder carBuilder = new CarBuilder();
        Car car;


        public string Print()
        {
            car = carBuilder.HasId(1)
            .MakingBy("Ford")
            .ModelType("Mustang")
            .WithTransmission("Manual")
            .WithBodyStyle("Coupe")
            .WithFuel("Petrol")
            .WithSeats(4)
            .WithColor("Black")
            .TotalPrice(50000).Car;

            return car.ToString();
        }
            
    }
}
