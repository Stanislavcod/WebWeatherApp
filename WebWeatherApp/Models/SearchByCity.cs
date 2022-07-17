using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebWeatherApp.Models
{
    public class SearchByCity
    {
        [Required(ErrorMessage = "Oops! The city was not found")]
        [Display(Name = "City:")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Invalid Input, Lenght must be between  2 to 20 character")]
        public string CityName { get; set; }

        public string Name { get; set; }
        [Display(Name = "Temp")]
        public float Temp { get; set; }
        [Display(Name = "Humidity")]
        public double Humidity { get; set; }
        [Display(Name = "Pressure")]
        public double Pressure { get; set; }
        [Display(Name = "Wind Speed")]
        public float Wind { get; set; }
        [Display(Name = "Weather Condition")]
        public string Weather { get; set; }
    }
}
