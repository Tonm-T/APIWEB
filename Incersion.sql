insert into Usuario(RolId, Nombre, Apellido, [Login], [Password], Estatus, FechaRegistro) 
values(1, 'Juan', 'P�rez', 'jp', '81ce825ec1ace3ee7cf7e92df2cc9905', 1,�SYSDATETIME());

insert into Rol(Nombre) 
values('Administrador');

select*from Usuario

select * from Rol