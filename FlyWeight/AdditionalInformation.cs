using AbstractFactory.Abstractions;
using FlyWeight.Additional_Info;
using FlyWeight.Interfaces;
using Mediator;
using Mediator.Participants;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlyWeight
{
    public class AdditionalInformation
    {
        private readonly Dictionary<string, IInformation> additionalInfos = new Dictionary<string, IInformation>();
        private readonly List<Excursion> _excursions;
        private readonly List<string> touristsInfo = new List<string>();
        string touristInfo;

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
                touristInfo = information.GetInformation();
                touristsInfo.Add(touristInfo);
            }
            else
            {
                if (infoType == "Children")
                {
                    information = new Children();
                    touristInfo = information.GetInformation();
                    touristsInfo.Add(touristInfo);
                    additionalInfos.Add(infoType, information);
                }
                else
                    if (infoType == "TouristInfo")
                {
                    information = new TouristInfo();
                    touristInfo = information.GetInformation();
                    touristsInfo.Add(touristInfo);
                    additionalInfos.Add(infoType, information);
                }
            }
            return information;
        }

        public void GetExcursionTotalPrice(int ID, int childrenCount, int touristsCount)
        {
            double totalExcursionSum = 0;

            for (int i = 0; i < _excursions.Count; i++)
            {
                if (_excursions[i].ID == ID)
                {
                    totalExcursionSum = (_excursions[i].Price - (_excursions[i].Price * 0.6)) * childrenCount
                        + (touristsCount * _excursions[i].Price);


                    Console.WriteLine("Where: {0}", _excursions[i].Destination);
                    Console.WriteLine("When: {0}", _excursions[i].DepartureDate);
                    Console.WriteLine("To When: {0}", _excursions[i].ReturnDate);
                    Console.WriteLine("Price: {0}", _excursions[i].Price + "$");
                    Console.WriteLine("Tourist Guide: {0}", _excursions[i].TouristGuide);
                    Console.WriteLine("Transport: {0}", _excursions[i].Transport);
                }
            }

            Console.WriteLine();

            for (int i = 0; i < touristsInfo.Count; i++)
            {
                Console.WriteLine("Tourist Information: {0}", touristsInfo[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Total Price: {0}", Math.Round(totalExcursionSum, 2) + "$");
            Console.WriteLine();
        }
    }
}
