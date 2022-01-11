using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace task15.Models
{
    public class City
    {
        public long ID { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public Country Country { get; set; }
        [NotMapped]
        public string CountryName
        {
            get
            {
                return this.Country?.Name;
            }
        }

        public City()
        {

        }
    }
}
