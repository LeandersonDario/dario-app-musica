# dario-app-musica
Sistema de repositório de musicas 

##  Conceitos aplicados no projeto

**Diferença entre bibliotecas, framework e Middleware**
 -  Bibliotecas: È um tecnologia para resolver um determinado problema.
   .Ex: React ( depende de outros biblioteas como axios, redux(Gerenciamento de states))   
   
 -  Middleware: È um tecnologoa para alterar a forma como framework funciona.

 -  Framework: Framework é um conjunto de ferramentas (código, bibliotecas) criadas POR desenvolvedores PARA (outros) desenvolvedores criarem aplicações.
  .Ex: Angular que já tem todas os conceitos embutidos dentro dele(Rotas, visualizações, gerenciamentos de states)
 
  Ou seja, é um conjunto de componentes que são usados para facilita a criação de um aplicação
 
  . Os principais beneficios são:
  . Reaproveitamento do código
  . Facilidade para criar teste
  . Extensível

## Padrão MVC

 . Foi criado pela xerox.
 . Um padrão de projeto de software
 . Promove a separação de responsabilidade
 . Facilita o reuso
 . Ganha de produtividade
 . Torna sua aplicação testável

- Model: È o modelo da aplicação que faz parte da lógica de dominio, ou seja, ele vai encapsula e gerenciar os dados da aplicação.

- View: São os componentes responsável pela exibição da interface com usuário, ou seja, é onde vai ficar os dados de visualização da aplicação.

- Controle: È responsável pela interação e o tratamento das requisições que chegar de api ou endereço da web, ele que vai ser responsável pelo conjunto de modelo. Ocrestação de bancos de dados 


## Rotas

**Diferença entre URL, URI e endpoint**
 . Não existe diferença entre os três termos, todos os termos está se referindo a endereço da web.

Rota determina qual é o controle e a action que será responsável por atender o request do usuário

As rotas são configuradas de forma centralizada dentro do startus.cs ou utilizando o atributo "Route"

O atributo route permite que você definir suas rotas no mesmo arquivo aonde está localizado o seu controller

## Repository


Repositórios são pontes entre dados e operações que estão em domínios diferentes. Um caso comum é o mapeamento de um domínio onde os dados são mal tipados, como um banco de dados ou lista do SharePoint, para um domínio onde os objetos são fortemente tipados, como um modelo de entidade de domínio.


**Data Mapper - Responsável por mapear as informações da entidade**
Ex: pasta Mapping com <Nome> + Mapping => NomeMapping 

**Query Object - È responsável por armazenar as query dos objeto**
Ex: <Nome>Repository => NomeRepository

**TDD** -> https://docs.microsoft.com/en-us/previous-versions/aspnet/ff847525(v=vs.100)?redirectedfrom=MSDN

**Modelo de projeto**
https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application


Referencia: 
 .https://docs.microsoft.com/en-us/previous-versions/msp-n-p/ff649690(v=pandp.10)?redirectedfrom=MSDN
 . https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application


## Status code

OS mais utilizados:

**Familias 2xx sucesso** 
 . 200 - OK
 . 201 - Created
 . 204 - No Content 

**Familias 4xx error no cliente**
 . 400 - Bad Request
 . 401 - Unauthorized
 . 403 - Forbidden
 . 404 - Not Found
 . 409 - Conflict

**Familias 5xx Error no servidor**
 . 500 - Internal Server Error
 . 502 - Bad Gateway
 . 503 - Service Unavailable

**Outros Status code existente**
Familias 1xx informativo

Familias 3xx Redirecionamentos



## Propriedade
Set: Pode setar qualquer valor  em qualquer parte do código
Readonly: - Só consegue seta valor no construtor da class
init: Só é setado uma vez o valor da propriedade em qualquer parte do código



## Pacotes Nu-Get utilizados

Microsoft.EntityFrameworkCore 
Microsoft.EntityFrameworkCore.Design 
Microsoft.EntityFrameworkCore.Relational 
Microsoft.EntityFrameworkCore.Sqlite

## AutoMapper

Comando do Migrations
dotnet ef migrations add InitialCreate
dotnet ef database add createuserAnduserFavorite
dotnet ef database update --verbose
