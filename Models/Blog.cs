namespace Models.Blog
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; } = string.Empty;
        public virtual List<Models.Post.Post> Posts { get; set; } = new List<Post.Post>(); // Use List<Models.Post.Post> se necessário
    }
}
