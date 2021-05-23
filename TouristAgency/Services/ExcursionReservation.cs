using AbstractFactory.Abstractions;
using FlyWeight;
using Mediator;
using Mediator.Participants;
using System;
using System.Collections.Generic;
using System.Text;

namespace TouristAgency.Services
{
    public class ExcursionReservation
    {
        private readonly List<Excursion> _excursions;
        private AdditionalInformation information;
        private readonly ServerMediator mediator;
        private readonly Staff staff;
        private readonly Client client;
        public ExcursionReservation(List<Excursion> excursions)
        {
            _excursions = excursions;
            mediator = new ServerMediator();
            staff = new Staff(mediator);
            client = new Client(mediator);
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

                mediator.Staff = staff;
                mediator.Client = client;

                staff.Send("Are you sure you want to reserve this trip? Yes/ No: ");
                var message = Console.ReadLine();
                if (message == "Yes")
                {
                    client.Send(message);
                }
                else if (message == "No")
                {
                    Console.Clear();
                    Console.Write("Enter a continent name: ");
                    string continentName = Console.ReadLine();

                    Continent continent = new Continent();

                    List<Excursion> excursions = continent.ChooseContinent(continentName);


                    Console.WriteLine("Choose an excursion: ");
                    int newexcursionID = int.Parse(Console.ReadLine());

                    ExcursionReservation reservation = new ExcursionReservation(excursions);
                    reservation.ChooseDestinationById(newexcursionID);
                }
                else
                {
                    Console.WriteLine("Something went wrong...");
                }
            }
            else
            {
                Console.WriteLine("Something went wrong...");
            }
        }
    }
}
