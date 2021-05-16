using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using StarWarsApiCSharp;

namespace NSS_Code_Challenge_CSharp
{
    public class LukeSkyWalker : Person
    {
        public IEnumerable<string> StarshipsFormatted { get; set; }
        
        public IEnumerable<string> FilmsFormatted { get; set; }
        
        public IEnumerable<string> SpeciesFormatted { get; set; }
        
        public IEnumerable<string> VehiclesFormatted { get; set; }
        
        public override string ToString()
        {
            return this.Name + Environment.NewLine +
                   "Height: " + this.Height + Environment.NewLine + 
                   "Mass: " + this.Mass + Environment.NewLine + 
                   "Hair Color: " + this.HairColor + Environment.NewLine +
                   "Skin Color: " + this.SkinColor + Environment.NewLine +
                   "Eye Color: " + this.EyeColor + Environment.NewLine +
                   "Birth year: " + this.BirthYear + Environment.NewLine +
                   "Gender: " + this.Gender + Environment.NewLine +
                   "Home World: " + this.Homeworld + Environment.NewLine +
                   "Films: " + String.Join(", ", this.FilmsFormatted) + Environment.NewLine +
                   "Species: " + String.Join(", ", this.SpeciesFormatted) + Environment.NewLine +
                   "Vehicles: " + String.Join(", ", this.VehiclesFormatted) + Environment.NewLine +
                   "Star Ships: " + String.Join(", ", this.StarshipsFormatted)  + Environment.NewLine +
                   ""; 
        }
    }
}

