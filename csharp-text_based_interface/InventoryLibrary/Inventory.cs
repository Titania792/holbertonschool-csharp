using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    /// <summary>
    /// Inventory
    /// </summary>
    public class Inventory : BaseClass
    {
        /// <summary>
        /// user_id
        /// </summary>
        /// <value></value>
        public string user_id { get; set; }

        /// <summary>
        /// item_id
        /// </summary>
        /// <value></value>
        public string item_id { get; set; }

        /// <summary>
        /// _quantity
        /// </summary>
        private int _quantity = 1;

        /// <summary>
        /// quantity
        /// </summary>
        /// <value></value>
        public int quantity 
        { 
            get
            {
                return _quantity;
            }
            set 
            { 
                if (value < 0)
                {
                    throw new ArgumentException("Quantity cannot be less than 0");
                }
                _quantity = value; 
            } 
        }

         /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="user"></param>
        /// <param name="item"></param>
        public Inventory(User user, Item item, int quantity) : base(item.id)
        {
            this.user_id = user.id;
            this.item_id = item.id;
            this.quantity = quantity;
        }
    }
}