USE [aeroflot]
GO
/****** Object:  Table [dbo].[Aeroflot]    Script Date: 11.04.2023 22:31:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aeroflot](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[flight number] [int] NOT NULL,
	[destination] [nvarchar](25) NOT NULL,
	[departure time] [time](0) NOT NULL,
	[Arrival time] [time](0) NOT NULL,
	[number of free
places] [smallint] NULL,
	[aircraft type] [nvarchar](50) NOT NULL,
	[total seats] [int] NOT NULL,
 CONSTRAINT [PK_Aeroflot] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Aeroflot] ON 

INSERT [dbo].[Aeroflot] ([ID], [flight number], [destination], [departure time], [Arrival time], [number of free
places], [aircraft type], [total seats]) VALUES (1, 1, N'Россия', CAST(N'03:50:00' AS Time), CAST(N'11:50:00' AS Time), 5, N'A321', 50)
INSERT [dbo].[Aeroflot] ([ID], [flight number], [destination], [departure time], [Arrival time], [number of free
places], [aircraft type], [total seats]) VALUES (6, 2, N'Казахстан', CAST(N'02:40:00' AS Time), CAST(N'06:50:00' AS Time), 3, N'A321', 30)
INSERT [dbo].[Aeroflot] ([ID], [flight number], [destination], [departure time], [Arrival time], [number of free
places], [aircraft type], [total seats]) VALUES (7, 3, N'Финляндия', CAST(N'09:50:00' AS Time), CAST(N'14:50:00' AS Time), 6, N'A319', 60)
INSERT [dbo].[Aeroflot] ([ID], [flight number], [destination], [departure time], [Arrival time], [number of free
places], [aircraft type], [total seats]) VALUES (8, 4, N'Дания', CAST(N'12:50:00' AS Time), CAST(N'02:30:00' AS Time), 4, N'A318', 40)
INSERT [dbo].[Aeroflot] ([ID], [flight number], [destination], [departure time], [Arrival time], [number of free
places], [aircraft type], [total seats]) VALUES (9, 5, N'Австралия', CAST(N'06:20:00' AS Time), CAST(N'14:50:00' AS Time), 5, N'A319', 55)
INSERT [dbo].[Aeroflot] ([ID], [flight number], [destination], [departure time], [Arrival time], [number of free
places], [aircraft type], [total seats]) VALUES (10, 6, N'Багамы', CAST(N'04:40:00' AS Time), CAST(N'07:40:00' AS Time), 5, N'A318', 60)
INSERT [dbo].[Aeroflot] ([ID], [flight number], [destination], [departure time], [Arrival time], [number of free
places], [aircraft type], [total seats]) VALUES (11, 7, N'Австрия', CAST(N'08:50:00' AS Time), CAST(N'06:50:00' AS Time), 10, N'A321', 100)
INSERT [dbo].[Aeroflot] ([ID], [flight number], [destination], [departure time], [Arrival time], [number of free
places], [aircraft type], [total seats]) VALUES (12, 8, N'Бахрейн', CAST(N'04:40:00' AS Time), CAST(N'07:40:00' AS Time), 2, N'A318', 20)
INSERT [dbo].[Aeroflot] ([ID], [flight number], [destination], [departure time], [Arrival time], [number of free
places], [aircraft type], [total seats]) VALUES (13, 9, N'Боливия', CAST(N'10:50:00' AS Time), CAST(N'12:50:00' AS Time), 6, N'A320', 60)
INSERT [dbo].[Aeroflot] ([ID], [flight number], [destination], [departure time], [Arrival time], [number of free
places], [aircraft type], [total seats]) VALUES (14, 10, N'Болгария', CAST(N'05:40:00' AS Time), CAST(N'13:50:00' AS Time), 7, N'A319', 70)
INSERT [dbo].[Aeroflot] ([ID], [flight number], [destination], [departure time], [Arrival time], [number of free
places], [aircraft type], [total seats]) VALUES (15, 11, N'Бруней', CAST(N'15:40:00' AS Time), CAST(N'23:50:00' AS Time), 30, N'A320', 40)
INSERT [dbo].[Aeroflot] ([ID], [flight number], [destination], [departure time], [Arrival time], [number of free
places], [aircraft type], [total seats]) VALUES (16, 12, N'Италия', CAST(N'14:00:00' AS Time), CAST(N'20:40:00' AS Time), 24, N'A320', 40)
INSERT [dbo].[Aeroflot] ([ID], [flight number], [destination], [departure time], [Arrival time], [number of free
places], [aircraft type], [total seats]) VALUES (17, 13, N'Оман', CAST(N'23:50:00' AS Time), CAST(N'02:40:00' AS Time), 10, N'A321', 25)
INSERT [dbo].[Aeroflot] ([ID], [flight number], [destination], [departure time], [Arrival time], [number of free
places], [aircraft type], [total seats]) VALUES (18, 14, N'Латвия', CAST(N'10:40:00' AS Time), CAST(N'09:20:00' AS Time), 1, N'A321', 40)
INSERT [dbo].[Aeroflot] ([ID], [flight number], [destination], [departure time], [Arrival time], [number of free
places], [aircraft type], [total seats]) VALUES (19, 15, N'Конго', CAST(N'15:50:00' AS Time), CAST(N'05:50:00' AS Time), 4, N'A321', 40)
INSERT [dbo].[Aeroflot] ([ID], [flight number], [destination], [departure time], [Arrival time], [number of free
places], [aircraft type], [total seats]) VALUES (20, 16, N'Мальдивы', CAST(N'17:40:00' AS Time), CAST(N'02:50:00' AS Time), 5, N'A321', 50)
INSERT [dbo].[Aeroflot] ([ID], [flight number], [destination], [departure time], [Arrival time], [number of free
places], [aircraft type], [total seats]) VALUES (21, 17, N'Мальта', CAST(N'02:00:00' AS Time), CAST(N'06:00:00' AS Time), 0, N'A320', 50)
INSERT [dbo].[Aeroflot] ([ID], [flight number], [destination], [departure time], [Arrival time], [number of free
places], [aircraft type], [total seats]) VALUES (22, 18, N'Монголия', CAST(N'02:30:00' AS Time), CAST(N'13:50:00' AS Time), 0, N'A321', 100)
INSERT [dbo].[Aeroflot] ([ID], [flight number], [destination], [departure time], [Arrival time], [number of free
places], [aircraft type], [total seats]) VALUES (23, 19, N'ОАЭ', CAST(N'05:40:00' AS Time), CAST(N'02:50:00' AS Time), 3, N'A319', 30)
INSERT [dbo].[Aeroflot] ([ID], [flight number], [destination], [departure time], [Arrival time], [number of free
places], [aircraft type], [total seats]) VALUES (24, 20, N'Пакистан', CAST(N'03:40:00' AS Time), CAST(N'03:50:00' AS Time), 2, N'A321', 20)
SET IDENTITY_INSERT [dbo].[Aeroflot] OFF
GO
