namespace VideoStore.Client.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        ActorId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.ActorId);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Genre_GenreId = c.Int(),
                    })
                .PrimaryKey(t => t.MovieId)
                .ForeignKey("dbo.Genres", t => t.Genre_GenreId)
                .Index(t => t.Genre_GenreId);
            
            CreateTable(
                "dbo.Dvds",
                c => new
                    {
                        DvdId = c.Int(nullable: false, identity: true),
                        MovieId = c.Int(nullable: false),
                        IsAvailable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.DvdId)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .Index(t => t.MovieId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.GenreId);
            
            CreateTable(
                "dbo.TransactionItems",
                c => new
                    {
                        TransactionItemId = c.Int(nullable: false, identity: true),
                        TransactionId = c.Int(nullable: false),
                        Returned = c.Boolean(nullable: false),
                        DateReturned = c.DateTime(),
                        ExpectedReturnDate = c.DateTime(nullable: false),
                        DvdId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TransactionItemId)
                .ForeignKey("dbo.Dvds", t => t.DvdId, cascadeDelete: true)
                .ForeignKey("dbo.Transactions", t => t.TransactionId, cascadeDelete: true)
                .Index(t => t.TransactionId)
                .Index(t => t.DvdId);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        TransactionId = c.Int(nullable: false, identity: true),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TransactionId);
            
            CreateTable(
                "dbo.MovieActors",
                c => new
                    {
                        Movie_MovieId = c.Int(nullable: false),
                        Actor_ActorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Movie_MovieId, t.Actor_ActorId })
                .ForeignKey("dbo.Movies", t => t.Movie_MovieId, cascadeDelete: true)
                .ForeignKey("dbo.Actors", t => t.Actor_ActorId, cascadeDelete: true)
                .Index(t => t.Movie_MovieId)
                .Index(t => t.Actor_ActorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TransactionItems", "TransactionId", "dbo.Transactions");
            DropForeignKey("dbo.TransactionItems", "DvdId", "dbo.Dvds");
            DropForeignKey("dbo.Movies", "Genre_GenreId", "dbo.Genres");
            DropForeignKey("dbo.Dvds", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.MovieActors", "Actor_ActorId", "dbo.Actors");
            DropForeignKey("dbo.MovieActors", "Movie_MovieId", "dbo.Movies");
            DropIndex("dbo.MovieActors", new[] { "Actor_ActorId" });
            DropIndex("dbo.MovieActors", new[] { "Movie_MovieId" });
            DropIndex("dbo.TransactionItems", new[] { "DvdId" });
            DropIndex("dbo.TransactionItems", new[] { "TransactionId" });
            DropIndex("dbo.Dvds", new[] { "MovieId" });
            DropIndex("dbo.Movies", new[] { "Genre_GenreId" });
            DropTable("dbo.MovieActors");
            DropTable("dbo.Transactions");
            DropTable("dbo.TransactionItems");
            DropTable("dbo.Genres");
            DropTable("dbo.Dvds");
            DropTable("dbo.Movies");
            DropTable("dbo.Actors");
        }
    }
}
