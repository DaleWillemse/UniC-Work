using System;
using System.Collections.Generic;

namespace Project2ExamPractice
{
    public class Order
    {
        public List<string> Item = new List<string>();
        public List<float> Price = new List<float>();
    }
    class Program
    {
        enum Menu { Breakfast = 1, Burgers, Pizza, Sides, Drinks, Checkout, Exit = 0 }
        enum Breakfast { EnglishBreakfast = 1, Omelette, Oats, Exit = 0 }
        enum Burgers { ChickenBurger = 1, BeefBurger, VegetarianBurger, Exit = 0 }
        enum Pizza { TikkaChicken = 1, Pepperoni, Margarita, FourCheese, Exit = 0 }
        enum Sides { Chips = 1, Nuggets, Suasages, Exit = 0 }
        enum Drinks { Coke = 1, Fanta, Sprite, Water, Exit = 0 }

        static void Main(string[] args)
        {
            Order newOrder = new Order();
            MainMenu(newOrder);
        }

        public static void MainMenu(Order newOrder) // Main menu
        {
            bool exit = false;
            do
            {
                Console.Clear();
                Console.WriteLine("------------\nDALES BISTRO\n------------");
                Console.WriteLine("1. Breakfast\n2. Burgers\n3. Pizza\n4. Sides\n5. Drinks\n----------\n6. Checkout\n0. Exit");

                Display(newOrder);
                int option = int.Parse(Console.ReadLine());
                Menu menu = (Menu)option;
                switch (menu)
                {
                    case Menu.Breakfast:
                        newOrder = BreakfastMenu(newOrder);
                        break;
                    case Menu.Burgers:
                        newOrder = BurgerMenu(newOrder);
                        break;
                    case Menu.Pizza:
                        newOrder = PizzaMenu(newOrder);
                        break;
                    case Menu.Sides:
                        newOrder = SidesMenu(newOrder);
                        break;
                    case Menu.Drinks:
                        newOrder = DrinksMenu(newOrder);
                        break;
                    case Menu.Checkout:
                        Checkout(newOrder);
                        break;
                    case Menu.Exit:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Input.");
                        break;
                }

            } while (exit == false);
        }

        public static Order BreakfastMenu(Order newOrder) //Breakfast
        {
            bool exit = false;
            do
            {
                Console.Clear();
                Console.WriteLine("1. English Breakfast{0,6}\n2. Omelette{1,15}\n3. Oats{2,19}\n0. Back", "25", "15", "10");

                Display(newOrder);
                int option = int.Parse(Console.ReadLine());
                Breakfast menu = (Breakfast)option;
                switch (menu)
                {
                    case Breakfast.EnglishBreakfast:
                        AddtoCart(newOrder, "English Breakfast", 25);
                        break;
                    case Breakfast.Omelette:
                        AddtoCart(newOrder, "Omelette", 15);
                        break;
                    case Breakfast.Oats:
                        AddtoCart(newOrder, "Oats", 10);
                        break;
                    case Breakfast.Exit:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Input.");
                        break;
                }

            } while (exit == false);

            return newOrder;
        }


        public static Order BurgerMenu(Order newOrder) // Burgers
        {
            bool exit = false;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Chicken Burger{0,12}\n2. Beef Burger{1,15}\n3. Vegetarian Burger{2,9}\n0. Back", "25", "30", "40");

                Display(newOrder);
                int option = int.Parse(Console.ReadLine());
                Burgers menu = (Burgers)option;
                switch (menu)
                {
                    case Burgers.ChickenBurger:
                        AddtoCart(newOrder, "Chicken Burger", 25);
                        break;
                    case Burgers.BeefBurger:
                        AddtoCart(newOrder, "Beef Burger", 30);
                        break;
                    case Burgers.VegetarianBurger:
                        AddtoCart(newOrder, "Vegetarian Burger", 40);
                        break;
                    case Burgers.Exit:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Input.");
                        break;
                }

            } while (exit == false);

