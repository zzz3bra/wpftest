using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBrowserApplication1.Model
{
    public class Car
    {
        public string Name { get; set; }
        public Car()
        {
            Name = "Honda1488";
        }
        public Car(string name)
        {
            Name = name;
        }
        override public string ToString()
        {
            return Name;
        }
    }
}
