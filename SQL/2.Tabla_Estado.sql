USE [pruebas]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =======================================================================================================================================
-- Author               date                    Description
-- =======================================================================================================================================
-- Edward Prieto       05/11/2019           	Se crea tabla estado
-- =======================================================================================================================================

CREATE TABLE  [pruebas].[dbo].[estado]
(
   	[esta_id] [int] IDENTITY(1,1) NOT NULL,
   	[esta_titulo] [varchar](50) NULL,
	[esta_descripcion] [varchar](50) NULL,
	
PRIMARY KEY CLUSTERED 
(
	[esta_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

