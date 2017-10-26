using System.Runtime.Serialization;

namespace MBran.TimeRangePicker
{
    [DataContract]
    public class TimeRangeHoursDataContract
    {
        [DataMember(Name = "hour")]
        public int Hour { get; set; }
        [DataMember(Name = "minute")]
        public int Minute { get; set; }
        [DataMember(Name = "meridian")]
        public string Meridian { get; set; }
    }
}