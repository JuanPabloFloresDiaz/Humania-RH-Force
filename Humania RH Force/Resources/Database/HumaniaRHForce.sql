DROP DATABASE if EXISTS HumaniaRHForce;
CREATE DATABASE HumaniaRHForce;
USE HumaniaRHForce;

-- 1 Tabla para los administradores, (se considerara armar una tabla extra, para asignarle permisos a los distintos tipos de administradores que puedan haber en el sistema)
CREATE TABLE administradores(
  id_administrador BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
  nombre_administrador VARCHAR(50) NOT NULL,
  apellido_administrador VARCHAR(50) NOT NULL,
  clave_administrador VARCHAR(100) NOT NULL,
  correo_administrador VARCHAR(50) NOT NULL,
  CONSTRAINT uq_correo_administrador_unico UNIQUE(correo_administrador),
  CONSTRAINT chk_correo_administrador_formato CHECK (correo_administrador REGEXP '^[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,4}$'),
  telefono_administrador VARCHAR(15) NOT NULL,
  dui_administrador VARCHAR(10) NOT NULL,
  CONSTRAINT uq_dui_administrador_unico UNIQUE(dui_administrador),
  fecha_creacion DATETIME DEFAULT NOW(),
  estado_administrador BOOLEAN DEFAULT 1,
  foto_administrador VARCHAR(50) NULL,
  CONSTRAINT chk_url_foto_administrador CHECK (foto_administrador LIKE '%.jpg' OR foto_administrador LIKE '%.png' OR foto_administrador LIKE '%.jpeg' OR foto_administrador LIKE '%.gif')
);

-- 2 Tabla para las distintas areas de trabajo que puedan estar los empleados dentro de la empresa
CREATE TABLE areas_trabajos(
  id_area_trabajo BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
  area_trabajo VARCHAR(50) NOT NULL,
  CONSTRAINT uq_area_trabajo_unico UNIQUE(area_trabajo)
);

-- 3 Tabla para los distintos tipos de empleados que pueda tener la empresa, se relaciona con el area de trabajo, para que el tipo de empleado se relacione directamente con el area en la cual trabaja
CREATE TABLE tipos_empleados(
  id_tipo_empleado BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
  tipo_empleado VARCHAR(50),
  CONSTRAINT uq_tipo_empleado_unico UNIQUE(tipo_empleado),
  id_area_trabajo BIGINT UNSIGNED NOT NULL,
  CONSTRAINT fk_areas_trabajos FOREIGN KEY (id_area_trabajo) REFERENCES areas_trabajos(id_area_trabajo)
);

-- 4 Tabla para definir las secciones dentro de la aplicación, en la cual los empleados tendran permiso de acceder, todo esto dependiendo del tipo de empleado que sea
CREATE TABLE accesos_empleados(
  id_acceso_empleados BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
  id_tipo_empleado BIGINT UNSIGNED NOT NULL,
  CONSTRAINT fk_accesos_del_tipo_de_empleado FOREIGN KEY (id_tipo_empleado) REFERENCES tipos_empleados(id_tipo_empleado)
  -- Aquí se pondran booleanos para definir las distintas secciones de la aplicación, para darles los distintos permisos a los distintos tipos de empleado, ESTA TABLA SE HARA CUANDO LA ESTRUCTURA DE LA BASE ESTE LISTA
);

-- 5 Tabla para asignar nacionalidades y paises
CREATE TABLE paises(
  id_pais BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
  pais VARCHAR(100) NOT NULL,
  nacionalidad VARCHAR(100) NOT NULL,
  imagen_pais VARCHAR(100) NULL,
  CONSTRAINT chk_url_imagen_pais CHECK (imagen_pais LIKE '%.jpg' OR imagen_pais LIKE '%.png' OR imagen_pais LIKE '%.jpeg' OR imagen_pais LIKE '%.gif')
);

