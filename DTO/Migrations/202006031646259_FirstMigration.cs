namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DatPhong",
                c => new
                    {
                        MaDatPhong = c.String(nullable: false, maxLength: 128),
                        MaPhong = c.String(),
                        MaDichVu = c.String(),
                        ThanhTien = c.String(),
                        MaNhanVien = c.String(),
                    })
                .PrimaryKey(t => t.MaDatPhong);
            
            CreateTable(
                "dbo.DichVu",
                c => new
                    {
                        MaDichVu = c.String(nullable: false, maxLength: 128),
                        TenDichVu = c.String(),
                        Gia = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaDichVu);
            
            CreateTable(
                "dbo.KhachHang",
                c => new
                    {
                        MaKhachHang = c.String(nullable: false, maxLength: 128),
                        TenKhachHang = c.String(),
                        QuocTich = c.String(),
                        SoDienThoai = c.String(),
                        SoLanDat = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaKhachHang);
            
            CreateTable(
                "dbo.LoaiPhong",
                c => new
                    {
                        MaLoaiPhong = c.String(nullable: false, maxLength: 128),
                        TenLoaiPhong = c.String(),
                        Gia = c.Int(nullable: false),
                        SoNguoiO = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaLoaiPhong);
            
            CreateTable(
                "dbo.Login",
                c => new
                    {
                        TenDangNhap = c.String(nullable: false, maxLength: 128),
                        MatKhau = c.String(),
                        MaNhanVien = c.String(),
                    })
                .PrimaryKey(t => t.TenDangNhap);
            
            CreateTable(
                "dbo.NhanVien",
                c => new
                    {
                        MaNhanVien = c.String(nullable: false, maxLength: 128),
                        TenNhanVien = c.String(),
                        ChucVu = c.String(),
                        NgaySinh = c.DateTime(nullable: false),
                        SoDienThoai = c.String(),
                    })
                .PrimaryKey(t => t.MaNhanVien);
            
            CreateTable(
                "dbo.Phong",
                c => new
                    {
                        MaPhong = c.String(nullable: false, maxLength: 128),
                        TenPhong = c.String(),
                        Available = c.Boolean(nullable: false),
                        MaLoaiPhong = c.String(),
                    })
                .PrimaryKey(t => t.MaPhong);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Phong");
            DropTable("dbo.NhanVien");
            DropTable("dbo.Login");
            DropTable("dbo.LoaiPhong");
            DropTable("dbo.KhachHang");
            DropTable("dbo.DichVu");
            DropTable("dbo.DatPhong");
        }
    }
}
