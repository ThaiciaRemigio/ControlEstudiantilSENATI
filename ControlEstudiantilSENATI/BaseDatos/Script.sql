-- =========================
-- TABLA: pais
-- =========================
CREATE TABLE pais (
    id_pais INT IDENTITY(1,1),
    nombre_pais VARCHAR(100) NOT NULL,

    CONSTRAINT PK_pais PRIMARY KEY (id_pais),
    CONSTRAINT UQ_pais_nombre UNIQUE (nombre_pais)
);
GO

-- =========================
-- TABLA: departamento
-- =========================
CREATE TABLE departamento (
    id_departamento INT IDENTITY(1,1),
    nombre_departamento VARCHAR(120) NOT NULL,
    id_pais INT NOT NULL,

    CONSTRAINT PK_departamento PRIMARY KEY (id_departamento),

    CONSTRAINT FK_departamento_pais
        FOREIGN KEY (id_pais) REFERENCES pais(id_pais)
);
GO

CREATE INDEX IX_departamento_pais ON departamento(id_pais);
GO

-- =========================
-- TABLA: provincia
-- =========================
CREATE TABLE provincia (
    id_provincia INT IDENTITY(1,1),
    nombre_provincia VARCHAR(120) NOT NULL,
    id_departamento INT NOT NULL,

    CONSTRAINT PK_provincia PRIMARY KEY (id_provincia),

    CONSTRAINT FK_provincia_departamento
        FOREIGN KEY (id_departamento) REFERENCES departamento(id_departamento)
);
GO

CREATE INDEX IX_provincia_departamento ON provincia(id_departamento);
GO

-- =========================
-- TABLA: distrito
-- =========================
CREATE TABLE distrito (
    id_distrito INT IDENTITY(1,1),
    nombre_distrito VARCHAR(120) NOT NULL,
    id_provincia INT NOT NULL,

    CONSTRAINT PK_distrito PRIMARY KEY (id_distrito),

    CONSTRAINT FK_distrito_provincia
        FOREIGN KEY (id_provincia) REFERENCES provincia(id_provincia)
);
GO

CREATE INDEX IX_distrito_provincia ON distrito(id_provincia);
GO

-- =========================
-- TABLA: genero
-- =========================
CREATE TABLE genero (
    id_genero INT IDENTITY(1,1),
    nombre_genero VARCHAR(10) NOT NULL,

    CONSTRAINT PK_genero PRIMARY KEY (id_genero),
    CONSTRAINT UQ_genero_nombre UNIQUE (nombre_genero)
);
GO

-- =========================
-- TABLA: condicion
-- =========================
CREATE TABLE condicion (
    id_condicion INT IDENTITY(1,1),
    nombre_condicion VARCHAR(100) NOT NULL,

    CONSTRAINT PK_condicion PRIMARY KEY (id_condicion),
    CONSTRAINT UQ_condicion_nombre UNIQUE (nombre_condicion)
);
GO

-- =========================
-- TABLA: procedencia
-- =========================
CREATE TABLE procedencia (
    id_procedencia INT IDENTITY(1,1),
    descripcion VARCHAR(100) NOT NULL,

    CONSTRAINT PK_procedencia PRIMARY KEY (id_procedencia),
    CONSTRAINT UQ_procedencia_descripcion UNIQUE (descripcion)
);
GO

-- =========================
-- TABLA: apoderado
-- =========================
CREATE TABLE apoderado (
    id_apoderado INT IDENTITY(1,1),
    dni CHAR(8) NOT NULL,
    nombres VARCHAR(150) NOT NULL,
    apellidos VARCHAR(200) NOT NULL,
    direccion_actual VARCHAR(255) NOT NULL,
    correo VARCHAR(150) NOT NULL,
    otro_contacto VARCHAR(200) NULL,
    id_genero INT NOT NULL,

    CONSTRAINT PK_apoderado PRIMARY KEY (id_apoderado),
    CONSTRAINT UQ_apoderado_dni UNIQUE (dni),
    CONSTRAINT UQ_apoderado_correo UNIQUE (correo),

    CONSTRAINT CK_apoderado_dni CHECK (LEN(dni) = 8),
    CONSTRAINT CK_apoderado_correo CHECK (correo LIKE '%@%.%'),

    CONSTRAINT FK_apoderado_genero
        FOREIGN KEY (id_genero) REFERENCES genero(id_genero)
);
GO

CREATE INDEX IX_apoderado_genero ON apoderado(id_genero);
GO

