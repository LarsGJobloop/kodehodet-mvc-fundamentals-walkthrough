namespace Models;

class Blog
{
  public string Id { get; init; }
  public string Title { get; set; }

  public string Body { get; set; }

  public Blog(string title, string body)
  {
    Title = title;
    Body = body;

    Id = System.Guid.NewGuid().ToString();
  }
}

class BlogList
{
  private List<Blog> blogs;

  public BlogList()
  {
    blogs = new List<Blog>();
  }

  public Blog AddBlog(string title, string body)
  {
    Blog newBlog = new Blog(title, body);

    blogs.Add(newBlog);

    return newBlog;
  }

  public Blog[] GetAllBlogs()
  {
    return blogs.ToArray();
  }
}