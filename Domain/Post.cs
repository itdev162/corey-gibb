using System;

namespace Domain
{
    public class Post
    {
        public Guid Id { get; set; }

        public string title { get; set; }

        public string Body { get; set; }

        public DateTime Date { get; set;}
        
    }
}