using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.PropertyEditors;

namespace MBran.TimeRangePicker
{

    [PropertyValueType(typeof(TimeRange))]
    [PropertyValueCache(PropertyCacheValue.All, PropertyCacheLevel.Content)]
    public class TimeRangePickerValueConverter : IPropertyValueConverter
    {
        public bool IsConverter(PublishedPropertyType propertyType)
        {
            return propertyType.PropertyEditorAlias == Constants.EDITOR_ALIAS;
        }

        public object ConvertDataToSource(PublishedPropertyType propertyType, object source, bool preview)
        {
            return Convert.ToString(source);
        }

        public object ConvertSourceToObject(PublishedPropertyType propertyType, object source, bool preview)
        {
            TimeRangeDataContract dataStore = new TimeRangeDataContract();

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(dataStore.GetType());
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes((string)source));
            dataStore = serializer.ReadObject(stream) as TimeRangeDataContract;
            stream.Close();

            TimeRange model = new TimeRange();

            model.Start = DateTime.Parse(
                dataStore.StartTime.Hour + ":" +
                dataStore.StartTime.Minute + " " +
                dataStore.StartTime.Meridian);

            model.End = DateTime.Parse(
                dataStore.EndTime.Hour + ":" +
                dataStore.EndTime.Minute + " " +
                dataStore.EndTime.Meridian);

            return model;
        }

        public object ConvertSourceToXPath(PublishedPropertyType propertyType, object source, bool preview)
        {
            return null;
        }


    }
}