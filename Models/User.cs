using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TroubleShooting_AspNet.Models
{
    public class User
    {
        public enum UserAccess
        {
            Normal = 0,
            Admin = 1,
            Root = 2,
        }

        public long ID { get; set; }
        
        public string username { get; set; }

        public string hashed_password { get; set; }

        [EnumDataType(typeof(UserAccess))]
        public UserAccess access { get; set; }
    }
}
