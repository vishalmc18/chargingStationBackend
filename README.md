# chargingStationBackend
Prerequisites
Before running the API, ensure you have the following installed on your system:
.NET SDK (8.0 or later): Required to build and run the ASP.NET Core application.
SQL Server LocalDB (or any SQL Server instance): Used by Entity Framework Core to store the application data.
A Code Editor: Visual Studio or VS Code with C# extensions.

Database:
Open appsettings.json (or appsettings.Development.json for development environment).
Verify or update the connection string to match your SQL Server setup.
Configure CORS Policy:
Open Program.cs.
Verify that http://localhost:5173 is explicitly allowed in the CORS configuration.
Apply Database Migrations:
Open your terminal in the root directory of the backend project.
Run the following commands:
      dotnet ef database update
      dotnet run


API Endpoints:
/api/chargingstations
/api/chargingstations/{id}
/api/chargingstations
/api/chargingstations/{id}
