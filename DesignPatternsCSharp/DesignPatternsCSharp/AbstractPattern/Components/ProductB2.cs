using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.AbstractPattern.Components
{
    public class ProductB2 : IAbstractProductB
    {
        public string UseProductB()
        {
            return "Result from product B-2";
        }
        public string SpecialFunctionProductB(IAbstractProductA function)
        {
            var result = function.UseProductA();
            return $"Return special functionality B-2 whit {function.UseProductA()}";
        }

       
    }
}
