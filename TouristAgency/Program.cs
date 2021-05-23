using AbstractFactory;
using AbstractFactory.Abstractions;
using AbstractFactory.Excursions;
using FlyWeight;
using Mediator;
using System;
using System.Collections.Generic;
using TouristAgency.Services;

namespace TouristAgency
{
    public class Program
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
        }
    }
}
