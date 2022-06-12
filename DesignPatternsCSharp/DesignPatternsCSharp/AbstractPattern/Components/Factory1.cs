using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.AbstractPattern.Components
{
    public class Factory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
