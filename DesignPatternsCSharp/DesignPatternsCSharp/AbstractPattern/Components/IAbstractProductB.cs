using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.AbstractPattern.Components
{
    public interface IAbstractProductB
    {
        string UseProductB();
        string SpecialFunctionProductB(IAbstractProductA function);
    }
}
