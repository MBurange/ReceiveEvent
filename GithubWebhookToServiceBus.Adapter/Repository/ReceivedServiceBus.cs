using Azure.Messaging.ServiceBus;
using GithubWebhookToServiceBus.Adapter.Contract;
using GithubWebhookToServiceBus.Adapter.KeyVault;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace GithubWebhookToServiceBus.Adapter.Repository
{
    public class ReceivedServiceBus : IRepositories
    {
        SecretServiceBus SecretServiceBus = new SecretServiceBus();

        public async Task<string> Receivefromtopic()
        {


            ServiceBusClient serviceBusClient1 = new ServiceBusClient(SecretServiceBus.GetServicebusConnectionString());
            ServiceBusReceiver serviceBusReceiver1 = serviceBusClient1.CreateReceiver(SecretServiceBus.GetTopicName(), SecretServiceBus.GetSubscriptionName(),
            new ServiceBusReceiverOptions() { ReceiveMode = ServiceBusReceiveMode.ReceiveAndDelete });
            IAsyncEnumerable<ServiceBusReceivedMessage> messages = serviceBusReceiver1.ReceiveMessagesAsync();

            return null;


        }

        
    }
}