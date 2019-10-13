namespace VidlyRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES VALUES (1 , 'Action')");
            Sql("INSERT INTO GENRES VALUES (2 , 'Adventure')");
            Sql("INSERT INTO GENRES VALUES (3 , 'Comedy')");
            Sql("INSERT INTO GENRES VALUES (4 , 'Crime')");
            Sql("INSERT INTO GENRES VALUES (5 , 'Drama')");
            Sql("INSERT INTO GENRES VALUES (6 , 'Fantasy')");
            Sql("INSERT INTO GENRES VALUES (7 , 'Historical')");
            Sql("INSERT INTO GENRES VALUES (8 , 'Horror')");
            Sql("INSERT INTO GENRES VALUES (9 , 'Mystery')");
            Sql("INSERT INTO GENRES VALUES (10 , 'Political')");
            Sql("INSERT INTO GENRES VALUES (11 , 'Romance')");
            Sql("INSERT INTO GENRES VALUES (12 , 'Saga')");
            Sql("INSERT INTO GENRES VALUES (13 , 'Science fiction')");
            Sql("INSERT INTO GENRES VALUES (14 , 'Social')");
            Sql("INSERT INTO GENRES VALUES (15 , 'Thriller')");
        }
        
        public override void Down()
        {
        }
    }
}
