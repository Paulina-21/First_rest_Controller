using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First_rest_Controller.Models;

namespace First_rest_Controller.Managers
{
    public class ItemManager
    {
        private static int _nextId = 1;

        public static readonly List<Item> items = new List<Item>
        {
            new Item(_nextId++, "Laptop", 10, 1),
            new Item(_nextId++,"Hair",8,3),
            new Item(_nextId++,"brush",9,2)
        };

        public List<Item> GetAll(string name, string quality, string quantity)
        {
            List<Item> _items = new List<Item>(items);

            if (!String.IsNullOrEmpty(name))
            {
                    _items=(_items.FindAll(item => item.Name.StartsWith(name, StringComparison.OrdinalIgnoreCase)));
            }

            if (!String.IsNullOrEmpty(quality))
            {
                _items = (_items.FindAll(item => item.ItemQuality.Equals(quality)));
            }

            if (!String.IsNullOrEmpty(quantity))
            {
                _items = (_items.FindAll(item => item.Quantity.Equals(quantity)));
            }

            return _items;
            // copy constructor
            // Callers should no get a reference to the Items object, but rather get a copy
        }

        public Item GetById(int id)
        {
            return items.Find(item => item.Id == id);
        }

        public Item Add(Item newItem)
        {
            newItem.Id = _nextId++;
            items.Add(newItem);
            return newItem;
        }

        public Item Delete(int id)
        {
            Item item = items.Find(book1 => book1.Id == id);
            if (item == null) return null;
            items.Remove(item);
            return item;
        }

        public Item Update(int id, Item updates)
        {
            Item item = items.Find(item1 => item1.Id == id);
            if (item == null) return null;
            item.ItemQuality = updates.ItemQuality;
            item.Name = updates.Name;
            item.Quantity = updates.Quantity;
            return item;
        }
    }
}
