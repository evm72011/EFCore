npm install --save mssql


docker exec -it sql-server-db "bash"
ls
/opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P My_super_secret_password
select name from sys.databases;
go

create database efCoreDB;
go

use efCoreDB
go

create table test(id INT, name NVARCHAR(50), email NVARCHAR(50))
go

insert into test values(1, 'Bill Gates', 'bill.gates@microsoft.com')
go

insert into test values(2, 'John Smith', 'john.smith@gmail.com')
go

insert into Users values('admin', 'admin@bitwork.com', '4f365efeb48b53e5ae7243987114528856a39b075b34a88b9946c5069a6cc096')