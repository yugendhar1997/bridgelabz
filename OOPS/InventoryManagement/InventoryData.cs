﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryData.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OOPS
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Contains InventoryData
    /// </summary>
    public class InventoryData
    {
        /// <summary>
        /// it create list of Rice class to stored multiple object.
        /// </summary>
        public IList<Rice> Rice { get; set; }

        /// <summary>
        /// it create list of Wheats class to stored multiple object.
        /// </summary>
        public IList<Wheats> Wheats { get; set; }

        /// <summary>
        /// it create list of Pulses class to stored multiple object.
        /// </summary>
        public IList<Pulses> Pulses { get; set; }
    }

    /// <summary>
    /// This is Rice class  here setter and getter use to set value Rice properties and get value from Rice
    /// </summary>
    public class Rice
    {
        /// <summary>
        /// this variable set the rice name 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// this variable take the price of rice
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// this variable take weight of rice.
        /// </summary>
        public double Weight { get; set; }
    }


    /// <summary>
    /// This is Wheats class  here setter and getter use to set value Rice properties and get value from Rice
    /// </summary>
    public class Wheats
    {
        /// <summary>
        /// this variable set the Wheats name 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// this variable take the price of Wheats
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// this variable take weight of Wheats.
        /// </summary>
        public double Weight { get; set; }
    }

    /// <summary>
    /// This is Pulses class  here setter and getter use to set value Rice properties and get value from Rice
    /// </summary>
    public class Pulses
    {
        /// <summary>
        /// this variable set the Pulses name 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// this variable take the price of Pulses
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// this variable take weight of Pulses.
        /// </summary>
        public double Weight { get; set; }
    }

}