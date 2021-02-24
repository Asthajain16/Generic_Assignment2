using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Asignment2._2
{
    
    class Program
    {
        static Dictionary<string, PM> obj1 = new Dictionary<string, PM>();
        static void Main(string[] args)
        {
            DictionaryInit();

            //For 2004
            Console.WriteLine("\nPrime Minister in 2004:-\n");
            foreach (var i in obj1.Values)
            {
                if (i.Year.Equals(2004))
                {
                    Console.WriteLine(i);
                }
            }

            //Adding current prime minister
            Console.WriteLine("\n\nAfter Adding current Prime Minister :-\n");
            obj1["Fourth"] = new PM("Narendra Modi",2021);
            foreach (var i in obj1.Values)
                Console.WriteLine(i);

            //Sorting by Year
            Console.WriteLine("\n\nIn Sorted Order(by Year):-\n");
            obj1 = obj1.OrderBy(r => r.Value.Year).ToDictionary(r => r.Key, r => r.Value);
            foreach (var i in obj1.Values)
                Console.WriteLine(i);
            
        }
        private static void DictionaryInit()
        {
            obj1.Add("First", new PM("Atal Bihari Vajpayee", 1998));
            obj1.Add("Second", new PM("Narendra Modi", 2014));
            obj1.Add("Third", new PM("Manmohan Singh", 2004));
        }
    }
    }