using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    #region Functions (prototype)
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public  string Print()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}";
        }

    }
    #endregion
}
