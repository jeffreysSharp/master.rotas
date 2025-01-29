# CRUD - REST com ASP.NET Core 8 WebAPI

![Modelo da Arquitetura proposta](https://raw.githubusercontent.com/jeffreysSharp/master.rotas/refs/heads/main/_docs/img/fluxo-arquitetura.jpg)

# Instalação
- 1) Clone o projeto: 
https://github.com/jeffreysSharp/master.rotas.git
- 2) Altere a string de conexão no arquivo appsettings.Development.json no projeto Master.Rotas.API  
- 3) Abrir o Package Manager Console > Selecione o Projeto Master.Rotas.Data > Rode o comando Update-Database
- 4) Selecione o Projeto Master.Rotas.API > Rode o comando update-database -Context ApplicationDbContext
- 5) Set Startup Project Master.Rotas.API
- 6) F5
- 7) Na tela do swagger crie uma nova conta
- 8) No SQL abra a tabela AspNetUsers e copie o Id do usuário
- 9) Na Tabela AspNetUserClaims Inserir um UserId, ClaimType = Rota, ClaimValue = Adicionar, Atualizar, Excluir
- 10) No swagger faça o login e copie o JWT gerado


# REST com ASP.NET Core WebAPI
- .NET Core 8
- C# 12.0
- EntityFrameworkCore 
- Swagger
- AutoMapper
- DependencyInjection
- FluentValidation
- Identity
- JWT 

# Ferramentas
- Visual Studio 2022
- SQL Server

# Features
- [x] CRUD - Rotas
- [x] Autenticação
- [x] Autorização
