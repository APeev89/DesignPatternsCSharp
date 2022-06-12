using DesignPatternsCSharp.AdapterPattern.Componets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.AdapterPattern
{
    public class AdapterPattern
    {

        private readonly EUStandart eu;
        private readonly IUSAdapter usa;

        public AdapterPattern()
        {
            eu = new EUStandart();
            usa = new Adapter(eu);
        }


        public string Print()
        {
            return this.usa.USExit();
        }

    }
}
