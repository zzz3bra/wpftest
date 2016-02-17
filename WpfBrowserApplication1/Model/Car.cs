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
            Name = "Honda";
        }
        public Car(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                Name = "Honda";
            }
            else
            {
                Name = name;
            }
        }
        override public string ToString()
        {
            return Name;
        }
    }
}
