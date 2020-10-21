namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChinhSuaDB2406 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DatPhong", "NgayDat", c => c.String());
            AddColumn("dbo.DatPhong", "NgayTra", c => c.String());
            AddColumn("dbo.DatPhong", "ThanhTien", c => c.Int(nullable: false));
            AddColumn("dbo.DatPhong", "MaKhanhHang", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DatPhong", "MaKhanhHang");
            DropColumn("dbo.DatPhong", "ThanhTien");
            DropColumn("dbo.DatPhong", "NgayTra");
            DropColumn("dbo.DatPhong", "NgayDat");
        }
    }
}
