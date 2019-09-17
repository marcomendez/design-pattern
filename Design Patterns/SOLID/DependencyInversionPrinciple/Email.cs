﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversionPrinciple
{
    public class Email : IMessage
    {
        public void SendMessage()
        {
            Console.WriteLine("Message from Email");
        }
    }
}