-- 6 Tabla para registrar los datos del empleado
CREATE TABLE empleados(
  id_empleado BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY, 
  nombre_empleado VARCHAR(50) NOT NULL, 
  apellido_empleado VARCHAR(50) NOT NULL, 
  clave_empleado VARCHAR(100) NOT NULL, 
  correo_empleado VARCHAR(50) NOT NULL, 
  CONSTRAINT uq_correo_empleado_unico UNIQUE(correo_empleado), 
  CONSTRAINT chk_correo_empleado_formato CHECK (correo_empleado REGEXP '^[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,4}$'), 
  telefono_empleado VARCHAR(15) NOT NULL, 
  dui_empleado VARCHAR(10) NOT NULL, 
  CONSTRAINT uq_dui_empleado_unico UNIQUE(dui_empleado),
  nit_empleado VARCHAR(20) NOT NULL,
  CONSTRAINT uq_nit_empleado_unico UNIQUE(nit_empleado),
  direccion_empleado VARCHAR(200) NOT NULL,
  estado_empleado ENUM('Activo', 'Baja temporal', 'Baja definitiva') DEFAULT 'Activo',
  id_tipo_empleado BIGINT UNSIGNED NOT NULL,
  CONSTRAINT fk_tipo_del_empleado FOREIGN KEY (id_tipo_empleado) REFERENCES tipos_empleados(id_tipo_empleado),
  genero ENUM('Masculino', 'Femenino', 'Otro'),
  estado_civil ENUM('Soltero', 'Casado', 'Divorciado', 'Viudo'),
  fecha_nacimiento_empleado DATE NOT NULL,
  fecha_creacion DATETIME NULL DEFAULT NOW(),
  id_pais BIGINT UNSIGNED NOT NULL,
  CONSTRAINT fk_pais_del_empleado FOREIGN KEY (id_pais) REFERENCES paises(id_pais),
  foto_empleado VARCHAR(50) NULL, 
  CONSTRAINT chk_url_foto_administrador CHECK (foto_empleado LIKE '%.jpg' OR foto_empleado LIKE '%.png' OR foto_empleado LIKE '%.jpeg' OR foto_empleado LIKE '%.gif')
);

-- 7 Tabla de tipos de documentos
CREATE TABLE tipos_documentos (
  id_tipo_documento BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY, 
  nombre_tipo_documento VARCHAR(100) NOT NULL,
  CONSTRAINT uq_nombre_tipo_documento_unico UNIQUE(nombre_tipo_documento)
);

-- 8 Tabla documentos de empleados
CREATE TABLE documentos_empleados(
  id_documento BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY, 
  id_tipo_documento BIGINT UNSIGNED NOT NULL,
  CONSTRAINT fk_id_tipo_documento FOREIGN KEY (id_tipo_documento) REFERENCES tipos_documentos(id_tipo_documento),
  id_empleado BIGINT UNSIGNED NOT NULL, 
  CONSTRAINT fk_documento_del_empleado FOREIGN KEY (id_empleado) REFERENCES empleados(id_empleado),
  nombre_documento_adjunto VARCHAR(200) NULL,
  fecha_registro DATETIME DEFAULT NOW()
);

-- 9 Tabla de formas de pago, para definir como se le pagara al empleado
CREATE TABLE formas_pagos(
  id_forma_pago BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
  tipo_forma_pago VARCHAR(50) NOT NULL,
  CONSTRAINT uq_tipo_forma_pago_unico UNIQUE(tipo_forma_pago)
);

-- 10 Tabla para estipular los contratos de los empleados
CREATE TABLE contratos_empleados(
  id_contrato BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
  fecha_de_firma_contrato DATE NOT NULL,
  nombre_empresa_contrato VARCHAR(200) NOT NULL,
  id_empleado BIGINT UNSIGNED,
  CONSTRAINT fk_contrato_del_empleado FOREIGN KEY (id_empleado) REFERENCES empleados(id_empleado),
  tipo_contrato ENUM('Temporal', 'Indefinido', 'Por proyecto') NOT NULL,
  estado_contrato ENUM('Activo', 'Finalizado') DEFAULT 'Activo',
  fecha_inicial_contrato DATE NULL,
  fecha_final_contrato DATE NULL,
  salario DECIMAL(10,2) NOT NULL,
  clausulas TEXT NULL,
  archivo_contrato VARCHAR(200) NULL,
  CONSTRAINT chk_validacion_de_fechas_del_contrato CHECK(fecha_inicial_contrato < fecha_final_contrato)
);

-- 11 Tabla para asignarle algún descuento del pago de salario a algún empleado, esto por algún tipo de sanción que se le de a este
CREATE TABLE descuentos(
  id_descuento BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
  tipo_descuento VARCHAR(50),
  CONSTRAINT uq_tipo_descuento_unico UNIQUE(tipo_descuento),
  porcentaje_descuento DECIMAL(3,2) NOT NULL
);

