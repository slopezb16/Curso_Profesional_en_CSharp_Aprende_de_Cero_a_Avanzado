create database FormularioDR
use FormularioDR 

create table Usuarios
(
Id int identity (1000,1),
Nombre varchar(50),
Email varchar(50),
Contrasenia varchar(50)
)

select*from Usuarios