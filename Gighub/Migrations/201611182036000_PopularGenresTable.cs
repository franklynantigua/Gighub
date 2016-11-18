namespace Gighub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopularGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT into Genres ( Name) VALUES ('Jazz')");
            Sql("INSERT into Genres ( Name) VALUES ('Blues')");
            Sql("INSERT into Genres ( Name) VALUES ('Rock')");
            Sql("INSERT into Genres ( Name) VALUES ('Country')");
        }
        
        public override void Down()
        {
            Sql("Delete from Genres  where Id IN (1,2,3,4)");
        }
    }
}
