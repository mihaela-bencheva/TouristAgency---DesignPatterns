using AbstractFactory.Abstractions;
using FlyWeight.Additional_Info;
using FlyWeight.Interfaces;
using System;
using System.Collections.Generic;

namespace FlyWeight
{
    public class AdditionalInformation
    {
        private readonly Dictionary<string, IInformation> additionalInfos = new Dictionary<string, IInformation>();
        private readonly List<Excursion> _excursions;
        private readonly List<string> tourists = new List<string>();
        string touristName;

        public AdditionalInformation(List<Excursion> excursions)
        {
            _excursions = excursions;
        }
        public IInformation GetAdditionalInfo(string infoType)
        {
            IInformation information = null;

            if (additionalInfos.ContainsKey(infoType))
            {
                information = additionalInfos[infoType];
                touristName = information.GetInformation();
                tourists.Add(touristName);
            }
            else
            {
                if (infoType == "Children")
                {
                    information = new Children();
                    touristName = information.GetInformation();
                    tourists.Add(touristName);
                    additionalInfos.Add(infoType, information);
                }
                else
                    if (infoType == "TouristInfo")
                {
                    information = new TouristInfo();
                    touristName = information.GetInformation();
                    tourists.Add(touristName);
                    additionalInfos.Add(infoType, information);
                }
            }
            return information;
        }

        public void GetExcursionTotalPrice(int ID)
        {
            int childrenCount = 0;
            int touristCount = 0;
            double totalExcursionSum = 0;

            if (additionalInfos.ContainsKey("Children"))
            {
                childrenCount = additionalInfos.Count;
            }
            if (additionalInfos.ContainsKey("TouristInfo"))
            {
                touristCount = additionalInfos.Count;
            }

            for (int i = 0; i < _excursions.Count; i++)
            {
                if (_excursions[i].ID == ID)
                {
                    totalExcursionSum = (_excursions[i].Price - (_excursions[i].Price * 0.6)) * childrenCount
                        + (touristCount * _excursions[i].Price);


                    Console.WriteLine("Where: {0}", _excursions[i].Destination);
                    Console.WriteLine("When: {0}", _excursions[i].DepartureDate);
                    Console.WriteLine("To When: {0}", _excursions[i].ReturnDate);
                    Console.WriteLine("Price: {0}", _excursions[i].Price);
                    Console.WriteLine("Tourist Guide: {0}", _excursions[i].TouristGuide);
                    Console.WriteLine("Transport: {0}", _excursions[i].Transport);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Total Price: {0}", Math.Round(totalExcursionSum, 2));
        }
    }
}
