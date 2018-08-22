Small demo project to show how to use EF Migratitions/Seeding and also how to make use of the in memory EF provider. This project is more for my own reference than anything else

# Get the bits

There are 2 flavors of EF command line, the .NET core command line and the PowerShell command line interface that can be run from Package Management Console Window

- Download CLI command line tools : https://docs.microsoft.com/dotnet/core/tools/
- EF Core Package Manager Console Tools : Install-Package Microsoft.EntityFrameworkCore.Tools
- Install-Package Microsoft.EntityFrameworkCore.Design
- https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/
- Install-Package Microsoft.EntityFrameworkCore.InMemory (FOR TEST IN MEMORY ONLY)

## Dot Net Command Line examples

**Create Migrations**
- dotnet ef migrations add InitialCreate
- dotnet ef migrations add BlogExtraColumn
- dotnet ef migrations add BlogExtraCreatedByColumn
- dotnet ef migrations script


**Revert Migrations**
- dotnet ef database update BlogExtraColumn (updates DB but not solution, you need to call 'remove' to get rid of it from solution)
- dotnet ef migrations remove


## Package Manager Console

**Create Migrations**
- Add-Migration InitialCreate
- Add-Migration BlogExtraColumn 
- Add-Migration BlogExtraCreatedByColumn 
- update-database –verbose

**Revert Migrations**
- Update-Database BlogExtraColumn
- Remove-Migration (updates DB but not solution, you need to call 'remove' to get rid of it from solution)



# Simple SQL Server demo 
You will need the following packages

- Install-Package Microsoft.EntityFrameworkCore.SqlServer

# Some useful links
- http://www.entityframeworktutorial.net/efcore/entity-framework-core-console-application.aspx
- https://docs.microsoft.com/en-gb/ef/core/miscellaneous/cli/dbcontext-creation
- https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/index
- https://docs.microsoft.com/en-us/ef/efcore-and-ef6/features
- https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/
- https://docs.microsoft.com/en-us/ef/core/miscellaneous/testing/in-memory

