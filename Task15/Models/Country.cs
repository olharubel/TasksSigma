using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace task15.Models
{
    public class Country
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public ICollection<City> Cities { get; set; }

        public Country()
        {
            Cities = new HashSet<City>();
        }
    }
}
