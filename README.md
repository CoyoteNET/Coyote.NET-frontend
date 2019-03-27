# Coyote.NETCore [CoyoteNET Organization](https://github.com/CoyoteNET)

[Coyote.NETCore Backend](https://github.com/dotNETSanta/Coyote.NETCore)

[Coyote Frontend](https://github.com/dotNETSanta/CoyoteFrontend)

This repository contains an implementation of [Coyote forum engine](https://github.com/adam-boduch/coyote) written in the [.NET Core framework](https://en.wikipedia.org/wiki/.NET_Core).

## Getting started

### Prerequisites

Before proper installation and running, ensure you have installed the following software:
* [.NET Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2)

### Installing

#### 1. Database setup

You may setup the database in two ways – as you prefer:

1. Using SQL Express:
	
	1. Download and install [SQL Express](https://www.microsoft.com/pl-pl/sql-server/sql-server-editions-express).
	2. Change the connection string in **appsettings.json** to `Server=.\\SQLExpress;Database=CoyoteNET;Trusted_Connection=Yes;`

2. Using MSSQL Docker image:

	* Get docker
        	- [Docker for Windows](https://docs.docker.com/docker-for-windows/install/)
        	- [Docker for Linux](https://docs.docker.com/install/linux/docker-ce/centos/)
	* Follow this [guide](https://docs.microsoft.com/en-us/sql/linux/quickstart-install-connect-docker?view=sql-server-2017) or just copy/paste and execute these commands:
	
		- Bash:

			```bash
			sudo docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=<YourStrong!Passw0rd>' \
			-p 1433:1433 --name sql1 \
			-d mcr.microsoft.com/mssql/server:2017-latest
			```

		- Powershell:

			```powershell
			docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=<YourStrong!Passw0rd>" `
			-p 1433:1433 --name sql1 `
			-d mcr.microsoft.com/mssql/server:2017-latest
			```

#### 2. Settings update

Change connection string in [appsettings.json](https://github.com/dotNETSanta/Coyote.NETCore/blob/master/Runner/appsettings.json) to:

```string
Server=localhost,1433;Database=CoyoteNET;User Id=sa;Password=<YourStrong!Passw0rd>
```

#### 3. Running

To run the project, go into the folder `Runner` and execute the following command:

```bash
dotnet run
```

## Links

* 💬 Chat (mainly in Polish language): [Slack](https://join.slack.com/t/coyotenetcore/shared_invite/enQtNTg3NDQ5NzA5OTcyLTNlYWU1YmY1Yjg0Yzc2MDFjMzU3NTZkNjIzNDdkODE1NGE5NTQwZDA4Y2UyMWRkOWMyZGJkYmIzZTlkYjA5OWE) (invitation to the this project's `coyotenetcore` workspace)

## Technologies this project is built with

* Web framework: [ASP.NET Core 2.2](https://docs.microsoft.com/pl-pl/aspnet/core/?view=aspnetcore-2.2).
* ORM: [EntityFrameworkCore](https://github.com/aspnet/EntityFrameworkCore).

## Contributors

If you want, you may contribute making [issues](https://github.com/dotNETSanta/Coyote.NETCore/issues) or [pull requests]() to this project.

Thank you to all our [contributors](https://github.com/dotNETSanta/Coyote.NETCore/graphs/contributors)!
