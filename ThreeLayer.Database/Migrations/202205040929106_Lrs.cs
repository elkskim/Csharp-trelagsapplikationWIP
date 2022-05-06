namespace ThreeLayer.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Lrs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Group",
                c => new
                    {
                        GroupId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.GroupId);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Group_GroupId = c.Int(),
                    })
                .PrimaryKey(t => t.PersonId)
                .ForeignKey("dbo.Group", t => t.Group_GroupId)
                .Index(t => t.Group_GroupId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Person", "Group_GroupId", "dbo.Group");
            DropIndex("dbo.Person", new[] { "Group_GroupId" });
            DropTable("dbo.Person");
            DropTable("dbo.Group");
        }
    }
}
