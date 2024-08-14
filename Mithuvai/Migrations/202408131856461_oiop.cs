namespace Mithuvai.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class oiop : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Designation", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "Email", c => c.String(nullable: false));
            DropColumn("dbo.Employees", "Dsignantion");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Dsignantion", c => c.String());
            AlterColumn("dbo.Employees", "Email", c => c.String());
            AlterColumn("dbo.Employees", "Name", c => c.String());
            DropColumn("dbo.Employees", "Designation");
        }
    }
}
