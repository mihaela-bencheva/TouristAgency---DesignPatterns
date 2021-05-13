using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Abstractions
{
    public abstract class Excursion
    {
        public int ID { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Transport { get; set; }
        public double Price { get; set; }
        public string TouristGuide { get; set; }
    }
}
