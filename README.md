<img src="https://s.w.org/images/core/emoji/12.0.0-1/svg/1f1fa-1f1f8.svg" height="25px" width="25px" />&nbsp; &nbsp;<img src="https://s.w.org/images/core/emoji/12.0.0-1/svg/1f1e7-1f1f7.svg" height="25px" width="25px" />

# WebApiExample 

This is a small solution to show how to connect a react stand-alone client project to a .Net Core Web Api. I’m using react, but any client project can make a web requisition. 

<img src="https://github.com/andrenm/WebApiExample/blob/master/client_print.png" alt="Application layout" />


**Client**<br />
1. Technologies: <br />
React version 16.13 with hooks / Typescript 3.7.2 / SASS to preprocess the CSS <br />
2. What this project does? <br />
The employees page displays a table with a list of employees from the server, you can filter the 
table results by any field in the table header.

**Back-End**<br />
1. Technologies: <br />
 	C# Web Api with .Net Core 3.102<br />
2. What this project does? <br />
The External project receive all web requisitions and it communicates with the Persistence 
project that connect with the repository.

## Executing the project step-by-step:

**Installing all you need<br />**
- I’m using Visual Studio 2019 community to work with server side (External and Persistence projects): <br />
https://visualstudio.microsoft.com/pt-br/vs/?rr=https%3A%2F%2Fwww.google.com%2F<br />

- You can download version 3.102  of .Net core here:    <br />
https://dotnet.microsoft.com/download/dotnet-core/3.0<br />

- And Visual Studio Code for the client (Webapp project): <br />
https://code.visualstudio.com/Download<br />

- You’ll also need Node.js and npm to execute react and to download all packages with npm instruction: <br />
https://nodejs.org/en/<br />

**Executing server side project<br />**
- Let’s execute the project WebApiExample.External. Click in the name of the project with the right button and select “set as a startup project”. Now click in the play button in the top menu. 

  Once the service is up (see the prompt window that will open), you can access the employees GET api through the url: https://localhost:5001/api/employees/get

- This will return a list of employees in json format.

**Executing client project<br />**
- Before starting the react project, you’ll need to download the project packages. If you are using Visual Studio Code, please confirm that you have packages-lock.json in the WebApiExample.App folder, if you have, just type the command “npm ci” in the terminal, if not, first execute “npm install”, and then “npm ci”. 

   You should now have the packages-lock.json file and a folder called node_modules. This folder contains all our plugins for the front-end, the folder, and its contents should    not be altered manually. And you don’t need to upload it to your repository or when you publish your site.

- Then, start the react project typing “npm start” in the terminal.

## Project Structure <br />
A short explanation of what each section of each project does:
<br /> <br />
**WebApiExample.Webapp:** <br />
api <br />
|
|_Constants  
|&nbsp; &nbsp;|_Https header config for GET/POST/DELETE calls<br />
|&nbsp; &nbsp;|_Define base web api route: https://localhost:5001/api<br />
|_Services <br />
|&nbsp; &nbsp; |_Service methods for GET/POST/DELETE and default methods using fetch <br />
|&nbsp; &nbsp; |_Common CRUD functions <br />
|_Src<br />
&nbsp; &nbsp;|_Components<br />
&nbsp; &nbsp;| &nbsp; &nbsp;|_A folder for each component<br />
&nbsp; &nbsp;| &nbsp; &nbsp;|_Table component used in employees.tsx<br />
&nbsp; &nbsp;|_Pages <br />
&nbsp; &nbsp; &nbsp; &nbsp; |_A folder for each page<br /> 	
&nbsp; &nbsp; &nbsp; &nbsp; |_Employees page tsx and style files<br />
&nbsp; &nbsp; &nbsp; &nbsp; |_Plugins <br /> 
&nbsp; &nbsp; &nbsp; &nbsp; |_SCSS with general class styles
<br /><br />
**WebApiExample.External:**<br />
|
|_Controllers   
|&nbsp; &nbsp; |_Http methods for web requisitions<br />
|_Injection <br />
|&nbsp; &nbsp; |_Dependency injection for service classes <br />
|_Properties <br />
|&nbsp; &nbsp; |_IIS configuration (applicationUrl port when executing External project)<br />
|_Services <br />
|&nbsp; &nbsp; |_Conection with repository layer.<br />
|_Program.cs <br />
|&nbsp; &nbsp; |_First class to be initialized when External application start<br />
|_Startup.cs <br />
&nbsp; &nbsp; |_Initialize cors policy for web requistions<br />
&nbsp; &nbsp; |_Allow specific connection route (localhost:3000)<br />
&nbsp; &nbsp; |_Added controllers to service collection
<br /> <br />
**WebApiExample.Persistence:**<br />
|
|_Injection<br />
|&nbsp; &nbsp; |_Persistence injecton for factory class and model repositories <br />
|_Models <br />
|&nbsp; &nbsp; |_Database models, Entity Framework Core data context <br />
|_Repository  <br />
|&nbsp; &nbsp; |_Database Repository for each model, with linq to sql interactions <br />
|_DbContextSettings <br />
  &nbsp; &nbsp; |_Store database connection string from appsettings. The connection string is used in DbContextFactory


# WebApiExample

Esta solução é um exemplo simples para demonstrar como conectar um projeto client independente feito em React, à uma Web API em .Net Core 3. 
Estou usando React, mas qualquer outra tecnologia pode fazer a chamada a API.
 
