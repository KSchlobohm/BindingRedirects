using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SecretServices.Standard
{
    public class SecretService
    {
        public async Task<string> GetSecretForFileServiceAsync(CancellationToken token)
        {
            const string FileStorageAccount = "well-known-key-name";
            var client = new SecretClient(new Uri("https://oih9gyabkdainwfx.vault.azure.net/"), new DefaultAzureCredential());

            var key = await client.GetSecretAsync(FileStorageAccount, cancellationToken: token);

            return key.Value.Value;
        }
    }
}
