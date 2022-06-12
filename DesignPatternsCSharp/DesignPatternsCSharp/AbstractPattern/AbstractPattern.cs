using DesignPatternsCSharp.AbstractPattern.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.AbstractPattern
{
    public class AbstractPattern
    {
        public void Main()
        {
            Console.WriteLine("Factory 1:");
            ClientMethod(new Factory1());
            Console.WriteLine();
            Console.WriteLine("Factory 2:");
            ClientMethod(new Factory2());

            
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();


            Console.WriteLine(productA.UseProductA());
            Console.WriteLine(productB.SpecialFunctionProductB(productA));
            
        }
    }
}
