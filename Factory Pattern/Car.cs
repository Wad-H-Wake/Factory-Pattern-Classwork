using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    class Car
    {
        public string company;
        public string model;
        public int speed;

        abstract private string get_company;
        abstract private string get_model;
        abstract private void set_model;
        abstract private int get_speed;
        abstract private void set_speed;
        
    }
}
