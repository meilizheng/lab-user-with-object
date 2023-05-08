using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_user_with_object
{
    internal class Smartphone : Phone //creat a inheritance class called smartphone;
    {
        bool watchmovie;  //add a field based on the parent class;
        public Smartphone(string brand, string type, string name, bool watchmovie = false) : base(brand, type, name) //creat a constructor base on the parent class;
        {
            this.Watchmovie = watchmovie; 
        }

        public bool Watchmovie { get => watchmovie; set => watchmovie = value; } //creat property;

        public override string ToString()  //use override to display result;
        {
            return $"Name: {_name}  Brand: {_Brand} ";
        }
    }
}
