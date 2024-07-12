using Google.Protobuf.WellKnownTypes;
using MyExample.AddressBook;
using MyExample.Cat;
using System.Text.Json;
using Tutorial;
using static MyExample.AddressBook.Person.Types;

Console.WriteLine("Hello");
var addressBook = new AddressBook();
var firstPerson = new Person()
{
    Id = 1,
    Email = "my@email.com",
    Name = "John Doe",
    LastUpdated = Timestamp.FromDateTime(DateTime.UtcNow),
    Phones =
    {
        new PhoneNumber()
        {
            Number="122432542342",
            Type=PhoneType.Home
        },
        new PhoneNumber()
        {
            Number="545456465",
            Type=PhoneType.Work
        }

    }
};
addressBook.People.Add(firstPerson);

Console.WriteLine(JsonSerializer.Serialize(addressBook, new JsonSerializerOptions { WriteIndented = true }));