using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MyScriptureJournal.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>()))
            {
                // Look for any movies.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Date = DateTime.Parse("2016-2-12"),
                        Book = "Alma",
                        Chapter = 37,
                        Verse = 37,
                        Notes = "This is my favorite scripture"
                    },

                     new Scripture
                     {
                         Date = DateTime.Parse("2016-2-13"),
                         Book = "1 Nephi",
                         Chapter = 1,
                         Verse = 3,
                         Notes = "This is another favorite scripture"
                     },

                     new Scripture
                     {
                         Date = DateTime.Parse("2016-2-13"),
                         Book = "2 Nephi",
                         Chapter = 2,
                         Verse = 2,
                         Notes = "This is my other favorite scripture"
                     },

                     new Scripture
                     {
                         Date = DateTime.Parse("2016-2-15"),
                         Book = "Moroni",
                         Chapter = 10,
                         Verse = 5,
                         Notes = "This is my favorite scripture"
                     }
                );
                context.SaveChanges();
            }
        }
    }
}
