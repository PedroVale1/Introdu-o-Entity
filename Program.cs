using Microsoft.EntityFrameworkCore;
using System.Linq;
using Blogg.Data;
using Blogg.Models;
using System;

namespace Blogg
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new BlogDataContext())
            {
                // var tag = new Tag{Name = ".Net", Slug = "dotnet"};
                // context.Tags.Add(tag);
                // context.SaveChanges();

                // var tag2 = new Tag { Name = "ASP.NET", Slug = "aspnet" };
                // context.Tags.Add(tag2);
                // context.SaveChanges();

                // var tag = context
                // .Tags
                // .FirstOrDefault(x => x.Id==3);
                // tag.Name = "Ponto NET";
                // tag.Slug = "pontonet";

                // context.Update(tag);
                // context.SaveChanges();

                // var tag = context.Tags.FirstOrDefault(x => x.Id == 2);

                // context.Remove(tag);
                // context.SaveChanges();

                // var tags = context
                // .Tags
                // .AsNoTracking()
                // .ToList();

                // foreach (var tag in tags)
                // {
                //     Console.WriteLine(tag.Name);
                // }

                // var tag = context
                // .Tags
                // .AsTracking()
                // .FirstOrDefault(x => x.Id == 3);
                // Console.WriteLine(tag?.Name);
            }
        }
    }
}
