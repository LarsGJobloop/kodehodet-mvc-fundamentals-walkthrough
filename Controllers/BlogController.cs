using Models;

namespace Controllers;
class BlogController
{
  private Models.BlogList blogs;

  public BlogController()
  {
    blogs = new Models.BlogList();
  }

  public void AddBlog(string title, string body)
  {
    blogs.AddBlog(title, body);
  }

  public Blog[] GetAllBlogs()
  {
    return blogs.GetAllBlogs();
  }
}
