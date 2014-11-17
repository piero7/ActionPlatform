namespace ActionPlatform.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class addUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        OpenId = c.String(),
                        NickName = c.String(),
                        subscribe = c.Boolean(nullable: false, defaultValue: false),
                        Sex = c.Int(nullable: false, defaultValue: 0),
                        City = c.String(),
                        Country = c.String(),
                        Province = c.String(),
                        Language = c.String(),
                        SubscribeTime = c.DateTime(),
                        Headimgurl = c.String(),
                        Level = c.Int(defaultValue: 0),
                        Remarks = c.String(),
                        Part = c.Int(nullable: false, defaultValue: 0),
                    })
                .PrimaryKey(t => t.UserId);

        }

        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
