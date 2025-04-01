using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    internal class Program
    {
        static void Main(string[] args) {
            ClothingItem[] clothes = new ClothingItem[200];
            uint _uint = 1000;
            string index = null;
            do {
                Console.WriteLine("Hey what do you want to do?\n\na - Add a new Clothing Item\nb - See all your wardrobe\nc - Exit\n");
                Console.Write("Please enter your pick: ");
                index = Console.ReadLine();
                switch (index.ToLower()) {
                    case "a":
                        initCloathingItem();
                        break;
                    case "b":
                        break;
                    case "c":
                        break;

                    default:
                        break;
                }

            } while (index.ToLower() != "c");
        }

        static void initCloathingItem() {
            string[] season_list = new string[4] { "summer", "spring", "winter", "fall" };
            string[] seasons_to_pass = new string[4];
            int[] season_index = new int[4];
            int season_counter;

            Console.Write("Please enter the name of the item: ");
            string name = Console.ReadLine();

            Console.Write("\nPlease enter the color code of the item: ");
            string color = Console.ReadLine();

            Console.Write("\n1) none\n2) average\n3) high\nPlease enter the amout of usage the item has: ");
            int usage_status = int.Parse(Console.ReadLine());

            Console.Write("\nPlease enter the cost of the item: ");
            int cost = int.Parse(Console.ReadLine());

            do {
                Console.Write("\nPlease enter the amount of seasons your item fits between 1-4: ");
                season_counter = int.Parse(Console.ReadLine());
            } while (season_counter < 1 || season_counter > 4);

            Console.Write("\n1) summer\n2) spring\n3) winter\n4) fall\nPlease enter the number for the following seassons this cloathing is attenable for:");

            for (int i = 0; i < season_counter; i++) {
                int curr_season = int.Parse(Console.ReadLine());
                if (season_index.Contains(curr_season)) {
                    Console.WriteLine($"{season_list[curr_season - 1]} Is already in please enter a diff season");
                    i--;
                    continue;
                }
                season_index[i] = curr_season;
                seasons_to_pass[i] = season_list[curr_season];
            }
            Console.Write("\nPlease enter True or Flase for wether the item is favorite or not: ");
            string is_favorite = (Console.ReadLine());
            Console.Write("\nPlease enter the type of your item: ");
            string type = (Console.ReadLine());
            Console.Write("\nPlease enter the brand name: ");
            string brand = (Console.ReadLine());

        }
    }
}