**Cliente** <br />
1. Tecnologias: <br />
React.js versão 16.13 com Hooks / Typescript 3.7.2 / SASS para pré-processar o CSS <br />
2. O que este projeto faz? <br />
A página de funcionários exibe uma tabela com uma lista de funcionários da base de dados, você pode filtrar os resultados da tabela por qualquer campo no cabeçalho da tabela.
 
**Back-End** <br />
1. Tecnologias: <br />
              C # Web Api com .Net Core 3.1 0 2 <br />
2. O que este projeto faz? <br />
O projeto Externo recebe todas as requisições da web e se comunica com o
projeto Persistence que se conecta ao repositório.

## Execução do projeto passo-a-passo:

**Instalando tudo que você precisa**<br /> 
- Eu estou usando Visual Studio 2019 community para trabalhar com o código back-end (Projetos External e Perssistence): <br />
https://visualstudio.microsoft.com/pt-br/vs/?rr=https%3A%2F%2Fwww.google.com%2F <br />

- Você pode baixar a versão 3.102 do .Net Core aqui: 
https://dotnet.microsoft.com/download/dotnet-core/3.0 <br />

- Visual Studio Code para o código front-end:<br /> 
https://code.visualstudio.com/download <br /> 

- Você também vai precisar Node.js e npm para executar o código React.js e baixar todos os pacotes: <br />
https://nodejs.org/en/ <br />
 
**A execução do lado do servidor do projeto**<br /> 
- Vamos executar o projeto WebApiExample.External. Clique no nome do projeto com o botão direito e selecione “definir como projeto de inicialização”. Agora clique no botão play no menu superior.
 
Assim que o serviço estiver ativo (veja a janela de prompt que se abre), você pode acessar os funcionários com uma chamada GET api pela url : 
https: // localhost: 5001 / api / workers / get 

- Isso retornará uma lista de funcionários no formato json.

**Execução de projeto client**<br /> 
- Antes de iniciar o projeto React, você vai precisar fazer o download dos pacotes com npm. Se você estiver usando o Visual Studio Code, verifique se você possui o arquivo packages-lock.json na pasta WebApiExample.App , se tiver, basta executar o comando “npm ci” no terminal , caso contrário, execute primeiro “npm install” e, em seguida, “npm ci”.
 
Agora você deve ter o arquivo packages-lock.json e uma pasta chamada node_modules. Esta pasta contém todos os plugins para o projeto client, a pasta e seu conteúdo não devem ser alterados manualmente. Você não precisa fazer o upload dessa pasta para o seu repositório ou quando publicar seu site.
 
- Em seguida, iniciar o projeto reagir digitando “npm start” no terminal 

## Estrutura do projecto <br /> 
Uma breve explicação sobre o que cada seção de cada projeto faz: <br /> <br />

**WebApiExample.Webapp:** <br />
api <br />
|_Constants <br />
| &nbsp;&nbsp;|_Configuração das chamadas Https para GET / POST / <br />
| &nbsp;&nbsp;|_Defini a rota web API: https: // localhost:5001/api 
<br />
|_Serices <br />
|&nbsp;&nbsp;|_Métodos de serviço para chamadas GET / POST / DELETE usando instrução fetch<br />
| &nbsp;&nbsp;|_Funções CRUD comuns <br />
|_Src <br />
&nbsp;&nbsp;|_Components <br />
&nbsp;&nbsp;| &nbsp;&nbsp;|_Uma pasta para cada componente <br />
&nbsp;&nbsp;| &nbsp;&nbsp;|_Componente tabela usada em employees.tsx <br />
&nbsp;&nbsp;|_Pages <br />
&nbsp;&nbsp;&nbsp;&nbsp;|_Uma pasta para cada página 
&nbsp;&nbsp;&nbsp;&nbsp;|_Página Empregados TSX e estilo arquivos <br />
&nbsp;&nbsp;&nbsp;&nbsp;|_Plugins <br />
&nbsp;&nbsp;&nbsp;&nbsp;|_Arquivo SCSS com os estilos
<br /> <br />

**WebApiExample.External:** <br />
|_Controllers   <br />
| &nbsp;&nbsp;|_Métodos HTTP para requisições web <br />
|_Injection <br />
| &nbsp;&nbsp;|_Injeção de dependência para as classes de serviço <br />
|_Properties <br />
| &nbsp;&nbsp;|_Configuração IIS  porta ao executar o projeto externo <br />
|_Services <br />
| &nbsp;&nbsp;|_Conexão com a camada repositório <br />
|_Program.cs <br />
| &nbsp;&nbsp;|_Primeira classe inicializada quando a aplicação externa inicia <br />
|_Startup.cs <br />
&nbsp;&nbsp;|_Inicializa política CORS de segurança para chamadas web  <br />
&nbsp;&nbsp;|_Permitir rota de conexão específica (localhost: 3000) <br />
&nbsp;&nbsp;|_Adicionados controladores à coleção de serviços
<br /> <br /> 

**WebApiExample.Persistence :** <br />

|_Injection <br />
| &nbsp;&nbsp;|_Injeção de dependência para as classes fábrica e repositórios <br />
|_Models <br />
| &nbsp;&nbsp;|_Modelos de banco de dados, contexto de dados Entity Framework Core <br />
|_Repository  <br />
| &nbsp;&nbsp;|_Repositório de dados para cada modelo, com instruções LINQ para chamadas sql  <br />
|_DbContextSettings <br />
  &nbsp;&nbsp;|_Instrução para conexão de banco de dados. A string de conexão é usada em DbContextFactory

