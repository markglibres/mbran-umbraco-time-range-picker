using System.Runtime.Serialization;

namespace MBran.TimeRangePicker
{
    [DataContract]
    public class TimeRangeDataContract
    {
        [DataMember(Name = "start")]
        public TimeRangeHoursDataContract StartTime { get; set; }
        [DataMember(Name = "end")]
        public TimeRangeHoursDataContract EndTime { get; set; }
    }
}