using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOne.services
{
    public class RestrauntPicker
    {
     public string RestaurantSuggestion(string category)
        {
        string[] fastfood = { "Wendy's", "Burger King", "McDonald's", "Jack in the Box", "Chick-fil-a", "Taco Bell", "Canes", "Popeyes", "KFC", "Church's Chicken" };
        string[] pizza = { "Little caesars", "Mountain mike", "Dominos", "Micheals", "new york style pizza", "Eddies pizza", "Papa johns", "Round Table", "Sams Pizza", "Fresh Slice Pizza" };
        string[] myfavorites = { "Misaki Toyo sushi", "Fogo De Chao", "Texas roadhouse", "L&L Hawaiian BBQ", "Nash & Tender", "Chillis", "Cheesecake Factory", "The Pho", "Sherman's Chinese Buffet", "In-n-out" };
            int rand = new Random().Next(0, 11);

            if (category == "fastfood")
                return fastfood[rand];
            else if (category == "pizza")
                return pizza[rand];
            else if (category == "myfavorites")
                return myfavorites[rand];
            else
                return "Please enter a valid category: fastfood, pizza, or myfavorites.";
        }
    }
}
    
