using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public class City
{
    public string CityName { get; set; }
    public string CountryName { get; set; }
    public int Population { get; set; }
    public string PhoneCode { get; set; }
    public string DistrictNames { get; set; }

    public void InputData(string cityName, string countryName, int population, string phoneCode, string districtNames)
    {
        CityName = cityName;
        CountryName = countryName;
        Population = population;
        PhoneCode = phoneCode;
        DistrictNames = districtNames;
    }

    public void OutputData()
    {
        Console.WriteLine($"Название города: {CityName}");
        Console.WriteLine($"Название страны: {CountryName}");
        Console.WriteLine($"Количество жителей: {Population}");
        Console.WriteLine($"Телефонный код города: {PhoneCode}");
        Console.WriteLine($"Название районов города: {DistrictNames}");
    }

    public static City operator +(City city, int increase)
    {
        city.Population += increase;
        return city;
    }

    public static City operator -(City city, int decrease)
    {
        city.Population -= decrease;
        return city;
    }

    public static bool operator ==(City city1, City city2)
    {
        return city1.Population == city2.Population;
    }

    public static bool operator !=(City city1, City city2)
    {
        return !(city1 == city2);
    }

    public static bool operator <(City city1, City city2)
    {
        return city1.Population < city2.Population;
    }

    public static bool operator >(City city1, City city2)
    {
        return city1.Population > city2.Population;
    }

    public override bool Equals(object obj)
    {
        if (obj is City city)
        {
            return Population == city.Population;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Population.GetHashCode();
    }
}

