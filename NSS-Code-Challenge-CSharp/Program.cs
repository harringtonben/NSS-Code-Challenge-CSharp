using System;

namespace NSS_Code_Challenge_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            var requestContext = new RequestContext();
            var lukeData = requestContext.GetLukeData();
            Console.WriteLine("*************************************************");
            Console.WriteLine("***********And the results are in!!**************");
            Console.WriteLine(lukeData.ToString());
            Console.WriteLine("*************************************************");

        }
    }
}