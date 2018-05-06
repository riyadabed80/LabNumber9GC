﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace LabNumber9GC
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Names = new List<string> { "Racheal", "Anna", "Sarah", "Tim", "Jasmine", "Riyad", "Michael", "Anthony", "Toni", "Jason", "Dr. K", "Mike", "Kim", "Kamesha", "Char", "Cody", "Yasmine", "Dana", "Danielle", "Edwin" };
            List<string> Hometown = new List<string> { "Uganda", "Detroit", "Troy", "Dearborn", "Rochester Hills", "Southwest Detroit", "Westland", "Garden City", "Canton", "Plymouth", "River Rouge", "Eastpointe", "St. Clair Shores", "Lincoln Park", "Allen Park", "Chicago", "New York", "Los Angeles", "Seattle", "Miami" };
            List<string> FavFood = new List<string> { "Pizza", "Hamburgers", "Mac & Cheese", "Chicken", "Salad", "Steak", "Salmon", "Hot Dogs", "Lobster", "Tacos", "Spaghetti", "Shawarma", "Lasagna", "French Fries", "Chocolate Ice Cream", "Salmon", "Hunan Chicken", "Curry Chicken", "Subway", "Lava Cake" };
            List<string> FavColor = new List<string> { "Blue", "Black", "Brown", "Yellow", "Green", "Lavender", "Pink", "Turquoise", "Orange", "Gray", "Red", "Taupe", "Purple", "Peach", "Periwinkle", "Cyan", "Crimson", "Violet", "Teal", "Emerald Green" };
            bool UserContinue2 = true;
            while (UserContinue2)
            {
                Console.WriteLine($"Welcome to our C# class. Which student would you like to learn more about?(Enter a number 1-{Names.Count}):");
                int nameInput = ValidateNum(Names.Count);
                bool UserContinue = true;
                while (UserContinue)
                {
                    Console.WriteLine("Student " + nameInput + " is " + Names[nameInput - 1] + ". What would you like to know about " + Names[nameInput - 1] + "?" + "\n(enter \"Hometown\" or \"Favorite Food\" or \"Favorite Color\")");
                    string choice1 = Console.ReadLine();
                    if (choice1.ToLower().Contains("hometown"))
                    {
                        Console.WriteLine(Hometown[nameInput - 1]);
                        UserContinue = false;
                    }
                    else if (choice1.ToLower().Contains("favorite food"))
                    {
                        Console.WriteLine(FavFood[nameInput - 1]);
                        UserContinue = false;
                    }
                    else if (choice1.ToLower().Contains("favorite color"))
                    {
                        Console.WriteLine(FavColor[nameInput - 1]);
                        UserContinue = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Try again.");
                    }
                    bool UserContinue3 = true;
                    while (UserContinue3)
                    {
                        Console.WriteLine("Would you like to find out info about another student (1) or add another student (2)?" +
                        "\nPress 1 or 2 to choose or \"n\" to end program");
                        string choice2 = Console.ReadLine();
                        if (choice2 == "1")
                        {
                            UserContinue3 = false;
                        }
                        else if (choice2 == "2")
                        {
                                string nameEntered = ValidateName("What is the first name of the person you want to add?", "^[a-z A-Z]{2,}$");
                                Names.Add(nameEntered);
                                string hometownEntered = ValidateName("What is the name of their hometown?", "^[a-z A-Z]{2,}$");
                                Hometown.Add(hometownEntered);
                                string favFoodEntered = ValidateName("What is their favorite food?", "^[a-z A-Z]{2,}$");
                                FavFood.Add(favFoodEntered);
                                string favColorEntered = ValidateName("What is their favorite color?", "^[a-z A-Z]{2,}$");
                                FavColor.Add(favFoodEntered);
                                
                        }
                        else if (choice2.ToLower() == "no" || choice2.ToLower() == "n")
                        {
                            UserContinue3 = false;
                            UserContinue2 = false;
                        }
                        else
                        {
                            Console.WriteLine("Not a valid input. Try again.");
                        }

                    }
                }
            }


        }

        private static string ValidateName(string prompt, string regex)
        {
            Console.WriteLine(prompt);
            string nameEntered = Console.ReadLine();
            while (!Regex.IsMatch(nameEntered, regex))
            {
                Console.WriteLine("Invalid input. " + prompt);
                nameEntered = Console.ReadLine();
            }

            return nameEntered;
        }

        private static int ValidateNum(int MaxValue)
        {
            int nameInput;
            while (!int.TryParse(Console.ReadLine(), out nameInput) || nameInput < 1 || nameInput > MaxValue)
            {
                Console.WriteLine($"Invalid input. Please enter number between 1 and {MaxValue}.");
            }

            return nameInput;
        }
    }
}

        
    

