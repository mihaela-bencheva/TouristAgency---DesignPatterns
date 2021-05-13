using FlyWeight.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight.Additional_Info
{
    public class TouristInfo : IInformation
    {
        public string GetInformation()
        {
            Console.Write("Enter a tourist's name: ");
            string tourist = Console.ReadLine();

            Console.Write("Enter the tourist's phone number: ");
            string phoneNumber = Console.ReadLine();
            return tourist + phoneNumber;
        }
    }
}
