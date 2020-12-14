# Xperience Query Debugger

A demo .NET console application for easy query debugging in Kentico Xperience applications

## Setup

1. Clone the repository and restore the packages

   ```bash
   > git clone https://github.com/wiredviews/xperience-query-debugger
   > cd xperience-query-debugger
   > dotnet restore
   > code .
   ```

1. Update `Xperience.QueryDebugger\appsettings.json` with your connection string

   ```json
   {
     "Logging": {
       "LogLevel": {
         "Default": "Information",
         "Microsoft": "Warning",
         "Microsoft.Hosting.Lifetime": "Information"
       }
     },
     "ConnectionStrings": {
       "CMSConnectionString": "<Connection String>"
     }
   }
   ```

1. Debug and check the Debug window for query text

## References

### Blog Posts

- [Kentico Xperience Xplorations: Quickly Debugging Queries in a Console Application](https://dev.to/seangwright/kentico-xperience-xplorations-quickly-debugging-queries-in-a-console-application-34bn)

### Packages

- [Xperience Query Extensions](https://github.com/wiredviews/xperience-query-extensions)
- [Xperience appsettings.json Registration](https://github.com/wiredviews/xperience-appsettings-json-registration)
