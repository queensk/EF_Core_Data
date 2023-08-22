// Create a new person with an address
using EFCoreOneToOneDemo.Model;
using EFCoreOneToOneDemo.Context;
using Microsoft.EntityFrameworkCore;

OneToOneDemoContext context = new();

var person = new Person
{
    Name = "John Doe",
    Address = new Address
    {
        Street = "123 Main Street",
        City = "New York"
    }
};

// Add the person to the context and save changes
context.People.Add(person);
context.SaveChanges();
Console.WriteLine($"Person: {person.Name}, Address: {person.Address.Street}, {person.Address.City}");

// Retrieve a person by id with their address
var person1 = context.People.Include(p => p.Address).FirstOrDefault(p => p.Id == 1);

// Update the person's name and address
// person.Name = "Jane Doe";
// person.Address.Street = "456 Main Street";
// person.Address.City = "Los Angeles";

// Save changes to the context
// context.SaveChanges();

// Delete the person and their address
// context.People.Remove(person);
// context.SaveChanges();

var person2 = new Person
{
    Name = "John Doe",
    Address = new Address
    {
        Street = "123 Main Street",
        City = "New York"
    }
};

// // Add the person to the context and save changes
// using (var context = new OneToOneDemoContext())
// {
//     context.People.Add(person);
//     context.SaveChanges();
// }

// // Retrieve a person by id with their address
// using (var context = new OneToOneDemoContext())
// {
//     var person = context.People.Find(1);
//     Console.WriteLine($"Person: {person.Name}, Address: {person.Address.Street}, {person.Address.City}");
// }

// // Update the person's name and address
// using (var context = new OneToOneDemoContext())
// {
//     var person = context.People.Find(1);
//     person.Name = "Jane Doe";
//     person.Address.Street = "456 Main Street";
//     person.Address.City = "Los Angeles";

//     // Save changes to the context
//     context.SaveChanges();
// }

// // Delete the person and their address
// using (var context = new OneToOneDemoContext())
// {
//     var person = context.People.Find(1);
//     context.People.Remove(person);
//     context.SaveChanges();
// }