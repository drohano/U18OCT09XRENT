using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace U18OCT09X1.Models
{
    public class Agreement
    {
        public string Id { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }

        public Car Car { get; set; }

        public UserRecord UserRecord { get; set; }
    }
}