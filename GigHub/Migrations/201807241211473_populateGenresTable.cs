namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(id,name) VALUES (1,'Classic')");
            Sql("INSERT INTO Genres(id,name) VALUES (2,'Rock')");
            Sql("INSERT INTO Genres(id,name) VALUES (3,'Country')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE id in (1,2,3)");
        }
    }
}
