using System;
using System.Collections.Generic;
using NUnit.Framework;
using InventoryLibrary;

namespace InventoryManager.Tests
{
    [TestFixture]
    /// <summary>
    /// Testing item class
    /// </summary>
    public class ItemClass_Tests
    {
        [Test]
        /// <summary>
        /// Constructor
        /// </summary>
        public void TestConstructor()
        {
            string id = "abc123";
            string name = "Test Item";
            float price = 12.34f;
            string description = "A test item";
            string[] tags = { "test", "item" };

            Item item = new Item(id, name, price, description, tags);

            Assert.AreEqual(item.id, id);
            Assert.AreEqual(item.name, name);
            Assert.AreEqual(item.price, price);
            Assert.AreEqual(item.description, description);
            Assert.AreEqual(item.tags, tags);
            Assert.IsNotNull(item.date_created);
            Assert.IsNotNull(item.date_updated);
        }

        [Test]
        /// <summary>
        /// Testing setting price
        /// </summary>
        public void TestSetPrice()
        {
            Item item = new Item("abc123", "Test Item", 12.34f, "A test item", new string[] { "test", "item" });
            item.price = 56.78f;

            Assert.AreEqual(item.price, 56.78f);
        }
    }
}