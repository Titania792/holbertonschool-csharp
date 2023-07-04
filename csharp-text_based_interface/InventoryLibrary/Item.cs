using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    /// <summary>
    /// Item
    /// </summary>
    public class Item : BaseClass
    {
        /// <summary>
        /// Required properties
        /// </summary>
        /// <value></value>
        public string name { get; set; }

        /// <summary>
        /// Optional properties
        /// </summary>
        /// <value></value>
        public string description { get; set; }

        /// <summary>
        /// price
        /// </summary>
        private float _price;

        /// <summary>
        /// price
        /// </summary>
        /// <value></value>
        public float price
        {
            get { return _price; }
            set { _price = (float)Math.Round(value, 2); }
        }

        /// <summary>
        /// tags
        /// </summary>
        /// <value></value>
        public List<string> tags { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public Item(string id, string name, float price) : base(id)
        {
            this.name = name;
            this.price = price;
            this.tags = new List<string>();
        }
    }
}
