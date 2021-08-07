using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eFaturanMVC.Models
{
    public class Email
    {
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Konu { get; set; }
        public string Mesaj { get; set; }
    }

    public class Message
    {
        public bool IsSuccess { get; set; }

        public string message { get; set; }
    }
}