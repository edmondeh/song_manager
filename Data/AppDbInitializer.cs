using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Songs_Manager.Data.Models;
using Songs_Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Songs_Manager.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                if (!context.Artists.Any())
                {
                    context.Artists.AddRange(new Artist()
                    {
                        Name = "Artist 1",
                        Slug = "Artist-1",
                        Country = "Country",
                        Bio = "Bio"
                    },
                    new Artist()
                    {
                        Name = "Artist 2",
                        Slug = "Artist-2",
                        Country = "Country",
                        Bio = "Bio"
                    });

                    context.SaveChanges();
                }

                if (!context.Songs.Any())
                {
                    context.Songs.AddRange(new Song()
                    {
                        Name = "Song 1",
                        Slug = "Song-1",
                        Album = "Album",
                        Lyrics = "Lyrics",
                        UserName = ""
                },
                    new Song()
                    {
                        Name = "Song 2",
                        Slug = "Song-2",
                        Album = "Album",
                        Lyrics = "Lyrics",
                        UserName = ""
                });

                    context.SaveChanges();
                }
            }
        }
    }
}
