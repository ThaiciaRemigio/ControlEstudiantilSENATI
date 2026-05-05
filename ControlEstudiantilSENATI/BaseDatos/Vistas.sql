-- =====================================
-- VISTA ESTUDIANTES
-- =====================================

CREATE OR ALTER VIEW vw_Estudiantes
AS
SELECT
    E.id_estudiante,
    E.dni,
    E.nombres,
    E.apellidos,
    E.fecha_nacimiento,
    E.edad,
    E.correo1,
    E.telefono1,

    G.nombre_genero,
    C.nombre_condicion,
    PR.descripcion AS procedencia,

    D.nombre_distrito,
    P.nombre_provincia,
    DP.nombre_departamento,
    PA.nombre_pais,

    AP.nombres + ' ' + AP.apellidos AS apoderado,

    E.estado

FROM estudiante E

INNER JOIN genero G 
    ON E.id_genero = G.id_genero

INNER JOIN condicion C 
    ON E.id_condicion = C.id_condicion

INNER JOIN procedencia PR 
    ON E.id_procedencia = PR.id_procedencia

INNER JOIN distrito D 
    ON E.id_distrito = D.id_distrito

INNER JOIN provincia P 
    ON D.id_provincia = P.id_provincia

INNER JOIN departamento DP 
    ON P.id_departamento = DP.id_departamento

INNER JOIN pais PA 
    ON DP.id_pais = PA.id_pais

INNER JOIN apoderado AP 
    ON E.id_apoderado = AP.id_apoderado

WHERE E.estado = 1;
GO