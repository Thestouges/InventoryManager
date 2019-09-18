CREATE TABLE [dbo].[Item](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Item] [nvarchar](50) NOT NULL,
	[Type] [nchar](10) NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ItemTypes](
	[Type] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](50) NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Log](
	[LogID] [int] NOT NULL,
	[ItemID] [int] NOT NULL,
	[Trans] [nvarchar](50) NOT NULL,
	[Quantity] [int] NOT NULL
) ON [PRIMARY]
GO