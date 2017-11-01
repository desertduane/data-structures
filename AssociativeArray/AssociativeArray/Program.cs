using System;
using System.Collections.Specialized;

namespace AssociativeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            NameValueCollection airports = new NameValueCollection()
            {
                {"LAX", "Los Angales" },
                {"SEA", "SeaTac" },
                {"PSP", "Palm Springs" }

            };

            for(var i = 0; i < airports.Count; i++)
            {
                Console.Write(airports[i]);
            }
            Console.Read();
            
        }
    }
}
