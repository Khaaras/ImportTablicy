
using _4_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            string filePath = @"I:\Programowanie\Kurs Udemy c#\_1_Array\ImportCSV.csv";

            CsvReader csvReader = new CsvReader(filePath);

            Dictionary<string, City> citys = csvReader.ReadAllCities();

            Console.WriteLine("Which city code do you want to search for? ");
            string userInput = Console.ReadLine();

            bool getCity = citys.TryGetValue(userInput, out City city);
            if (!getCity)
            {
                Console.WriteLine($"There is no city with code {userInput}");
            }
            else
                Console.WriteLine($"{city.TotalPopulation: ### ### ###} : {city.CityCode} : {city.CityName}");

            
            //City slaskie = new City("Slaskie", "SLA", "Polska", 4524091, 2180662, 2343429);
            //City malopolskie = new City("Malopolskie", "MLP", "Polska", 3404863, 1652663, 1752200);

            //var citys = new Dictionary<string, City>
            //{
            //    //Dictionary<string, City> citys = new Dictionary<string, City>(); - równoznaczne z tym co na górze, ale jest dłuższe

            //    { slaskie.CityCode, slaskie },
            //    { malopolskie.CityCode, malopolskie }
            //};

            //var searchedCity = citys.TryGetValue("MLP", out City city);


            //if (searchedCity)
            //    Console.WriteLine(city.CityName);
            //else
            //    Console.WriteLine("Nie ma takiego miasta");

            //citys.Remove(malopolskie.CityCode);

            //citys[slaskie.CityCode] = malopolskie;
            //Console.WriteLine("TEST  " + slaskie.CityCode);

            //bool exists = citys.ContainsKey(malopolskie.CityCode);


            //Console.WriteLine("TEST 2 " + exists);

            //foreach (var city2 in citys.Values)
            //{
            //    Console.WriteLine(city2.CityName);
            //    Console.WriteLine(city2.CityCode);
            //    Console.WriteLine(city2.Country);
            //    Console.WriteLine(city2.TotalPopulation);
            //    Console.WriteLine(city2.MenPopulation);
            //    Console.WriteLine(city2.WomenPopulation);
            //}


            //foreach (var city in citys.Values)
            //{
            //    Console.WriteLine(city.CityName);
            //}

            //foreach (var city in citys)
            //{
            //    Console.WriteLine(city.Value.CityName); -to to samo co wyżej
            //}
        }
    }
}
