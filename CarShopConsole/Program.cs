using CarClass;
using System;

namespace CarShopConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Store s = new Store();

            Console.WriteLine(" Welcome to the car store. First you must create some car inventory. then you may add some cars to the shopping cart. Finally you may checkout which will give you a total value of the shopping cart.  ");

            int action = chooseAction();

            while (action != 0)
            {
                Console.WriteLine("You chose "+ action);
                switch(action)
                {
                    case 1: //add car to car list of inventory
                        Console.WriteLine("You choose to add a new car to the inventory");
                        string carMake = "";
                        string carModel = "";
                        decimal carPrice = 0;

                        Console.WriteLine("What is the car make?");
                        carMake = Console.ReadLine();

                        Console.WriteLine("what is the car model?");
                        carModel = Console.ReadLine();

                        Console.WriteLine("What is the price of the car");
                        carPrice = int.Parse(Console.ReadLine());

                        Car newCar = new Car(carMake, carModel, carPrice);
                        s.CarList.Add(newCar);

                        printInventory(s);

                        break;

                    case 2: //add car from car list to shopping list
                        Console.WriteLine(" You choose to add a car to your shopping cart");
                        printInventory(s);
                        Console.WriteLine("Which item would you like to buy? (number)" );

                        int carChosen = int.Parse(Console.ReadLine());

                        s.ShoppingList.Add(s.CarList[carChosen]);
                        

                        printShoppingCart(s);
                        break;

                    case 3: //add total of price from shopping list
                        printShoppingCart(s);
                        Console.WriteLine("The total cost of your items is : " + s.Checkout());
                        break;

                    default:
                        break;

                }
                action = chooseAction();
            }


        }

        private static void printShoppingCart(Store s)
        {
            Console.WriteLine("Cars you have chosen to buy");
            for (int i = 0; i < s.ShoppingList.Count; i++)
            {
                Console.WriteLine("car # " + i + " " + s.ShoppingList[i]);
            }
        }
    private static void printInventory(Store s)
        {
            for (int i = 0; i < s.CarList.Count; i++)
            {
                Console.WriteLine("car # "+ i +" "+ s.CarList[i]);
            }
        }

        static public int chooseAction()
        {
            int choice = 0;
            Console.WriteLine("Choose an action (0) to quit (1) to add a new car (2) add car to cart (3) to checkout " );

            choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
