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

CREATE PROCEDURE [dbo].[SP_UPD_ANIMAL]
(
	@anim_id INT,
	@anim_nombre VARCHAR(50),
	@anim_edad INT,
	@anim_origen VARCHAR(50),
	@anim_tipo_alimento  VARCHAR(50),
	@anim_cantidad INT
)
AS
BEGIN

	UPDATE	[dbo].[animal]
	SET		[anim_nombre] = @anim_nombre,
			[anim_edad] = @anim_edad,
			[anim_origen] = @anim_origen,
			[anim_tipo_alimento] = @anim_tipo_alimento,
			[anim_cantidad] = @anim_cantidad
	WHERE	[anim_id] = @anim_id
	
END
