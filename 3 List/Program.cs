using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_List
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //List<string> months = new List<string>
            //{
            //"January",
            //"February",
            //"March",
            //"April",
            //"May",
            //"June",
            //"July",
            //"August",
            //"September",
            //"October",
            //"November",
            //"December",
            //}; 

            string filePath = @"C:\C# 2019 Łukaszenko\Programowanie\Kurs Udemy c#\ImportTablicy\ImportCSV.csv";

            CsvReader csvReader = new CsvReader(filePath);

            List<City> citys = csvReader.ReadAllCities();

            City cititest = new City("Test", "Tes", "Pol", 3000000, 1600000, 1400000);

            int index = citys.FindIndex(city => city.TotalPopulation < 3000000);
            citys.Insert(index, cititest);
            //citys.RemoveAt(0);
            citys.Remove(cititest);

            foreach (var city in citys)
            {
                Console.WriteLine($"{city.TotalPopulation: ### ### ###} : {city.CityCode} : {city.CityName}");
            }

            Console.WriteLine($"{citys.Count()} cities");

            citys.RemoveAt(4);
        }
    }
}
