using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreOneToOneDemo.Model
{
    [Table("Address, Schema = public")]
    public class Address
    {
        [Key]
        [ForeignKey("Person")]
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public Person Person { get; set; }
        
    }
}