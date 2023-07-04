using System;
using System.Collections.Generic;
using NUnit.Framework;
using InventoryLibrary;

namespace InventoryManager.Tests
{
    [TestFixture]
    /// <summary>
    /// Testing user class
    /// </summary>
    public class UserClass_Tests
    {
        [Test]
        /// <summary>
        /// constructor
        /// </summary>
        public void TestConstructor()
        {
            string id = "abc123";
            string name = "Test User";

            User user = new User(id, name);

            Assert.AreEqual(user.id, id);
            Assert.AreEqual(user.name, name);
            Assert.IsNotNull(user.date_created);
            Assert.IsNotNull(user.date_updated);
        }

        [Test]
        /// <summary>
        /// Testing setting name
        /// </summary>
        public void TestSetName()
        {
            User user = new User("abc123", "Test User");
            user.name = "New User Name";

            Assert.AreEqual(user.name, "New User Name");
        }
    }
}