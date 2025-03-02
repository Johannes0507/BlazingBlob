using BlazingBlob.Domain.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingBlob.Application.Articles
{
    public class ArticleService : IArticleService
    {
        public List<Article> GetAllArticle()
        {
            return
            [
                new() { Id = 1, Title = "Article 1", Content = "Content 1", DatePublished = DateTime.Now, IsPublished = true },
                new() { Id = 2, Title = "Article 2", Content = "Content 2", DatePublished = DateTime.Now, IsPublished = true },
                new() { Id = 3, Title = "Article 3", Content = "Content 3", DatePublished = DateTime.Now, IsPublished = true },
                new() { Id = 4, Title = "Article 4", Content = "Content 4", DatePublished = DateTime.Now, IsPublished = true },
                new() { Id = 5, Title = "Article 5", Content = "Content 5", DatePublished = DateTime.Now, IsPublished = true }
            ];
        }
    }
}
