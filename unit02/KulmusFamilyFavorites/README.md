# Kulmus Family Favorites

CSE 325 — ASP.NET Core MVC assignment
By Jacquelyn Kulmus

## Video Demonstration

[My application demonstration](https://youtu.be/9al4SQ99U3Y)

## Features

* Create, view, edit, and delete movies
* Search by title and filter by genre
* Filter by release year to show that year or newer
* Movie ratings and input validation
* Personalized application title and movie listing heading
* Three family favorites added to the movie data
* Padding inside form inputs and dropdowns



\## Run Locally



Requires the .NET 10 SDK and Entity Framework Core CLI tools version 10.



From the repository's main folder:



```powershell

cd unit02/KulmusFamilyFavorites

dotnet restore

```



If the Entity Framework CLI tool is not installed:



```powershell

dotnet tool install --global dotnet-ef --version "10.\*"

```



Create or update the SQLite database, then start the application:



```powershell

dotnet ef database update

dotnet watch

```



Open the localhost address printed in the terminal.



The application adds the seven starter movies when it starts.

Local database files are excluded from GitHub.

