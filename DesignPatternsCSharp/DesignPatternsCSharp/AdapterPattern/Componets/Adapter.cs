using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.AdapterPattern.Componets
{
    public class Adapter : IUSAdapter
    {
        private readonly EUStandart _europe;

        public Adapter(EUStandart europe)
        {
            _europe = europe;
        }
        public string USExit()
        {
            return $"You can put this US adapter on {this._europe.StandardExit()} ";
        }
    }
}
