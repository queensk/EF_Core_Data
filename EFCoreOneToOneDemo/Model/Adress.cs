using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreOneToOneDemo.Model
{
    public class Adress
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Street { get; set; }

        [Required]
        public string City { get; set; }

        public int PersonId { get; set; }
        
    }
}