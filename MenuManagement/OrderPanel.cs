using System;
using System.IO;
using System.Collections.Generic;
namespace MenuManagement
{
    public class OrderPanel:IdentifiableEntities
    {
        private List<Menu> _menuList;
        private List<Dish> _orderList;
        private double totalPrice;
        private StreamWriter _orderHistory;
        public OrderPanel():base
            (new String[] {"op", "order panel" }, "Order Panel")
        {
            _menuList = new List<Menu>();
            _orderList = new List<Dish>();
            _orderHistory = new StreamWriter("Orderhistory.txt");
        }


        /// <summary>
        /// this method should be able to load information from a
        /// text file, adding different menu to the menu list.
        /// </summary>
        public override void Load()
        {

        }

        public override void Save()
        {
            _orderHistory.WriteLine("Order is :");
            foreach (Dish d in _orderList)
            {
                _orderHistory.WriteLine(d.Name + "  Price:" + d.Price);
            }
            _orderHistory.WriteLine("Total price is: " + totalPrice + "\n\n");
        }

        public override void Locate()
        {
            ///
        }

        /// <summary>
        /// this method calculates the total price
        /// </summary>
        public void calculatePrice()
        {
            double totalPrice = 0;
            foreach (Dish d in _orderList)
            {
                totalPrice += d.Price;
            }
            Console.WriteLine("The bill comes to: " + totalPrice + "$.");
            clearOrderList();
        }
        /// <summary>
        /// this method shoule be able to be called for the customer to finalize their orders
        /// </summary>
        public void processOrder()
        {
            displayOrder();
            calculatePrice();
            Save();
            clearOrderList();
        }
        /// <summary>
        /// this method  is called to display the order.
        /// </summary>
        public void displayOrder()
        {
            Console.WriteLine("You have ordered:");
            foreach (Dish d in _orderList)
            {
                Console.WriteLine(d.Name + "  Price:" + d.Price + "\n" + d.Description);
            }
        }
        /// <summary>
        /// the orderList should be cleared after customers finish ordering
        /// </summary>
        private void clearOrderList()
        {
            _orderList.Clear();

        }

        public void addDishToOrder(Dish aDish)
        {
            _orderList.Add(aDish);
            displayOrder();
        }

        public void deleteDishFromOrder(Dish aDish)
        {
            _orderList.Remove(aDish);
            displayOrder();
        }

    }
}
