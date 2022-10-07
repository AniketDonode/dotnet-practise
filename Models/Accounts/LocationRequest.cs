using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.Accounts
{
    public class LocationRequest
    {
        public long LatUpdatedLocation{get;set;}
        public long LongUpdatedLocation{get;set;}
        public DateTime TimeOfUpdation{get;set;}  
    }
}