-- =========================
-- TABLA: estudiante
-- =========================
CREATE TABLE estudiante (
    id_estudiante INT IDENTITY(1,1),
    id_distrito INT NOT NULL,
    dni CHAR(8) NOT NULL,
    nombres VARCHAR(100) NOT NULL,
    apellidos VARCHAR(130) NOT NULL,
    id_genero INT NOT NULL,
    fecha_nacimiento DATE NOT NULL,
    edad INT NOT NULL,
    correo1 VARCHAR(150) NOT NULL,
    correo2 VARCHAR(150) NULL,
    fecha_registro DATE NOT NULL DEFAULT GETDATE(),
    telefono1 VARCHAR(20) NOT NULL,
    telefono2 VARCHAR(20) NULL,
    id_procedencia INT NOT NULL,
    id_condicion INT NOT NULL,
    estado BIT NOT NULL DEFAULT 1,
    id_apoderado INT NOT NULL,

    CONSTRAINT PK_estudiante PRIMARY KEY (id_estudiante),
    CONSTRAINT UQ_estudiante_dni UNIQUE (dni),
    CONSTRAINT UQ_estudiante_correo1 UNIQUE (correo1),
    CONSTRAINT UQ_estudiante_telefono1 UNIQUE (telefono1),

    CONSTRAINT CK_estudiante_dni CHECK (LEN(dni) = 8),
    CONSTRAINT CK_estudiante_correo1 CHECK (correo1 LIKE '%@%.%'),
    CONSTRAINT CK_estudiante_edad CHECK (edad >= 0),

    CONSTRAINT FK_estudiante_distrito
        FOREIGN KEY (id_distrito) REFERENCES distrito(id_distrito),
    CONSTRAINT FK_estudiante_genero
        FOREIGN KEY (id_genero) REFERENCES genero(id_genero),
    CONSTRAINT FK_estudiante_procedencia
        FOREIGN KEY (id_procedencia) REFERENCES procedencia(id_procedencia),
    CONSTRAINT FK_estudiante_condicion
        FOREIGN KEY (id_condicion) REFERENCES condicion(id_condicion),
    CONSTRAINT FK_estudiante_apoderado
        FOREIGN KEY (id_apoderado) REFERENCES apoderado(id_apoderado)
);
GO

CREATE INDEX IX_estudiante_distrito ON estudiante(id_distrito);
CREATE INDEX IX_estudiante_genero ON estudiante(id_genero);
CREATE INDEX IX_estudiante_procedencia ON estudiante(id_procedencia);
CREATE INDEX IX_estudiante_condicion ON estudiante(id_condicion);
CREATE INDEX IX_estudiante_apoderado ON estudiante(id_apoderado);
GO

-- =========================
-- TABLA: rol
-- =========================
CREATE TABLE rol (
    id_rol INT IDENTITY(1,1),
    nombre_rol VARCHAR(50) NOT NULL,
    descripcion VARCHAR(45) NULL,

    CONSTRAINT PK_rol PRIMARY KEY (id_rol),
    CONSTRAINT UQ_rol_nombre UNIQUE (nombre_rol)
);
GO

-- =========================
-- TABLA: registro_usuario
-- =========================
CREATE TABLE registro_usuario (
    id_usuario INT IDENTITY(1,1),
    correo VARCHAR(150) NOT NULL,
    contrasena_hash VARCHAR(255) NOT NULL,
    estado TINYINT NOT NULL DEFAULT 1,
    fecha_registro DATE NOT NULL DEFAULT GETDATE(),
    fecha_modificacion DATE NULL,

    CONSTRAINT PK_registro_usuario PRIMARY KEY (id_usuario),
    CONSTRAINT UQ_registro_usuario_correo UNIQUE (correo),

    CONSTRAINT CK_registro_usuario_correo CHECK (correo LIKE '%@%.%'),
    CONSTRAINT CK_registro_usuario_estado CHECK (estado IN (0,1))
);
GO

-- =========================
-- TABLA: tipo_pago
-- =========================
CREATE TABLE tipo_pago (
    id_tipo_pago INT IDENTITY(1,1),
    concepto_pago VARCHAR(200) NOT NULL,

    CONSTRAINT PK_tipo_pago PRIMARY KEY (id_tipo_pago),
    CONSTRAINT UQ_tipo_pago_concepto UNIQUE (concepto_pago)
);
GO

