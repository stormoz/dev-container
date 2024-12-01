# My API

## TODO:
- lock versions of tools e.g. ef cli

## Prerequisites
> NB: this application is configured to run using Dev Container Docker environment. All application specific dependencies (e.g. .NET SDK) is automatically installed inside the Docker container

- Install VS Code
- Install Docker for Desktop
- Install "Dev Containers" extension by Microsoft
- In command pallet of VS Code run "Dev Containers: Open Folder in Container" (NB: it may take some time to finish, please be patient)
- Once open add username and email to the container environment's Git
  - `git config --global user.email "<you@example.com>"`
  - `git config --global user.name "<Your Name>"`
- Authenticate to project via Git

## Fix C# syntax highlighting in VS Code
- Run `dotnet restore` to restore packages for all projects
- In command pallet of VS Code run ".NET: Restart language server"

## Start app
- In VS Code run or debug "Start API" launch configuration

> NB: the configuration will restore packages, build project, start the server and launch the Swagger page

## Connect to DB
- The SQL Server is available via the forwarded port 1433

> NB: you can use any MS SQL client to connect to the DB - DBeaver is recommended on Mac, MS SQL Server Management Studio is recommended on Windows

## Troubleshooting

...
