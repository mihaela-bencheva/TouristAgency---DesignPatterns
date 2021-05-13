using AbstractFactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Excursions
{
    public class Asia : ContinentFactory
    {
        public override List<Excursion> GetExcursions()
        {
            throw new NotImplementedException();
        }
    }
}
