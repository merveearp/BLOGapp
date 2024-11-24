using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class BlogController : Controller
    {
        private List<BlogPost> blogPosts;
        public BlogController()
        {
            blogPosts=[ 

             new BlogPost { Title = "Blog Yazısı 1", Summary = "Bu bir özet 1.", ImageUrl = "https://picsum.photos/200/100?random=1" },
            new BlogPost { Title = "Blog Yazısı 2", Summary = "Bu bir özet 2.", ImageUrl = "https://picsum.photos/200/100?random=2" },
            new BlogPost { Title = "Blog Yazısı 3", Summary = "Bu bir özet 3.", ImageUrl = "https://picsum.photos/200/100?random=3" },
            new BlogPost { Title = "Blog Yazısı 4", Summary = "Bu bir özet 4.", ImageUrl = "https://picsum.photos/200/100?random=4" },
            new BlogPost { Title = "Blog Yazısı 5", Summary = "Bu bir özet 5.", ImageUrl = "https://picsum.photos/200/100?random=5" },
            new BlogPost { Title = "Blog Yazısı 6", Summary = "Bu bir özet 6.", ImageUrl = "https://picsum.photos/200/100?random=6" },
            new BlogPost { Title = "Blog Yazısı 7", Summary = "Bu bir özet 7.", ImageUrl = "https://picsum.photos/200/100?random=7" },
            new BlogPost { Title = "Blog Yazısı 8", Summary = "Bu bir özet 8.", ImageUrl = "https://picsum.photos/200/100?random=8" },
            new BlogPost { Title = "Blog Yazısı 9", Summary = "Bu bir özet 9.", ImageUrl = "https://picsum.photos/200/100?random=9" },
            new BlogPost { Title = "Blog Yazısı 10", Summary = "Bu bir özet 10.", ImageUrl = "https://picsum.photos/200/100?random=10" }
        ];

        }

                public IActionResult Index()
        {
            ViewBag.BlogPost = blogPosts;
        return View(blogPosts);

        }
    }}



   
    
