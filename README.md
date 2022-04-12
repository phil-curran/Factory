# Factory

#### By _**Phil Curran**_

#### An MVC web app that manages relationships between two different datasets.

## Technologies Used

* C#
* .Net 6.0
* MySql 8.0 & MySql Workbench
* Bootstrap
* JetBrains Rider

## Description

An MVC web app that manages relationships between two different datasets.  Create an Engineer profile, a Machine Profile, and manage the relationship between the Machines and the Engineers that service them.

## Setup/Installation Requirements

* Install or Update MySql to version 8.0
* Install or Update .net to 6.0
* Install or Update dotnet-ef to version 6.0
* Download repo: link
* Create an <code>appsettings.json</code> file in your root directory and add the following code:

```json
{
  "ConnectionStrings": {
    "ConnectionString": "server=localhost;user id=[ user id ];password=[ user password ];port=3306;database=phil_curran;"
  }
}
```
* Update the appsettings.json file by replacing the <code>[ user id ]</code> and <code>[ user password ]</code> above with your MySql user id and password.
* Navigate to the root directory of the project
* Create an initial database migration for the project: <code>dotnet ef migrations add InitialCreate --context ApplicationDbContext</code>
* Update the database: <code>dotnet ef database update --context ApplicationDbContext</code>
* Use MySql Workbench to verify that the database table has been created
* Install dependencies: dotnet restore
* Build & check for errors: dotnet build
* Run the project: dotnet watch run

## Known Bugs

* None

## Contact Me

Let me know what you think! pecurran@hotmail.com

## License

_MIT_

Copyright (c) 2022 / Phil Curran
