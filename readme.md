Para criar uma nova aula (ex: Aula69), rode no terminal dentro de c:\coisarada\algunsEstudos\:


dotnet new console -n Aula69 -o Aula69 --framework net9.0
cd Aula69
dotnet new sln -n Aula69
dotnet sln Aula69.sln add Aula69.csproj