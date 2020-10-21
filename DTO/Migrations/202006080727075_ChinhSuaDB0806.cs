namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChinhSuaDB0806 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Login", "MaNhanVien", c => c.String(maxLength: 128));
            CreateIndex("dbo.Login", "MaNhanVien");
            AddForeignKey("dbo.Login", "MaNhanVien", "dbo.NhanVien", "MaNhanVien");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Login", "MaNhanVien", "dbo.NhanVien");
            DropIndex("dbo.Login", new[] { "MaNhanVien" });
            AlterColumn("dbo.Login", "MaNhanVien", c => c.String());
        }
    }
}
