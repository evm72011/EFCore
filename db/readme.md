npm install --save mssql


docker exec -it sql-server-db "bash"
ls
/opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P My_super_secret_password
select name from sys.databases;
go

dotnet ef database drop --force
dotnet ef database update

create database efCoreDB;
go
