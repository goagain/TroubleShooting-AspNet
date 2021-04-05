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

        public int Stars { get; set; }
        public string Comment { get; set; }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Postcode { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

    }
}