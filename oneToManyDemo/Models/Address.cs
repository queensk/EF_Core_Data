using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oneToManyDemo.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }

        public int PersonId { get; set; }
        public Person? Person { get; set; }
    }
}