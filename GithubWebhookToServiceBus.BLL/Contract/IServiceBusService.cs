﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace GithubWebhookToServiceBus.BLL.Contract
{
    public interface IServiceBusService
    {
        public Task<string> ReceiveFromServiceBus();
    }
}
