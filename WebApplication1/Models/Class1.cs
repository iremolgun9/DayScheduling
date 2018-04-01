using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Class1
    {
        public int id { get; set; }
        public string PlaceName { get; set; }
        public string Cost { get; set; }
        public string Description { get; set; }
        public string StartTime { get; set; }
        public string FinishTime { get; set; }
        public Class1(int id, string name) {
            this.id = id;
            this.PlaceName = name;
        }
    }

}