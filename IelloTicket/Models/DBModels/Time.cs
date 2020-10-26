using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IelloTicket.Models.DBModels
{
    public class Time
    {
        public int Id { get; set; }
        
        public int? SessionId { get; set; }
        
        public Session Session { get; set; }
    }
}
