using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BindReader
{
    public class Class
    {
        public String Name { get; set; }
        public List<Item> Items { get; set; }
    }
    public class Item
    {
        public string Language { get; set; }
        public string Tool { get; set; }
    }
}
