using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        //possible array needed to contain all countries/country names?
        private static List<Countries> allCountries = new List<Countries>(); //list which will contain all the countries that have been instantiated 
        private static List<Countries> yesCountries = new List<Countries>(); //list which will contain all country objects that voted yes
        private static List<Countries> abstainCountries = new List<Countries>(); //list which will contain all country objects that have abstained
        private static List<Countries> noCountries = new List<Countries>(); //list which will contain all country objects that have voted no
        private static float totalPercent = 0f; //float that will be used to accumolate the total percent of each country that voted yes
        private static int totalCountries = 0; //int that will be used to add the number of countries that voted yes
        private static string QualifiedMajority() //Qualified Majority method
        {
            foreach (Countries country in yesCountries) //for every country object that voted yes
            {
                totalPercent = totalPercent + country.percentage; //add the percentage of the population that country has to the total percent variable
                totalCountries = totalCountries + 1; //add 1 to the total number of countries that voted yes
            }
            if (totalPercent >= 65.0f && totalCountries >= 15) //if the total percentage of the population that voted yes if greater than or equal to 65% and the number of countries who voted yes is greater than or equal to 15, the motion passes. Else it fails
            {
                Console.WriteLine($"Total percent of population that voted yes = {totalPercent} Total number of countries that voted yes ={totalCountries}");
                return "Motion passed"; //string returned for when the method is called in main
            }
            else
            {
                Console.WriteLine($"Total percent of population that voted yes = {totalPercent} Total number of countries that voted yes = {totalCountries}");
                return "Motion failed"; //string returned for when the method is called in main
            }
        }
        private static void countriesVotes(List<Countries> voteList) //method that will take a list of Countries that voted a certain way, and output each country name from that list of objects
        {
            foreach (Countries country in voteList)
            {
                Console.WriteLine(country.countryName);
            }
        }
        static void Main(string[] args)
        {
            //objects created for each country
            Countries austria = new Countries("Austria", 1.98f);
            Countries belgium = new Countries("Belgium", 2.56f);
            Countries bulgaria = new Countries("Bulgaria", 1.56f);
            Countries croatia = new Countries("Croatia", 0.91f);
            Countries cyprus = new Countries("Cyprus", 0.2f);
            Countries czechRepublic = new Countries("Czech Republic", 2.35f);
            Countries denmark = new Countries("Denmark", 1.3f);
            Countries estonia = new Countries("Estonia", 0.3f);
            Countries finland = new Countries("Finland", 1.23f);
            Countries france = new Countries("France", 14.98f);
            Countries germany = new Countries("Germany", 18.54f);
            Countries greece = new Countries("Greece", 2.4f);
            Countries hungary = new Countries("Hungary", 2.18f);
            Countries ireland = new Countries("Ireland", 1.1f);
            Countries italy = new Countries("Italy", 13.65f);
            Countries latvia = new Countries("Latvia", 0.43f);
            Countries lithuania = new Countries("Lithuania", 0.62f);
            Countries luxembourg = new Countries("Luxembourg", 0.14f);
            Countries malta = new Countries("Malta", 0.11f);
            Countries netherlands = new Countries("Netherlands", 3.89f);
            Countries poland = new Countries("Poland", 8.49f);
            Countries portugal = new Countries("Portugal", 2.3f);
            Countries romania = new Countries("Romania", 4.34f);
            Countries slovakia = new Countries("Slovakia", 1.22f);
            Countries slovinia = new Countries("Slovinia", 0.47f);
            Countries spain = new Countries("Spain", 10.49f);
            Countries sweden = new Countries("Sweden", 2.29f);
            
            //all country objects added to a list
            allCountries.Add(austria);
            allCountries.Add(belgium);
            allCountries.Add(bulgaria);
            allCountries.Add(croatia);
            allCountries.Add(cyprus);
            allCountries.Add(czechRepublic);
            allCountries.Add(denmark);
            allCountries.Add(estonia);
            allCountries.Add(finland);
            allCountries.Add(france);
            allCountries.Add(germany);
            allCountries.Add(greece);
            allCountries.Add(hungary);
            allCountries.Add(ireland);
            allCountries.Add(italy);
            allCountries.Add(latvia);
            allCountries.Add(lithuania);
            allCountries.Add(luxembourg);
            allCountries.Add(malta);
            allCountries.Add(netherlands);
            allCountries.Add(poland);
            allCountries.Add(portugal);
            allCountries.Add(romania);
            allCountries.Add(slovakia);
            allCountries.Add(slovinia);
            allCountries.Add(spain);
            allCountries.Add(sweden);
            //for every country object in the list, the countryVote method is called
            for (int i = 0; i < allCountries.Count; i++)
            {
               string vote = allCountries[i].countryVote(allCountries[i].countryName); //a vote variable is created which is then used to store each countries vote from the object list, and requires the country name parameter to work, so each object accesses the country name variable
               if (vote == "yes")
               {
                     yesCountries.Add(allCountries[i]); //if they voted yes they are added to a list that stores each country that voted yes
               }
               else if (vote == "no") 
               {
                    noCountries.Add(allCountries[i]); //if they voted no they are added to a list that stores each country that voted no
               }
               else
               {
                    abstainCountries.Add(allCountries[i]); //if they didn't do either, the vote is taken as an abstain and the country is added to a list that stores each country that abstained
               }
            }
            Console.WriteLine(QualifiedMajority()); //Qualified Majority method is called
            Console.WriteLine("These Countries voted yes:"); //each list will be called in the countriesVotes() method and each country's name will be outputed from the list
            countriesVotes(yesCountries);
            Console.WriteLine("These countries voted no:");
            countriesVotes(noCountries);
            Console.WriteLine("These countries abstained");
            countriesVotes(abstainCountries);
        }
    }
}
