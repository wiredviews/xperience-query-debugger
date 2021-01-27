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

### Using in an Xperience Solution / Project

If you want to incorporate this into your Xperience 13.0 project to help debug queries you are working on for your site, you can also use [User Secrets](https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-3.1&tabs=windows), in VS Code or Visual Studio, to store your Connection String and other settings.

This app also supports using an `appsettings.local.json`, which you could ignore from source control if needed.

Whether or not you include this project in source control along with your application code depends on how you want to use it.

If it's a way to share query snippets for your team and be able to quickly test those, then use User Secrets to store the Connection String and commit everything to source control.

If it's a scratchpad to explore ideas but not share with the team, then add the project path to your `.gitignore` and debug in VS Code so you don't run into the limitations in Visual Studio with not having the project in your shared solution files.

## References

### Blog Posts

- [Kentico Xperience Xplorations: Quickly Debugging Queries in a Console Application](https://dev.to/seangwright/kentico-xperience-xplorations-quickly-debugging-queries-in-a-console-application-34bn)

### Packages

- [Xperience Query Extensions](https://github.com/wiredviews/xperience-query-extensions)
- [Xperience appsettings.json Registration](https://github.com/wiredviews/xperience-appsettings-json-registration)
