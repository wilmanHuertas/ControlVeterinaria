SELECT TOP (1000) [documento]
      ,[nombre]
      ,[telefono]
      ,[contraseña]
      ,[perfil]
      ,[correo]
  FROM [ControlVeterinariaMU].[dbo].[Persona]

CREATE TABLE veterinaria(
    rut int PRIMARY KEY not null,
    nombre_veterinaria VARCHAR(70) not null,
    ciudad VARCHAR(50) null,
    direccion VARCHAR(60) null,
    telefono int null
);

CREATE TABLE veterinario(
    id_veterinario int PRIMARY KEY IDENTITY (1,1) not null,
    doc_veterinario int not null,
    rut_veterinaria int not null,
    num_matri_profesional int not null 
);

CREATE TABLE asistente_veterinaria(
    id_asistente int PRIMARY KEY IDENTITY (1,1) not null,
    doc_asistente int not null,
    rut_veterinaria int not null
);

CREATE TABLE mascota(
    id_mascota int PRIMARY KEY IDENTITY (1,1) not null,
    nombre_mascota VARCHAR(60) not null,
    doc_dueño int not null,
    edad int null,
    tipo VARCHAR(50) not null,
    raza VARCHAR(50) null 
);

CREATE TABLE agenda_citas(
    id_cita int PRIMARY KEY IDENTITY (1,1) not null,
    id_veterinario int not null,
    id_mascota int not null,
    fecha DATE not null,
    hora TIME not null
);

ALTER TABLE veterinario ADD CONSTRAINT FK_veterinario_persona FOREIGN KEY(doc_veterinario) REFERENCES persona(documento);
ALTER TABLE veterinario ADD CONSTRAINT FK_veterinario_veterinaria FOREIGN KEY(rut_veterinaria) REFERENCES veterinaria(rut);
ALTER TABLE asistente_veterinaria ADD CONSTRAINT FK_asistenteveterinaria_persona FOREIGN KEY(doc_asistente) REFERENCES persona(documento);
ALTER TABLE asistente_veterinaria ADD doc_responsable int;
ALTER TABLE asistente_veterinaria ADD nombre_responsable VARCHAR(50);
ALTER TABLE asistente_veterinaria ADD telefono_responsable int;
ALTER TABLE mascota ADD CONSTRAINT FK_mascota_persona FOREIGN KEY(doc_dueño) REFERENCES persona(documento);
ALTER TABLE agenda_citas ADD CONSTRAINT FK_agendaCitas_veterinario FOREIGN KEY(id_veterinario) REFERENCES veterinario(id_veterinario);
ALTER TABLE agenda_citas ADD CONSTRAINT FK_agendaCitas_mascota FOREIGN KEY(id_mascota) REFERENCES mascota(id_mascota);