-- =========================
-- TABLA: control_pagos
-- =========================
CREATE TABLE control_pagos (
    id_control_pagos INT IDENTITY(1,1),
    id_tipo_pago INT NOT NULL,
    numero_operacion VARCHAR(64) NOT NULL,
    fecha_registro DATE NOT NULL DEFAULT GETDATE(),
    fecha_actualizacion DATE NULL,

    importe INT NOT NULL,
    total INT NOT NULL,

    observaciones VARCHAR(500) NULL,
    id_estudiante INT NOT NULL,

    CONSTRAINT PK_control_pagos PRIMARY KEY (id_control_pagos),
    CONSTRAINT UQ_control_pagos_operacion UNIQUE (numero_operacion),

    CONSTRAINT CK_control_pagos_importe CHECK (importe > 0),
    CONSTRAINT CK_control_pagos_total CHECK (total >= 0),

    CONSTRAINT FK_control_pagos_tipo_pago
        FOREIGN KEY (id_tipo_pago) REFERENCES tipo_pago(id_tipo_pago),

    CONSTRAINT FK_control_pagos_estudiante
        FOREIGN KEY (id_estudiante) REFERENCES estudiante(id_estudiante)
);
GO
-- =========================
-- TABLA: ciclo
-- =========================
CREATE TABLE ciclo (
    id_ciclo INT IDENTITY(1,1),
    nombre_ciclo VARCHAR(80) NOT NULL,

    CONSTRAINT PK_ciclo PRIMARY KEY (id_ciclo),
    CONSTRAINT UQ_ciclo_nombre UNIQUE (nombre_ciclo)
);
GO

-- =========================
-- TABLA: carrera
-- =========================
CREATE TABLE carrera (
    id_carrera INT IDENTITY(1,1),
    nombre_carrera VARCHAR(255) NOT NULL,
    estado TINYINT NOT NULL DEFAULT 1,

    CONSTRAINT PK_carrera PRIMARY KEY (id_carrera),
    CONSTRAINT UQ_carrera_nombre UNIQUE (nombre_carrera),
    CONSTRAINT CK_carrera_estado CHECK (estado IN (0,1))
);
GO

-- =========================
-- TABLA: curso
-- =========================
CREATE TABLE curso (
    id_curso INT IDENTITY(1,1),
    nombre_curso VARCHAR(200) NOT NULL,
    id_carrera INT NOT NULL,
    id_ciclo INT NOT NULL,
    descripcion VARCHAR(255) NULL,
    estado TINYINT NOT NULL DEFAULT 1,

    CONSTRAINT PK_curso PRIMARY KEY (id_curso),

    CONSTRAINT CK_curso_estado CHECK (estado IN (0,1)),

    CONSTRAINT FK_curso_carrera
        FOREIGN KEY (id_carrera) REFERENCES carrera(id_carrera),
    CONSTRAINT FK_curso_ciclo
        FOREIGN KEY (id_ciclo) REFERENCES ciclo(id_ciclo)
);
GO

CREATE INDEX IX_curso_carrera ON curso(id_carrera);
CREATE INDEX IX_curso_ciclo ON curso(id_ciclo);
GO

-- =========================
-- TABLA: semestre
-- =========================
CREATE TABLE semestre (
    id_semestre INT IDENTITY(1,1),
    nombre_semestre VARCHAR(60) NOT NULL,

    CONSTRAINT PK_semestre PRIMARY KEY (id_semestre),
    CONSTRAINT UQ_semestre_nombre UNIQUE (nombre_semestre)
);
GO

-- =========================
-- TABLA: plan_estudios
-- =========================
CREATE TABLE plan_estudios (
    id_plan_estudios INT IDENTITY(1,1),
    nombre_semanas INT NOT NULL,
    horas_tecnologia INT NOT NULL,
    horas_taller INT NOT NULL,
    vae INT NOT NULL,
    observaciones VARCHAR(500) NULL,
    id_curso INT NOT NULL,
    id_semestre INT NOT NULL,

    CONSTRAINT PK_plan_estudios PRIMARY KEY (id_plan_estudios),

    CONSTRAINT CK_plan_estudios_horas CHECK (
        nombre_semanas >= 0 AND
        horas_tecnologia >= 0 AND
        horas_taller >= 0 AND
        vae >= 0
    ),

    CONSTRAINT FK_plan_estudios_curso
        FOREIGN KEY (id_curso) REFERENCES curso(id_curso),
    CONSTRAINT FK_plan_estudios_semestre
        FOREIGN KEY (id_semestre) REFERENCES semestre(id_semestre)
);
GO

CREATE INDEX IX_plan_estudios_curso ON plan_estudios(id_curso);
CREATE INDEX IX_plan_estudios_semestre ON plan_estudios(id_semestre);
GO

-- =========================
-- TABLA: modalidad
-- =========================
CREATE TABLE modalidad (
    id_modalidad INT IDENTITY(1,1),
    nombre_modalidad VARCHAR(180) NOT NULL,

    CONSTRAINT PK_modalidad PRIMARY KEY (id_modalidad),
    CONSTRAINT UQ_modalidad_nombre UNIQUE (nombre_modalidad)
);
GO

-- =========================
-- TABLA: turno
-- =========================
CREATE TABLE turno (
    id_turno INT IDENTITY(1,1),
    descripcion VARCHAR(120) NOT NULL,

    CONSTRAINT PK_turno PRIMARY KEY (id_turno),
    CONSTRAINT UQ_turno_descripcion UNIQUE (descripcion)
);
GO

