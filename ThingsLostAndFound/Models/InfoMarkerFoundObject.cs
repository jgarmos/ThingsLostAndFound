﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThingsLostAndFound.Models
{
    public class InfoMarkerFoundObject
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public int Id { get; set; }
        public int UserIdreported { get; set; }
        public System.DateTime Date { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string SerialID { get; set; }
        public string Title { get; set; }
        public string Color { get; set; }
        public string Observations { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string LocationObservations { get; set; }
        public string Location { get; set; }
        public string CityTownRoad { get; set; }
    }
}