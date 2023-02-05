///////////////////////////////////////////////////////////////////////////////
//
// Author: Jason Self, selfj1@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 1
// Description: Creates a backpack of items using a class called ItemFactory
//
///////////////////////////////////////////////////////////////////////////////
namespace GameInventory
{
    /// <summary>
    /// Creates the driver that runs the code for creating items and displaying them
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method that creates an instance of a backpack and item factory and then makes items to be added to the backpack, then displays the items inside of the backpack
        /// </summary>
        public static void Main()
        {
            // creates a new instance of a BackPack
            BackPack backPack = new BackPack();

            // creates a new instance of the ItemFactory
            ItemFactory itemFactory = new ItemFactory();

            //use the ItemFactory to create some random items to add to the backpack inside a loop
            for (int i = 0; i < 10; i++)
            {
                backPack.Add(itemFactory.MakeRandomItem());
            }

            //Display all items in the backpack
            Console.WriteLine(backPack.ListItems());
        }
    }
}