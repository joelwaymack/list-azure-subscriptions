using Azure.Identity;
using Azure.ResourceManager;

Console.WriteLine("*** List Tenants and Subscriptions ***");

var credential = new DefaultAzureCredential(new DefaultAzureCredentialOptions());
var arm = new ArmClient(credential);

var tenants = arm.GetTenants();
foreach (var tenant in tenants)
{
    try
    {
        var tenantCred = new DefaultAzureCredential(new DefaultAzureCredentialOptions { TenantId = tenant.Data.TenantId.ToString() });
        var tenantArm = new ArmClient(tenantCred);

        Console.WriteLine($"{tenant.Data.DisplayName} - {tenant.Data.TenantId.ToString()}");
        var subscriptions = tenantArm.GetSubscriptions();

        foreach (var subscription in subscriptions)
        {
            Console.WriteLine($"\t{subscription.Data.DisplayName}");
        }
    }
    catch
    {
        Console.WriteLine($"Error retrieving subscriptions for {tenant.Data.DisplayName}");
    }
}
