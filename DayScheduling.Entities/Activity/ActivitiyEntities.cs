using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayScheduling.Entities.Activity
{
    public class vmActivitiyEntities
    {
        public List<vmPartialActivity> Activities {get;set;}

    }
    public class vmPartialActivity
    {
        public DateTime FinishTime { get; set; }
        public DateTime StartTime { get; set; }
        public string ActivityPlaceName { get; set; }
        public string ActivityPlaceRating { get; set; }
        public string ActivityPlaceCategory { get; set; }
        public string ActivityPrice { get; set; }
    }
}
