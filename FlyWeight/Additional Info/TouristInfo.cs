using FlyWeight.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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
            bool flag = false;

            Regex regexPhone = new Regex(@"0[8-9][7-9][0-9]{7}");
            Match matchPhone = regexPhone.Match(phoneNumber);

            while (flag == false)
            {
                if (!matchPhone.Success)
                {
                    Console.WriteLine("Invalid phone number! Try Again: ");
                    phoneNumber = Console.ReadLine();
                    matchPhone = regexPhone.Match(phoneNumber);
                }
                else
                {
                    flag = true;
                }
            }

            Console.Write("Enter an email address: ");
            string email = Console.ReadLine();
            bool isEmailValid = false;

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);

            while (isEmailValid == false)
            {
                if (!match.Success)
                {
                    Console.WriteLine("Invalid email address! Try Again: ");
                    email = Console.ReadLine();
                    match = regex.Match(email);
                }
                else
                {
                    isEmailValid = true;
                }
            }

            return tourist + " " + phoneNumber + " " + email;
        }
    }
}
