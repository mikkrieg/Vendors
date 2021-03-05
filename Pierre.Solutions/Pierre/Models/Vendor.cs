using System.Collections.Generic;

namespace Pierre.Models
{
    public class Vendor
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public List<Order> Orders { get; set; }
        private static List<Vendor> _instances = new List<Vendor> {};

        public Vendor(string name, string description)
        {
            Name = name;
            Description = description;
            Id = _instances.Count;
            Orders = new List<Order>{};
        }

        public static List<Vendor> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}