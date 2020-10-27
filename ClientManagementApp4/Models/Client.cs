using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientManagementApp4.Models
{
    public class Client

    {
        public int ClientId { get; set; }
        public Rating ClientRating { get; set; }
        public string ClientName { get; set; }
    }
}