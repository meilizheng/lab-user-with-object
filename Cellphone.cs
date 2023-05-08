using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_user_with_object
{
    internal class Cellphone : Phone //creat a inheritance class called cellphone;
    {
        public Cellphone(string brand, string type, string name) : base(brand, type, name) //creat constructor based on parent class;
        {
        }
    }
}
