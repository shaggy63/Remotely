﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Remotely_Shared.Models
{
    public class InviteLink
    {
        [Key]
        public string ID { get; set; } = Guid.NewGuid().ToString();
        public string InvitedUser { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime DateSent { get; set; }
        public virtual Organization Organization { get; set; }
    }
}