            return newOrder;
        }
        public static Order PizzaMenu(Order newOrder) // Pizza
        {
            bool exit = false;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Tikka Chicken{0,11}\n2. Pepperoni{1,15}\n3. Margarita{2,15}\n4. Fourcheese{3,14}\n0. Back", "25", "25", "15", "30");

                Display(newOrder);
                int option = int.Parse(Console.ReadLine());
                Pizza menu = (Pizza)option;
                switch (menu)
                {
                    case Pizza.TikkaChicken:
                        AddtoCart(newOrder, "Tikka Chicken", 25);
                        break;
                    case Pizza.Pepperoni:
                        AddtoCart(newOrder, "Pepperoni", 25);
                        break;
                    case Pizza.Margarita:
                        AddtoCart(newOrder, "Margarita", 15);
                        break;
                    case Pizza.FourCheese:
                        AddtoCart(newOrder, "Four Cheese", 30);
                        break;
                    case Pizza.Exit:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Input.");
                        break;
                }

            } while (exit == false);

            return newOrder;
        }

        public static Order SidesMenu(Order newOrder) // Sides
        {
            bool exit = false;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Chips{0,15}\n2. Nuggets{1,13}\n3. Suasages{2,12}\n0. Back", "10", "10", "15");

                Display(newOrder);
                int option = int.Parse(Console.ReadLine());
                Sides menu = (Sides)option;
                switch (menu)
                {
                    case Sides.Chips:
                        AddtoCart(newOrder, "Chips", 10);
                        break;
                    case Sides.Nuggets:
                        AddtoCart(newOrder, "Nuggets", 10);
                        break;
                    case Sides.Suasages:
                        AddtoCart(newOrder, "Suasages", 15);
                        break;
                    case Sides.Exit:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Input.");
                        break;
                }

            } while (exit == false);

            return newOrder;

        }
        public static Order DrinksMenu(Order newOrder) // Drinks
        {
            bool exit = false;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Coke{0,16}\n2. Fanta{1,15}\n3. Sprite{2,14}\n4. Water{3,15}\n0. Back", "5", "5", "5", "10");

                Display(newOrder);
                int option = int.Parse(Console.ReadLine());
                Drinks menu = (Drinks)option;
                switch (menu)
                {
                    case Drinks.Coke:
                        AddtoCart(newOrder, "Coke", 5);
                        break;
                    case Drinks.Fanta:
                        AddtoCart(newOrder, "Fanta", 5);
                        break;
                    case Drinks.Sprite:
                        AddtoCart(newOrder, "Sprite", 5);
                        break;
                    case Drinks.Water:
                        AddtoCart(newOrder, "Water", 10);
                        break;
                    case Drinks.Exit:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Input.");
                        break;
                }

            } while (exit == false);

            return newOrder;
        }

        public static void Display(Order newOrder) // Display order.
        {
            Console.WriteLine("\n----------------------------------\nOrder List\n----------------------------------");
            int Length = newOrder.Item.Count;
            float price = 0;
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine("{0,-25}R{1}", newOrder.Item[i], newOrder.Price[i]);
                price += newOrder.Price[i];
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Total Price:{0,-13}R{1}", "", price);

        }
        public static void Checkout(Order newOrder) // Checkout your order.
        {
            Console.Clear();
            Console.WriteLine("------------\nDALES BISTRO\n------------");
            Console.WriteLine("\n1. Checkout\n0. Back");
            Display(newOrder);
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1: // Checkout, clears order.
                    Console.Clear();
                    Console.WriteLine("Thank you! Your order will be with you soon.");
                    Console.ReadKey();
                    ClearCart(newOrder);
                    break;
                case 0: // Back, goes to the main menu without clearing order.
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    break;
            }
        }
        public static void AddtoCart(Order newOrder, string foodItem, float price) // Adds order to the list.
        {
            newOrder.Item.Add(foodItem);
            newOrder.Price.Add(price);
        }
        public static void ClearCart(Order newOrder) // Clears newOrder lists.
        {
            newOrder.Item.Clear();
            newOrder.Price.Clear();
        }
    }
}
