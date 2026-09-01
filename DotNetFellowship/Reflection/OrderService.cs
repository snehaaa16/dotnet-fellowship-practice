using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public class OrderService
    {
        private ILogger logger;
        public OrderService(ILogger logger)
        {
            this.logger = logger;
        }
        public void CreateOrder()
        {
            logger.Log("Order Created");
        }
    }
}

