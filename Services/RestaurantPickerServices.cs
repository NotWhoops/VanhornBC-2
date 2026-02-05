using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VanhornBMC6.Services
{
    public class RestaurantPickerServices
    {
        public string RestaurantPicker(string userInput)
        {

        string[] FastFood = {
        "TacoBell",
        "Carl's Jr",
        "McDonald's",
        "Subway",
        "Burger King",
        "In n Out",
        "Sonic",
        "Chick fil A",
        "Wendy's",
        "Wing stop"
        };

        string[] Pizza = {
        "Mountain Mike's Pizza",
        "Little Caesars",
        "Papa Johns",
        "Marcos Pizza",
        "Smack Pie",
        "Dominos Pizza",
        "Strattons Pizza",
        "Pizza Guys",
        "Round Table Pizza",
        "Papa Murphy's",
        };

        string[] Restaurants ={
        "Olive Garden",
        "Red Lobster",
        "Texas Roadhouse",
        "Velvet Grill and Creamery",
        "El Rancho Steak & Lobster",
        "BJ Restaurant and Brewhouse",
        "Cheesecake Factory",
        "The Old Spaghetti Factory",
        "The Firehouse Steakhouse",
        "Magpie Cafe",
        };

        Random rand = new Random();

        int index1 = rand.Next(FastFood.Length);
        int index2 = rand.Next(Pizza.Length);
        int index3 = rand.Next(Restaurants.Length);



        if (userInput == "FastFood")
        {
        return $"Here is your choice: {FastFood[index1]}";        
        }
        else if (userInput == "Pizza")
        {
            return $"Here is your choice: {Pizza[index2]}";
        }
        else if (userInput == "Restaurant")
        {
            return $"Here is your choice: {Restaurants[index3]}";
        }
        else
        {
            return "Please enter a valid restaurant choice: Restaurant or Pizza or FastFood";
        }
        }
    }
}