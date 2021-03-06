USE [Prueba]
GO
/****** Object:  Table [dbo].[Contacto]    Script Date: 01/03/2019 10:26:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacto](
	[idRegistro] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Telefono] [bigint] NULL,
	[Asunto] [varchar](250) NULL,
	[Mensaje] [varchar](350) NULL,
 CONSTRAINT [PK_Contacto] PRIMARY KEY CLUSTERED 
(
	[idRegistro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
