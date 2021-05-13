using AbstractFactory;
using AbstractFactory.Abstractions;
using AbstractFactory.Excursions;
using FlyWeight;
using System;
using System.Collections.Generic;
using TouristAgency.Services;

namespace TouristAgency
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter a continent name: ");
            string continentName = Console.ReadLine();

            Continent continent = new Continent();

            List<Excursion> excursions = continent.ChooseContinent(continentName);
            

            Console.WriteLine("Choose an excursion: ");
            int excursionID = int.Parse(Console.ReadLine());

            ExcursionReservation reservation = new ExcursionReservation(excursions);
            reservation.ChooseDestinationById(excursionID);

            //ServerMediator server = new ServerMediator();

            //Staff staff = new Staff(server);
            //Client client = new Client(server);

            //server.Staff = staff;
            //server.Client = client;

            //staff.Send("Are you sure you want to reserve this excursion?");

            //string message = Console.ReadLine();
            //client.Send(message);
        }
    }
}
