﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Remotely_Shared.Models
{
    public class PSCoreCommandResult
    {
        public string CommandContextID { get; set; }
        public string DeviceID { get; set; }
        public List<string> VerboseOutput { get; set; }
        public List<string> DebugOutput { get; set; }
        public List<string> ErrorOutput { get; set; }
        public string HostOutput { get; set; }
        public List<string> InformationOutput { get; set; }
        public List<string> WarningOutput { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}
