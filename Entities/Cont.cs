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

        public Cont()
        {
            id = generateRandomID();
        }

        public Cont( string categorie, string userName, string password, string description )
        {
            id = generateRandomID();
            this.categorie = categorie;
            this.userName = userName;
            this.password = password;
            this.description = description;
            this.concatAllProperties = concatProperties();
        }
        public Cont( long id, string categorie, string userName, string password, string description )
        {
            this.id = id;
            this.categorie = categorie;
            this.userName = userName;
            this.password = password;
            this.description = description;
            this.concatAllProperties = concatProperties();
        }

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

        public override string? ToString()
        {
            return "username = " + userName + "\n"
                + "parola = " + password;
        }

        private string concatProperties()
        {
            return Regex.Replace(
                ( categorie + userName + description ).ToLower(), @"\d|\W", "");
        }
    }
}
