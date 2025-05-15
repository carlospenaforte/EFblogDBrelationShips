namespace EFblogDBrelationShips.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string AboutMe { get; set; }
        public DateTime CreatedDate { get; set; }

        // navigation property
        public Blog Blog { get; set; }
        public ICollection<Post> Post { get; set; }
    }
}
