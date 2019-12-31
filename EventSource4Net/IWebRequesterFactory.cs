﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventSource4Net
{
    public interface IWebRequesterFactory
    {
        int Timeout { get; set; }
        IWebRequester Create();
    }
}
