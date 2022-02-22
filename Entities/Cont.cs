using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PassOrganiser.Entities
{
    public class Cont
    {
        public long id { get; set; }
        public string categorie { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string description { get; set; }
        public string concatAllProperties { get; set; }

        /// <summary>
        /// No args constructor.
        /// Sets the id.
        /// </summary>
        public Cont()
        {
            id = generateRandomID();
        }

        /// <summary>
        /// Constructor of COnt Class without receiving id as parameter.
        /// Id is set inside constructor.
        /// For creating new objects for persisting in database.
        /// </summary>
        /// <param name="categorie"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="description"></param>
        public Cont( string categorie, string userName, string password, string description )
        {
            id = generateRandomID();
            this.categorie = categorie;
            this.userName = userName;
            this.password = password;
            this.description = description;
            this.concatAllProperties = concatProperties();
        }

        /// <summary>
        /// All args constructor.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="categorie"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="description"></param>
        public Cont( long id, string categorie, string userName, string password, string description )
        {
            this.id = id;
            this.categorie = categorie;
            this.userName = userName;
            this.password = password;
            this.description = description;
            this.concatAllProperties = concatProperties();
        }

        /// <summary>
        /// Generates a id based on the current time and date.
        /// </summary>
        /// <returns>long</returns>
        private long generateRandomID()
        {
            DateTime dt = DateTime.Now;

            return long.Parse(Regex.Replace(dt.ToString(), "\\D", ""));

        }

        public override bool Equals( object? obj )
        {
            return obj is Cont cont &&
                   categorie == cont.categorie &&
                   userName == cont.userName &&
                   password == cont.password &&
                   description == cont.description;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Override the Object.ToString method, using the username and description of the object.
        /// </summary>
        /// <returns>string</returns>
        public override string? ToString()
        {
            return "username = " + userName + "\n"
                + "description = " + description;
        }

        /// <summary>
        /// Sets the value of concatAllProperties by adding only letter characters, by concatenating all the properties without password.
        /// </summary>
        /// <returns>string</returns>
        private string concatProperties()
        {
            return Regex.Replace(
                ( categorie + userName + description ).ToLower(), @"\d|\W", "");
        }
    }
}
