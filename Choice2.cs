using System;

class Program {
    static void Main(string[] args) {
        
        int breakfastSet = 5;
        int weekendSet = 2;
        int coffee = 3;
        
        
        Console.Write("Enter day of week (1-7): ");
        int dayOfWeek = Convert.ToInt32(Console.ReadLine());
        
        
        Console.Write("Enter time of day (8-18): ");
        int timeOfDay = Convert.ToInt32(Console.ReadLine());
        
        string order;
        do {
            Console.Write("Enter your order: ");
            order = Console.ReadLine();
            
            if (order == "Breakfast Set") {
                if (dayOfWeek >= 1 && dayOfWeek <= 7 && timeOfDay <= 11 && breakfastSet > 0) {
                    Console.WriteLine("Your order of Breakfast Set is successful.");
                    breakfastSet--;
                }
                else {
                    Console.WriteLine("Sorry your order is not available.");
                }
            }
            else if (order == "Weekend Set") {
                if (dayOfWeek >= 6 && dayOfWeek <= 7 && weekendSet > 0) {
                    Console.WriteLine("Your order of Weekend Set is successful.");
                    weekendSet--;
                }
                else {
                    Console.WriteLine("Sorry your order is not available.");
                }
            }
            else if (order == "Coffee") {
                if (coffee > 0) {
                    Console.WriteLine("Your order of Coffee is successful.");
                    coffee--;
                }
                else {
                    Console.WriteLine("Sorry your order is out of stock.");
                }
            }
            else {
                Console.WriteLine("Please enter a valid menu.");
            }
        } while (order != "End");
    }
}
