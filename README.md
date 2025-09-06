## 🌟 ASP.NET Minimals APIs

![Logo C#](https://learn.microsoft.com/pt-br/training/achievements/get-started-c-sharp-part-1.svg)


### 📃 Sobre o Projeto

API utilizando a técnica de Minimals APIs para o registro de veículos realizado pela plataforma **DIO**.

### ⚙️ Pré-requisitos

- **IDE**: VSCode ou outra de sua preferência (Plugin .Net e C#).
- **GitHub**: Plataforma para armazenar seus códigos desenvolvidos.
- **Dotnet**: Dotnet na versão 7 ou superior instalado.

### 🛠️ Tecnologias Utilizadas

- C#
- .NET
- Minimals APIs

### 🚀 Criar estrutura inicial do projeto: 

    dotnet new web -o minimal-api

#### Iniciar aplicação 

    dotnet run

#### Iniciar aplicação com auto-reload

    dotnet watch run

#### Instalar a ferramenta .Net Entity Framework
    
    dotnet tool install --global dotnet-ef

#### Confirmar instalação checando a versão

    dotnet-ef --version

#### Criar pasta e arquivos de Migrations

    dotnet ef migrations add AdministradorMigration
    dotnet ef migrations add VeiculosMigration


#### Criar banco e tabelas

    dotnet ef database update

### Acessar aplicação

Projeto: [URL da aplicação](http://localhost:5096/swagger/index.html)

#### Criar Seed para cadastrar administrador padrão 
##### Rodar o comando para criar banco e tabelas novamente para aplicar migration Seed

    dotnet ef migrations add SeedAdministrador

### Criar uma solução / Adicionar projetos dentro da solução

    dotnet new sln
    dotnet sln add Api/minimal-api.csproj

### Criar novo projeto de Test usando mstest

    dotnet new --list
    dotnet new mstest -o Test
    dotnet sln add Test/Test.csproj

### Referenciar projeto a pasta Test - acessar pasta Test

    dotnet add reference ../Api/minimal-api.csproj

### Alguns comandos úteis para acessar o container e praticar SQL via terminal

    docker ps --format '{{.Names}}'

    docker exec -it minimal-api_devcontainer-mysql-1 bash

    mysql -u root -p'rootpassword'
    CREATE DATABASE minimal_apitest;
    SHOW DATABASES;
    exit;

    mysql -h mysql -u root -p'rootpassword'
    USE minimal_apitest;
    SHOW TABLES;
    SELECT * FROM Administradores;

    INSERT INTO Administradores (Email, Senha, Perfil)
    VALUES ('joao@teste.com', 'editor', 'Editor');

    UPDATE Administradores
    SET Senha = 'editor'
    WHERE Email = 'joao@teste.com';

    DROP DATABASE minimal_apitest;

### Dump do Banco original na pasta Test e restaurar para o banco minimal_apitest via terminal comum e via workspace do Dev Container

    mysqldump -uroot -p'rootpassword' minimal_api > minimal_api.dump.sql

    mysql -u root -p'rootpassword' minimal_apitest < minimal_api.dump.sql

    mysqldump -h mysql -u root -p'rootpassword' minimal_api > minimal_api.dump.sql

    mysql -h mysql -u root -p'rootpassword' minimal_apitest < minimal_api.dump.sql

### Comandos para Teste

    dotnet test
    dotnet test --filter "Name=TestandoSalvarAdministrador"
    dotnet test --filter "Name=TestandoBuscaPorId"

### 📚 Referências

- [EntityFrameworkCore](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/9.0.7)
- [EntityFrameworkCoreDesign](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Design/9.0.7)
- [EntityFrameworkCoreTools](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools/9.0.7)
- [EntityFrameworkCoreMySql](https://www.nuget.org/packages/Pomelo.EntityFrameworkCore.MySql/9.0.0-preview.3.efcore.9.0.0)
- [Swashbuckle.AspNetCore](https://www.nuget.org/packages/Swashbuckle.AspNetCore)
- [Microsoft.AspNetCore.Authentication.JwtBearer](https://www.nuget.org/packages/Microsoft.AspNetCore.Authentication.JwtBearer/7.0.14)
- [.NetEntityFramework](https://learn.microsoft.com/en-us/ef/core/cli/dotnet)


- [GitignoreIo](https://www.toptal.com/developers/gitignore)
- [Repositório](https://github.com/digitalinnovationone/minimal-api) - Repositório referência DIO
- [Miro](https://miro.com/pt/) - Criar quadros, diagramas, desenhos e outros conteúdos
- [Trello](https://www.trello.com/) - Gerencie seus projetos com quadros estilo Kanban
- [Draw.io](https://www.draw.io/) - Desenvolva mapas mentais e diagramas
- [Planing](https://planningpokeronline.com/) - Auxiliar equipes a estimar o esforço necessário para completar tarefas
- [JWT Debugger](https://www.jwt.io/) - Validar JSON Web Token (JWT) Debugger


---
---

### 👨‍💻 Expert

<p>
<img 
      align="left" 
      style="margin: 10px; width: 80px; border-radius: 50%;" 
      src="https://avatars.githubusercontent.com/u/52001930?s=400&u=fb999c966c5c652a8357cbede4b1112e79cbfe18&v=4" 
/>
    <p style="padding-top:25px">&nbsp&nbsp&nbsp Wagner Andrade<br>
    &nbsp&nbsp&nbsp
    <a href="https://github.com/wsawebmaster">
    GitHub</a>&nbsp;|&nbsp;
    <a href="https://www.linkedin.com/in/
wsawebmaster">LinkedIn</a>
&nbsp;|&nbsp;
<a href="mailto:wsawebmaster@yahoo.com.br">
    Email</a>
  &nbsp;|&nbsp;
</p>
</p>