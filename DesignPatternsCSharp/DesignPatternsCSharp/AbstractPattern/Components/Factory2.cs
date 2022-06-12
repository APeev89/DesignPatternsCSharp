using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.AbstractPattern.Components
{
    public class Factory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
