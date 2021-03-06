USE [master]
GO
/****** Object:  Database [QLPhongTro]    Script Date: 2/25/2018 5:15:35 PM ******/
CREATE DATABASE [QLPhongTro]
GO
USE [QLPhongTro]
GO
/****** Object:  Table [dbo].[BaiViet]    Script Date: 2/25/2018 5:15:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BaiViet](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[tieu_de] [nvarchar](255) NOT NULL,
	[hinh_anh] [varchar](255) NULL,
	[noi_dung] [nvarchar](max) NULL,
	[ngay_tao] [datetime] NULL,
	[nguoi_tao] [varchar](255) NULL,
	[dia_chi] [nvarchar](255) NULL,
	[dien_tich] [nvarchar](255) NULL,
	[gia_ca] [int] NULL,
	[do_uu_tien] [int] NULL,
	[ma_danh_muc] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DanhMuc]    Script Date: 2/25/2018 5:15:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMuc](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhuTro]    Script Date: 2/25/2018 5:15:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhuTro](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[da_xoa] [bit] NULL,
	[dia_chi] [nvarchar](255) NULL,
	[chu_tro] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhongTro]    Script Date: 2/25/2018 5:15:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhongTro](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[da_xoa] [bit] NULL,
	[so_phong] [int] NULL,
	[ma_khu_tro] [int] NULL,
	[nguoi_thue] [nvarchar](255) NULL,
	[cmtnd] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 2/25/2018 5:15:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[tai_khoan] [varchar](255) NOT NULL,
	[mat_khau] [varchar](255) NULL,
	[ten_hien_thi] [nvarchar](255) NULL,
	[hinh_anh] [nvarchar](255) NULL,
	[loai_tai_khoan] [int] NULL,
	[ten] [varchar](255) NULL,
	[ngay_sinh] [date] NULL,
	[so_dien_thoai] [varchar](20) NULL,
	[email] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[tai_khoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[BaiViet] ON 

INSERT [dbo].[BaiViet] ([ma], [tieu_de], [hinh_anh], [noi_dung], [ngay_tao], [nguoi_tao], [dia_chi], [dien_tich], [gia_ca], [do_uu_tien], [ma_danh_muc]) VALUES (1, N'Cần tìm 1 nam ở ghép đường gò dầu quận tân phú', N'1.jpg', N'<p> <a href="http://phongtot.vn/phong-tro-nha-tro/can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu">143/15 gò dầu quận tân phú </a>, <a href="http://phongtot.vn/phong-tro-nha-tro/can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu">Gò Dầu</a>, <a href="http://phongtot.vn/phong-tro-nha-tro/can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu">Tân Phú</a>, <a href="http://phongtot.vn/phong-tro-nha-tro/can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu">Hồ Chí Minh</a></p><p>Diện tích <a href="http://phongtot.vn/phong-tro-nha-tro/can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu">25m2</a> Loại phòng <a href="http://phongtot.vn/phong-tro-nha-tro/can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu">Phòng trọ, nhà trọ</a></p><p>Tầng <a href="http://phongtot.vn/phong-tro-nha-tro/can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu">1</a></p><p>Vệ sinh <a href="http://phongtot.vn/phong-tro-nha-tro/can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu">Chưa xác định</a> Số người ở <a href="http://phongtot.vn/phong-tro-nha-tro/can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu">4</a></p><p>Giá điện <a href="http://phongtot.vn/phong-tro-nha-tro/can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu">Nhà nước quy định</a> Giá nước <a href="http://phongtot.vn/phong-tro-nha-tro/can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu">Nhà nước quy định</a></p><p>Tiện ích <a href="http://phongtot.vn/phong-tro-nha-tro/can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu">Chỗ để xe</a> , <a href="http://phongtot.vn/phong-tro-nha-tro/can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu">Sân phơi</a> , <a href="http://phongtot.vn/phong-tro-nha-tro/can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu">Internet</a></p><p><a href="http://phongtot.vn/phong-tro-nha-tro/can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu">Thông Tin Liên Hệ</a></p><hr /><p><a href="http://phongtot.vn/phong-tro-nha-tro/can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu">750,000 Đ/Tháng</a></p><p><a href="http://phongtot.vn/phong-tro-nha-tro/can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu">Trong Nhuong Nguyen</a></p><p><a href="http://phongtot.vn/phong-tro-nha-tro/can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu">0961143325</a></p><p><a href="http://phongtot.vn/phong-tro-nha-tro/can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu#tab_auth_login">Phản Hồi Tình Trạng</a> <a href="http://phongtot.vn/luu-tin/phong-tro-nha-tro/can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu">Lưu Tin</a></p><p><img alt="can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu" src="http://media.phongtot.vn/xc5tx4cj/can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu-wjoav.jpg" /></p><p><img alt="can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu" src="http://media.phongtot.vn/xc5tx4cj/can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu-1tyw3.jpg" /></p><p><img alt="can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu" src="http://media.phongtot.vn/xc5tx4cj/can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu-rdpgk.jpg" /></p><p><img alt="can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu" src="http://media.phongtot.vn/xc5tx4cj/can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu-z5wkl.jpg" /></p><p><img alt="can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu" src="http://media.phongtot.vn/xc5tx4cj/can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu-n2r81.jpg" /></p><p><img alt="can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu" src="http://media.phongtot.vn/xc5tx4cj/can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu-wjoav.jpg" /></p><p><img alt="can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu" src="http://media.phongtot.vn/xc5tx4cj/can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu-1tyw3.jpg" /></p><p><img alt="can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu" src="http://media.phongtot.vn/xc5tx4cj/can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu-rdpgk.jpg" /></p><p><img alt="can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu" src="http://media.phongtot.vn/xc5tx4cj/can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu-z5wkl.jpg" /></p><p><img alt="can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu" src="http://media.phongtot.vn/xc5tx4cj/can-tim-1-nam-o-ghep-duong-go-dau-quan-tan-phu-n2r81.jpg" /></p><p>Cần tìm 1 nam ở ghép đường gò dầu quận tân phú <br />Phòng rộng 25m2 , 4 ng ở thoải mái ,không chung chủ , giá 3tr, hiện phòng có 3 ng ở là thợ cắt tóc nhân viên bán hàng đa số đều đi làm đến 9h tối mới về rất vui vẻ thoải mái , nếu ở 4 ng thì 750k /tháng <br />Phòng nằm trong nhà nguyên căn ko chung chủ , , h giấc tự do , phòng rất sạch sẽ có 1 cửa sổ mặt tiền hẻm lớn nên rất thông thoáng và 1 ban công nhỏ ngay trong phòng rất tiện phơi đồ , wc rộng rãi ngay trc cửa phòng , 1 phòng bếp chung sạch sẽ nấu ăn thoải mái , chỗ để xe tầng trệt rất rộng rãi , cửa nhà sử dụng chìa khóa bấm tự động rất tiện cho ra vào và an ninh nên tối ko sợ mất đồ , nước 50k 1 người , điện theo giá nhà nước , vị trí thuận tiện gần đh công nghệ thực phẩm , đh văn hiến , đh bách khoa... ai có nhu cầu liên hệ ngân sdt 0966714419 hoặc 0961143325, nhà rất đẹp vào xem sẽ thik ngay </p>', CAST(N'2018-02-04 00:24:36.000' AS DateTime), NULL, N'143/15 gò dầu quận tân phú , Gò Dầu, Tân Phú, Hồ Chí Minh', N'25', 700000, 1, 1)
INSERT [dbo].[BaiViet] ([ma], [tieu_de], [hinh_anh], [noi_dung], [ngay_tao], [nguoi_tao], [dia_chi], [dien_tich], [gia_ca], [do_uu_tien], [ma_danh_muc]) VALUES (2, N'Phòng trọ mới xây thoáng mát view đẹp an ninh sạch sẽ free gửi xe', N'2.jpg', N'<p>Dãy phòng trọ mới xây có gác lửng, toilet riêng, có chỗ nấu ăn.<br />Gần chợ, gần trường học, gần siêu thị khu ăn uống chợ đêm. Khu vực dân trí cao.<br />Giữ xe free có camera, khoá thẻ từ dấu vân tay, an ninh cao. Phòng thoáng mát sạch sẽ, tiện nghi.<br />Có sân phơi đồ view đẹp có thể thư giãn buổi tối hoặc cuối tuần<br />Điện 3.5 k/ký nuớc 5k/ khối<br />Phòng 23m2 cả gác 2 triệu/ tháng. Phòng lớn 28m2 cả gác 2 triệu rưỡi/ tháng. Cọc 1 tháng <br /><br /><br />Chủ nhà thân thiện dễ tính, xem nhà gọi báo trước 30 phút<br />Liên hệ anh Duy:</p>', CAST(N'2018-02-04 00:25:40.560' AS DateTime), NULL, N'133/8 Bình Thành, P Bình Hưng Hòa, Q Bình Tân, TP HCM, Bình Thành, Bình Tân, Hồ Chí Minh', N'23', 1000000, 2, 1)
SET IDENTITY_INSERT [dbo].[BaiViet] OFF
SET IDENTITY_INSERT [dbo].[DanhMuc] ON 

INSERT [dbo].[DanhMuc] ([ma], [ten]) VALUES (1, N'Phòng trọ')
INSERT [dbo].[DanhMuc] ([ma], [ten]) VALUES (2, N'Văn phòng')
INSERT [dbo].[DanhMuc] ([ma], [ten]) VALUES (3, N'Giới thiệu')
INSERT [dbo].[DanhMuc] ([ma], [ten]) VALUES (4, N'Liên hệ')
SET IDENTITY_INSERT [dbo].[DanhMuc] OFF
SET IDENTITY_INSERT [dbo].[KhuTro] ON 

INSERT [dbo].[KhuTro] ([ma], [da_xoa], [dia_chi], [chu_tro]) VALUES (1, NULL, N'Nhổn ', N'admin')
INSERT [dbo].[KhuTro] ([ma], [da_xoa], [dia_chi], [chu_tro]) VALUES (2, NULL, N'Nhổn 2', N'admin')
SET IDENTITY_INSERT [dbo].[KhuTro] OFF
SET IDENTITY_INSERT [dbo].[PhongTro] ON 

INSERT [dbo].[PhongTro] ([ma], [da_xoa], [so_phong], [ma_khu_tro], [nguoi_thue], [cmtnd]) VALUES (3, NULL, 1, 1, N'Tạ Minh Luận', N'152122342')
INSERT [dbo].[PhongTro] ([ma], [da_xoa], [so_phong], [ma_khu_tro], [nguoi_thue], [cmtnd]) VALUES (4, NULL, 2, 1, N'Luận Tạ Minh', N'123123123')
SET IDENTITY_INSERT [dbo].[PhongTro] OFF
INSERT [dbo].[TaiKhoan] ([tai_khoan], [mat_khau], [ten_hien_thi], [hinh_anh], [loai_tai_khoan], [ten], [ngay_sinh], [so_dien_thoai], [email]) VALUES (N'admin', N'admin', N'admin', N'admin.jpg', 0, N'admin', CAST(N'1996-11-25' AS Date), N'0966 810 907', N'ngoalongtb001@gmail.com')
INSERT [dbo].[TaiKhoan] ([tai_khoan], [mat_khau], [ten_hien_thi], [hinh_anh], [loai_tai_khoan], [ten], [ngay_sinh], [so_dien_thoai], [email]) VALUES (N'user', N'user', N'user', NULL, 1, NULL, NULL, NULL, NULL)
ALTER TABLE [dbo].[BaiViet]  WITH CHECK ADD FOREIGN KEY([ma_danh_muc])
REFERENCES [dbo].[DanhMuc] ([ma])
GO
ALTER TABLE [dbo].[BaiViet]  WITH CHECK ADD FOREIGN KEY([nguoi_tao])
REFERENCES [dbo].[TaiKhoan] ([tai_khoan])
GO
ALTER TABLE [dbo].[KhuTro]  WITH CHECK ADD FOREIGN KEY([chu_tro])
REFERENCES [dbo].[TaiKhoan] ([tai_khoan])
GO
ALTER TABLE [dbo].[PhongTro]  WITH CHECK ADD FOREIGN KEY([ma_khu_tro])
REFERENCES [dbo].[KhuTro] ([ma])
GO
USE [master]
GO
ALTER DATABASE [QLPhongTro] SET  READ_WRITE 
GO
