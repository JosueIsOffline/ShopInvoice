create database MoonShop3
go

use MoonShop3
go

create table Ventas (
IdVenta  int primary key identity(1,1),
Subtotal decimal(18,2),
Pago decimal(18,2),
Balance decimal(18,2)
)
go

create table ProductoVenta(
IdProdV int primary key identity(1,1),
IdVenta int references Ventas(IdVenta),
NombreProd varchar(50),
Precio decimal(18,2),
Cantidad int,
Total decimal(18,2)
)
go

insert into Ventas(SubTotal, Pago, Balance) values ('30000', '40000', '10000') select @@IDENTITY;

insert into ProductoVenta (IdVenta, NombreProd, Precio, Cantidad, Total) values ('1', 'PS5', '30000', '1', '30000');

select * from ProductoVenta