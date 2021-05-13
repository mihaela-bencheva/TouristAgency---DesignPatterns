using AbstractFactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Excursions
{
    public class SouthAmerica : ContinentFactory
    {
        public override List<Excursion> GetExcursions()
        {
            throw new NotImplementedException();
        }
    }
}
