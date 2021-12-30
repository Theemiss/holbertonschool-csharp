using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    public class Item : BaseClass
    {
        private string _name;

        public string name
        {
            get { return _name; }
            set
            {
                updatetime();

                _name = value;
            }
        }
        private string _descrption;
        public string description
        {
            set
            {
                updatetime();

                _descrption = value;
            }
            get { return _descrption; }
        }
        private float _price;
        public float price
        {
            set
            {
                updatetime();

                _price = (float)Math.Round(value * 100) / 100f;
            }
            get { return _price; }
        }
        private List<string> _tags;

        public List<string> tags
        {
            set
            {
                updatetime();
                _tags = value;
            }
            get { return _tags; }
        }
        public Item(string name)
        {
            this.name = name;
            tags = new List<string>();
        }
    }
}
