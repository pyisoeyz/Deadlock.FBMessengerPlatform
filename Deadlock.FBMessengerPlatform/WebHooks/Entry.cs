﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.WebHooks
{
    public class Entry
    {
        public string Id { get; set; }

        public string Time { get; set; }

        public List<Messaging> Messaging { get; set; }
    }
}
