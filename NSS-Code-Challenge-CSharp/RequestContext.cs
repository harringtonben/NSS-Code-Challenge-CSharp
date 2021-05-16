using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using RestSharp;
using StarWarsApiCSharp;

namespace NSS_Code_Challenge_CSharp
{
    public class RequestContext
    {

        public LukeSkyWalker GetLukeData()
        {
            var peopleRepo = new Repository<LukeSkyWalker>();

            var people = peopleRepo.GetEntities();

            var lukeDetails = people.Select(x => x).Where(y => y.Name == "Luke Skywalker");
            var lukeDetail = lukeDetails.First();
            lukeDetail.FilmsFormatted = lukeDetail.Films;
            lukeDetail.SpeciesFormatted = lukeDetail.Species;
            lukeDetail.StarshipsFormatted = lukeDetail.Starships;
            lukeDetail.VehiclesFormatted = lukeDetail.Vehicles;
            
            return lukeDetail;
        }
    }
}