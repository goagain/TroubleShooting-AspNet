using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TroubleShooting_AspNet.Models
{
    /// <summary>
    /// Data structure of AssistanceRequest
    /// </summary>
    public class AssistanceRequest
    {
        public enum State
        {
            Received = 0,
            Processing = 1,
            Solved = 2,
            Rejected = 3,
        }
        public int ID { get; set; }

        public string Name { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }


        [DataType(DataType.Date)]
        public DateTime date { get; set; }

        [EnumDataType(typeof(State))]
        public State state { get; set; }

    }
}

