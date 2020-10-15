using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chetch.Services;
using System.Configuration.Install;
using System.ComponentModel;

namespace BBManagerService
{
    [RunInstaller(true)]
    public class BBManagerServiceInstaller : ServiceInstaller
    {
        public BBManagerServiceInstaller() : base("BBManagerService",
                                    "Bulan Baru Manager Service",
                                    "Service to manage/combine other services")
        {
            //empty
        }
    }
}
