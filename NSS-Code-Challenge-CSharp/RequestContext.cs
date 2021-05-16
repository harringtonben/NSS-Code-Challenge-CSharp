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

            var peopleDetails = peopleRepo.GetEntities();

            var lukeDetails = peopleDetails.Select(x => x).Where(y => y.Name == "Luke Skywalker");

            return lukeDetails.First();
        }
    }
}