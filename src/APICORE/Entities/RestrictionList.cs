using System;
using System.Xml;
using System.Xml.Serialization;

namespace API.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class RestrictionList
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlAnyElement]
        public XmlElement[] Elements { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string CATALOG_NAME { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string CUBE_NAME { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool CUBE_NAMESpecified
        {
            get { return !string.IsNullOrWhiteSpace(CUBE_NAME); }
            set { return; }
        }
        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string DIMENSION_UNIQUE_NAME { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool DIMENSION_UNIQUE_NAMESpecified
        {
            get { return !string.IsNullOrWhiteSpace(DIMENSION_UNIQUE_NAME); }
            set { return; }
        }
        /// <summary>
        /// 
        /// </summary>
        [XmlElement(IsNullable = true)]
        public Nullable<Int16> DIMENSION_VISIBILITY { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool DIMENSION_VISIBILITYSpecified
        {
            get { return DIMENSION_VISIBILITY.HasValue; }
            set { return; }
        }
        /// <summary>
        /// 
        /// </summary>
        [XmlElement(IsNullable = true)]
        public Nullable<Int16> MEASURE_VISIBILITY { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool MEASURE_VISIBILITYSpecified
        {
            get { return MEASURE_VISIBILITY.HasValue; }
            set { return; }
        }
        /// <summary>
        /// 
        /// </summary>
        [XmlElement(IsNullable = true)]
        public Nullable<Int16> CUBE_SOURCE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool CUBE_SOURCESpecified
        {
            get { return CUBE_SOURCE.HasValue; }
            set { return; }
        }
        [XmlElement(IsNullable = true)]
        public Nullable<Int16> HIERARCHY_VISIBILITY { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool HIERARCHY_VISIBILITYSpecified
        {
            get { return HIERARCHY_VISIBILITY.HasValue; }
            set { return; }
        }
        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string HIERARCHY_UNIQUE_NAME { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool HIERARCHY_UNIQUE_NAMESpecified
        {
            get { return !string.IsNullOrWhiteSpace(HIERARCHY_UNIQUE_NAME); }
            set { return; }
        }
        /// <summary>
        /// 
        /// </summary>
        [XmlElement(IsNullable = true)]
        public Nullable<Int16> LEVEL_VISIBILITY { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool LEVEL_VISIBILITYSpecified
        {
            get { return LEVEL_VISIBILITY.HasValue; }
            set { return; }
        }
    }
}