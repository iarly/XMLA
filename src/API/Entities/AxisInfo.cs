using System.Collections.Generic;
using System.Xml.Serialization;

namespace API.Entities
{
    public class AxisInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("HierarchyInfo", typeof(HierarchyInfo))]
        public List<HierarchyInfo> HierarchyInfoElements { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute("name")]
        public string AxisName { get; set; }
    }
}