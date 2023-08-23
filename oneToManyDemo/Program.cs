// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using oneToManyDemo.Models;
using oneToManyDemo.Query;

Person person = new Person(){
    Name = "John",
    PersonAddress = new Address(){
        City = "New York",
        State = "NY"
    }
};

Query query = new Query();

await query.CreatePerson(person);
