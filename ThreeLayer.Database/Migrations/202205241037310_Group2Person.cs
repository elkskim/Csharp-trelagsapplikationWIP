namespace ThreeLayer.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Group2Person : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Person", new[] { "Group_GroupId" });
            CreateIndex("dbo.Person", "group_GroupId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Person", new[] { "group_GroupId" });
            CreateIndex("dbo.Person", "Group_GroupId");
        }
    }
}
