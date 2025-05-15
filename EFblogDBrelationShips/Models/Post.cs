namespace EFblogDBrelationShips.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }

        // Navigaton property
        public Blog Blog { get; set; }
    }
}
