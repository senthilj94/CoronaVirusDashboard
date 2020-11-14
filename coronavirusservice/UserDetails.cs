using System;
using System.Collections.Generic;
using System.Text;

namespace coronavirusservice
{

    public class UserDetails
    {
        public User[] Users { get; set; }
    }

    public class User
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }

}
