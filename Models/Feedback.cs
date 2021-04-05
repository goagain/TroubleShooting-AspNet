using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TroubleShooting_AspNet.Models
{
    /// <summary>
    /// Data structure of Feedbacks
    /// </summary>
    public class Feedback
    {
        public int ID { get; set; }

        public int stars { get; set; }
        public string comment { get; set; }

        public string firstName { get; set; }
        
        public string lastName { get; set; }

        public string phoneNumber { get; set; }

        public string postcode { get; set; }

        [DataType(DataType.Date)]
        public DateTime date { get; set; }

    }
}