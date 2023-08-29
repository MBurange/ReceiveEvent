using GithubWebhookToServiceBus.Adapter.Contract;
using GithubWebhookToServiceBus.BLL.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace GithubWebhookToServiceBus.BLL.Services
{
    
        public class ServiceBusService : IServiceBusService
        {
            private readonly IRepositories _repository;
            public ServiceBusService(IRepositories repositories)
            {
                _repository = repositories;
            }


            public async Task<string> ReceiveFromServiceBus()
            {
                try
                {

                    return await _repository.Receivefromtopic();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return null;
                }

            }
        }
    
}
