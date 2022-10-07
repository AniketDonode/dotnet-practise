using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Entities
{
    [Table("Location")]
    public partial class Location
    {
        [Key,ForeignKey("UserId")]
        public int AccountId{get;set;}
        public double LatCreation{get;set;}
        public double LongCreation{get;set;}
        public double LatLastLocation{get;set;}
        public double LongLastLocation{get;set;}
        public double LatUpdatedLocation{get;set;}
        public double LongUpdatedLocation{get;set;}
        public DateTime TimeOfUpdation{get;set;}        

    }
}