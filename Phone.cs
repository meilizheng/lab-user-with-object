using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace lab_user_with_object
{
    public class Phone  //creat a phone class as a parent class;
    {
        public string _Brand; //creat filed;
        public string _type;
        public string _name;
        private bool fuction;

        public Phone(string brand, string type, string name) //creat constructor with three arguments;
        {
            _Brand = brand;
            _type = type;
            _name = name;
        }
        public string Brand1 { get => _Brand; set => _Brand = value; } //creat property;
        public string Type { get => _type; set => _type = value; }
        public string Name { get => _name; set => _name = value; }
        public bool Fuction { get => fuction; set => fuction = value; }

        public void IsSmartPhone(bool fuction) //creat method to check the phone is smart phone or not, 
        {
            if (fuction)  //if this phone has fuction like can play game or watch movie online, display it is smart phone;
            {
                Console.WriteLine("smart");
            }
            else  //else display not smart phone;
            {
                Console.WriteLine("not smart");
            }
        }

        public override string ToString()  //use override tostring display resut;
        {
            return $"{_name} {_Brand} {_type}";
        }
    }
}
