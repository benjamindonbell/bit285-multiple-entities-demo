namespace bit285_multiple_entities_demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Genre = c.String(),
                    })
                .PrimaryKey(t => t.AuthorID);
            
            AddColumn("dbo.Books", "Author_AuthorID", c => c.Int());
            AddColumn("dbo.Purchases", "MemberID", c => c.Int(nullable: false));
            AddColumn("dbo.Members", "FirstName", c => c.String());
            AddColumn("dbo.Members", "LastName", c => c.String());
            AddColumn("dbo.Members", "Email", c => c.String());
            CreateIndex("dbo.Books", "Author_AuthorID");
            CreateIndex("dbo.Purchases", "MemberID");
            AddForeignKey("dbo.Books", "Author_AuthorID", "dbo.Authors", "AuthorID");
            AddForeignKey("dbo.Purchases", "MemberID", "dbo.Members", "MemberID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Purchases", "MemberID", "dbo.Members");
            DropForeignKey("dbo.Books", "Author_AuthorID", "dbo.Authors");
            DropIndex("dbo.Purchases", new[] { "MemberID" });
            DropIndex("dbo.Books", new[] { "Author_AuthorID" });
            DropColumn("dbo.Members", "Email");
            DropColumn("dbo.Members", "LastName");
            DropColumn("dbo.Members", "FirstName");
            DropColumn("dbo.Purchases", "MemberID");
            DropColumn("dbo.Books", "Author_AuthorID");
            DropTable("dbo.Authors");
        }
    }
}
