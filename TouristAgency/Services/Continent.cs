using AbstractFactory;
using AbstractFactory.Abstractions;
using AbstractFactory.Excursions;
using FlyWeight;
using System;
using System.Collections.Generic;
using System.Text;

namespace TouristAgency.Services
{
    public class Continent
    {
        List<Excursion> excursions;
        ContinentFactory europe = new Europe();
        ContinentFactory africa = new Africa();
        ContinentFactory asia = new Asia();
        ContinentFactory northAmerica = new NorthAmerica();
        ContinentFactory southAmerica = new SouthAmerica();
        ContinentFactory australia = new Australia();

        public List<Excursion> ChooseContinent(string continentName)
        {
            while (continentName != null)
            {
                if (continentName == europe.GetType().Name)
                {
                    Office office = new Office(europe);
                    office.GetExcursionsInfo();
                    excursions = europe.GetExcursions();
                    break;
                }
                else if (continentName == africa.GetType().Name)
                {
                    Office office = new Office(africa);
                    office.GetExcursionsInfo();
                    excursions = africa.GetExcursions();
                    break;
                }
                else if (continentName == asia.GetType().Name)
                {
                    Office office = new Office(asia);
                    office.GetExcursionsInfo();
                    excursions = asia.GetExcursions();
                    break;
                }
                else if (continentName == northAmerica.GetType().Name)
                {
                    Office office = new Office(northAmerica);
                    office.GetExcursionsInfo();
                    excursions = northAmerica.GetExcursions();
                    break;
                }
                else if (continentName == southAmerica.GetType().Name)
                {
                    Office office = new Office(southAmerica);
                    office.GetExcursionsInfo();
                    excursions = southAmerica.GetExcursions();
                    break;
                }
                else if (continentName == australia.GetType().Name)
                {
                    Office office = new Office(australia);
                    office.GetExcursionsInfo();
                    excursions = australia.GetExcursions();
                    break;
                }
                else
                {
                    Console.WriteLine("You've entered a wrong name!");
                    continentName = Console.ReadLine();
                }
            }
            
            return excursions;
        }
    }
}
