internal class Program
{
  private static void Main(string[] args)
  {
    var builder = WebApplication.CreateBuilder(args);
    var app = builder.Build();

    Controllers.BlogController blogController = new Controllers.BlogController();

    app.MapGet("/health", () => "Server running!");

    // Add a new blog
    app.MapPost("/blog", (Models.CreateBlogRequest request) =>
    {
      Console.WriteLine($"Title: {request.title}");
      Console.WriteLine($"Body: {request.body}");

      blogController.AddBlog(request.title, request.body);

      return Results.Created();
    });

    // Get All Blogs
    app.MapGet("/blog", () =>
    {
      return Results.Ok(blogController.GetAllBlogs());
    });

    app.Run();
  }
}