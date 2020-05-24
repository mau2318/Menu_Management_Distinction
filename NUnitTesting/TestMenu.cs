using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MenuManagement;

namespace NUnitTesting
{
    [TestFixture()]
    public class TestMenu
    {
        private Menu _menu;
        private Dish burger, pasta;

        [SetUp]
        public void SetUp()
        {
            _menu = new Menu(new string[] {"Full","MENU"},"Full menU");
            burger = new Dish(new string[] { "bUrger", " anGus beef" }, "beef burger", "Classic angus beef burger served with cheese, lettuce and tomato.", 9.9);
            pasta = new Dish(new string[] { "cream", "pasta" }, "creamy pasta", "Creamy pasta with seafood or ham.", 9.9);
        }

        [Test]
        public void TestMenuExists()
        {
            // Test object exists
            Assert.IsNotNull(_menu);
            //Test property
            StringAssert.AreEqualIgnoringCase("full meNu", _menu.Name,"Test menu name is the same");
            //string[] testList = new string[] {"full","menu" };
            //CollectionAssert.AreEqual(testList, _menu.Identifiers);

        }

        [Test]
        public void TestAddDish()
        {
            _menu.addDish(burger);
            Assert.IsTrue(_menu.Dishes.Contains(burger));
        }

        [Test]
        public void TestDeleteDish()
        {
            _menu.addDish(burger);
            _menu.addDish(pasta);
            _menu.deleteDish(1);
            Assert.IsFalse(_menu.Dishes.Contains(burger));
        }
    }
}
