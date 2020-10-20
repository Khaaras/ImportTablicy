using System;

namespace _2_ImportDanychZPliku
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Programowanie\Kurs Udemy c#\ConsoleApp1\ImportCSV.csv";

            CsvReader csvReader = new CsvReader(filePath);

            City[] citys = csvReader.ReadFirstNCitys(6);

            foreach (var city in citys)
            {
                Console.WriteLine($"{city.TotalPopulation: ### ### ###} : {city.CityCode} : {city.CityName}");
            }
        }
    }
}
