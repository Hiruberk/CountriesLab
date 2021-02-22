using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountriesLab.Models
{
    public class Country
    {
        public string Name { get; set; }
        public string Lang { get; set; }
        public string Greet { get; set; }
        public string Description { get; set; }
        public string[] Colors { get; set; }

        public Country()
        {

        }

        public Country(string Name, String Lang, string Greet, string Description, string[] Colors)
        {
            this.Name = Name;
            this.Lang = Lang;
            this.Greet = Greet;
            this.Description = Description;
            this.Colors = Colors;
        }
    }
}
