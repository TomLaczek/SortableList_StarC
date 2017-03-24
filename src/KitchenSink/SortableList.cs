using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Starcounter;

namespace KitchenSink
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int IdPerson;

    }
 


    [Database]
    class SortableList
    {
        public static void Main()
        {

            //    Db.Transact(() =>
            //    {
            //        var anyone = Db.SQL<Person>("SELECT p FROM Person p").First;
            //    });

            //    Db.Transact(() => { new Person { FirstName = "John", LastName = "Simons", IdPerson = 2 }; });
            //    Db.Transact(() => { new Person { FirstName = "John", LastName = "Simons", IdPerson = 3 }; });
            //    Db.Transact(() => { new Person { FirstName = "John", LastName = "Simons", IdPerson = 4 }; });
            //    Db.Transact(() => { new Person { FirstName = "John", LastName = "Simons", IdPerson = 5 }; });
            //    Db.Transact(() => { new Person { FirstName = "John", LastName = "Simons", IdPerson = 6 }; });
            //    Db.Transact(() => { new Person { FirstName = "John", LastName = "Simons", IdPerson = 7 }; });
            //    Db.Transact(() => { new Person { FirstName = "John", LastName = "Simons", IdPerson = 8 }; });
            //    Db.Transact(() => { new Person { FirstName = "John", LastName = "Simons", IdPerson = 9 }; });
            //    Db.Transact(() => { new Person { FirstName = "John", LastName = "Simons", IdPerson = 10 }; });

        }
    }
}
