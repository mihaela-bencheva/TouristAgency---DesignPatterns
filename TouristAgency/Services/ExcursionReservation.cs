using AbstractFactory.Abstractions;
using FlyWeight;
using System;
using System.Collections.Generic;
using System.Text;

namespace TouristAgency.Services
{
    public class ExcursionReservation
    {
        private readonly List<Excursion> _excursions;
        private AdditionalInformation information;
        public ExcursionReservation(List<Excursion> excursions)
        {
            _excursions = excursions;
        }

        public void ChooseDestinationById(int excursionID) 
        {
            for (int i = 0; i < _excursions.Count; i++)
            {
                if (_excursions[i].ID == excursionID)
                {
                    if (_excursions[i].DepartureDate > new DateTime(2021, 5, 1) || _excursions[i].ReturnDate > new DateTime(2021, 5, 1))
                    {
                        if (_excursions[i].DepartureDate < new DateTime(2021, 6, 30) || _excursions[i].ReturnDate < new DateTime(2021, 6, 30))
                        {
                            Console.WriteLine("This excursion is postponed. Choose another.");
                            excursionID = int.Parse(Console.ReadLine());
                            i = -1;
                        }
                        else
                        {
                            Console.Clear();
                            GetAdditionalInfo(excursionID);
                            break;
                        }
                    }
                }
                if (excursionID > _excursions.Count || excursionID < 0)
                {
                    Console.WriteLine("Wrong ID");
                    excursionID = int.Parse(Console.ReadLine());
                    i = -1;
                }
            }
        }

        public void GetAdditionalInfo(int excursionID)
        {
            information = new AdditionalInformation(_excursions);
            if (information != null)
            {
                Console.Write("Children under 18 years old: ");
                int childrenCount = int.Parse(Console.ReadLine());
                for (int i = 0; i < childrenCount; i++)
                {
                    information.GetAdditionalInfo("Children");
                }

                Console.Clear();

                Console.Write("Tourists: ");
                int touristsCount = int.Parse(Console.ReadLine());
                for (int i = 0; i < touristsCount; i++)
                {
                    information.GetAdditionalInfo("TouristInfo");
                }

                Console.Clear();

                information.GetExcursionTotalPrice(excursionID);
            }
            else
            {
                Console.WriteLine("Something went wrong...");
            }
        }
    }
}
