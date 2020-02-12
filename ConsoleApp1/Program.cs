using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        //possible array needed to contain all countries/country names?
        public static List<Countries> allCountries = new List<Countries>();
        public static List<float> allPercents = new List<float>();
        public float totalPercent = 0f;
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
            //all the percentages each country equates to in the calculator
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
            // all country percentages added to this list
            //allPercents.Add(austria.percentage);
            //allPercents.Add(belgium.percentage);
            //allPercents.Add(bulgaria.percentage);
            //allPercents.Add(croatia.percentage);
            //allPercents.Add(cyprus.percentage);
            //allPercents.Add(czechRepublic.percentage);
            //allPercents.Add(denmark.percentage);
            //allPercents.Add(estonia.percentage);
            //allPercents.Add(finland.percentage);
            //allPercents.Add(france.percentage);
            //allPercents.Add(germany.percentage);
            //allPercents.Add(greece.percentage);
            //allPercents.Add(hungary.percentage);
            //allPercents.Add(ireland.percentage);
            //allPercents.Add(italy.percentage);
            //allPercents.Add(latvia.percentage);
            //allPercents.Add(lithuania.percentage);
            //allPercents.Add(luxembourg.percentage);
            //allPercents.Add(malta.percentage);
            //allPercents.Add(netherlands.percentage);
            //allPercents.Add(poland.percentage);
            //allPercents.Add(portugal.percentage);
            //allPercents.Add(romania.percentage);
            //allPercents.Add(slovakia.percentage);
            //allPercents.Add(slovinia.percentage);
            //allPercents.Add(spain.percentage);
            //allPercents.Add(sweden.percentage);
            //for every country object in the list, the countryVote method is called
            //for (int i = 0; i <= allCountries.Count; i++)
            //{
            //    allCountries[i].countryVote();
            //    if (allCountries[i].countryVote() == "yes")
            //    {

            //    }
            //}
        }
    }
}
