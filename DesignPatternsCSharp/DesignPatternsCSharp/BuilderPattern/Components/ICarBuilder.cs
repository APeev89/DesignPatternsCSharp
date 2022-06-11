using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.BuilderPattern.Components
{
    public interface ICarBuilder
    {
        Car Car { get; }

        ICarBuilder HasId(int id);
        ICarBuilder MakingBy(string make);
        ICarBuilder ModelType(string model);
        ICarBuilder WithBodyStyle(string body);
        ICarBuilder WithFuel(string fuel);
        ICarBuilder WithColor(string color);
        ICarBuilder WithSeats(int seats);
        ICarBuilder WithTransmission(string transmission);
        ICarBuilder TotalPrice(decimal price);
    }
}
