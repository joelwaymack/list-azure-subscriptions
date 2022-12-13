# List Azure Subscriptions

This app lists all Azure subscriptions across tenants that a user has access to based on the Azure CLI login.

A new ArmClient and DefaultCredential is needed for each queried tenant based on [this GitHub issue](https://github.com/Azure/azure-sdk-for-net/issues/26553).

## Requirements

* [Azure CLI](https://learn.microsoft.com/en-us/cli/azure/install-azure-cli)
* [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)

## To Run

In a terminal:

1. Login to the Azure CLI.

    ```bash
    az login
    ```

1. Run the app in the same directory as the .csproj file.

    ```bash
    dotnet run
    ```
