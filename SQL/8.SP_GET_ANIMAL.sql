USE [pruebas]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =======================================================================================================================================
-- Author               date                    Description
-- =======================================================================================================================================
-- Edward Prieto       31/10/2019           	Se crea tabla de stock
-- =======================================================================================================================================

CREATE PROCEDURE [dbo].[SP_GET_ANIMAL]
AS
BEGIN

	SET NOCOUNT ON;

	SELECT
      [anim_id]
      ,[anim_nombre]
      ,[anim_edad]
      ,[anim_origen]
      ,[anim_tipo_alimento]
      ,[anim_cantidad]
	  ,[gene_nombre]
	  ,[espe_nombre]	  
  FROM [dbo].[animal] as ani WITH(NOLOCK)
  INNER JOIN [dbo].[genero] as gen ON gen.gene_id = ani.gene_id
  INNER JOIN [dbo].[especie] as esp ON esp.espe_id = ani.espe_id
	
END


	

