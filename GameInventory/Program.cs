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

    public class Program
    {
        static void Main(string[] args)
        {
            BackPack backPack = new BackPack();

            //use the ItemFactory to create some random items to add to the backpack
            ItemFactory itemFactory = new ItemFactory();

            for (int i = 0; i < 10; i++)
            {
                backPack.Add(itemFactory.MakeRandomItem());
            }
            //Display all items in the backpack
            Console.WriteLine(backPack.ListItems());
        }
    }
}