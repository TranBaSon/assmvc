namespace PenalizeManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditPenalize3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Penalizes", "Deadline", c => c.DateTime(nullable: false));
            DropColumn("dbo.Penalizes", "Period");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Penalizes", "Period", c => c.DateTime(nullable: false));
            DropColumn("dbo.Penalizes", "Deadline");
        }
    }
}
