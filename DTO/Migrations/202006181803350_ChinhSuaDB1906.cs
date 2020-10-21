namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChinhSuaDB1906 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DatPhong", "KhachHang_MaKhachHang", c => c.String(maxLength: 128));
            AddColumn("dbo.KhachHang", "NgaySinh", c => c.String());
            AddColumn("dbo.KhachHang", "PassPort", c => c.String());
            AddColumn("dbo.NhanVien", "Mail", c => c.String());
            AddColumn("dbo.Phong", "Tang", c => c.String());
            AlterColumn("dbo.DatPhong", "MaPhong", c => c.String(maxLength: 128));
            AlterColumn("dbo.DatPhong", "MaDichVu", c => c.String(maxLength: 128));
            AlterColumn("dbo.DatPhong", "MaNhanVien", c => c.String(maxLength: 128));
            AlterColumn("dbo.NhanVien", "NgaySinh", c => c.String());
            AlterColumn("dbo.Phong", "Available", c => c.String());
            AlterColumn("dbo.Phong", "MaLoaiPhong", c => c.String(maxLength: 128));
            CreateIndex("dbo.DatPhong", "MaPhong");
            CreateIndex("dbo.DatPhong", "MaDichVu");
            CreateIndex("dbo.DatPhong", "MaNhanVien");
            CreateIndex("dbo.DatPhong", "KhachHang_MaKhachHang");
            CreateIndex("dbo.Phong", "MaLoaiPhong");
            AddForeignKey("dbo.DatPhong", "MaDichVu", "dbo.DichVu", "MaDichVu");
            AddForeignKey("dbo.DatPhong", "MaNhanVien", "dbo.NhanVien", "MaNhanVien");
            AddForeignKey("dbo.Phong", "MaLoaiPhong", "dbo.LoaiPhong", "MaLoaiPhong");
            AddForeignKey("dbo.DatPhong", "MaPhong", "dbo.Phong", "MaPhong");
            AddForeignKey("dbo.DatPhong", "KhachHang_MaKhachHang", "dbo.KhachHang", "MaKhachHang");
            DropColumn("dbo.DatPhong", "ThanhTien");
            DropColumn("dbo.KhachHang", "SoLanDat");
        }
        
        public override void Down()
        {
            AddColumn("dbo.KhachHang", "SoLanDat", c => c.Int(nullable: false));
            AddColumn("dbo.DatPhong", "ThanhTien", c => c.String());
            DropForeignKey("dbo.DatPhong", "KhachHang_MaKhachHang", "dbo.KhachHang");
            DropForeignKey("dbo.DatPhong", "MaPhong", "dbo.Phong");
            DropForeignKey("dbo.Phong", "MaLoaiPhong", "dbo.LoaiPhong");
            DropForeignKey("dbo.DatPhong", "MaNhanVien", "dbo.NhanVien");
            DropForeignKey("dbo.DatPhong", "MaDichVu", "dbo.DichVu");
            DropIndex("dbo.Phong", new[] { "MaLoaiPhong" });
            DropIndex("dbo.DatPhong", new[] { "KhachHang_MaKhachHang" });
            DropIndex("dbo.DatPhong", new[] { "MaNhanVien" });
            DropIndex("dbo.DatPhong", new[] { "MaDichVu" });
            DropIndex("dbo.DatPhong", new[] { "MaPhong" });
            AlterColumn("dbo.Phong", "MaLoaiPhong", c => c.String());
            AlterColumn("dbo.Phong", "Available", c => c.Boolean(nullable: false));
            AlterColumn("dbo.NhanVien", "NgaySinh", c => c.DateTime(nullable: false));
            AlterColumn("dbo.DatPhong", "MaNhanVien", c => c.String());
            AlterColumn("dbo.DatPhong", "MaDichVu", c => c.String());
            AlterColumn("dbo.DatPhong", "MaPhong", c => c.String());
            DropColumn("dbo.Phong", "Tang");
            DropColumn("dbo.NhanVien", "Mail");
            DropColumn("dbo.KhachHang", "PassPort");
            DropColumn("dbo.KhachHang", "NgaySinh");
            DropColumn("dbo.DatPhong", "KhachHang_MaKhachHang");
        }
    }
}
