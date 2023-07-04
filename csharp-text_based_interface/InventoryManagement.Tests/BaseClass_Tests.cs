using System;
using System.Collections.Generic;
using NUnit.Framework;
using InventoryLibrary;

namespace InventoryManager.Tests
{
    [TestFixture]
    /// <summary>
    /// Testing base class
    /// </summary>
    public class BaseClass_Tests
    {
        [Test]
        /// <summary>
        /// Constructor
        /// </summary>
        public void TestConstructor()
        {
            string id = "abc123";
            BaseClass bc = new BaseClass(id);

            Assert.AreEqual(bc.id, id);
            Assert.IsNotNull(bc.date_created);
            Assert.IsNotNull(bc.date_updated);
        }

        [Test]
        /// <summary>
        /// Testing setting id
        /// </summary>
        public void TestSetId()
        {
            BaseClass bc = new BaseClass("abc123");
            bc.id = "def456";

            Assert.AreEqual(bc.id, "def456");
        }
    }
}