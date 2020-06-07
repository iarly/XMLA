namespace API.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestType
    {
        DBSCHEMA_CATALOGS,
        /// <summary>
        /// Returns a list of XML for Analysis data sources available on the server or Web Service. 
        /// (For an example of how these may be published, see "XML for Analysis Implementation Walkthrough.")
        /// </summary>
        DISCOVER_DATASOURCES,
        /// <summary>
        /// Returns a list of information and values about the requested properties that are supported by 
        /// the specified data source (provider).
        /// </summary>
        DISCOVER_PROPERTIES,
        /// <summary>
        /// Returns the names, values, and other information of all supported RequestTypes enumeration 
        /// values (including those listed here), and any additional provider-specific enumeration values.
        /// </summary>
        DISCOVER_SCHEMA_ROWSETS,
        /// <summary>
        /// Returns a list of names, data types, and enumeration values of enumerators supported by a 
        /// specific data source’s provider.
        /// </summary>
        DISCOVER_ENUMERATORS,
        /// <summary>
        /// Returns a rowset containing a list of keywords reserved by the provider.
        /// </summary>
        DISCOVER_KEYWORDS,
        /// <summary>
        /// Returns information about literals supported by the data source provider.
        /// </summary>
        DISCOVER_LITERALS,
        /// <summary>
        /// 
        /// </summary>
        MDSCHEMA_CUBES,
        /// <summary>
        /// 
        /// </summary>
        MDSCHEMA_MEASURES,
        /// <summary>
        /// 
        /// </summary>
        MDSCHEMA_DIMENSIONS,
        /// <summary>
        /// 
        /// </summary>
        MDSCHEMA_SETS,
        /// <summary>
        /// 
        /// </summary>
        MDSCHEMA_HIERARCHIES,
        /// <summary>
        /// 
        /// </summary>
        MDSCHEMA_LEVELS,
        /// <summary>
        /// 
        /// </summary>
        MDSCHEMA_KPIS 
    }
}