using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _4_List
{
    public class CsvReader
    {
        private string _csvFilePath;

        public CsvReader(string csvFilePath)
        {
            _csvFilePath = csvFilePath;
        }

        public Dictionary<string, City> ReadAllCities()
        {
            var citys = new Dictionary<string, City>();

            using (StreamReader streamReader = new StreamReader(_csvFilePath))
            {
                //read header here
                streamReader.ReadLine();

                string csvLine;
                while((csvLine = streamReader.ReadLine()) != null)
                {
                    
                    City city = ReadCityFromCsvLine(csvLine);
                    citys.Add(city.CityCode, city);
                }

            }
            return citys;
        }
        public City ReadCityFromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(new char[] { ',' }); //string[] parts = csvLine.Split(','); - też by zadziałało


            string cityName = parts[0];
            string cityCode = parts[1];
            string country = parts[2];
            int totalPopulation = int.Parse(parts[3]);
            int menPopulation = int.Parse(parts[4]);
            int womenPopulation = int.Parse(parts[5]);

            return new City(cityName, cityCode, country, totalPopulation, menPopulation, womenPopulation);
        }
    }
}
