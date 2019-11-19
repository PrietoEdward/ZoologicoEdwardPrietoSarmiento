USE [pruebas]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =======================================================================================================================================
-- Author               date                    Description
-- =======================================================================================================================================
-- Edward Prieto       31/10/2019           	Se crea tabla de Animal por su ID
-- =======================================================================================================================================

CREATE PROCEDURE [dbo].[SP_GET_ANIMAL_ID]
(
	@anim_id INT
)
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
  FROM [dbo].[animal] as ani WITH(NOLOCK)
  WHERE [anim_id] = @anim_id
	
END


	

