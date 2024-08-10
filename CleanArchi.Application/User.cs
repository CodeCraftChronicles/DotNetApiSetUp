using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchi.Application
{
    public class User
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
    }
}
