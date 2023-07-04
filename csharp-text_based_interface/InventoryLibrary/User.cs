using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    /// <summary>
    /// User
    /// </summary>
    public class User : BaseClass
    {
        /// <summary>
        /// Name of the user
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">The unique identifier of the user</param>
        /// <param name="name">The name of the user</param>
        public User(string id, string name) : base(id)
        {
            this.name = name;
        }
    }
}
