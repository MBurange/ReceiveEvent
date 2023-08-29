using System;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;
using Azure.Messaging.ServiceBus;
using GithubWebhookToServiceBus.Adapter.Contract;
using GithubWebhookToServiceBus.BLL.Contract;
using GithubWebhookToServiceBus.BLL.Services;
using Newtonsoft.Json;

   
   public class receiver
  {
    private readonly IServiceBusService serviceBusService;

     
    public receiver(IServiceBusService serviceBusService) 
    {
        this.serviceBusService = serviceBusService;
        this.serviceBusService.ReceiveFromServiceBus();
    }
     

   }

 


    




