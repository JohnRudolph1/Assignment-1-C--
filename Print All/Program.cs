using System;
using System.Collections.Generic;

namespace Print_All
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dictionary<string, string>> dictionaryList = new List<Dictionary<string, string>>();
            Dictionary<string, string> dictionary1 = new Dictionary<string, string>();
            dictionary1.Add("name", "Junior Data Analyst")
                dictionary1.Add("employer", "Lockerdome")

            Dictionary<string, string> dictionary2 = new Dictionary<string, string>();

            Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
            Dictionary<string, string> dictionary4 = new Dictionary<string, string>();
            Dictionary<string, string> dictionary5 = new Dictionary<string, string>();
            Dictionary<string, string> dictionary6 = new Dictionary<string, string>();
            Dictionary<string, string> dictionary7 = new Dictionary<string, string>();
            Dictionary<string, string> dictionary8 = new Dictionary<string, string>();
            Dictionary<string, string> dictionary9 = new Dictionary<string, string>();
            Dictionary<string, string> dictionary10 = new Dictionary<string, string>();
            Dictionary<string, string> dictionary11 = new Dictionary<string, string>();



            PrintJobs(dictionaryList);
        }
        private static void PrintJobs(List<Dictionary<string, string>> someJobs)
        {
            if (columnChoices.Count == 0)
            {
                Console.WriteLine("No Results!");
            }
            foreach (Dictionary<string, string> job in someJobs)
            {
             
                {
                    Console.WriteLine(job);
                }
                
            }
        }
    }
   
}
