namespace Models.Post
{
    public class Post
    {
        public int PostId { get; set; }
        public string Content { get; set; } = string.Empty;
        public int BlogId { get; set; } // Para relacionar com Blog
    }
}
