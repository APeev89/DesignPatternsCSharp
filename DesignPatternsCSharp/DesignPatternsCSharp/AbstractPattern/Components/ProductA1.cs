﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.AbstractPattern.Components
{
    public class ProductA1 : IAbstractProductA
    {
        public string UseProductA()
        {
            return "Result from product A-1";
        }
    }
}
