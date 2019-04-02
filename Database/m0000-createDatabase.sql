create database Beastbase;
go

use Beastbase;
go

create table dbo.Migrations
(
	id uniqueidentifier primary key default newid(),
	migrationNumber int not null,
	migrationDescription nvarchar(255) not null,
	runDate datetime not null default getdate()
);
go

insert into dbo.Migrations 
(
	migrationNumber,
	migrationDescription
)
VALUES 
	(0, 'Create database and then create migration table');
go