using System.Collections.Generic;
using VideoStore.Common.Models;

namespace VideoStore.Client.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<VideoStore.Client.VideoStoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(VideoStore.Client.VideoStoreContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Movies.AddOrUpdate(
                m => m.Title,
                new Movie()
                {
                    Title = "Fast and Furious",
                    Actors = new List<Actor>()
                    {
                        new Actor()
                        {
                            FirstName = "Vin",
                            LastName = "Diesel"
                        },
                        
                        new Actor()
                        {
                            FirstName = "Paul",
                            LastName = "Walker"
                        }
                    },
                    Genre = new Genre()
                    {
                        Title = "Action"
                    },

                    Dvds = new List<Dvd>()
                    {
                        new Dvd()
                        {
                            IsAvailable = true,
                        },
                        new Dvd()
                        {
                            IsAvailable = true
                        },
                        new Dvd()
                        {
                            IsAvailable = false
                        }
                    }
                },

                new Movie()
                {
                    Title = "Fantastic Beasts and Where to Find",
                    Actors = new List<Actor>()
                    {
                        new Actor()
                        {
                            FirstName = "Eddie",
                            LastName = "Redmayne"
                        },

                        new Actor()
                        {
                            FirstName = "Johnny",
                            LastName = "Depp"
                        }
                    },
                    Genre = new Genre()
                    {
                        Title = "Drama"
                    },

                    Dvds = new List<Dvd>()
                    {
                        new Dvd()
                        {
                            IsAvailable = true,
                        },
                        new Dvd()
                        {
                            IsAvailable = true
                        },
                        new Dvd()
                        {
                            IsAvailable = false
                        }
                    }
                }
            );
        }
    }
}
