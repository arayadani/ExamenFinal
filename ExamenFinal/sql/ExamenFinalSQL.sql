create database ExamenFinal

create table Usuarios
(
IdUsuario int identity Primary Key,
	Usuario varchar (50) Unique,
	Clave varchar (30),
	Nombre  varchar (50),
	Apellido varchar (50),

)

	
create table Placa
(

IdPlaca int identity (1,1) PRIMARY KEY,
NumPlaca Varchar(50) UNIQUE,
IdUsuario int,
Monto money default (0)
CONSTRAINT FK_IdUsuario FOREIGN KEY (IdUsuario) REFERENCES Usuarios (IdUsuario)

)






create procedure ConsultarPlaca
as

begin

select * from Placa

end

create procedure IngresarPlaca
@NumPlaca Varchar (70),
@IdUsuario int,
@Monto money 

as
	begin
		insert into Placa (NumPlaca,IdUsuario,Monto) Values (@NumPlaca, @IdUsuario, @Monto)
			end


	exec IngresarPlaca 'aaa222',3,2500

	create procedure BorrarPlacas
@NumPlaca varchar (70)
	as
		begin 
			Delete from Placa where NumPlaca=@NumPlaca
	end


exec BorrarPlacas'abc123'


create procedure ActualizarPlacas
@IdUsuario int,
@NumPlaca varchar(30),
@Monto int

as 
Update Placa set  IdUsuario = @IdUsuario, NumPlaca = @NumPlaca , Monto=@Monto where IdUsuario = @IdUsuario

exec ActualizarPlacas 3,'yy22',5800
select * from Placa
------------------------------------------------------------------------------------------------------------------------




insert into Usuarios (Usuario,Clave,Nombre,Apellido) values ('jholy@uh.com','1111','jholy','araya')


create procedure ConsultarUsuarios
as

begin

select * from Usuarios

end

---para llamarlo---
exec ConsultarUsuarios


----borrar----
create procedure BorrarUsuarios
@Usuario varchar (70)
	as
		begin 
			Delete from Usuarios where Usuario=@Usuario
	end


exec BorrarUsuarios 'dani@uh.com'
exec ConsultarUsuarios


----agregar----
---si quiero update le pongo alter procedure---
     
create procedure IngresarUsuarios
@Usuario Varchar (70),
@Clave Varchar (70) ,
@Nombre Varchar (50),
@Apellido Varchar (50)
as
	begin
		insert into Usuarios (Usuario, Clave, Nombre, Apellido) Values (@Usuario, @Clave, @Nombre,@Apellido)
			end



create procedure ValidarUsu
@Usuario varchar(70), 
@Clave varchar (70)
as 
	begin
		select *from Usuarios where Usuario=@Usuario and Clave=@Clave
		end
	


-----modificar----

create procedure ActualizarUsuarios
@Usuario varchar(50),
@Clave varchar(30),
@Nombre nvarchar(50), 
@Apellido nvarchar(50)
as 
Update Usuarios set  Nombre = @nombre, Apellido = @apellido, Clave=@Clave
where Usuario =	@Usuario
		exec ActualizarUsuarios 'jholy@uh.com', '2022', 'jholita', 'Jimenez'
		Select *from Usuarios



create procedure ValidarUsuario
@Usuario varchar (30),
@clave varchar(30)
as

begin
select * from Usuarios where Usuario=@Usuario and Clave=@Clave
end



exec ValidarUsuario 'dani@uh.com','123'


create procedure Reporte 
@NumPlaca nvarchar(6)
as
select Nombre, Apellido, Placa.Monto, (Placa.Monto * 0.13) as IVA, ((Placa.Monto*0.13)+Placa.Monto) as Total from Usuarios
join Placa
on Usuarios.idUsuario = Placa.idUsuario
where NumPlaca = @numPlaca
exec Reporte 'yy22'


---
