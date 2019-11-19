USE [pruebas]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =======================================================================================================================================
-- Author               date                    Description
-- =======================================================================================================================================
-- Edward Prieto       05/11/2019           	Se crea tabla animal
-- =======================================================================================================================================

CREATE TABLE  [pruebas].[dbo].[animal]
(
   	[anim_id] [int] IDENTITY(1,1) NOT NULL,
   	[anim_nombre] [varchar](50) NULL,
	[anim_edad] [int] NULL,
	[anim_origen] [varchar](50) NULL,
	[anim_tipo_alimento] [varchar](50) NULL,
	[anim_cantidad] [int] NULL,
	[gene_id] [int] NOT NULL,
	[espe_id] [int] NOT NULL,
	[esta_id] [int] NOT NULL
	
PRIMARY KEY CLUSTERED 
(
	[anim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [pruebas].[dbo].[animal]  WITH CHECK ADD  CONSTRAINT [FK_dbo_especie_1] FOREIGN KEY([anim_id])
REFERENCES [pruebas].[dbo].[especie] ([espe_id])
GO

ALTER TABLE [pruebas].[dbo].[animal]  WITH CHECK ADD  CONSTRAINT [FK_dbo_genero_1] FOREIGN KEY([anim_id])
REFERENCES [pruebas].[dbo].[genero] ([gene_id])
GO

ALTER TABLE [pruebas].[dbo].[animal]  WITH CHECK ADD  CONSTRAINT [FK_dbo_estado_1] FOREIGN KEY([anim_id])
REFERENCES [pruebas].[dbo].[estado] ([esta_id])
GO
