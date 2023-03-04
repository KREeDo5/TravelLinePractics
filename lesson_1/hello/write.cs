using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part
{
    internal class First
    {
        private string _name;

        public string Name
        {
            get 
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public First(string name)
        {
            _name = name;
        }
    }
}
