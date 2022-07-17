﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebWeatherApp.Models
{
    public class City
    {
        [Display(Name = "City:")]
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
        public string Weather{ get; set; }
    }
}
