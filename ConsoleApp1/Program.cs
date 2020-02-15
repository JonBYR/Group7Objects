using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        //possible array needed to contain all countries/country names?
        public static List<Countries> allCountries = new List<Countries>(); //list which will contain all the countries that have been instantiated 
        public static List<Countries> yesCountries = new List<Countries>(); //list which will contain all country objects that voted yes
        public static List<Countries> abstainCountries = new List<Countries>(); //list which will contain all country objects that have abstained
        public static List<Countries> noCountries = new List<Countries>(); //list which will contain all country objects that have voted no
        public static float totalPercent = 0f; //float that will be used to accumolate the total percent of each country that voted yes
        public static int totalCountries = 0; //int that will be used to add the number of countries that voted yes
        public static string QualifiedMajority() //Qualified Majority method
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
        public static void countriesVotes(List<Countries> voteList) //method that will take a list of Countries that voted a certain way, and output each country name from that list of objects
        {
            foreach (Countries country in voteList)
            {
                Console.WriteLine(country.countryName);
            }
        }
        static void Main(string[] args)
        {
            //objects created for each country
            Countries austria = new Countries();
            Countries belgium = new Countries();
            Countries bulgaria = new Countries();
            Countries croatia = new Countries();
            Countries cyprus = new Countries();
            Countries czechRepublic = new Countries();
            Countries denmark = new Countries();
            Countries estonia = new Countries();
            Countries finland = new Countries();
            Countries france = new Countries();
            Countries germany = new Countries();
            Countries greece = new Countries();
            Countries hungary = new Countries();
            Countries ireland = new Countries();
            Countries italy = new Countries();
            Countries latvia = new Countries();
            Countries lithuania = new Countries();
            Countries luxembourg = new Countries();
            Countries malta = new Countries();
            Countries netherlands = new Countries();
            Countries poland = new Countries();
            Countries portugal = new Countries();
            Countries romania = new Countries();
            Countries slovakia = new Countries();
            Countries slovinia = new Countries();
            Countries spain = new Countries();
            Countries sweden = new Countries();
            //all the percentages each country equates to in the calculator are initialised
            austria.percentage = 1.98f;
            belgium.percentage = 2.56f;
            bulgaria.percentage = 1.56f;
            croatia.percentage = 0.91f;
            cyprus.percentage = 0.2f;
            czechRepublic.percentage = 2.35f;
            denmark.percentage = 1.3f;
            estonia.percentage = 0.3f;
            finland.percentage = 1.23f;
            france.percentage = 14.98f;
            germany.percentage = 18.54f;
            greece.percentage = 2.4f;
            hungary.percentage = 2.18f;
            ireland.percentage = 1.1f;
            italy.percentage = 13.65f;
            latvia.percentage = 0.43f;
            lithuania.percentage = 0.62f;
            luxembourg.percentage = 0.14f;
            malta.percentage = 0.11f;
            netherlands.percentage = 3.89f;
            poland.percentage = 8.49f;
            portugal.percentage = 2.3f;
            romania.percentage = 4.34f;
            slovakia.percentage = 1.22f;
            slovinia.percentage = 0.47f;
            spain.percentage = 10.49f;
            sweden.percentage = 2.29f;
            //initalising all country names
            austria.countryName = "Austria";
            belgium.countryName = "Belgium";
            bulgaria.countryName = "Bulgaria";
            croatia.countryName = "Croatia";
            cyprus.countryName = "Cyprus";
            czechRepublic.countryName = "Czech Republic";
            denmark.countryName = "Denmark";
            estonia.countryName = "Estonia";
            finland.countryName = "Finland";
            france.countryName = "France";
            germany.countryName = "Germany";
            greece.countryName = "Greece";
            hungary.countryName = "Hungary";
            ireland.countryName = "Ireland";
            italy.countryName = "Italy";
            latvia.countryName = "Latvia";
            lithuania.countryName = "Lithuania";
            luxembourg.countryName = "Luxembourg";
            malta.countryName = "Malta";
            netherlands.countryName = "Netherlands";
            poland.countryName = "Poland";
            portugal.countryName = "Portugal";
            romania.countryName = "Romania";
            slovakia.countryName = "Slovakia";
            slovinia.countryName = "Slovinia";
            spain.countryName = "Spain";
            sweden.countryName = "Sweden";
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
