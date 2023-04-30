using System;
using System.Collections.Generic;
using NUnit.Framework;
using InventoryLibrary;

namespace InventoryManager.Tests
{
    [TestFixture]
    /// <summary>
    /// Testing inventory class
    /// </summary>
    public class InventoryClass_Tests
    {
        [Test]
        /// <summary>
        /// constructor
        /// </summary>
        public void TestConstructor()
        {
            string userId = "abc123";
            string itemId = "def456";
            int quantity = 5;

            Inventory inventory = new Inventory(userId, itemId, quantity);

            Assert.AreEqual(inventory.user_id, userId);
            Assert.AreEqual(inventory.item_id, itemId);
            Assert.AreEqual(inventory.quantity, quantity);
            Assert.IsNotNull(inventory.date_created);
            Assert.IsNotNull(inventory.date_updated);
        }

        [Test]
        /// <summary>
        /// Testing setting quantity
        /// </summary>
        public void TestSetQuantity()
        {
            Inventory inventory = new Inventory("abc123", "def456", 5);
            inventory.quantity = 10;

            Assert.AreEqual(inventory.quantity, 10);
        }
    }
}