-- 12 Tabla para el registro de pagos al empleado
CREATE TABLE registros_pagos(
  id_registro_pago BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
  fecha_pago DATE NOT NULL,
  fecha_vencimiento DATE NOT NULL,
  fecha_registro DATETIME DEFAULT NOW(),
  pago_total DECIMAL(10,2) UNSIGNED NOT NULL,
--  CONSTRAINT chk_validacion_del_pago_total CHECK(pago_total >= 0),
  hora_extra INT(2) UNSIGNED NULL DEFAULT 0,
--  CONSTRAINT chk_validacion_de_horas_extras CHECK(hora_extra >= 0),
  total_bonificacion DECIMAL(10, 2) UNSIGNED NULL DEFAULT 0,
 -- CONSTRAINT chk_validacion_del_bono CHECK(total_bonificacion >= 0),
  total_descuento DECIMAL(10, 2) UNSIGNED NULL DEFAULT 0 ,
--  CONSTRAINT chk_validacion_del_descuento CHECK(total_descuento >= 0),
  total_aguinaldo DECIMAL(10, 2) UNSIGNED NULL DEFAULT 0 ,
 -- CONSTRAINT chk_validacion_del_aguinaldo CHECK(total_aguinaldo >= 0),
  id_contrato BIGINT UNSIGNED NOT NULL,
  CONSTRAINT fk_contrato_del_registro_de_pago FOREIGN KEY (id_contrato) REFERENCES contratos_empleados(id_contrato),
  id_forma_pago BIGINT UNSIGNED NOT NULL,
  CONSTRAINT fk_forma_pago_del_registro_de_pago FOREIGN KEY (id_forma_pago) REFERENCES formas_pagos(id_forma_pago),
  id_descuento BIGINT UNSIGNED NOT NULL, 
  CONSTRAINT fk_descuento_de_registro_de_pago FOREIGN KEY (id_descuento) REFERENCES descuentos(id_descuento)
);

-- 13 Tabla para el horario de trabajo del empleado
CREATE TABLE horarios(
  id_horario BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
  turno ENUM('Diurno', 'Vespertino', 'Nocturno'),
  lugar VARCHAR(200) NOT NULL,
  hora_inicial TIME NOT NULL, 
  hora_final TIME NOT NULL, 
  CONSTRAINT chk_validacion_de_horas CHECK(hora_inicial < hora_final), 
  dia ENUM('Lunes', 'Martes', 'Miércoles', 'Jueves', 'Viernes', 'Sábado', 'Domingo') NOT NULL, 
  id_empleado BIGINT UNSIGNED,
  CONSTRAINT fk_horario_del_empleado FOREIGN KEY (id_empleado) REFERENCES empleados(id_empleado)
);

-- 14 Tabla para las solicitudes de adelantos salariales
CREATE TABLE adelantos_salariales(
  id_adelanto BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY, 
  fecha_solicitada DATE NOT NULL,
  hora_solicitada TIME NOT NULL,
  fecha_registro DATETIME DEFAULT NOW(),
  id_forma_pago BIGINT UNSIGNED NOT NULL,
  CONSTRAINT fk_forma_pago_del_adelanto_salarial FOREIGN KEY (id_forma_pago) REFERENCES formas_pagos(id_forma_pago),
  id_empleado BIGINT UNSIGNED,
  CONSTRAINT fk_adelanto_salarial_del_empleado FOREIGN KEY (id_empleado) REFERENCES empleados(id_empleado),
  justificacion VARCHAR(5000),
  archivo_adjunto VARCHAR(200),
  Estatus ENUM('Pendiente', 'Aceptado', 'Rechazado') NULL DEFAULT 'Pendiente'
);

-- 15 Tabla para clasificar los distintos tipos de permiso que los empleados puedan solicitar
CREATE TABLE clasificaciones_permisos(
  id_clasificacion_permiso BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
  clasificacion_permiso VARCHAR(80),
  CONSTRAINT uq_clasificacion_permiso_unico UNIQUE(clasificacion_permiso),
  estado_clasificacion BOOLEAN NULL DEFAULT 1
);

