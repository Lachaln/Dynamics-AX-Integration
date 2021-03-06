﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationUtility
{
    public partial class ClientConfiguration
    {
        public static ClientConfiguration Default { get { return ClientConfiguration.OneBox; } }

        public static ClientConfiguration OneBox = new ClientConfiguration()
        {
            UriString = "https://usncax1aos.cloud.onebox.dynamics.com/",
            UserName = "tusr1@TAEOfficial.ccsctp.net",
            Password = "PASSWORD",
            ActiveDirectoryResource = "https://usncax1aos.cloud.onebox.dynamics.com",
            ActiveDirectoryTenant = "https://login.windows-ppe.net/TAEOfficial.ccsctp.net",
            ActiveDirectoryClientAppId = "d8a9a121-b463-41f6-a86c-041272bdb340",
        };

        public string UriString { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ActiveDirectoryResource { get; set; }
        public String ActiveDirectoryTenant { get; set; }
        public String ActiveDirectoryClientAppId { get; set; }
    }
}
