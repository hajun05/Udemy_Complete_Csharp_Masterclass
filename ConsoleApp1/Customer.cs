using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Customer : People
    {
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        public Customer(string name, string address, string cantatcNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = cantatcNumber;
        }

        public Customer(string name)
        {
            Name = name;
        }

        public Customer() { }

        public void SetDetails(string name, string address, string cantatcNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = cantatcNumber;
        }
    }

    internal class People
    {
        public string Name { get; set; }

        virtual public void SetDetails()
        {

        }
    }
}
