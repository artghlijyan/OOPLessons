using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLessons.Models
{
    class Users
    {
        public Phone Phone { get; set; } = new Phone();
    }

    class Phone
    {
        public Company Company { get; set; } 
    }

    class Company
    {
        public int? Id { get; set; }

        public Company()
        {
            Id = 0;
        }
    }
}
