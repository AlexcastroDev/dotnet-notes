# Definition

- Class Library

The result is a DLL file that contains the compiled code. This DLL can be referenced by other projects and distributed independently. Class libraries are used to create APIs, reusable components, and other libraries.

- Console Application

The result is an executable file that can be run from the command line. Console applications are used for command-line tools, background services, daemons, and other programs meant to be run from a command prompt.

- Web Application
    - ASP.NET Web
    - ASP.NET MVC
    - ASP.NET WebAPI 

- Test Project
    - Microsoft Test

# CLI

## Create a new project - Class Library

```bash
dotnet new classlib
```

## Create a new project - Web Application

```bash
dotnet new web
```

## Create a new project - Web Application - MVC

```bash
dotnet new mvc
```

## Create a new project - Web Application - WebAPI

```bash
dotnet new webapi
```

## Create a new project - Console

```bash
dotnet new console
```

## Create a new project - Test

```bash
dotnet new mstest
```

We can specify the folder to create the project with the `-o` option:

```bash
dotnet new webapi -o MyProject
```