-- =========================
-- TABLA: matricula
-- =========================
CREATE TABLE matricula (
    id_matricula INT IDENTITY(1,1),
    fecha_matricula DATE NOT NULL DEFAULT GETDATE(),
    id_estudiante INT NOT NULL,
    numero_operacion VARCHAR(32) NOT NULL,
    id_carrera INT NOT NULL,
    id_turno INT NOT NULL,
    id_semestre INT NOT NULL,
    id_ciclo INT NOT NULL,
    id_modalidad INT NOT NULL,
    observaciones VARCHAR(500) NULL,
    otros VARCHAR(500) NULL,
    fecha_actualizacion DATE NULL,
    estado TINYINT NOT NULL DEFAULT 1,

    CONSTRAINT PK_matricula PRIMARY KEY (id_matricula),
    CONSTRAINT UQ_matricula_operacion UNIQUE (numero_operacion),

    CONSTRAINT CK_matricula_estado CHECK (estado IN (0,1)),

    CONSTRAINT FK_matricula_estudiante
        FOREIGN KEY (id_estudiante) REFERENCES estudiante(id_estudiante),
    CONSTRAINT FK_matricula_carrera
        FOREIGN KEY (id_carrera) REFERENCES carrera(id_carrera),
    CONSTRAINT FK_matricula_turno
        FOREIGN KEY (id_turno) REFERENCES turno(id_turno),
    CONSTRAINT FK_matricula_semestre
        FOREIGN KEY (id_semestre) REFERENCES semestre(id_semestre),
    CONSTRAINT FK_matricula_ciclo
        FOREIGN KEY (id_ciclo) REFERENCES ciclo(id_ciclo),
    CONSTRAINT FK_matricula_modalidad
        FOREIGN KEY (id_modalidad) REFERENCES modalidad(id_modalidad)
);
GO

CREATE INDEX IX_matricula_estudiante ON matricula(id_estudiante);
CREATE INDEX IX_matricula_carrera ON matricula(id_carrera);
CREATE INDEX IX_matricula_turno ON matricula(id_turno);
CREATE INDEX IX_matricula_semestre ON matricula(id_semestre);
CREATE INDEX IX_matricula_ciclo ON matricula(id_ciclo);
CREATE INDEX IX_matricula_modalidad ON matricula(id_modalidad);
GO

-- =========================
-- TABLA: pabellon
-- =========================
CREATE TABLE pabellon (
    id_pabellon INT IDENTITY(1,1),
    nombre_pabellon VARCHAR(120) NOT NULL,

    CONSTRAINT PK_pabellon PRIMARY KEY (id_pabellon),
    CONSTRAINT UQ_pabellon_nombre UNIQUE (nombre_pabellon)
);
GO

-- =========================
-- TABLA: aula
-- =========================
CREATE TABLE aula (
    id_aula INT IDENTITY(1,1),
    numero INT NOT NULL,

    CONSTRAINT PK_aula PRIMARY KEY (id_aula),
    CONSTRAINT UQ_aula_numero UNIQUE (numero)
);
GO

-- =========================
-- TABLA: dias
-- =========================
CREATE TABLE dias (
    id_dia INT IDENTITY(1,1),
    nombre_dia VARCHAR(50) NOT NULL,

    CONSTRAINT PK_dias PRIMARY KEY (id_dia),
    CONSTRAINT UQ_dias_nombre UNIQUE (nombre_dia)
);
GO

-- =========================
-- TABLA: horario
-- =========================
CREATE TABLE horario (
    id_horario INT IDENTITY(1,1),
    id_estudiante INT NOT NULL,
    id_dia INT NOT NULL,
    fecha DATE NOT NULL,
    hora_inicio TIME NOT NULL,
    hora_fin TIME NOT NULL,
    id_pabellon INT NOT NULL,
    id_aula INT NOT NULL,

    CONSTRAINT PK_horario PRIMARY KEY (id_horario),

    CONSTRAINT CK_horario_horas CHECK (hora_fin > hora_inicio),

    CONSTRAINT FK_horario_estudiante
        FOREIGN KEY (id_estudiante) REFERENCES estudiante(id_estudiante),
    CONSTRAINT FK_horario_dia
        FOREIGN KEY (id_dia) REFERENCES dias(id_dia),
    CONSTRAINT FK_horario_pabellon
        FOREIGN KEY (id_pabellon) REFERENCES pabellon(id_pabellon),
    CONSTRAINT FK_horario_aula
        FOREIGN KEY (id_aula) REFERENCES aula(id_aula)
);
GO

CREATE INDEX IX_horario_estudiante ON horario(id_estudiante);
CREATE INDEX IX_horario_dia ON horario(id_dia);
CREATE INDEX IX_horario_pabellon ON horario(id_pabellon);
CREATE INDEX IX_horario_aula ON horario(id_aula);
GO