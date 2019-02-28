namespace CodeFirstModel.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoriesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            // Use Sql command to insert from here to the table.
            Sql("INSERT INTO Categories VALUES ('Web Development')");
            Sql("INSERT INTO Categories VALUES ('Programming Languages')");
            Sql("INSERT INTO Categories VALUES ('Phyton')");
            Sql("INSERT INTO Categories VALUES ('Angular Development')");
        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
