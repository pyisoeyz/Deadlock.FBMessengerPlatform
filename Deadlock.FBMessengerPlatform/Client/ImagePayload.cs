﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Client
{
    public class ImagePayload : IPayload
    {
        /// <summary>
        /// URL of image
        /// </summary>
        public string url { get; set; }
    }
}
