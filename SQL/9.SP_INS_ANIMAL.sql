USE [pruebas]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =======================================================================================================================================
-- Author               date                    Description
-- =======================================================================================================================================
-- Edward Prieto       31/10/2019           	Se crea tabla de Animal
-- =======================================================================================================================================

CREATE PROCEDURE [dbo].[SP_INS_ANIMAL]
(
	@anim_nombre VARCHAR(50),
	@anim_edad INT,
	@anim_origen VARCHAR(50),
	@anim_tipo_alimento  VARCHAR(50),
	@anim_cantidad INT,
	@gene_id INT,
	@espe_id INT,
	@esta_id INT
)
AS
BEGIN

	INSERT INTO [dbo].[animal]
		(
			[anim_nombre]
			,[anim_edad]
			,[anim_origen]
			,[anim_tipo_alimento]
			,[anim_cantidad]
			,[gene_id]
			,[espe_id]
			,[esta_id]
		)
		VALUES 
		(
			@anim_nombre
			,@anim_edad
			,@anim_origen
			,@anim_tipo_alimento
			,@anim_cantidad
			,@gene_id
			,@espe_id
			,@esta_id
		)	
END

