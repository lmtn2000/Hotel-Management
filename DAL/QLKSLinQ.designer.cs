﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QuanLyKhachSanDoAn")]
	public partial class QLKSLinQDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDatPhong(DatPhong instance);
    partial void UpdateDatPhong(DatPhong instance);
    partial void DeleteDatPhong(DatPhong instance);
    partial void InsertDichVu(DichVu instance);
    partial void UpdateDichVu(DichVu instance);
    partial void DeleteDichVu(DichVu instance);
    partial void InsertKhachHang(KhachHang instance);
    partial void UpdateKhachHang(KhachHang instance);
    partial void DeleteKhachHang(KhachHang instance);
    partial void InsertLoaiPhong(LoaiPhong instance);
    partial void UpdateLoaiPhong(LoaiPhong instance);
    partial void DeleteLoaiPhong(LoaiPhong instance);
    partial void InsertLogin(Login instance);
    partial void UpdateLogin(Login instance);
    partial void DeleteLogin(Login instance);
    partial void InsertNhanVien(NhanVien instance);
    partial void UpdateNhanVien(NhanVien instance);
    partial void DeleteNhanVien(NhanVien instance);
    partial void InsertPhong(Phong instance);
    partial void UpdatePhong(Phong instance);
    partial void DeletePhong(Phong instance);
    #endregion
		
		public QLKSLinQDataContext() : 
				base(global::DAL.Properties.Settings.Default.QuanLyKhachSanDoAnConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLKSLinQDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLKSLinQDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLKSLinQDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLKSLinQDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DatPhong> DatPhongs
		{
			get
			{
				return this.GetTable<DatPhong>();
			}
		}
		
		public System.Data.Linq.Table<DichVu> DichVus
		{
			get
			{
				return this.GetTable<DichVu>();
			}
		}
		
		public System.Data.Linq.Table<KhachHang> KhachHangs
		{
			get
			{
				return this.GetTable<KhachHang>();
			}
		}
		
		public System.Data.Linq.Table<LoaiPhong> LoaiPhongs
		{
			get
			{
				return this.GetTable<LoaiPhong>();
			}
		}
		
		public System.Data.Linq.Table<Login> Logins
		{
			get
			{
				return this.GetTable<Login>();
			}
		}
		
		public System.Data.Linq.Table<NhanVien> NhanViens
		{
			get
			{
				return this.GetTable<NhanVien>();
			}
		}
		
		public System.Data.Linq.Table<Phong> Phongs
		{
			get
			{
				return this.GetTable<Phong>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DatPhong")]
	public partial class DatPhong : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaDatPhong;
		
		private string _MaPhong;
		
		private string _MaNhanVien;
		
		private string _MaKhachHang;
		
		private string _NgayDat;
		
		private string _NgayTra;
		
		private int _ThanhTien;
		
		private string _TinhTrangThanhToan;
		
		private EntityRef<KhachHang> _KhachHang;
		
		private EntityRef<NhanVien> _NhanVien;
		
		private EntityRef<Phong> _Phong;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDatPhongChanging(string value);
    partial void OnMaDatPhongChanged();
    partial void OnMaPhongChanging(string value);
    partial void OnMaPhongChanged();
    partial void OnMaNhanVienChanging(string value);
    partial void OnMaNhanVienChanged();
    partial void OnMaKhachHangChanging(string value);
    partial void OnMaKhachHangChanged();
    partial void OnNgayDatChanging(string value);
    partial void OnNgayDatChanged();
    partial void OnNgayTraChanging(string value);
    partial void OnNgayTraChanged();
    partial void OnThanhTienChanging(int value);
    partial void OnThanhTienChanged();
    partial void OnTinhTrangThanhToanChanging(string value);
    partial void OnTinhTrangThanhToanChanged();
    #endregion
		
		public DatPhong()
		{
			this._KhachHang = default(EntityRef<KhachHang>);
			this._NhanVien = default(EntityRef<NhanVien>);
			this._Phong = default(EntityRef<Phong>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDatPhong", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaDatPhong
		{
			get
			{
				return this._MaDatPhong;
			}
			set
			{
				if ((this._MaDatPhong != value))
				{
					this.OnMaDatPhongChanging(value);
					this.SendPropertyChanging();
					this._MaDatPhong = value;
					this.SendPropertyChanged("MaDatPhong");
					this.OnMaDatPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaPhong", DbType="NVarChar(128)")]
		public string MaPhong
		{
			get
			{
				return this._MaPhong;
			}
			set
			{
				if ((this._MaPhong != value))
				{
					if (this._Phong.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaPhongChanging(value);
					this.SendPropertyChanging();
					this._MaPhong = value;
					this.SendPropertyChanged("MaPhong");
					this.OnMaPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNhanVien", DbType="NVarChar(128)")]
		public string MaNhanVien
		{
			get
			{
				return this._MaNhanVien;
			}
			set
			{
				if ((this._MaNhanVien != value))
				{
					if (this._NhanVien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNhanVienChanging(value);
					this.SendPropertyChanging();
					this._MaNhanVien = value;
					this.SendPropertyChanged("MaNhanVien");
					this.OnMaNhanVienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhachHang", DbType="NVarChar(128)")]
		public string MaKhachHang
		{
			get
			{
				return this._MaKhachHang;
			}
			set
			{
				if ((this._MaKhachHang != value))
				{
					if (this._KhachHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKhachHangChanging(value);
					this.SendPropertyChanging();
					this._MaKhachHang = value;
					this.SendPropertyChanged("MaKhachHang");
					this.OnMaKhachHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayDat", DbType="NVarChar(MAX)")]
		public string NgayDat
		{
			get
			{
				return this._NgayDat;
			}
			set
			{
				if ((this._NgayDat != value))
				{
					this.OnNgayDatChanging(value);
					this.SendPropertyChanging();
					this._NgayDat = value;
					this.SendPropertyChanged("NgayDat");
					this.OnNgayDatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayTra", DbType="NVarChar(MAX)")]
		public string NgayTra
		{
			get
			{
				return this._NgayTra;
			}
			set
			{
				if ((this._NgayTra != value))
				{
					this.OnNgayTraChanging(value);
					this.SendPropertyChanging();
					this._NgayTra = value;
					this.SendPropertyChanged("NgayTra");
					this.OnNgayTraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThanhTien", DbType="Int NOT NULL")]
		public int ThanhTien
		{
			get
			{
				return this._ThanhTien;
			}
			set
			{
				if ((this._ThanhTien != value))
				{
					this.OnThanhTienChanging(value);
					this.SendPropertyChanging();
					this._ThanhTien = value;
					this.SendPropertyChanged("ThanhTien");
					this.OnThanhTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinhTrangThanhToan", DbType="NVarChar(MAX)")]
		public string TinhTrangThanhToan
		{
			get
			{
				return this._TinhTrangThanhToan;
			}
			set
			{
				if ((this._TinhTrangThanhToan != value))
				{
					this.OnTinhTrangThanhToanChanging(value);
					this.SendPropertyChanging();
					this._TinhTrangThanhToan = value;
					this.SendPropertyChanged("TinhTrangThanhToan");
					this.OnTinhTrangThanhToanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_DatPhong", Storage="_KhachHang", ThisKey="MaKhachHang", OtherKey="MaKhachHang", IsForeignKey=true)]
		public KhachHang KhachHang
		{
			get
			{
				return this._KhachHang.Entity;
			}
			set
			{
				KhachHang previousValue = this._KhachHang.Entity;
				if (((previousValue != value) 
							|| (this._KhachHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KhachHang.Entity = null;
						previousValue.DatPhongs.Remove(this);
					}
					this._KhachHang.Entity = value;
					if ((value != null))
					{
						value.DatPhongs.Add(this);
						this._MaKhachHang = value.MaKhachHang;
					}
					else
					{
						this._MaKhachHang = default(string);
					}
					this.SendPropertyChanged("KhachHang");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_DatPhong", Storage="_NhanVien", ThisKey="MaNhanVien", OtherKey="MaNhanVien", IsForeignKey=true)]
		public NhanVien NhanVien
		{
			get
			{
				return this._NhanVien.Entity;
			}
			set
			{
				NhanVien previousValue = this._NhanVien.Entity;
				if (((previousValue != value) 
							|| (this._NhanVien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NhanVien.Entity = null;
						previousValue.DatPhongs.Remove(this);
					}
					this._NhanVien.Entity = value;
					if ((value != null))
					{
						value.DatPhongs.Add(this);
						this._MaNhanVien = value.MaNhanVien;
					}
					else
					{
						this._MaNhanVien = default(string);
					}
					this.SendPropertyChanged("NhanVien");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Phong_DatPhong", Storage="_Phong", ThisKey="MaPhong", OtherKey="MaPhong", IsForeignKey=true)]
		public Phong Phong
		{
			get
			{
				return this._Phong.Entity;
			}
			set
			{
				Phong previousValue = this._Phong.Entity;
				if (((previousValue != value) 
							|| (this._Phong.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Phong.Entity = null;
						previousValue.DatPhongs.Remove(this);
					}
					this._Phong.Entity = value;
					if ((value != null))
					{
						value.DatPhongs.Add(this);
						this._MaPhong = value.MaPhong;
					}
					else
					{
						this._MaPhong = default(string);
					}
					this.SendPropertyChanged("Phong");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DichVu")]
	public partial class DichVu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaDichVu;
		
		private string _TenDichVu;
		
		private int _Gia;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDichVuChanging(string value);
    partial void OnMaDichVuChanged();
    partial void OnTenDichVuChanging(string value);
    partial void OnTenDichVuChanged();
    partial void OnGiaChanging(int value);
    partial void OnGiaChanged();
    #endregion
		
		public DichVu()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDichVu", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaDichVu
		{
			get
			{
				return this._MaDichVu;
			}
			set
			{
				if ((this._MaDichVu != value))
				{
					this.OnMaDichVuChanging(value);
					this.SendPropertyChanging();
					this._MaDichVu = value;
					this.SendPropertyChanged("MaDichVu");
					this.OnMaDichVuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDichVu", DbType="NVarChar(MAX)")]
		public string TenDichVu
		{
			get
			{
				return this._TenDichVu;
			}
			set
			{
				if ((this._TenDichVu != value))
				{
					this.OnTenDichVuChanging(value);
					this.SendPropertyChanging();
					this._TenDichVu = value;
					this.SendPropertyChanged("TenDichVu");
					this.OnTenDichVuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gia", DbType="Int NOT NULL")]
		public int Gia
		{
			get
			{
				return this._Gia;
			}
			set
			{
				if ((this._Gia != value))
				{
					this.OnGiaChanging(value);
					this.SendPropertyChanging();
					this._Gia = value;
					this.SendPropertyChanged("Gia");
					this.OnGiaChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KhachHang")]
	public partial class KhachHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaKhachHang;
		
		private string _TenKhachHang;
		
		private string _QuocTich;
		
		private string _SoDienThoai;
		
		private string _NgaySinh;
		
		private string _PassPort;
		
		private EntitySet<DatPhong> _DatPhongs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKhachHangChanging(string value);
    partial void OnMaKhachHangChanged();
    partial void OnTenKhachHangChanging(string value);
    partial void OnTenKhachHangChanged();
    partial void OnQuocTichChanging(string value);
    partial void OnQuocTichChanged();
    partial void OnSoDienThoaiChanging(string value);
    partial void OnSoDienThoaiChanged();
    partial void OnNgaySinhChanging(string value);
    partial void OnNgaySinhChanged();
    partial void OnPassPortChanging(string value);
    partial void OnPassPortChanged();
    #endregion
		
		public KhachHang()
		{
			this._DatPhongs = new EntitySet<DatPhong>(new Action<DatPhong>(this.attach_DatPhongs), new Action<DatPhong>(this.detach_DatPhongs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhachHang", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaKhachHang
		{
			get
			{
				return this._MaKhachHang;
			}
			set
			{
				if ((this._MaKhachHang != value))
				{
					this.OnMaKhachHangChanging(value);
					this.SendPropertyChanging();
					this._MaKhachHang = value;
					this.SendPropertyChanged("MaKhachHang");
					this.OnMaKhachHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKhachHang", DbType="NVarChar(MAX)")]
		public string TenKhachHang
		{
			get
			{
				return this._TenKhachHang;
			}
			set
			{
				if ((this._TenKhachHang != value))
				{
					this.OnTenKhachHangChanging(value);
					this.SendPropertyChanging();
					this._TenKhachHang = value;
					this.SendPropertyChanged("TenKhachHang");
					this.OnTenKhachHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuocTich", DbType="NVarChar(MAX)")]
		public string QuocTich
		{
			get
			{
				return this._QuocTich;
			}
			set
			{
				if ((this._QuocTich != value))
				{
					this.OnQuocTichChanging(value);
					this.SendPropertyChanging();
					this._QuocTich = value;
					this.SendPropertyChanged("QuocTich");
					this.OnQuocTichChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDienThoai", DbType="NVarChar(MAX)")]
		public string SoDienThoai
		{
			get
			{
				return this._SoDienThoai;
			}
			set
			{
				if ((this._SoDienThoai != value))
				{
					this.OnSoDienThoaiChanging(value);
					this.SendPropertyChanging();
					this._SoDienThoai = value;
					this.SendPropertyChanged("SoDienThoai");
					this.OnSoDienThoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="NVarChar(MAX)")]
		public string NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PassPort", DbType="NVarChar(MAX)")]
		public string PassPort
		{
			get
			{
				return this._PassPort;
			}
			set
			{
				if ((this._PassPort != value))
				{
					this.OnPassPortChanging(value);
					this.SendPropertyChanging();
					this._PassPort = value;
					this.SendPropertyChanged("PassPort");
					this.OnPassPortChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_DatPhong", Storage="_DatPhongs", ThisKey="MaKhachHang", OtherKey="MaKhachHang")]
		public EntitySet<DatPhong> DatPhongs
		{
			get
			{
				return this._DatPhongs;
			}
			set
			{
				this._DatPhongs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_DatPhongs(DatPhong entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang = this;
		}
		
		private void detach_DatPhongs(DatPhong entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LoaiPhong")]
	public partial class LoaiPhong : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaLoaiPhong;
		
		private string _TenLoaiPhong;
		
		private int _Gia;
		
		private int _SoNguoiO;
		
		private EntitySet<Phong> _Phongs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaLoaiPhongChanging(string value);
    partial void OnMaLoaiPhongChanged();
    partial void OnTenLoaiPhongChanging(string value);
    partial void OnTenLoaiPhongChanged();
    partial void OnGiaChanging(int value);
    partial void OnGiaChanged();
    partial void OnSoNguoiOChanging(int value);
    partial void OnSoNguoiOChanged();
    #endregion
		
		public LoaiPhong()
		{
			this._Phongs = new EntitySet<Phong>(new Action<Phong>(this.attach_Phongs), new Action<Phong>(this.detach_Phongs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLoaiPhong", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaLoaiPhong
		{
			get
			{
				return this._MaLoaiPhong;
			}
			set
			{
				if ((this._MaLoaiPhong != value))
				{
					this.OnMaLoaiPhongChanging(value);
					this.SendPropertyChanging();
					this._MaLoaiPhong = value;
					this.SendPropertyChanged("MaLoaiPhong");
					this.OnMaLoaiPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenLoaiPhong", DbType="NVarChar(MAX)")]
		public string TenLoaiPhong
		{
			get
			{
				return this._TenLoaiPhong;
			}
			set
			{
				if ((this._TenLoaiPhong != value))
				{
					this.OnTenLoaiPhongChanging(value);
					this.SendPropertyChanging();
					this._TenLoaiPhong = value;
					this.SendPropertyChanged("TenLoaiPhong");
					this.OnTenLoaiPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gia", DbType="Int NOT NULL")]
		public int Gia
		{
			get
			{
				return this._Gia;
			}
			set
			{
				if ((this._Gia != value))
				{
					this.OnGiaChanging(value);
					this.SendPropertyChanging();
					this._Gia = value;
					this.SendPropertyChanged("Gia");
					this.OnGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoNguoiO", DbType="Int NOT NULL")]
		public int SoNguoiO
		{
			get
			{
				return this._SoNguoiO;
			}
			set
			{
				if ((this._SoNguoiO != value))
				{
					this.OnSoNguoiOChanging(value);
					this.SendPropertyChanging();
					this._SoNguoiO = value;
					this.SendPropertyChanged("SoNguoiO");
					this.OnSoNguoiOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiPhong_Phong", Storage="_Phongs", ThisKey="MaLoaiPhong", OtherKey="MaLoaiPhong")]
		public EntitySet<Phong> Phongs
		{
			get
			{
				return this._Phongs;
			}
			set
			{
				this._Phongs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Phongs(Phong entity)
		{
			this.SendPropertyChanging();
			entity.LoaiPhong = this;
		}
		
		private void detach_Phongs(Phong entity)
		{
			this.SendPropertyChanging();
			entity.LoaiPhong = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Login")]
	public partial class Login : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TenDangNhap;
		
		private string _MatKhau;
		
		private string _MaNhanVien;
		
		private EntityRef<NhanVien> _NhanVien;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTenDangNhapChanging(string value);
    partial void OnTenDangNhapChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    partial void OnMaNhanVienChanging(string value);
    partial void OnMaNhanVienChanged();
    #endregion
		
		public Login()
		{
			this._NhanVien = default(EntityRef<NhanVien>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDangNhap", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TenDangNhap
		{
			get
			{
				return this._TenDangNhap;
			}
			set
			{
				if ((this._TenDangNhap != value))
				{
					this.OnTenDangNhapChanging(value);
					this.SendPropertyChanging();
					this._TenDangNhap = value;
					this.SendPropertyChanged("TenDangNhap");
					this.OnTenDangNhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="NVarChar(MAX)")]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNhanVien", DbType="NVarChar(128)")]
		public string MaNhanVien
		{
			get
			{
				return this._MaNhanVien;
			}
			set
			{
				if ((this._MaNhanVien != value))
				{
					if (this._NhanVien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNhanVienChanging(value);
					this.SendPropertyChanging();
					this._MaNhanVien = value;
					this.SendPropertyChanged("MaNhanVien");
					this.OnMaNhanVienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_Login", Storage="_NhanVien", ThisKey="MaNhanVien", OtherKey="MaNhanVien", IsForeignKey=true)]
		public NhanVien NhanVien
		{
			get
			{
				return this._NhanVien.Entity;
			}
			set
			{
				NhanVien previousValue = this._NhanVien.Entity;
				if (((previousValue != value) 
							|| (this._NhanVien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NhanVien.Entity = null;
						previousValue.Logins.Remove(this);
					}
					this._NhanVien.Entity = value;
					if ((value != null))
					{
						value.Logins.Add(this);
						this._MaNhanVien = value.MaNhanVien;
					}
					else
					{
						this._MaNhanVien = default(string);
					}
					this.SendPropertyChanged("NhanVien");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NhanVien")]
	public partial class NhanVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaNhanVien;
		
		private string _TenNhanVien;
		
		private string _ChucVu;
		
		private string _NgaySinh;
		
		private string _SoDienThoai;
		
		private string _Mail;
		
		private EntitySet<DatPhong> _DatPhongs;
		
		private EntitySet<Login> _Logins;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNhanVienChanging(string value);
    partial void OnMaNhanVienChanged();
    partial void OnTenNhanVienChanging(string value);
    partial void OnTenNhanVienChanged();
    partial void OnChucVuChanging(string value);
    partial void OnChucVuChanged();
    partial void OnNgaySinhChanging(string value);
    partial void OnNgaySinhChanged();
    partial void OnSoDienThoaiChanging(string value);
    partial void OnSoDienThoaiChanged();
    partial void OnMailChanging(string value);
    partial void OnMailChanged();
    #endregion
		
		public NhanVien()
		{
			this._DatPhongs = new EntitySet<DatPhong>(new Action<DatPhong>(this.attach_DatPhongs), new Action<DatPhong>(this.detach_DatPhongs));
			this._Logins = new EntitySet<Login>(new Action<Login>(this.attach_Logins), new Action<Login>(this.detach_Logins));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNhanVien", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaNhanVien
		{
			get
			{
				return this._MaNhanVien;
			}
			set
			{
				if ((this._MaNhanVien != value))
				{
					this.OnMaNhanVienChanging(value);
					this.SendPropertyChanging();
					this._MaNhanVien = value;
					this.SendPropertyChanged("MaNhanVien");
					this.OnMaNhanVienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNhanVien", DbType="NVarChar(MAX)")]
		public string TenNhanVien
		{
			get
			{
				return this._TenNhanVien;
			}
			set
			{
				if ((this._TenNhanVien != value))
				{
					this.OnTenNhanVienChanging(value);
					this.SendPropertyChanging();
					this._TenNhanVien = value;
					this.SendPropertyChanged("TenNhanVien");
					this.OnTenNhanVienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChucVu", DbType="NVarChar(MAX)")]
		public string ChucVu
		{
			get
			{
				return this._ChucVu;
			}
			set
			{
				if ((this._ChucVu != value))
				{
					this.OnChucVuChanging(value);
					this.SendPropertyChanging();
					this._ChucVu = value;
					this.SendPropertyChanged("ChucVu");
					this.OnChucVuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="NVarChar(MAX)")]
		public string NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDienThoai", DbType="NVarChar(MAX)")]
		public string SoDienThoai
		{
			get
			{
				return this._SoDienThoai;
			}
			set
			{
				if ((this._SoDienThoai != value))
				{
					this.OnSoDienThoaiChanging(value);
					this.SendPropertyChanging();
					this._SoDienThoai = value;
					this.SendPropertyChanged("SoDienThoai");
					this.OnSoDienThoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mail", DbType="NVarChar(MAX)")]
		public string Mail
		{
			get
			{
				return this._Mail;
			}
			set
			{
				if ((this._Mail != value))
				{
					this.OnMailChanging(value);
					this.SendPropertyChanging();
					this._Mail = value;
					this.SendPropertyChanged("Mail");
					this.OnMailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_DatPhong", Storage="_DatPhongs", ThisKey="MaNhanVien", OtherKey="MaNhanVien")]
		public EntitySet<DatPhong> DatPhongs
		{
			get
			{
				return this._DatPhongs;
			}
			set
			{
				this._DatPhongs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_Login", Storage="_Logins", ThisKey="MaNhanVien", OtherKey="MaNhanVien")]
		public EntitySet<Login> Logins
		{
			get
			{
				return this._Logins;
			}
			set
			{
				this._Logins.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_DatPhongs(DatPhong entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = this;
		}
		
		private void detach_DatPhongs(DatPhong entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = null;
		}
		
		private void attach_Logins(Login entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = this;
		}
		
		private void detach_Logins(Login entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Phong")]
	public partial class Phong : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaPhong;
		
		private string _TenPhong;
		
		private string _Available;
		
		private string _MaLoaiPhong;
		
		private string _Tang;
		
		private EntitySet<DatPhong> _DatPhongs;
		
		private EntityRef<LoaiPhong> _LoaiPhong;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaPhongChanging(string value);
    partial void OnMaPhongChanged();
    partial void OnTenPhongChanging(string value);
    partial void OnTenPhongChanged();
    partial void OnAvailableChanging(string value);
    partial void OnAvailableChanged();
    partial void OnMaLoaiPhongChanging(string value);
    partial void OnMaLoaiPhongChanged();
    partial void OnTangChanging(string value);
    partial void OnTangChanged();
    #endregion
		
		public Phong()
		{
			this._DatPhongs = new EntitySet<DatPhong>(new Action<DatPhong>(this.attach_DatPhongs), new Action<DatPhong>(this.detach_DatPhongs));
			this._LoaiPhong = default(EntityRef<LoaiPhong>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaPhong", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaPhong
		{
			get
			{
				return this._MaPhong;
			}
			set
			{
				if ((this._MaPhong != value))
				{
					this.OnMaPhongChanging(value);
					this.SendPropertyChanging();
					this._MaPhong = value;
					this.SendPropertyChanged("MaPhong");
					this.OnMaPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenPhong", DbType="NVarChar(MAX)")]
		public string TenPhong
		{
			get
			{
				return this._TenPhong;
			}
			set
			{
				if ((this._TenPhong != value))
				{
					this.OnTenPhongChanging(value);
					this.SendPropertyChanging();
					this._TenPhong = value;
					this.SendPropertyChanged("TenPhong");
					this.OnTenPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Available", DbType="NVarChar(MAX)")]
		public string Available
		{
			get
			{
				return this._Available;
			}
			set
			{
				if ((this._Available != value))
				{
					this.OnAvailableChanging(value);
					this.SendPropertyChanging();
					this._Available = value;
					this.SendPropertyChanged("Available");
					this.OnAvailableChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLoaiPhong", DbType="NVarChar(128)")]
		public string MaLoaiPhong
		{
			get
			{
				return this._MaLoaiPhong;
			}
			set
			{
				if ((this._MaLoaiPhong != value))
				{
					if (this._LoaiPhong.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaLoaiPhongChanging(value);
					this.SendPropertyChanging();
					this._MaLoaiPhong = value;
					this.SendPropertyChanged("MaLoaiPhong");
					this.OnMaLoaiPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tang", DbType="NVarChar(MAX)")]
		public string Tang
		{
			get
			{
				return this._Tang;
			}
			set
			{
				if ((this._Tang != value))
				{
					this.OnTangChanging(value);
					this.SendPropertyChanging();
					this._Tang = value;
					this.SendPropertyChanged("Tang");
					this.OnTangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Phong_DatPhong", Storage="_DatPhongs", ThisKey="MaPhong", OtherKey="MaPhong")]
		public EntitySet<DatPhong> DatPhongs
		{
			get
			{
				return this._DatPhongs;
			}
			set
			{
				this._DatPhongs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiPhong_Phong", Storage="_LoaiPhong", ThisKey="MaLoaiPhong", OtherKey="MaLoaiPhong", IsForeignKey=true)]
		public LoaiPhong LoaiPhong
		{
			get
			{
				return this._LoaiPhong.Entity;
			}
			set
			{
				LoaiPhong previousValue = this._LoaiPhong.Entity;
				if (((previousValue != value) 
							|| (this._LoaiPhong.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LoaiPhong.Entity = null;
						previousValue.Phongs.Remove(this);
					}
					this._LoaiPhong.Entity = value;
					if ((value != null))
					{
						value.Phongs.Add(this);
						this._MaLoaiPhong = value.MaLoaiPhong;
					}
					else
					{
						this._MaLoaiPhong = default(string);
					}
					this.SendPropertyChanged("LoaiPhong");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_DatPhongs(DatPhong entity)
		{
			this.SendPropertyChanging();
			entity.Phong = this;
		}
		
		private void detach_DatPhongs(DatPhong entity)
		{
			this.SendPropertyChanging();
			entity.Phong = null;
		}
	}
}
#pragma warning restore 1591
