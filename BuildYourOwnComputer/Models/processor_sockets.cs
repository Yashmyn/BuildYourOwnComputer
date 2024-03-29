﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BuildYourOwnComputer.Models;
using System.ComponentModel.DataAnnotations;

namespace BuildYourOwnComputer.Models
{
    public class processor_sockets
    {
        [Key]
        public long processor_socket_id { get; set; }

        public string processor_socket_name { get; set; }

        public virtual ICollection<motherboards> motherboards { get; set; }
        public virtual ICollection<processors> processors { get; set; }
    }
}