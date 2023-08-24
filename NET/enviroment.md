# Run dotnet in environment

### Run in production environment

```bash
dotnet run --environment=production
```

### Run in development environment

```bash
dotnet run --environment=development
```

### Run in staging environment

```bash
dotnet run --environment=staging
```

### Run in test environment

```bash
dotnet run --environment=test
```

### Notes

The run will not attach a debugger. To attach a debugger, use the following command:

```bash
dotnet run --environment=development --configuration=Debug
```

