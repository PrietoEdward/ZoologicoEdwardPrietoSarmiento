USE [pruebas]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =======================================================================================================================================
-- Author               date                    Description
-- =======================================================================================================================================
-- Edward Prieto       05/11/2019           	Se crea tabla animal_has_novedad
-- =======================================================================================================================================

CREATE TABLE  [pruebas].[dbo].[animal_has_novedad]
(
   	[ahasn_id] [int] IDENTITY(1,1) NOT NULL,
   	[anim_id] [int] NULL,
	[nove_id] [int] NULL	
	
PRIMARY KEY CLUSTERED 
(
	[ahasn_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [pruebas].[dbo].[animal_has_novedad]  WITH CHECK ADD  CONSTRAINT [FK_dbo_has_animal] FOREIGN KEY([ahasn_id])
REFERENCES [pruebas].[dbo].[animal] ([anim_id])
GO

ALTER TABLE [pruebas].[dbo].[animal_has_novedad]  WITH CHECK ADD  CONSTRAINT [FK_dbo_has_novedad] FOREIGN KEY([ahasn_id])
REFERENCES [pruebas].[dbo].[novedad] ([nove_id])
GO
