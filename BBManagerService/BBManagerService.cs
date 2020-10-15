using System;
using System.Collections.Generic;
using System.Timers;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chetch.Services;
using System.Diagnostics;
using Chetch.Messaging;
using System.Globalization;

namespace BBManagerService
{
    class BBManagerService : TCPMessagingClient
    {
        
        public BBManagerService() : base("BBManager", "BBManagerClient", "BBManagerService", "BBManagerServiceLog")
        {
            try
            {
                
            }
            catch (Exception e)
            {
                Tracing?.TraceEvent(TraceEventType.Error, 0, e.Message);
                throw e;
            }
        }

        protected override void OnStart(string[] args)
        {
            base.OnStart(args);

            try
            {

            }
            catch (Exception e)
            {
                Tracing?.TraceEvent(TraceEventType.Error, 0, e.Message);
                throw e;
            }
        }

        protected override void OnStop()
        {
            base.OnStop();
            
        }

        public override void AddCommandHelp()
        {
            base.AddCommandHelp();


        }

        public override void HandleClientError(Connection cnn, Exception e)
        {
            Tracing?.TraceEvent(TraceEventType.Error, 0, e.Message);
        }

        public override bool HandleCommand(Connection cnn, Message message, string command, List<object> args, Message response)
        {
            switch (command)
            {
                case "status":
                    break;
                    
            }

            return true;
        }
        
    }
}
