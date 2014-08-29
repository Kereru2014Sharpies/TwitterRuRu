using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwitterRuRu.Models
{
    public class HomeViewModel
    {
        public string UserId { get; set; }
        public List<Tweets> Tweets { get; set; }
        public string Tweet { get; set; }
    }
}