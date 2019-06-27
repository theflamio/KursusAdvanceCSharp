using System;
using System.Collections.Generic;
using System.Linq;
using SQLiteEF;

namespace Opgaver_DataBaser_Entity_Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SQLiteEF.PeopleContext c = new SQLiteEF.PeopleContext())
            {
                List<SQLiteEF.Person> lst;
                //lst = c.People.ToList();
                //lst.ForEach(i => Console.WriteLine(i));


                //lst = c.People.Take(5).ToList();
                //lst.ForEach(i => Console.WriteLine(i));


                //lst = c.People.OrderBy(i => i.LastName).ToList();
                //lst.ForEach(i => Console.WriteLine(i));


                //lst = c.People.OrderBy(i => i.Gender).ThenBy(i => i.LastName).ToList();
                //lst.ForEach(i => Console.WriteLine(i));


                //lst = c.People.Where(i => i.Gender.Equals(1)).ToList();
                //lst.ForEach(i => Console.WriteLine(i));


                //lst = c.People.Where(i => i.Gender.Equals(1) && i.IsHealthy).ToList();
                //lst.ForEach(i => Console.WriteLine(i));


                //lst = c.People.Where(i => i.Gender.Equals(1) && i.IsHealthy).OrderBy(i => i.LastName).ToList();
                //lst.ForEach(i => Console.WriteLine(i));


                //var res = c.People.GroupBy(i => i.IsHealthy);
                //foreach (var item in res)
                //{
                //    Console.WriteLine($"IsHealthy {item.Key}");
                //    foreach (var item2 in item)
                //    {
                //        Console.WriteLine($"\t Navn: {item2.FirstName}");
                //    }
                //} 

                //var p = c.People.Where(i => i.PersonId == 1).FirstOrDefault();
                //p.Height = 150;
                //c.SaveChanges();
                //lst = c.People.OrderBy(i => i.PersonId).ToList();
                //lst.ForEach(i => Console.WriteLine(i));

                SQLiteEF.Person person = new SQLiteEF.Person();
                person.FirstName = "a";
                person.LastName = "b";
                person.DateOfBirth = DateTime.Now;
                person.Gender = 1;
                person.Height = 180;
                person.IsHealthy = true;
                c.People.Add(person);
                c.SaveChanges();

                //int id = person.PersonId;

                //Console.WriteLine($"Person oprettet med {id}");

                //var p = c.People.Where(i => i.PersonId == id).FirstOrDefault();

                //c.People.Remove(p);

                //c.SaveChanges();
            }
        }
    }
}

namespace SQLiteEF
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.DependencyInjection;

    [Table("person")]
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsHealthy { get; set; }
        public int Gender { get; set; }
        public int Height { get; set; }

        public override string ToString()
        {
            return $"I'm {FirstName} {LastName} with id {PersonId} born {DateOfBirth.ToShortDateString()}. I'm {(IsHealthy ? "healthy" : "not healthy")}, a {(Gender == 1 ? "woman" : "man")} and {Height} cm.";
        }

    }

    public class PeopleContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=c:\\temp\\people.db");
            // Enable logging to console
            optionsBuilder.UseLoggerFactory(GetLoggerFactory());

        }

        // For logging...
        private ILoggerFactory GetLoggerFactory()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging(builder =>
                   builder.AddConsole()
                          .AddFilter(DbLoggerCategory.Database.Command.Name,
                                     LogLevel.Information));
            return serviceCollection.BuildServiceProvider()
                    .GetService<ILoggerFactory>();
        }
    }
}

