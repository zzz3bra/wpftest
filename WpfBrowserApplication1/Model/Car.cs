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
            Name = "Honda1488"; // Комментарии тоже обновляются?)
            //канешн
            //особенно если дед был штурмфюрер СС
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
