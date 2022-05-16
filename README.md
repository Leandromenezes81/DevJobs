# Jornada NET Direto ao Ponto - 'luis_dev'
## Links:
<p>Aula 01 - **https://www.youtube.com/watch?v=RJsgsYifw10**</p>
<p>Aula 02 - **https://www.youtube.com/watch?v=0ioQwcIHU7E**</P>
<p>Aula 03 - **https://www.youtube.com/watch?v=117cZiKY22k**</P>
<p>Aula 04 - **https://www.youtube.com/watch?v=4wobHZpovMg**</P>

## Conexão segura com DataBase

<p>dotnet user-secrets init</p>

## Configuração de StringConnection no Linux

<p>dotnet user-secrets set "ConnectionStrings:DevJobsCs" "Data Source=localhost;Initial Catalog=DevJobsDb;User ID=sa;Password=************"</p>

## Configuração EF Core/ Migrations

<p>dotnet tool install --global dotnet-ef</p>
<p>dotnet ef migrations add InitialMigrations -o Persistence/Migrations</p>
<p>dotnet ef database update</p>
