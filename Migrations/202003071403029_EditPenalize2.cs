namespace PenalizeManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditPenalize2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Penalizes", "amount", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Penalizes", "amount", c => c.Int(nullable: false));
        }
    }
}
