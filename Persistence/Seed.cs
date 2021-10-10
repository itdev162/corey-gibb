using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (context.Posts.Count() == 0)
            {
                List < Post > seedPosts = new List<Post>
                {
                    new Post()
                    {
                        title = "First Post", Body = "This is the body of my first post.  It will be used if there is no post in the database."
                    },
                    new Post()
                    {
                        title = "Second Post", Body = "This is the body of my second post.  It will be used if there is no post in the database."
                    },
                    new Post()
                    {
                        title = "Third Post", Body = "This is the body of my third post.  It will be used if there is no post in the database."
                    }
                };
                
                context.Posts.AddRange(seedPosts);

                context.SaveChanges();
            }
        }
    }
}