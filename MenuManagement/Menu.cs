using System;
using System.Collections.Generic;
namespace MenuManagement
{
    public class Menu:IdentifiableEntities
    {
        private List<Dish> _dishes;
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="ids">the menu should be identified by its name and acronym
        /// identifiers should be all lowercase letters! identifers for menu may not
        /// be necessary because menu will be identified by its index number in
        /// order's arrylist. </param>
        /// <param name="name">menu name</param>
        public Menu(String[] ids, String name)
            :base(ids, name)
        {
            _dishes = new List<Dish>();
        }

        /// <summary>
        /// should be able to identify itelf by its own identifier,
        /// </summary>
        public override void Locate()
        {
        }

        public List<Dish> Dishes
        {
            get { return _dishes; }
        }

        public void addDish(Dish d)
        {
            _dishes.Add(d);
        }

        public void deleteDish(int num)
        {
            _dishes.RemoveAt(num - 1);
        }

    }
}
