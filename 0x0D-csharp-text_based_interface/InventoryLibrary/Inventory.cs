using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryLibrary
{
    public class Inventory : BaseClass
    {
        private string _user_id;
        private string _item_id;
        private int _quantity;
        public string user_id { get { return _user_id; } set
            {
                updatetime();
                _user_id = value;
            }
        }
        public string item_id { get { return _item_id; } set {
                updatetime();

                _item_id = value;
            } }
        public int quantity { get { return _quantity; } set {
                updatetime();

                if (value < 0)
                    value = 0;
                _quantity = value;

            }
        }
        public Inventory(User user, Item item, int quantity = 1)
        {
            user_id = user.id;
            item_id = item.id;
            this.quantity = quantity;
        }


    }

}
