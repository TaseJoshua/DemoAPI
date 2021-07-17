using DemoAPI.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Linq;

namespace DemoAPI.Controllers
{ 
    /// <summary>
    /// This is where we give information about the class
    /// </summary>
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();


        public PeopleController()
        {
            people.Add(new Person { FirstName = "Tase", Id = 1, LastName = "Akpo" });
            people.Add(new Person { FirstName = "Cersei", Id = 2, LastName = "Lannister" });
            people.Add(new Person { FirstName = "Beni", Id = 3, LastName = "Ibeh" });
        }
        /// <summary>
        /// Gets a list of the first names of all users.//more than one get call/ also passes in more than one value
        /// </summary>
        /// <param name="userId">The Unique Id for this person</param>
        /// <param name="age">We want to know how old they are</param>
        /// <returns>A list of first names</returns>

        [Route("api/People/GetFirstNames/{userId:int}/{age:int}")]
        [HttpGet]
        public List<string> GetFirstName(int userId, int age)
        {
            List<string> output = new List<string>();
            foreach (var p in people)
            {
                output.Add(p.FirstName);
            }
            return output;
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
