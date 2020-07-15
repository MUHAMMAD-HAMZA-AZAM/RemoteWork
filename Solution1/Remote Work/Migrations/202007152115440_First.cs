namespace Remote_Work.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dummies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.uzairs",
                c => new
                    {
                        UzairId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.UzairId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.uzairs");
            DropTable("dbo.Dummies");
        }
    }
}
