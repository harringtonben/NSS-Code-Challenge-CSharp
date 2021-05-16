using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using StarWarsApiCSharp;

namespace NSS_Code_Challenge_CSharp
{
    public class LukeSkyWalker : Person
    {
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
                   "Home World: " + this.Gender + Environment.NewLine +
                   "Films: " + String.Join(", ", this.Films) + Environment.NewLine +
                   "Species: " + String.Join(", ", this.Species) + Environment.NewLine +
                   "Vehicles: " + String.Join(", ", this.Vehicles) + Environment.NewLine +
                   "Star Ships: " + String.Join(", ", this.Starships)  + Environment.NewLine +
                   ""; 
        }
    }
}

