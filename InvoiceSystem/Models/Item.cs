﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceSystem
{
    /// <summary>
    /// An item that can be on an invoice. (ItemDesc)
    /// </summary>
    public class Item
    {
        /// <summary>
        /// The name of the item.
        /// </summary>
        public string ItemCode { get; set; }


        /// <summary>
        /// The description of an item
        /// </summary>
        public string ItemDesc { get; set; }


        /// <summary>
        /// The cost of an item
        /// </summary>
        public decimal Cost { get; set; }
    }
}