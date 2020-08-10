using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLessons.Models
{
    class FirstClass
    {
        public int id1 = default;
        public string id2 = default;

        public FirstClass() { }

        public FirstClass(int id1, string id2)
        {
            this.id1 = id1;
            this.id2 = id2;
        }

        public override string ToString()
        {
            return $"id1 = {id1}, id2 = {id2}";
        }
    }
}
