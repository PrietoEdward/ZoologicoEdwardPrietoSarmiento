USE [pruebas]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =======================================================================================================================================
-- Author               date                    Description
-- =======================================================================================================================================
-- Edward Prieto       05/11/2019           	Se crea tabla especie
-- =======================================================================================================================================

CREATE TABLE  [pruebas].[dbo].[especie]
(
   	[espe_id] [int] IDENTITY(1,1) NOT NULL,
   	[espe_nombre] [varchar](50) NOT NULL
	
PRIMARY KEY CLUSTERED 
(
	[espe_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


