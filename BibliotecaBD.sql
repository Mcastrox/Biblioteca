create table DOCENTE (
docenteid int primary key not null identity,
nombre_docente varchar(50) not null,
apellido_docente varchar(50) not null,
username varchar(100),
pass varchar(20)
)

create table ENCARGADO (
encargadoid int primary key not null identity,
nombre_encargado varchar(50) not null,
apellido_encargado varchar(50) not null,
username varchar(100),
pass varchar(20)
)

create table libro (
idlibro int primary key not null identity,
titulo varchar (100) ,
numero_ejemplares int ,
ISBN int ,
autor varchar(100),
editorial varchar(100),
numero_edicion int ,
pais varchar(20),
idioma varchar(3),
materia varchar(50),
num_paginas int,
descripcion varchar(255),
estado varchar(20)  --para saber si esta prestado o no 

)

create table Prestamo ( 
idprestamo int primary key not null identity,
idlibro int ,
docenteid int,
fecha_prestamo datetime,
fecha_vencimiento datetime,
foreign key (idlibro) references libro(idlibro),
foreign key (docenteid) references docente(docenteid)
)

create table Devolucion (
devolucionid int primary key not null identity,
docenteid int ,
idlibro int, 
fecha_devolucion datetime,

foreign key (idlibro) references libro(idlibro),
foreign key (docenteid) references docente(docenteid)
)