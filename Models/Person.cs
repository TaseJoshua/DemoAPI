using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAPI.Models
{
    /// <summary>
    /// Class to represent one specific person
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Id from SQL
        /// </summary>
        public int Id { get; set; } = 0;
        /// <summary>
        /// Users firstname
        /// </summary>
        public string FirstName { get; set; } = "";
        /// <summary>
        /// It is obvious what this is
        /// </summary>
        public string LastName { get; set; } = "";

    }
}