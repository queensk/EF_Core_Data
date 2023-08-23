using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using oneToManyDemo.Models;
using oneToManyDemo.Context;
using System.Formats.Asn1;

namespace oneToManyDemo.Query
{
    public class Query
    {
    OneToOneDemoContext _db = new ();

        public async Task CreatePerson(Person person)
        {
            await _db.Persons.AddAsync(person);
            await _db.SaveChangesAsync();
        }
    }
}