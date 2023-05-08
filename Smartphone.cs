using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_user_with_object
{
    internal class Smartphone : Phone
    {
        bool watchmovie;
        public Smartphone(string brand, string type, string name, bool watchmovie = false) : base(brand, type, name)
        {
            this.Watchmovie = watchmovie;
        }

        public bool Watchmovie { get => watchmovie; set => watchmovie = value; }

        public override string ToString()
        {
            return $"Name: {_name}  Brand: {_Brand} ";
        }
    }
}
