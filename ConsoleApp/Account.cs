using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Account
    {
        public int Id { get; set; }

        public DateTime Subscribe { get; set; }

        public DateTime ExpireDate { get; set; }

        public AccountType Type { get; set; }

        public User User { get; set; }
    }
}
