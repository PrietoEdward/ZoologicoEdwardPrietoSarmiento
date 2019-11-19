USE [pruebas]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =======================================================================================================================================
-- Author               date                    Description
-- =======================================================================================================================================
-- Edward Prieto       05/11/2019           	Se crea tabla Visitas_Veterinario
-- =======================================================================================================================================

CREATE TABLE  [pruebas].[dbo].[Visitas_Veterinario]
(
   	[vive_id] [int] IDENTITY(1,1) NOT NULL,
   	[vive_fecha] [datetime] NULL,
	[vive_observaciones] [varchar](500) NULL,
	[anim_id] [int] NOT NULL
	
PRIMARY KEY CLUSTERED 
(
	[vive_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [pruebas].[dbo].[Visitas_Veterinario]  WITH CHECK ADD  CONSTRAINT [FK_dbo_Visitas_Veterinario] FOREIGN KEY([vive_id])
REFERENCES [pruebas].[dbo].[animal] ([anim_id])
GO