-- 16 Tabla para los tipos de permiso solicitados por los empleados
CREATE TABLE tipos_permisos(
  id_tipo_permiso BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
  tipo_permiso VARCHAR(60) NOT NULL,
  CONSTRAINT uq_tipo_permiso_unico UNIQUE(tipo_permiso),
  estado_tipo_permiso BOOLEAN NULL DEFAULT 1,
  id_clasificacion_permiso BIGINT UNSIGNED,
  CONSTRAINT fk_clasificacion_del_tipo_de_permiso FOREIGN KEY (id_clasificacion_permiso) REFERENCES clasificaciones_permisos(id_clasificacion_permiso)
);

-- 17 Tabla para los permisos solicitados por los empleados
CREATE TABLE permisos(
  id_permiso BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
  fecha_inicio DATE NOT NULL,
  fecha_final DATE NOT NULL,
  fecha_solicitada DATETIME NULL DEFAULT NOW(),
  id_empleado BIGINT UNSIGNED,
  CONSTRAINT fk_permiso_del_empleado FOREIGN KEY (id_empleado) REFERENCES empleados(id_empleado),
  id_tipo_permiso BIGINT UNSIGNED,
  CONSTRAINT fk_tipo_permiso_solicitado_por_el_empleado FOREIGN KEY (id_tipo_permiso) REFERENCES tipos_permisos(id_tipo_permiso),
  justificacion VARCHAR(5000),
  Estatus ENUM('Pendiente', 'Aceptado', 'Rechazado') NULL DEFAULT 'Pendiente'
);

-- 18 Tabla para las distintas funciones a realizar por los empleados
CREATE TABLE funciones(
  id_funcion BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
  funcion VARCHAR(200) NOT NULL,
  CONSTRAINT uq_funcion_unico UNIQUE(funcion)
);

-- 19 Tabla para las tareas de los empleados
CREATE TABLE tareas(
  id_tarea BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
  tarea VARCHAR(50) NOT NULL,
  CONSTRAINT uq_tarea_unico UNIQUE(tarea),
  descripcion_tarea TEXT NOT NULL,
  fecha_tarea DATE NOT NULL,
  hora_inicial_tarea TIME NOT NULL,
  hora_finalizacion_tarea TIME NOT NULL
);

-- 20 Tabla para las sub tareas de los empleados
CREATE TABLE sub_tareas(
  id_sub_tarea BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
  sub_tarea VARCHAR(50),
  CONSTRAINT uq_sub_tarea_unico UNIQUE(sub_tarea),
  descripcion_sub_tarea TEXT NOT NULL,
  id_tarea BIGINT UNSIGNED,
  CONSTRAINT fk_sub_tarea_tarea FOREIGN KEY (id_tarea) REFERENCES tareas(id_tarea)
);

-- 21 Tabla para las asistencias de los empleados
CREATE TABLE asistencias(
  id_asistencia BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY, 
  id_empleado BIGINT UNSIGNED NOT NULL, 
  CONSTRAINT fk_empleado_asistencia FOREIGN KEY (id_empleado) REFERENCES empleados(id_empleado), 
  id_horario BIGINT UNSIGNED NOT NULL, 
  CONSTRAINT fk_horario_asistencia FOREIGN KEY (id_horario) REFERENCES horarios(id_horario), 
  fecha_asistencia DATETIME NULL DEFAULT NOW(),
  hora_entrada TIME NULL,
  hora_salida TIME NULL,
  estado_asistencia ENUM('Presente', 'Ausente', 'Tarde', 'Justificado') NULL DEFAULT 'Presente', 
  observacion_asistencia VARCHAR(2000) NULL,
  INDEX (id_empleado),
  INDEX (id_horario)
);

-- 22 Tabla para el control de descansos de los empleados
CREATE TABLE descansos(
  id_descanso BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY, 
  tipo_descanso VARCHAR(70) NOT NULL,
  hora_inicial TIME NOT NULL,
  hora_final TIME NOT NULL,
  id_horario BIGINT UNSIGNED NOT NULL, 
  CONSTRAINT fk_descansos_horario FOREIGN KEY (id_horario) REFERENCES horarios(id_horario)
);

-- 23 Tabla para los trabajos asignados para los empleados
CREATE TABLE trabajos_empleados(
  id_trabajos BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
  id_empleado BIGINT UNSIGNED NOT NULL, 
  CONSTRAINT fk_trabajo_empleado FOREIGN KEY (id_empleado) REFERENCES empleados(id_empleado), 
  id_sub_tarea BIGINT UNSIGNED NOT NULL, 
  CONSTRAINT fk_sub_tarea_empleado FOREIGN KEY (id_sub_tarea) REFERENCES sub_tareas(id_sub_tarea),
  id_funcion BIGINT UNSIGNED NOT NULL, 
  CONSTRAINT fk_funcion_empleado FOREIGN KEY (id_funcion) REFERENCES funciones(id_funcion)
);

