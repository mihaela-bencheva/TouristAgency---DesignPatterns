using FlyWeight.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight.Additional_Info
{
    public class Children : IInformation
    {
        public string GetInformation()
        {
            Console.Write("Enter a child's name: ");
            string children = Console.ReadLine();
            return children;
        }
    }
}
