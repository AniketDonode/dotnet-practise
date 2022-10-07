using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.Accounts
{
    public class LocationResponce
    {
        public double LatLastLocation{get;set;}
        public double LongLastLocation{get;set;}
        public double LatUpdatedLocation{get;set;}
        public double LongUpdatedLocation{get;set;}
        public DateTime TimeOfUpdation{get;set;}  
    }
}