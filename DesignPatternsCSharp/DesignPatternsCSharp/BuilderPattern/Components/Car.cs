using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.BuilderPattern.Components
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string BodyStyle { get; set; }
        public string FuelType { get; set; }
        public string Color { get; set; }
        public int Seats { get; set; }
        public string TransmissionType { get; set; }

        public decimal Price { get; set; }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Id: {Id}");
            sb.AppendLine($"Make: {Make} Model: {Model}");
            sb.AppendLine($"Body Style: {BodyStyle}");
            sb.AppendLine($"Fuel Type: {FuelType}, Transmission Type: {TransmissionType}");
            sb.AppendLine($"Seats: {Seats} Color: {Color}");
            sb.AppendLine($"Price: ${Price} ");

            return sb.ToString().TrimEnd(); ;
        }

    }
}
