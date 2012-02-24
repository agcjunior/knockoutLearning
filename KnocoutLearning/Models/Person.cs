using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnocoutLearning.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Friend> Friends { get; set; }
    }
}