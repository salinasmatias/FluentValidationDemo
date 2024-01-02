using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public int Stock {  get; set; }
    }

    public enum Category
    {
        CPU = 0,
        GPU = 1,
        PSU = 2,
        RAM = 3,
        Storage = 4,
        Motherboard = 5,
        PowerSupply = 6,
        Case = 7,
        Keyboard = 8,
        Mouse = 9
    }
}
