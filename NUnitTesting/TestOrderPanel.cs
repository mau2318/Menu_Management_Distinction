using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MenuManagement;
using System.IO;

namespace NUnitTesting
{
    [TestFixture()]
    public class TestOrderPanel
    {
        private OrderPanel _orderPanelTest;
        private Menu _menu;
        private Dish burger, pasta, croissant;

        [SetUp]
        public void SetUp()
        {
            _orderPanelTest = new OrderPanel();
            _menu = new Menu(new string[] { "Full", "MENU" }, "Full menU");
            burger = new Dish(new string[] { "bUrger", " anGus beef" }, "beef burger", "Classic angus beef burger served with cheese, lettuce and tomato.", 9.9);
            pasta = new Dish(new string[] { "cream", "pasta" }, "creamy pasta", "Creamy pasta with seafood or ham.", 12.99);
            croissant = new Dish(new string[] { "pastry", "croissant", "vegan" }, "Classic croissant", "Freshly baked croissant.", 4.9);
            _menu.addDish(burger);
            _menu.addDish(pasta);
            _menu.addDish(croissant);
        }

        [Test]
        public void TestMenuExists()
        {
            // Test object exists
            Assert.IsNotNull(_orderPanelTest);
        }

        [Test]
        public void TestAddDishtoOrder()
        {
            _orderPanelTest.addDishToOrder(_menu, 1);
            _orderPanelTest.addDishToOrder(_menu, 3);
            Assert.IsTrue(_orderPanelTest.OrderList.Contains(burger));
            Assert.IsTrue(_orderPanelTest.OrderList.Contains(croissant));
        }
       
        [Test]
        public void TestDeleteDishFromOrder()
        {
            _orderPanelTest.addDishToOrder(_menu, 2);
            _orderPanelTest.deleteDishFromOrder(1);
            Assert.IsFalse(_orderPanelTest.OrderList.Any());
        }
      
        [Test]
        public void TestCalculatePriceAndFinalizeOrder()
        {
            _orderPanelTest.addDishToOrder(_menu, 2);
            _orderPanelTest.addDishToOrder(_menu, 3);
            _orderPanelTest.addDishToOrder(_menu, 1);
            _orderPanelTest.FinalizeOrder();
            Assert.AreEqual(burger.Price + pasta.Price + croissant.Price, _orderPanelTest.DailySaleTotal);
            Assert.AreEqual(1, _orderPanelTest.GuestCount);
        }     
    }
}

