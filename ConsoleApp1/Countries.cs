using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Countries
    {
        public string countryName; //in case we need to specify the country names
        public string vote; //in case we need to specify each countries vote
        public float percentage; //for each countries percent
        List<string> yesCountries = new List<string>(); //list containing all countries that voted yes
        List<float> yesPercentages = new List<float>();  //list containing the percents of all yes voting contries 
        //method below will ask user to input what a country voted, and convert the vote to lower case. It is then returned for the main method
        public string countryVote()
        {
            Console.WriteLine("Please enter the vote for your country");
            vote = Console.ReadLine();
            vote = vote.ToLower();
            return vote;
        }
    }
}
