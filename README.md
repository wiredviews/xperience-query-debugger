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
