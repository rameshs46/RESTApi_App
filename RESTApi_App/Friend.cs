using System;
namespace RESTApi_App
{
    public class Friend
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string location { get; set; }

        public Friend()
        {

        }

        public Friend(string firstName, string lastName, string location)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.location = location;
        }
    }
}