-- 24 Tabla para el tipo de cumplimiento que se le evalua al empleado
CREATE TABLE tipos_cumplimientos(
  id_tipo_cumplimiento BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
  tipo_cumplimiento VARCHAR(60) NOT NULL,
  CONSTRAINT uq_tipo_cumplimiento_unico UNIQUE(tipo_cumplimiento)
);

-- 25 Tabla para calificar el cumplimiento del empleado
CREATE TABLE cumplimientos_empleados(
  id_cumplimiento BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
  id_tipo_cumplimiento BIGINT UNSIGNED,
  CONSTRAINT fk_id_tipo_cumplimiento_empleado FOREIGN KEY (id_tipo_cumplimiento) REFERENCES tipos_cumplimientos(id_tipo_cumplimiento),
  calificacion DECIMAL(3,2) NOT NULL,
  id_empleado BIGINT UNSIGNED,
  CONSTRAINT fk_cumplimiento_empleado FOREIGN KEY (id_empleado) REFERENCES empleados(id_empleado)
);

-- 26 Tabla para el tipo de cumplimiento que se le evalua al empleado
CREATE TABLE reconocimientos(
  id_reconocimiento BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
  reconocimiento VARCHAR(60) NOT NULL,
  descripcion_tipo_reconocimiento TEXT NOT NULL,
  CONSTRAINT uq_reconocimiento_unico UNIQUE(reconocimiento)
);

-- 27 Tabla para el historial de reconocimientos de los empleados
CREATE TABLE historiales_reconocimientos(
  id_reconocimientos BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
  id_reconocimiento BIGINT UNSIGNED,
  CONSTRAINT fk_reconocimiento_empleado FOREIGN KEY (id_reconocimiento) REFERENCES reconocimientos(id_reconocimiento),
  fecha_reconocimiento DATE NOT NULL,
  id_empleado BIGINT UNSIGNED,
  CONSTRAINT fk_empleado_reconocimiento FOREIGN KEY (id_empleado) REFERENCES empleados(id_empleado)
);

-- 28 Tabla para los tipos de sanciones
CREATE TABLE tipos_sanciones(
  id_tipo_sancion BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
  tipo_sancion VARCHAR(200) NOT NULL,
  CONSTRAINT uq_tipo_sancion_unico UNIQUE(tipo_sancion),
  gravedad_sancion ENUM('Muy grave', 'Grave', 'Leve', 'Muy leve') NOT NULL
);

-- 29 Tabla para asignarles sanciones a los empleados
CREATE TABLE sanciones(
  id_sancion BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
  id_tipo_sancion BIGINT UNSIGNED,
  CONSTRAINT fk_tipo_sancion FOREIGN KEY (id_tipo_sancion) REFERENCES tipos_sanciones(id_tipo_sancion),
  id_empleado BIGINT UNSIGNED,
  CONSTRAINT fk_empleado_sancionado FOREIGN KEY (id_empleado) REFERENCES empleados(id_empleado),
  fecha_sancion DATE NOT NULL,
  motivo_sancion VARCHAR(3000) NOT NULL
);

-- 30 Tabla para las vacaciones a los empleados
CREATE TABLE vacaciones (
    id_vacacion BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    id_empleado BIGINT UNSIGNED NOT NULL,
    CONSTRAINT fk_empleado_vacaciones FOREIGN KEY (id_empleado) REFERENCES empleados(id_empleado),
    fecha_inicio DATE NOT NULL,
    fecha_fin DATE NOT NULL,
    dias_disponibles INT UNSIGNED NOT NULL,
    tipo_vacacion ENUM('Anual', 'Licencia', 'Maternidad', 'Paternidad', 'Enfermedad'),
    observacion VARCHAR(500)
);

CREATE INDEX idx_empleado_correo ON empleados(correo_empleado);
CREATE INDEX idx_registros_pago_fecha ON registros_pagos(fecha_pago);
CREATE INDEX idx_vacaciones_tipo ON vacaciones(tipo_vacacion);
