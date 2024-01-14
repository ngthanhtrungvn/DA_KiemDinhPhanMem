create database [QL_LINHKIENDIENTU_WEB]
go
USE [QL_LINHKIENDIENTU_WEB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE accounts(
	id int IDENTITY(1,1) NOT NULL primary key,
	username varchar(100) NULL,
	email varchar(100) NULL,
	phone varchar(11) NULL,
	password varchar(500) NULL,
	image nvarchar(500) NULL,
	fullname nchar(100) NULL,
	address nvarchar(100) NULL,
	status bit NULL,
	idrole int NULL,
)

GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE category(
	id int IDENTITY(1,1) NOT NULL primary key,
	name nvarchar(100) NULL,
	alias varchar(100) NULL,
)
GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE orderdetails(
	idorder int NOT NULL,
	idproduct int NOT NULL,
	price decimal (18, 0) NULL,
	quantity int NULL,
	subtotal decimal(18, 0) NULL,
 CONSTRAINT [PK_orderdetails] PRIMARY KEY CLUSTERED 
(
	[idorder] ASC,
	[idproduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[orders]    Script Date: 4/24/2022 1:03:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[orders](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idaccount] [int] NULL,
	[createdate] [date] NULL,
	[email] [varchar](100) NULL,
	[fullname] [nvarchar](100) NULL,
	[address] [nvarchar](500) NULL,
	[phone] [varchar](11) NULL,
	[total] [decimal](18, 0) NULL,
	[note] [nvarchar](500) NULL,
 CONSTRAINT [PK_orders] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[products]    Script Date: 4/24/2022 1:03:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](200) NULL,
	[alias] [varchar](200) NULL,
	[price] [decimal](18, 0) NULL,
	[quantity] [int] NULL,
	[promationprice] [decimal](18, 0) NULL,
	[description] [ntext] NULL,
	[image] [varchar](500) NULL,
	[newproduct] [bit] NULL,
	[idcategory] [int] NULL,
 CONSTRAINT [PK_products] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[role]    Script Date: 4/24/2022 1:03:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[role](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[alias] [varchar](100) NOT NULL,
 CONSTRAINT [PK_role] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[accounts] ON 

INSERT [dbo].[accounts] ([id], [username], [email], [phone], [password], [image], [fullname], [address], [status], [idrole]) VALUES (1, N'dongduy', N'dongduy0612@gmail.com', N'0376880903', N'827ccb0eea8a706c4c34a16891f84e7b', N'Assets/Client/img/logo.svg', N'Duong Dong                                                                                          ', N'TP.HCM', 1, 2)
SET IDENTITY_INSERT [dbo].[accounts] OFF
SET IDENTITY_INSERT [dbo].[category] ON 

INSERT [dbo].[category] ([id], [name], [alias]) VALUES (1, N'Laptop', N'lap-top')
INSERT [dbo].[category] ([id], [name], [alias]) VALUES (2, N'Mainboard', N'main-board')
INSERT [dbo].[category] ([id], [name], [alias]) VALUES (3, N'CPU', N'cpu')
INSERT [dbo].[category] ([id], [name], [alias]) VALUES (4, N'RAM', N'ram')
SET IDENTITY_INSERT [dbo].[category] OFF
INSERT [dbo].[orderdetails] ([idorder], [idproduct], [price], [quantity], [subtotal]) VALUES (3, 4, CAST(4444 AS Decimal(18, 0)), 4444, CAST(444 AS Decimal(18, 0)))
INSERT [dbo].[orderdetails] ([idorder], [idproduct], [price], [quantity], [subtotal]) VALUES (4, 4, CAST(5500 AS Decimal(18, 0)), 1, CAST(5500 AS Decimal(18, 0)))
INSERT [dbo].[orderdetails] ([idorder], [idproduct], [price], [quantity], [subtotal]) VALUES (6, 3, CAST(8490 AS Decimal(18, 0)), 1, CAST(8490 AS Decimal(18, 0)))
INSERT [dbo].[orderdetails] ([idorder], [idproduct], [price], [quantity], [subtotal]) VALUES (7, 4, CAST(5500 AS Decimal(18, 0)), 1, CAST(5500 AS Decimal(18, 0)))
INSERT [dbo].[orderdetails] ([idorder], [idproduct], [price], [quantity], [subtotal]) VALUES (8, 2, CAST(1000 AS Decimal(18, 0)), 1, CAST(1000 AS Decimal(18, 0)))
INSERT [dbo].[orderdetails] ([idorder], [idproduct], [price], [quantity], [subtotal]) VALUES (9, 4, CAST(5500 AS Decimal(18, 0)), 1, CAST(5500 AS Decimal(18, 0)))
INSERT [dbo].[orderdetails] ([idorder], [idproduct], [price], [quantity], [subtotal]) VALUES (10, 4, CAST(5500 AS Decimal(18, 0)), 1, CAST(5500 AS Decimal(18, 0)))
INSERT [dbo].[orderdetails] ([idorder], [idproduct], [price], [quantity], [subtotal]) VALUES (12, 3, CAST(8490 AS Decimal(18, 0)), 1, CAST(8490 AS Decimal(18, 0)))
INSERT [dbo].[orderdetails] ([idorder], [idproduct], [price], [quantity], [subtotal]) VALUES (13, 4, CAST(5500 AS Decimal(18, 0)), 1, CAST(5500 AS Decimal(18, 0)))
INSERT [dbo].[orderdetails] ([idorder], [idproduct], [price], [quantity], [subtotal]) VALUES (14, 3, CAST(8490 AS Decimal(18, 0)), 1, CAST(8490 AS Decimal(18, 0)))
INSERT [dbo].[orderdetails] ([idorder], [idproduct], [price], [quantity], [subtotal]) VALUES (15, 1, CAST(2000 AS Decimal(18, 0)), 1, CAST(2000 AS Decimal(18, 0)))
INSERT [dbo].[orderdetails] ([idorder], [idproduct], [price], [quantity], [subtotal]) VALUES (16, 3, CAST(8490 AS Decimal(18, 0)), 1, CAST(8490 AS Decimal(18, 0)))
INSERT [dbo].[orderdetails] ([idorder], [idproduct], [price], [quantity], [subtotal]) VALUES (17, 2, CAST(1000 AS Decimal(18, 0)), 1, CAST(1000 AS Decimal(18, 0)))
INSERT [dbo].[orderdetails] ([idorder], [idproduct], [price], [quantity], [subtotal]) VALUES (18, 2, CAST(1000 AS Decimal(18, 0)), 1, CAST(1000 AS Decimal(18, 0)))
INSERT [dbo].[orderdetails] ([idorder], [idproduct], [price], [quantity], [subtotal]) VALUES (19, 4, CAST(5500 AS Decimal(18, 0)), 1, CAST(5500 AS Decimal(18, 0)))
INSERT [dbo].[orderdetails] ([idorder], [idproduct], [price], [quantity], [subtotal]) VALUES (20, 2, CAST(1000 AS Decimal(18, 0)), 11, CAST(11000 AS Decimal(18, 0)))
INSERT [dbo].[orderdetails] ([idorder], [idproduct], [price], [quantity], [subtotal]) VALUES (20, 4, CAST(5500 AS Decimal(18, 0)), 1, CAST(5500 AS Decimal(18, 0)))
INSERT [dbo].[orderdetails] ([idorder], [idproduct], [price], [quantity], [subtotal]) VALUES (21, 3, CAST(8490 AS Decimal(18, 0)), 3, CAST(25470 AS Decimal(18, 0)))
INSERT [dbo].[orderdetails] ([idorder], [idproduct], [price], [quantity], [subtotal]) VALUES (22, 1, CAST(2000 AS Decimal(18, 0)), 6, CAST(12000 AS Decimal(18, 0)))
INSERT [dbo].[orderdetails] ([idorder], [idproduct], [price], [quantity], [subtotal]) VALUES (23, 2, CAST(1000 AS Decimal(18, 0)), 1, CAST(1000 AS Decimal(18, 0)))
INSERT [dbo].[orderdetails] ([idorder], [idproduct], [price], [quantity], [subtotal]) VALUES (24, 4, CAST(5500 AS Decimal(18, 0)), 1, CAST(5500 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[orders] ON 

INSERT [dbo].[orders] ([id], [idaccount], [createdate], [email], [fullname], [address], [phone], [total], [note]) VALUES (1, 1, CAST(N'2022-03-27' AS Date), N'dongduy0612@gmail.com', N'Duong Dong                                                                                          ', N'166, ấp Tân Phú 2 6442 186 20', NULL, NULL, N'fadsf
                        ')
INSERT [dbo].[orders] ([id], [idaccount], [createdate], [email], [fullname], [address], [phone], [total], [note]) VALUES (2, 1, CAST(N'2022-03-27' AS Date), N'dongduy0612@gmail.com', N'Duong Dong                                                                                          ', N'   ', NULL, NULL, N'
                        ')
INSERT [dbo].[orders] ([id], [idaccount], [createdate], [email], [fullname], [address], [phone], [total], [note]) VALUES (3, 1, CAST(N'2022-03-27' AS Date), N'dongduy0612@gmail.com', N'Duong Dong                                                                                          ', N'   ', NULL, NULL, N'
                        ')
INSERT [dbo].[orders] ([id], [idaccount], [createdate], [email], [fullname], [address], [phone], [total], [note]) VALUES (4, 1, CAST(N'2022-03-27' AS Date), N'dongduy0612@gmail.com', N'Duong Dong                                                                                          ', N'   ', NULL, NULL, N'
                        ')
INSERT [dbo].[orders] ([id], [idaccount], [createdate], [email], [fullname], [address], [phone], [total], [note]) VALUES (5, 1, CAST(N'2022-03-27' AS Date), N'dongduy0612@gmail.com', N'Duong Dong                                                                                          ', N'   ', NULL, NULL, N'
                        ')
INSERT [dbo].[orders] ([id], [idaccount], [createdate], [email], [fullname], [address], [phone], [total], [note]) VALUES (6, 1, CAST(N'2022-03-27' AS Date), N'dongduy0612@gmail.com', N'Duong Dong                                                                                          ', N'   ', NULL, NULL, N'
                        ')
INSERT [dbo].[orders] ([id], [idaccount], [createdate], [email], [fullname], [address], [phone], [total], [note]) VALUES (7, 1, CAST(N'2022-03-28' AS Date), N'dongduy0612@gmail.com', N'Duong Dong                                                                                          ', N'   ', NULL, NULL, N'
                        ')
INSERT [dbo].[orders] ([id], [idaccount], [createdate], [email], [fullname], [address], [phone], [total], [note]) VALUES (8, 1, CAST(N'2022-03-28' AS Date), N'dongduy0612@gmail.com', N'Duong Dong                                                                                          ', N'   ', NULL, NULL, N'
                        ')
INSERT [dbo].[orders] ([id], [idaccount], [createdate], [email], [fullname], [address], [phone], [total], [note]) VALUES (9, 1, CAST(N'2022-03-28' AS Date), N'dongduy0612@gmail.com', N'Duong Dong                                                                                          ', N'   ', NULL, NULL, N'
                        ')
INSERT [dbo].[orders] ([id], [idaccount], [createdate], [email], [fullname], [address], [phone], [total], [note]) VALUES (10, 1, CAST(N'2022-03-28' AS Date), N'dongduy0612@gmail.com', N'Duong Dong                                                                                          ', N'   ', NULL, NULL, N'
                        ')
INSERT [dbo].[orders] ([id], [idaccount], [createdate], [email], [fullname], [address], [phone], [total], [note]) VALUES (11, 1, CAST(N'2022-03-28' AS Date), N'dongduy0612@gmail.com', N'Duong Dong                                                                                          ', N'   ', NULL, NULL, N'
                        ')
INSERT [dbo].[orders] ([id], [idaccount], [createdate], [email], [fullname], [address], [phone], [total], [note]) VALUES (12, 1, CAST(N'2022-03-28' AS Date), N'dongduy0612@gmail.com', N'Duong Dong                                                                                          ', N'   ', NULL, NULL, N'
                        ')
INSERT [dbo].[orders] ([id], [idaccount], [createdate], [email], [fullname], [address], [phone], [total], [note]) VALUES (13, 1, CAST(N'2022-03-28' AS Date), N'dongduy0612@gmail.com', N'Duong Dong                                                                                          ', N'FASDFA 1297 42 4', NULL, NULL, N'FSADFASD
                        ')
INSERT [dbo].[orders] ([id], [idaccount], [createdate], [email], [fullname], [address], [phone], [total], [note]) VALUES (14, 1, CAST(N'2022-03-28' AS Date), N'dongduy0612@gmail.com', N'Duong Dong                                                                                          ', N'   ', NULL, NULL, N'
                        ')
INSERT [dbo].[orders] ([id], [idaccount], [createdate], [email], [fullname], [address], [phone], [total], [note]) VALUES (15, 1, CAST(N'2022-03-28' AS Date), N'dongduy0612@gmail.com', N'Duong Dong                                                                                          ', N'   ', NULL, NULL, NULL)
INSERT [dbo].[orders] ([id], [idaccount], [createdate], [email], [fullname], [address], [phone], [total], [note]) VALUES (16, 1, CAST(N'2022-03-28' AS Date), N'dongduy0612@gmail.com', N'Duong Dong                                                                                          ', N'   ', NULL, NULL, NULL)
INSERT [dbo].[orders] ([id], [idaccount], [createdate], [email], [fullname], [address], [phone], [total], [note]) VALUES (17, 1, CAST(N'2022-03-28' AS Date), N'dongduy0612@gmail.com', N'Duong Dong', N'TP.HCM 742 26 2', NULL, NULL, NULL)
INSERT [dbo].[orders] ([id], [idaccount], [createdate], [email], [fullname], [address], [phone], [total], [note]) VALUES (18, 1, CAST(N'2022-03-28' AS Date), N'dongduy0612@gmail.com', N'Duong Dong                                                                                          ', N'166 1402 45 4', NULL, NULL, NULL)
INSERT [dbo].[orders] ([id], [idaccount], [createdate], [email], [fullname], [address], [phone], [total], [note]) VALUES (19, 1, CAST(N'2022-03-28' AS Date), N'dongduy0612@gmail.com', N'Duong Dong                                                                                          ', N'166 ấp Tân Phú 2 Xã Tân Thuận Bình Huyện Chợ Gạo Tỉnh Tiền Giang', NULL, NULL, NULL)
INSERT [dbo].[orders] ([id], [idaccount], [createdate], [email], [fullname], [address], [phone], [total], [note]) VALUES (20, 1, CAST(N'2022-03-28' AS Date), N'dongduy0612@gmail.com', N'Duong Dong                                                                                          ', N'   ', NULL, NULL, NULL)
INSERT [dbo].[orders] ([id], [idaccount], [createdate], [email], [fullname], [address], [phone], [total], [note]) VALUES (21, 1, CAST(N'2022-03-29' AS Date), N'dongduy0612@gmail.com', N'Duong Dong                                                                                          ', N'Mỹ Tho Xã An Thịnh Huyện Văn Yên Tỉnh Yên Bái', NULL, NULL, N'dfasdfa')
INSERT [dbo].[orders] ([id], [idaccount], [createdate], [email], [fullname], [address], [phone], [total], [note]) VALUES (22, 1, CAST(N'2022-03-31' AS Date), N'dongduy0612@gmail.com', N'Duong Dong                                                                                          ', N' Phường Yên Thanh Thành phố Uông Bí Tỉnh Quảng Ninh', NULL, NULL, NULL)
INSERT [dbo].[orders] ([id], [idaccount], [createdate], [email], [fullname], [address], [phone], [total], [note]) VALUES (23, 1, CAST(N'2022-04-24' AS Date), N'dongduy0612@gmail.com', N'Duong Dong                                                                                          ', N'   ', NULL, NULL, NULL)
INSERT [dbo].[orders] ([id], [idaccount], [createdate], [email], [fullname], [address], [phone], [total], [note]) VALUES (24, 1, CAST(N'2022-04-24' AS Date), N'dongduy0612@gmail.com', N'Duong Dong                                                                                          ', N'Tiền Giang Xã Tả Sử Choóng Huyện Hoàng Su Phì Tỉnh Hà Giang', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[orders] OFF
SET IDENTITY_INSERT [dbo].[products] ON 

INSERT [dbo].[products] ([id], [name], [alias], [price], [quantity], [promationprice], [description], [image], [newproduct], [idcategory]) VALUES (1, N'Asus Rog Strix G G512 Ial013t', N'asus-rog-strix-g-g512-ial013t', CAST(2199 AS Decimal(18, 0)), 100, CAST(2000 AS Decimal(18, 0)), N'Màu xám kim loại và ấn tượng hơn khi kết hợp với những đường phây xước đẹp mắt.Thiết kế chiến lược này là sự hợp tác của Asus với Tập đoàn BMW Designworks cho ra đời dãi màu 3D Flow Zone sống động', N'Assets/Client/img/imagelp1.jpg', 1, 1)
INSERT [dbo].[products] ([id], [name], [alias], [price], [quantity], [promationprice], [description], [image], [newproduct], [idcategory]) VALUES (2, N'Asus H410m-e', N'asus-h410m-e', CAST(1865 AS Decimal(18, 0)), 100, CAST(1000 AS Decimal(18, 0)), N'Sẵn sàng cho bộ vi xử lý Intel® Core ™ thế hệ thứ 10 mới nhất', N'Assets/Client/img/imagemb1.jpg', 0, 1)
INSERT [dbo].[products] ([id], [name], [alias], [price], [quantity], [promationprice], [description], [image], [newproduct], [idcategory]) VALUES (3, N'AMD Ryzen 7 3700x', N'amd-ryzen-7-3700x', CAST(8490 AS Decimal(18, 0)), 100, CAST(0 AS Decimal(18, 0)), N'Một trong những mã CPU được nhiều người mong đợi nhất trong list cpu Ryezn 3000 Series', N'Assets/Client/img/imagecp1.jpg', 1, 3)
INSERT [dbo].[products] ([id], [name], [alias], [price], [quantity], [promationprice], [description], [image], [newproduct], [idcategory]) VALUES (4, N'Adata Value Value 4GB', N'adata-value-value-4gb', CAST(5500 AS Decimal(18, 0)), 100, CAST(0 AS Decimal(18, 0)), N'một trong những công ty đứng đầu trong ngành sản xuất, thiết kế bộ nhớ và ổ cứng kho dữ liệu trên thế giói được thành lập vào tháng 5 năm 2001', N'Assets/Client/img/imagera1.jpg', 1, 4)
SET IDENTITY_INSERT [dbo].[products] OFF
SET IDENTITY_INSERT [dbo].[role] ON 

INSERT [dbo].[role] ([id], [name], [alias]) VALUES (1, N'admin', N'admin')
INSERT [dbo].[role] ([id], [name], [alias]) VALUES (2, N'user', N'user')
SET IDENTITY_INSERT [dbo].[role] OFF
ALTER TABLE [dbo].[accounts]  WITH CHECK ADD  CONSTRAINT [FK_accounts_role] FOREIGN KEY([idrole])
REFERENCES [dbo].[role] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[accounts] CHECK CONSTRAINT [FK_accounts_role]
GO
ALTER TABLE [dbo].[orderdetails]  WITH CHECK ADD  CONSTRAINT [FK_orderdetails_orders] FOREIGN KEY([idorder])
REFERENCES [dbo].[orders] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[orderdetails] CHECK CONSTRAINT [FK_orderdetails_orders]
GO
ALTER TABLE [dbo].[orderdetails]  WITH CHECK ADD  CONSTRAINT [FK_orderdetails_products] FOREIGN KEY([idproduct])
REFERENCES [dbo].[products] ([id])
GO
ALTER TABLE [dbo].[orderdetails] CHECK CONSTRAINT [FK_orderdetails_products]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_orders_accounts] FOREIGN KEY([idaccount])
REFERENCES [dbo].[accounts] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_orders_accounts]
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD  CONSTRAINT [FK_products_category] FOREIGN KEY([idcategory])
REFERENCES [dbo].[category] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[products] CHECK CONSTRAINT [FK_products_category]
GO
