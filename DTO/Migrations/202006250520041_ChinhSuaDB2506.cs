namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChinhSuaDB2506 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DatPhong", "MaDichVu", "dbo.DichVu");
            DropIndex("dbo.DatPhong", new[] { "MaDichVu" });
            DropColumn("dbo.DatPhong", "MaDichVu");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DatPhong", "MaDichVu", c => c.String(maxLength: 128));
            CreateIndex("dbo.DatPhong", "MaDichVu");
            AddForeignKey("dbo.DatPhong", "MaDichVu", "dbo.DichVu", "MaDichVu");
        }
    }
}
