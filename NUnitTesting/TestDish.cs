using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MenuManagement;

namespace NUnitTesting
{
    [TestFixture]
    public class TestDish
    {
        private Dish _dish;

        [SetUp]
        public void SetUp()
        {
            _dish = new Dish(new string[] {"bUrger"," anGus beef" },"beef burger","Classic angus beef burger served with cheese, lettuce and tomato.",9.9);
        }

        [Test]
        public void TestObjectExists()
        {
            //Test if dish exists or not
            Assert.IsNotNull(_dish);

            //Test dish property
            Assert.AreEqual(9.9, _dish.Price);  //Price
            StringAssert.AreEqualIgnoringCase("beef burger", _dish.Name, "Testing the name are actually the same."); //Name
            StringAssert.AreEqualIgnoringCase("Classic angus beef burger served with cheese, lettuce and tomato.", _dish.Description, "Testing the description are actually the same.");
            //Assert.IsTrue(_dish.Identifiers.Contains("burger"));
            //Assert.IsTrue(_dish.Identifiers.Contains("angus beef"));
        }

        //Test case
        [Test]
        public void TestPriceRange()
        {
            _dish.Price = new Random().NextDouble() +150;
            Assert.AreEqual(_dish.Price, 0);
        }

        [Test]
        public void TestLoad()
        {
        }
    }
}