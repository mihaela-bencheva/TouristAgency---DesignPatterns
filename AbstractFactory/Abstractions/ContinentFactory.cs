using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Abstractions
{
    public abstract class ContinentFactory
    {
        public abstract List<Excursion> GetExcursions();
    }
}
