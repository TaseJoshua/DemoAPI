using DemoAPI.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Linq;

namespace DemoAPI.Controllers
{
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();


        public PeopleController()
        {
            people.Add(new Person { FirstName = "Tase", Id = 1, LastName = "Akpo" });
            people.Add(new Person { FirstName = "Cersei", Id = 2, LastName = "Lannister" });
            people.Add(new Person { FirstName = "Beni", Id = 3, LastName = "Ibeh" });
        }
        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(person => person.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person val)
        {
            people.Add(val);
        }

     
        // DELETE: api/People/5
        public void Delete(int id)
        {
            people.Remove(people.Where(person => person.Id == id).FirstOrDefault());
        }
    }
}
