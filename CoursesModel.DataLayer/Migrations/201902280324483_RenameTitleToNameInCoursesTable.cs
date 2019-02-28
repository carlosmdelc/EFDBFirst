namespace CodeFirstModel.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameTitleToNameInCoursesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Name", c => c.String(nullable: false));           // nullable: false because it doesn't make sense have Courses without a Name, so it is not null.
            Sql("UPDATE Courses SET Name = Title");
            DropColumn("dbo.Courses", "Title");         // When running this we are going to lose all the names of Courses in the db
                                                        // To resolve this, there are two techniques, you can use the RenameColumn method
                                                        // RenameColumn("dbo.Courses", "Title", "Name"); and delete the AddColumn and DropColumn

                                                        // Second technique is to use Sql command after the AddColumn method
                                                        // Sql("UPDATE Courses SET Name = Title");
                                                        // Then the DropColumn
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Title", c => c.String(nullable: false));         // Is the opposite we do in Up method. We need to ensure that the content
            Sql("UPDATE Courses SET Title = Name");                     // on the Name column is in the Title column before drop
            DropColumn("dbo.Courses", "Name");                          
        }

        // Before running this migration, remember when you make any changes in the Up method, make sure to double check the Down method
        // because the Down method is used to downgrade the db. Sometimes you bring the db to the latest version but you need to downgrade to
        // specific version for maintenance.
        // If you just modify the Up method but not the Down method sometimes you are running into problems and you cannot downgrade your db.
        // So, in this case 
    }
}
