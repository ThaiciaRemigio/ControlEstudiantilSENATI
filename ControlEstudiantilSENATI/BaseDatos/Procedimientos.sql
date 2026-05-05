-- =====================================
-- Procesos ESTUDIANTES
-- =====================================

/*PRIMERO PROCEDIMIENTO ESTUDIANTES*/
CREATE OR ALTER PROCEDURE sp_BuscarEstudiante
(
    @TextoBusqueda VARCHAR(100) = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT *
    FROM vw_Estudiantes
    WHERE
        (@TextoBusqueda IS NULL OR LTRIM(RTRIM(@TextoBusqueda)) = '')
        OR dni LIKE '%' + @TextoBusqueda + '%'
        OR nombres LIKE '%' + @TextoBusqueda + '%'
        OR apellidos LIKE '%' + @TextoBusqueda + '%'
        OR correo1 LIKE '%' + @TextoBusqueda + '%'
        OR telefono1 LIKE '%' + @TextoBusqueda + '%'
        OR nombre_genero LIKE '%' + @TextoBusqueda + '%'
        OR nombre_condicion LIKE '%' + @TextoBusqueda + '%'
        OR procedencia LIKE '%' + @TextoBusqueda + '%'
        OR nombre_distrito LIKE '%' + @TextoBusqueda + '%';
END
GO

/*SEGUNDO PROCEDIMIENTO ESTUDIANTES*/
CREATE OR ALTER PROCEDURE sp_InsertarEstudiante
(
    @IdDistrito INT,
    @Dni CHAR(8),
    @Nombres VARCHAR(100),
    @Apellidos VARCHAR(130),
    @IdGenero INT,
    @FechaNacimiento DATE,
    @Edad INT,
    @Correo1 VARCHAR(150),
    @Correo2 VARCHAR(150) = NULL,
    @Telefono1 VARCHAR(20),
    @Telefono2 VARCHAR(20) = NULL,
    @IdProcedencia INT,
    @IdCondicion INT,
    @IdApoderado INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        IF LEN(@Dni) <> 8
        BEGIN
            SELECT 'DNI inválido' AS Mensaje;
            RETURN;
        END

        IF EXISTS (SELECT 1 FROM estudiante WHERE dni = @Dni)
        BEGIN
            SELECT 'DNI ya registrado' AS Mensaje;
            RETURN;
        END

        IF EXISTS (SELECT 1 FROM estudiante WHERE correo1 = @Correo1)
        BEGIN
            SELECT 'Correo ya registrado' AS Mensaje;
            RETURN;
        END

        IF EXISTS (SELECT 1 FROM estudiante WHERE telefono1 = @Telefono1)
        BEGIN
            SELECT 'Teléfono ya registrado' AS Mensaje;
            RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM distrito WHERE id_distrito = @IdDistrito)
        BEGIN
            SELECT 'El distrito no existe' AS Mensaje;
            RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM genero WHERE id_genero = @IdGenero)
        BEGIN
            SELECT 'El género no existe' AS Mensaje;
            RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM procedencia WHERE id_procedencia = @IdProcedencia)
        BEGIN
            SELECT 'La procedencia no existe' AS Mensaje;
            RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM condicion WHERE id_condicion = @IdCondicion)
        BEGIN
            SELECT 'La condición no existe' AS Mensaje;
            RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM apoderado WHERE id_apoderado = @IdApoderado)
        BEGIN
            SELECT 'El apoderado no existe' AS Mensaje;
            RETURN;
        END

        INSERT INTO estudiante
        (
            id_distrito,
            dni,
            nombres,
            apellidos,
            id_genero,
            fecha_nacimiento,
            edad,
            correo1,
            correo2,
            telefono1,
            telefono2,
            id_procedencia,
            id_condicion,
            estado,
            id_apoderado
        )
        VALUES
        (
            @IdDistrito,
            @Dni,
            @Nombres,
            @Apellidos,
            @IdGenero,
            @FechaNacimiento,
            @Edad,
            @Correo1,
            @Correo2,
            @Telefono1,
            @Telefono2,
            @IdProcedencia,
            @IdCondicion,
            1,
            @IdApoderado
        );

        SELECT 'Estudiante registrado correctamente' AS Mensaje;

    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Mensaje;
    END CATCH
