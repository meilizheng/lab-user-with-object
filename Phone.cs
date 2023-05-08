using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace lab_user_with_object
{
    public class Phone
    {
        public string _Brand;
        public string _type;
        public string _name;
        private bool fuction;

        public Phone(string brand, string type, string name)
        {
            _Brand = brand;
            _type = type;
            _name = name;
        }
        public string Brand1 { get => _Brand; set => _Brand = value; }
        public string Type { get => _type; set => _type = value; }
        public string Name { get => _name; set => _name = value; }
        public bool Fuction { get => fuction; set => fuction = value; }

        public void IsSmartPhone(bool fuction)
        {
            if (fuction)
            {
                Console.WriteLine("smart");
            }
            else
            {
                Console.WriteLine("not smart");
            }
        }

        public override string ToString()
        {
            return $"{_name} {_Brand} {_type}";
        }
    }
}
