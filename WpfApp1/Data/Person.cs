using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; } = "";

        public Person(string name,  int age)
        {
            Age=age;
            Name=name;
        }
    }
}