END
GO

/*TERCER PROCEDIMIENTO ESTUDIANTES*/
CREATE OR ALTER PROCEDURE sp_ModificarEstudiante
(
    @IdEstudiante INT,
    @IdDistrito INT,
    @Dni CHAR(8),
    @Nombres VARCHAR(100),
    @Apellidos VARCHAR(130),
    @IdGenero INT,
    @FechaNacimiento DATE,
    @Edad INT,
    @Correo1 VARCHAR(150),
    @Correo2 VARCHAR(150) = NULL,
    @Telefono1 VARCHAR(20),
    @Telefono2 VARCHAR(20) = NULL,
    @IdProcedencia INT,
    @IdCondicion INT,
    @IdApoderado INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        IF NOT EXISTS (SELECT 1 FROM estudiante WHERE id_estudiante = @IdEstudiante)
        BEGIN
            SELECT 'No existe el estudiante' AS Mensaje;
            RETURN;
        END

        IF LEN(@Dni) <> 8
        BEGIN
            SELECT 'DNI inválido' AS Mensaje;
            RETURN;
        END

        IF EXISTS (
            SELECT 1 FROM estudiante 
            WHERE dni = @Dni AND id_estudiante <> @IdEstudiante
        )
        BEGIN
            SELECT 'DNI ya registrado en otro estudiante' AS Mensaje;
            RETURN;
        END

        IF EXISTS (
            SELECT 1 FROM estudiante 
            WHERE correo1 = @Correo1 AND id_estudiante <> @IdEstudiante
        )
        BEGIN
            SELECT 'Correo ya registrado en otro estudiante' AS Mensaje;
            RETURN;
        END

        IF EXISTS (
            SELECT 1 FROM estudiante 
            WHERE telefono1 = @Telefono1 AND id_estudiante <> @IdEstudiante
        )
        BEGIN
            SELECT 'Teléfono ya registrado en otro estudiante' AS Mensaje;
            RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM distrito WHERE id_distrito = @IdDistrito)
        BEGIN
            SELECT 'El distrito no existe' AS Mensaje;
            RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM genero WHERE id_genero = @IdGenero)
        BEGIN
            SELECT 'El género no existe' AS Mensaje;
            RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM procedencia WHERE id_procedencia = @IdProcedencia)
        BEGIN
            SELECT 'La procedencia no existe' AS Mensaje;
            RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM condicion WHERE id_condicion = @IdCondicion)
        BEGIN
            SELECT 'La condición no existe' AS Mensaje;
            RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM apoderado WHERE id_apoderado = @IdApoderado)
        BEGIN
            SELECT 'El apoderado no existe' AS Mensaje;
            RETURN;
        END

        UPDATE estudiante
        SET
            id_distrito = @IdDistrito,
            dni = @Dni,
            nombres = @Nombres,
            apellidos = @Apellidos,
            id_genero = @IdGenero,
            fecha_nacimiento = @FechaNacimiento,
            edad = @Edad,
            correo1 = @Correo1,
            correo2 = @Correo2,
            telefono1 = @Telefono1,
            telefono2 = @Telefono2,
            id_procedencia = @IdProcedencia,
            id_condicion = @IdCondicion,
            id_apoderado = @IdApoderado,
            fecha_registro = fecha_registro
        WHERE id_estudiante = @IdEstudiante;

        SELECT 'Estudiante actualizado correctamente' AS Mensaje;

    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Mensaje;
    END CATCH
END
GO

/*CUARTO PROCEDIMIENTO ESTUDIANTES*/
CREATE OR ALTER PROCEDURE sp_EliminarEstudiante
(
    @IdEstudiante INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        IF NOT EXISTS (SELECT 1 FROM estudiante WHERE id_estudiante = @IdEstudiante)
        BEGIN
            SELECT 'El estudiante no existe' AS Mensaje;
            RETURN;
        END

        UPDATE estudiante
        SET estado = 0
        WHERE id_estudiante = @IdEstudiante;

        SELECT 'Estudiante desactivado correctamente' AS Mensaje;

    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Mensaje;
    END CATCH
END
GO