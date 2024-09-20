using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Data.BloggingContext;
using Models.Blog;


class Program{
    static void Main(string[] args){

    using (var db = new BloggingContext()){

        Console.Write("Enter a name for a new Blog: ");
        string name = Console.ReadLine();

        var blog = new Blog {Name = name};
        db.Blogs.Add(blog);
        db.SaveChanges();

        var query = from x in db.Blogs 
                    orderby x.Name
                    select x;

        Console.Write("All blogs in DB: ");
        foreach (var i in query){
            Console.Write(i.Name);
        }

        Console.Write("Press any key to exit");
        Console.ReadKey();
    }
}
}

