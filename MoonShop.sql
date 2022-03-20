create database MoonShop
go

use MoonShop
go

create table Ventas (
IdVenta  int primary key identity(1,1),
Total decimal(18,2),
Itbis decimal(18,2),
Subtotal decimal(18,2),
Pago decimal(18,2),
Balance decimal(18,2)
)
go

create table ProductoVenta(
IdProdV int primary key identity(1,1),
IdVenta int,
NombreProd varchar(50),
Precio decimal(18,2),
Cantidad int,
Total decimal(18,2)
)
go


insert into Ventas(SubTotal, Pago, Balance) values ('60000', '60000', '0');

insert into ProductoVenta (IdVenta, NombreProd, Precio, Cantidad, Total) values (@@IDENTITY, 'PS5', '30000', '2', '60000');

select * from Ventas
select * from ProductoVenta

