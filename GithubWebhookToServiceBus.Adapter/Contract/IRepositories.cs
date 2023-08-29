using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubWebhookToServiceBus.Adapter.Contract
{
    public interface IRepositories
    {
        public Task<string> Receivefromtopic();
    }
}
