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
        //method below will ask user to input what a country voted, and convert the vote to lower case. It is then returned for the main method
        public string countryVote(string name) //method takes a string name that is the country name, assigned in main
        {
            Console.WriteLine($"Please enter the vote for your country: {name}"); //asks the user to input the vote for each country
            vote = Console.ReadLine(); //stores the user input by reading the above line
            vote = vote.Trim(); //removes all trailing whitespaces from the user input
            vote = vote.ToLower(); //converts the user input to lower case
            return vote; //returns the vote so it can be stored in main
        }

        public Countries(string name, float percent)
        {
            countryName = name;
            percentage = percent;
        }
    }
}
