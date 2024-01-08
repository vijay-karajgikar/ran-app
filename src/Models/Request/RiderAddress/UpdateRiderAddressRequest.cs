using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Request.RiderAddress
{
    public class UpdateRiderAddressRequest
    {
        public string Id { get; set; }
        
        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int Zip { get; set; }

    }
}