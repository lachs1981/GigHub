namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (ID, Name) VALUES (1, 'Heavy Metal')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (2, 'Trance')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (3, 'Breaks')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (4, 'House')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (1,2,3,4)");
        }
    }
}
