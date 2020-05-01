using System;
using System.Collections.Generic;
namespace MenuManagement
{
    public class OrderPanel:IdentifiableEntities
    {
        private List<Menu> _menuList;
        private List<Dish> _orderList;
        private double totalPrice;

        public OrderPanel():base
            (new String[] {"op", "order panel" }, "Order Panel")
        {
            _menuList = new List<Menu>();
            _orderList = new List<Dish>();
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

        }

        public override void Locate()
        {
        }


        /// <summary>
        /// this method shoule be able to be called to 
        /// </summary>
        public void processOrder()
        {

        }

        public void addDishToOrder()
        {

        }

        public void deleteDishFromOrder()
        {

        }

    }
}
