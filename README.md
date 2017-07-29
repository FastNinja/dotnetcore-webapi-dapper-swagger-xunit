# Dot Net Core for the win

Example project that Uses latest DotNet Core , Web API, Dapper and Swagger and Build API Docker container

* use DotNet Core to demonstrate that we can build Web API
* added XUnit test project to show that it can be unit tested
* added Swagger - API shall help developers and expose documentation
* added Dapper and Postrges support - to proove that other Databases can be used - not only SQL Server
* Added Docker file - that can Build and Run this Web Api as Linux Container

### Hooray! Now we can run .Net WebAPI inside a Linux and we do not need to pay MS for Operation system or SQL Server!

# How the hell shall I build it locally?

navigate to `./rocket` folder.
- run **`dotnet restore`**
- run **`dotnet build`**
- run **`dotnet run`**

to execut unit tests:
navigate to `./rocket-tests` folder.
- run **`dotnet restore`**
- run **`dotnet build`**
- run **`dotnet test`**

# And how can I run it inside the Docker?

1. Navigate to `./rocket` folder.
1. run **`docker  build -t mission_core .`** this will build docker image. you can see it if you run `docker images` command later.
  this image can be uploaded to the DockerHub or ECR and used in production.
1. run **`docker run -p 5000:5000 mission_core`** . this will start docker image and will connect port 5000.

You can hit API after that either going to: **`localhost:5000/api/Values`**.

### Windows 7 or Docker-Machine users
if you are using Win7 and running inside Docker-Machine
you need to find you docker machine IP address `docker-machine ip`. Then hit `{that ip}:5000/api/Values`
