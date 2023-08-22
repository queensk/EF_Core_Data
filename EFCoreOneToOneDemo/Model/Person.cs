using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreOneToOneDemo.Model
{
    [Table("Person, Schema = public")]
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation property to the dependent entity
        public Address Address { get; set; }
    }
}