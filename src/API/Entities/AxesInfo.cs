using System.Collections.Generic;
using System.Xml.Serialization;

namespace API.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class AxesInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("AxisInfo", typeof(AxisInfo))]
        public List<AxisInfo> AxisInfoElements { get; set; }
    }
}