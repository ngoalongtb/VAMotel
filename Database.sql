USE master
IF EXISTS (SELECT 1 FROM sys.databases WHERE name = 'QLPhongTro')
	DROP DATABASE QLPhongTro
GO
CREATE DATABASE QLPhongTro
GO
USE QLPhongTro
GO

CREATE TABLE TaiKhoan(
	tai_khoan VARCHAR(255) PRIMARY KEY,
	mat_khau VARCHAR(255),
	ten_hien_thi VARCHAR(255),
	url_anh VARCHAR(255),
	da_xoa BIT, --1: xóa
	loai_tai_khoan INT, --0: admin, 1: chủ trọ, 2: thành viên

	ten VARCHAR(255),
	ngay_sinh DATE,
	so_dien_thoai VARCHAR(20),
	email VARCHAR(255)
)

CREATE TABLE BaiViet(
	ma INT IDENTITY PRIMARY KEY,
	da_xoa BIT, --1: xoa
	tieu_de VARCHAR(255) NOT NULL,
	noi_dung VARCHAR(MAX),
	ngay_tao DATETIME,
	nguoi_tao VARCHAR(255),
	do_uu_tien INT -- độ ưu tiên của bài viết hiển thị lên đầu
)

CREATE TABLE BinhLuan(
	ma INT IDENTITY PRIMARY KEY,
	da_xoa BIT,
	noi_dung VARCHAR(MAX),
	ngay_tao DATETIME,
	nguoi_tao VARCHAR(255),
	ma_bai_viet INT --
)

CREATE TABLE KhuTro(
	ma INT IDENTITY PRIMARY KEY,
	da_xoa BIT, --1:xoa
	dia_chi VARCHAR(255),
	chu_tro VARCHAR(255)
)

CREATE TABLE PhongTro(
	ma INT IDENTITY PRIMARY KEY,
	da_xoa BIT, --1:xoa
	so_phong INT,
	ma_khu_tro INT, --
	nguoi_thue VARCHAR(255)
)

CREATE TABLE LichSuThueNha(
	ma INT IDENTITY PRIMARY KEY,
	ma_phong INT,
	nguoi_thue VARCHAR(255),
	ngay_thue DATE
)

GO

ALTER TABLE BaiViet
ADD FOREIGN KEY(nguoi_tao) REFERENCES TaiKhoan(tai_khoan)

ALTER TABLE KhuTro
ADD FOREIGN KEY(chu_tro) REFERENCES TaiKhoan(tai_khoan)

ALTER TABLE PhongTro
ADD FOREIGN KEY(nguoi_thue) REFERENCES TaiKhoan(tai_khoan)
ALTER TABLE PhongTro
ADD FOREIGN KEY(ma_khu_tro) REFERENCES KhuTro(ma)

ALTER TABLE BinhLuan
ADD FOREIGN KEY(ma_bai_viet) REFERENCES BaiViet(ma)

ALTER TABLE LichSuThueNha
ADD FOREIGN KEY(ma_phong) REFERENCES PhongTro(ma)
ALTER TABLE LichSuThueNha
ADD FOREIGN KEY(nguoi_thue) REFERENCES TaiKhoan(tai_khoan)

