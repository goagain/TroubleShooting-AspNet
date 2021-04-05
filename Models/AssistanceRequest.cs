using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TroubleShooting_AspNet.Models
{
    public enum AssistanceRequestState
    {
        Received = 0,
        Processing = 1,
        Solved = 2,
        Rejected = 3,
    }
    /// <summary>
    /// Data structure of AssistanceRequest
    /// </summary>
    public class AssistanceRequest
    {
        public int ID { get; set; }

        public string Name { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }


        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [EnumDataType(typeof(AssistanceRequestState))]
        public AssistanceRequestState State { get; set; }

    }
}

