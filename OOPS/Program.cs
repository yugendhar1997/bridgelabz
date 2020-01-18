﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OOPS
{
    using System;
    using OOPS.AddressBook;
    using OOPS.InventoryManagement;

    /// <summary>
    /// Run Total Application
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(" Press 1 : Address Book");
                Console.WriteLine(" Press 2 : Inventory Data");
                Console.WriteLine(" Press 3 : Inventory Management");
                Console.WriteLine(" Press 4 : Stock Account Management");
                Console.WriteLine(" Press 5 : Deck of Cards");

                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        AddressBookOperations addressBookOperations = new AddressBookOperations();
                        addressBookOperations.AddressOperation();
                        break;
                    case 2:
                        InventoryOperation inventoryOperation = new InventoryOperation();
                        inventoryOperation.InventoryManage();
                        break;
                    case 3:
                        InventoryManagement.InventoryDataManagementOperation.DataOperation();
                        break;
                    case 4:

                        break;
                    case 5:
                        DeckOfCards.PlayGame();
                        break;
                }
            }
        }
    }
}
