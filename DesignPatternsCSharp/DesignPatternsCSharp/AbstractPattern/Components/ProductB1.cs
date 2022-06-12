using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.AbstractPattern.Components
{
    public class ProductB1 : IAbstractProductB
    {
        public string UseProductB()
        {
            return "Result from product B-1";
        }

        public string SpecialFunctionProductB(IAbstractProductA function)
        {
            var result = function.UseProductA();
            return $"Return special functionality B-1 whit {function.UseProductA()}";
        }

    } 
}
