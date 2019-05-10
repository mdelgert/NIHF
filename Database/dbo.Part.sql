USE [NIHF]
GO

/****** Object:  Table [dbo].[Part]    Script Date: 5/10/2019 2:17:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Part](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Number] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
	[ManufacturerID] [int] NOT NULL,
 CONSTRAINT [PK_Part] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


