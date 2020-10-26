using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using CityProvince.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CityProvince.Models
{
    public class City
    {
        public int CityId { get; set; }
        [Display(Name = "City")]
        public string CityName { get; set; }
        public int Population { get; set; }
        
        
        public string ProvinceCode { get; set; }
        [ForeignKey("ProvinceCode")]

        public Province Province {get; set; }

        public static List<City> GetCities()
        {
            List<City> cities = new List<City>()
            {
                new City
                {
                    CityId = 1,
                    CityName = "Vancouver",
                    Population = 2100000,
                    ProvinceCode = "BC"
                },
                new City
                {
                    CityId = 2,
                    CityName = "Kelowna",
                    Population = 500000,
                    ProvinceCode = "BC"
                },
                new City
                {
                    CityId = 3,
                    CityName = "Smithers",
                    Population = 400000,
                    ProvinceCode = "BC"
                },
                new City
                {
                    CityId = 4,
                    CityName = "Edmonton",
                    Population = 1500000,
                    ProvinceCode = "AB"
                },
                new City
                {
                    CityId = 5,
                    CityName = "Lethbridge",
                    Population = 100000,
                    ProvinceCode = "AB"
                },
                new City
                {
                    CityId = 6,
                    CityName = "Calgary",
                    Population = 1700000,
                    ProvinceCode = "AB"
                },
                new City
                {
                    CityId = 7,
                    CityName = "Regina",
                    Population = 2000000,
                    ProvinceCode = "SA"
                },
                new City
                {
                    CityId = 8,
                    CityName = "Saskatoon",
                    Population = 1000000,
                    ProvinceCode = "SA"
                },
                new City
                {
                    CityId = 9,
                    CityName = "Moose Jaw",
                    Population = 10000,
                    ProvinceCode = "SA"
                }
            };
            return cities;
        }
    }
}
