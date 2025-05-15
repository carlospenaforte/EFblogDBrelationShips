namespace EFblogDBrelationShips.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public string ImageUrl { get; set; }


        public ICollection<Blog> Blogs { get; set; } 
    }
}
