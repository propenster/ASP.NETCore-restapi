using System;
using System.Collections.Generic;
using System.Text;

namespace RESTAPIYouTube.Domain
{
    public class Developer
    {
        public int Id { get; set; }
        public string DeveloperName { get; set; }
        public string Email { get; set; }
        public string GithubURL { get; set; }
        public string ImageURL { get; set; }
        public string Department { get; set; }
        public DateTime JoinedDate { get; set; }

    }
}
