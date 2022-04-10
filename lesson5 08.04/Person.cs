using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5_08._04
{
    public class Person
    {
        public string Name { get; set; }
        public int Scores { get; set; }
        public double Time { get; set; }

        public Person()
        {
        }
        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{this.Name}, {this.Scores}, {this.Time}";
        }
    }
}
