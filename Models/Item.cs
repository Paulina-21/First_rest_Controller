using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_rest_Controller.Models
{
    public class Item
    {
        public Item(){}

        public Item(int Id, string name, int quality, int quantity)
        {
            this.Id = Id;
            Name = name;
            ItemQuality = quality;
            Quantity = quantity;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ItemQuality { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
