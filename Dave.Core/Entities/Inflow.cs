using System;
using System.Collections.Generic;
using System.Text;

namespace Dave.Core.Entities
{
    public enum InflowType
    {
        Email,
        Upload
    }
    public class Inflow
    {
        public int InflowId { get; set; }
        public DateTime ReceivedDate { get; set; }
        public InflowType InflowType { get; set; }
        
    }
}
