Codigo desenvolvido com base no Code First, organização de pastas seguindo boas práticas de DDD, CQRS e Repository pattern.

IDE Visual Studio 2019 Version 16.11.11
SQL Server express 2019
Postman 9.15.2

Linguagem C# Netcore com Entity Framework.

Ao tentar gerar o Migration estava causando um erro resolvido atraves dos comandos abaixo

```
dotnet new tool-manifest
dotnet tool install dotnet-ef
```