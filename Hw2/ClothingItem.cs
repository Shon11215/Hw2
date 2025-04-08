using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    internal class ClothingItem
    {
        uint _uint;
        int cost, usage_status;
        string[] seasons;
        string name, color, size, type, brand;
        bool is_favorite, is_casual;

        public ClothingItem(uint _uint, string color, string name, string[] seasson, string is_favorite, int usage_status, string type, string brand, int cost,string size,string is_casual): this(name,is_casual){
            SetCost(cost);
            UsageStatus(usage_status);
            SetColor(color);
            SetSize(size);
            this._uint = _uint;
            this.seasons = seasson;
            if (is_favorite.ToLower() == "yes" || is_favorite.ToLower() == "true" || is_favorite == "1") {
                this.is_favorite = true;
            }
            //this.name = name;
            this.brand = brand;
            this.type = type;
            //SetIsCasual(is_casual);

        }

        public ClothingItem() { }
        public ClothingItem(string name, string is_casual) {
            this.name = name;
            SetIsCasual(is_casual);
        }
        public void Print() {
            Console.WriteLine($"The name of the item is: {this.name}\nThe items unit number: {this._uint} \nColor: {this.color}\nFavorite?: {this.is_favorite}");
            Console.WriteLine($"Usage Status: {this.usage_status}\nType: {this.type}\nBrand: {this.brand}\nCost: {this.cost}\nCasual?: {this.is_casual}");
            Console.WriteLine($"The seasons the items fits for: {string.Join(", ", seasons)}");
            Console.WriteLine($"The size of the item: {this.size}");
            Console.WriteLine($"Is the item Casual? - {this.is_casual}\n\n");
        }

        public void SetCost(int cost) {
            while (cost <= 0) {
                Console.Write("Please enter a postive price tag: ");
                cost = int.Parse(Console.ReadLine());
            }
            this.cost = cost;
        }
        public void UsageStatus(int usage_status) {
            while (usage_status < 1 && usage_status > 3) {
                Console.Write("Please enter a number between 1-3 for the usage rate: ");
                usage_status = int.Parse(Console.ReadLine());
            }
            this.usage_status = usage_status;

        }
        public void SetColor(string color) {
            while (true) {
                if (color[0] != '#') {
                    Console.WriteLine("please start the color with # : ");
                }
                else if (color.Length != 7) {
                    Console.WriteLine("please enter a 7 digits : ");
                }
                else if (!IsValidColor(color)) {
                    Console.WriteLine("Please enter only numbers or a-f chars");
                }
                else {
                    this.color = color;
                    break;

                }
                color = Console.ReadLine();
            }

        }
        static bool IsValidColor(string color) {
            for (int i = 1; i < color.Length; i++) {
                if (!char.IsDigit(color[i]) && (color[i] < 'a' || color[i] > 'f') && (color[i] < 'A' || color[i] > 'F')) return false;
            }
            return true;
        }
        public void SetSize(string size) {
            string[] sizes = new string[] { "S", "M", "L", "XL", "XXL", "OS" };
            bool is_size = false;
            while (!is_size) {
                foreach (string curr_size in sizes) {
                    if (curr_size == size.ToUpper()) {
                        this.size = size;
                        is_size = true;
                        break;
                    }
                }
                if (!is_size) {
                    Console.Write("please enter a new size: ");
                    size = Console.ReadLine();
                }
            }
        }
        public void SetIsCasual(string is_casual) {
            if (is_casual.ToLower() == "yes" || is_casual.ToLower() == "true" || is_casual == "1") {
                this.is_casual = true;
            }
        }
        public bool GetIsCasual() {
            return is_casual;
        }

    }
}
