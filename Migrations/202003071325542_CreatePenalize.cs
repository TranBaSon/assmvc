namespace PenalizeManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePenalize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Penalizes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RollNumber = c.String(nullable: false),
                        PenaltyOption = c.Int(nullable: false),
                        amount = c.Int(nullable: false),
                        Period = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Penalizes");
        }
    }
}
