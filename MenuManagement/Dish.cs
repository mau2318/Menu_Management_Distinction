using System;
namespace MenuManagement
{
    public class Dish:IdentifiableEntities
    {
        private String _description;
        private double _price;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="ids">the dish should be identified by its name and acronym
        /// identifiers should be all lowercase letters!</param>
        /// <param name="name">dish name, combination of lowercase and uppercase letters</param>
        public Dish
            (String[] ids, String name, String description, double price)
            :base(ids, name)
        {
            _description = description;
            _price = priceRange(price);
        }

        /// <summary>
        /// the method return type is not determined yet
        /// it could return a string for other objects/classes to print out
        /// or it could print out the string on its own
        /// this method will display the discription of each dish.
        /// not to be confused with _description, this method will show a full
        /// description of the dish.
        /// </summary>
        public void displayFullDiscription()
        {

        }

        public override void Load()
        {

        }

        public override void Save()
        {

        }

        private double priceRange(double num)
        {
            if (num < 150 && num > 0)
                return num;
            return 0;
        }

        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = priceRange(value); }
        }
    }
}
