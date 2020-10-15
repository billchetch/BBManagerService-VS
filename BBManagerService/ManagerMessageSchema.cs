using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBManagerService
{
    public class ManagerMessageSchema : Chetch.Messaging.MessageSchema
    {
        public const String COMMAND_LIST_SERVICES = "list-services";
    }
}
