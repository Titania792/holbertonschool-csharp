using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    /// <summary>
    /// Class BaseClass, all other classes will inherit from it.
    /// </summary>
    public class BaseClass
    {
        /// <summary>
        /// id
        /// </summary>
        /// <value></value>
        public string id {get; set;}

        /// <summary>
        /// date_created
        /// </summary>
        /// <value></value>
        public DateTime date_created {get; set;}

        /// <summary>
        /// date_updated
        /// </summary>
        /// <value></value>
        public DateTime date_updated {get; set;}

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id"></param>
        public BaseClass(string id)
        {
            this.id = id;
            date_created = DateTime.Now;
            date_updated = DateTime.Now;
        }
    }
}
