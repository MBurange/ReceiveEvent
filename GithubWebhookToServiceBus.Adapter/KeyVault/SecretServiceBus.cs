using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubWebhookToServiceBus.Adapter.KeyVault
{
    public class SecretServiceBus
    {
        string KeyVaultUri = "";
        public string GetServicebusConnectionString()
        {

            var KeyVaultSecret = new SecretClient(new Uri(KeyVaultUri), new DefaultAzureCredential());
            var ConnectionString = KeyVaultSecret.GetSecret("");
            return ConnectionString.Value.Value;

        }

        public string GetTopicName()
        {
            var KeyVaultSecret = new SecretClient(new Uri(KeyVaultUri), new DefaultAzureCredential());
            var TopicName = KeyVaultSecret.GetSecret("");
            return TopicName.Value.Value;
        }

        public string GetSubscriptionName()
        {
            var KeyVaultSecret = new SecretClient(new Uri(KeyVaultUri), new DefaultAzureCredential());
            var SubscriptionName = KeyVaultSecret.GetSecret("");
            return SubscriptionName.Value.Value;
        }

    }
}
