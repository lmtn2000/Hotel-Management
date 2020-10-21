namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChinhSuaDB2406_2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.DatPhong", name: "KhachHang_MaKhachHang", newName: "MaKhachHang");
            RenameIndex(table: "dbo.DatPhong", name: "IX_KhachHang_MaKhachHang", newName: "IX_MaKhachHang");
            DropColumn("dbo.DatPhong", "MaKhanhHang");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DatPhong", "MaKhanhHang", c => c.String());
            RenameIndex(table: "dbo.DatPhong", name: "IX_MaKhachHang", newName: "IX_KhachHang_MaKhachHang");
            RenameColumn(table: "dbo.DatPhong", name: "MaKhachHang", newName: "KhachHang_MaKhachHang");
        }
    }
}
