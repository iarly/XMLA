using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;

namespace API.Entities
{
	/// <summary>
	/// 
	/// </summary>
	public class Row
	{
		#region Inner Class

		#region Catalog -DBSCHEMA_CATALOGS-
		/// <summary>
		/// 
		/// </summary>
		public class CatalogRow
		{
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("CATALOG_NAME")]
			public string CatalogName { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("DESCRIPTION")]
			public string Description { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("ROLES")]
			public string Roles { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("DATE_MODIFIED")]
			public string DateModified { get; set; }
		}
		#endregion

		#region Cube -MDSCHEMA_CUBES-
		/// <summary>
		/// 
		/// </summary>
		public class CubeRow
		{
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("CATALOG_NAME")]
			public string CatalogName { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("CUBE_NAME")]
			public string CubeName { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("CUBE_TYPE")]
			public string CubeType { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("LAST_SCHEMA_UPDATE")]
			public string LastSchemaUpdate { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("LAST_DATA_UPDATE")]
			public DateTime LastDataUpdate { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("DESCRIPTION")]
			public string Description { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("IS_DRILLTHROUGH_ENABLED")]
			public string IsDrillThroughEnabled { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("IS_LINKABLE")]
			public string IsLinkable { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("IS_WRITE_ENABLED")]
			public string IsWriteEnabled { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("IS_SQL_ENABLED")]
			public string IsSqlEnabled { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("CUBE_CAPTION")]
			public string CubeCaption { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("BASE_CUBE_NAME")]
			public string BaseCubeName { get; set; }
		}
		#endregion

		#region Measure -MDSCHEMA_MEASURES-
		/// <summary>
		/// 
		/// </summary>
		public class MeasureRow
		{
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("MEASURE_NAME")]
			public string MeasureName { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("MEASURE_UNIQUE_NAME")]
			public string MeasureUniqueName { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("MEASURE_CAPTION")]
			public string MeasureCaption { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("MEASURE_AGGREGATOR")]
			public string MeasureAggregator { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("DATA_TYPE")]
			public string DataType { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("NUMERIC_PRECISION")]
			public string NumericPrecision { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("NUMERIC_SCALE")]
			public string NumericScale { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("MEASURE_UNITS")]
			public string MeasureUnits { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("DESCRIPTION")]
			public string MeasureDescription { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("EXPRESSION")]
			public string Expression { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("MEASURE_IS_VISIBLE")]
			public string MeasureIsVisible { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("LEVELS_LIST")]
			public string LevelList { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("MEASURE_NAME_SQL_COLUMN_NAME")]
			public string MeasureNameSqlColumnName { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("MEASURE_UNQUALIFIED_CAPTION")]
			public string MeasureUnqualifiedCaption { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("MEASUREGROUP_NAME")]
			public string MeasureGroupName { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("MEASURE_DISPLAY_FOLDER")]
			public string MeasureDisplayFolder { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("DEFAULT_FORMAT_STRING")]
			public string DefaultFormatString { get; set; }
		}
		#endregion

		#region Dimension -MDSCHEMA_DIMENSIONS-
		/// <summary>
		/// 
		/// </summary>
		public class DimensionRow
		{
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("CUBE_NAME")]
			public string CubeName { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("DIMENSION_NAME")]
			public string DimensionName { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("DIMENSION_UNIQUE_NAME")]
			public string DimensionUniqueName { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("DIMENSION_CAPTION")]
			public string DimensionCaption { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("DIMENSION_ORDINAL")]
			public string DimensionOrdinal { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("DIMENSION_TYPE", IsNullable = true)]
			public Nullable<Int16> DimensionType { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlIgnore]
			public bool DimensionTypeSpecified
			{
				get { return DimensionType.HasValue; }
				set { return; }
			}
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("DIMENSION_CARDINALITY")]
			public string DimensionCardinality { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("DEFAULT_HIERARCHY")]
			public string DefaultHierarchy { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("DESCRIPTION")]
			public string Description { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("IS_VIRTUAL")]
			public string IsVirtual { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("IS_READWRITE")]
			public string IsReadWrite { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("DIMENSION_UNIQUE_SETTINGS")]
			public string DimensionUniqueSettings { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("DIMENSION_MASTER_UNIQUE_NAME")]
			public string DimensionMasterUniqueName { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("DIMENSION_IS_VISIBLE")]
			public string DimensionIsVisible { get; set; }
		}
		#endregion

		#region Set -MDSCHEMA_SETS-
		/// <summary>
		/// 
		/// </summary>
		public class SetRow
		{
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("CATALOG_NAME")]
			public string CatalogName { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("SCHEMA_NAME")]
			public string SchemaName { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("CUBE_NAME")]
			public string CubeName { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("SET_NAME")]
			public string SetName { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("SCOPE")]
			public int Scope { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("DESCRIPTION")]
			public string Description { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("EXPRESSION")]
			public string Expression { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("DIMENSIONS")]
			public string Dimensions { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("SET_CAPTION")]
			public string SetCaption { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("SET_DISPLAY_FOLDER")]
			public string SetDisplayFolder { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("SET_EVALUATION_CONTEXT")]
			public string SetEvaluationContext { get; set; }
		}
		#endregion

		#region Hierarquia -MDSCHEMA_HIERARCHIES-
		/// <summary>
		/// 
		/// </summary>
		public class HierarchyRow
		{
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("DIMENSION_UNIQUE_NAME")]
			public string DimensionUniqueName { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("HIERARCHY_NAME")]
			public string HierarchyName { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("HIERARCHY_UNIQUE_NAME")]
			public string HierarchyUniqueName { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("HIERARCHY_GUID")]
			public string HierarchyGuid { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("HIERARCHY_CAPTION")]
			public string HierarchyCaption { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("DIMENSION_TYPE")]
			public string DimensionType { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("HIERARCHY_CARDINALITY")]
			public string HierarchyCardinality { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("DEFAULT_MEMBER")]
			public string DefaultMember { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("ALL_MEMBER")]
			public string AllMember { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("DESCRIPTION")]
			public string Description { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("HIERARCHY_ORIGIN")]
			public HierarchyOrigin HierarchyOrigin { get; set; }

		}

		public enum HierarchyOrigin
		{
			UserHierarchy = 1,
			AttributeHierarchy = 2,
			ParentChildHierarchy = 3
		}
		#endregion

		#region Level -MDSCHEMA_LEVELS-
		/// <summary>
		/// 
		/// </summary>
		public class LevelRow
		{
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("DIMENSION_UNIQUE_NAME")]
			public string DimensionUniqueName { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("HIERARCHY_UNIQUE_NAME")]
			public string HierarchyUniqueName { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("LEVEL_NAME")]
			public string LevelName { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("LEVEL_UNIQUE_NAME")]
			public string LevelUniqueName { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("LEVEL_GUID")]
			public string LevelGuid { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("LEVEL_CAPTION")]
			public string LevelCaption { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("LEVEL_NUMBER")]
			public int LevelNumber { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("LEVEL_CARDINALITY")]
			public string LevelCardinality { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("LEVEL_TYPE")]
			public string LevelType { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("DESCRIPTION")]
			public string Description { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("LEVEL_ATTRIBUTE_HIERARCHY_NAME")]
			public string LevelAttributeHierarchyName { get; set; }
		}
		#endregion

		#region Kpi -MDSCHEMA_KPIS-
		/// <summary>
		/// 
		/// </summary>
		public class KpiRow
		{
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("CATALOG_NAME")]
			public string CatalogName { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("CUBE_NAME")]
			public string CubeName { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("MEASUREGROUP_NAME")]
			public string MeasureGroupName { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("KPI_NAME")]
			public string KPIName { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("KPI_CAPTION")]
			public string KPICaption { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("KPI_DESCRIPTION")]
			public string KPIDescription { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("KPI_DISPLAY_FOLDER")]
			public string KPIDisplayFolder { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("KPI_VALUE")]
			public string KPIValue { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("KPI_GOAL")]
			public string KPIGoal { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("KPI_STATUS")]
			public string KPIStatus { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("KPI_TREND")]
			public string KPITrend { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("KPI_STATUS_GRAPHIC")]
			public string KPIStatusGraph { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("KPI_TREND_GRAPHIC")]
			public string KPITrendGraph { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("KPI_WEIGHT")]
			public string KPIWeight { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("KPI_PARENT_KPI_NAME")]
			public string KPIParentKPIName { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("ANNOTATIONS")]
			public string Annotations { get; set; }
			/// <summary>
			/// 
			/// </summary>
			[XmlElement("SCOPE")]
			public string Scope { get; set; }
		}
		#endregion

		#endregion
		/// <summary>
		/// Construtor padrão
		/// </summary>
		public Row()
		{
			RowElements = new List<XmlNode>();
		}
		/// <summary>
		/// 
		/// </summary>
		[XmlAnyElement]
		public List<XmlNode> RowElements { get; set; }
		/// <summary>
		/// 
		/// </summary>
		private static ConcurrentDictionary<PropertyInfo, XmlElementAttribute> _mappers = new ConcurrentDictionary<PropertyInfo, XmlElementAttribute>();
		/// <summary>
		/// 
		/// </summary>
		/// <param name="prop"></param>
		/// <returns></returns>
		private XmlElementAttribute GetXmlAtt(PropertyInfo prop)
		{
			if (!_mappers.ContainsKey(prop))
				_mappers[prop] = Attribute.GetCustomAttribute(prop, typeof(XmlElementAttribute)) as XmlElementAttribute;
			return _mappers[prop];
		}
		/// <summary>
		/// 
		/// </summary>
		private Func<string, Func<XmlNode, bool>> builder = x => y => y.Name.Equals(x, StringComparison.InvariantCultureIgnoreCase);
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="rowT"></typeparam>
		/// <returns></returns>
		public rowT Read<rowT>() where rowT : class, new()
		{
			var rowData = new rowT();
			rowData.GetType().GetProperties().ToList().ForEach(prop =>
			{
				var elementInfo = GetXmlAtt(prop);
				if (elementInfo != null)
				{
					Func<XmlNode, bool> predicate = builder(elementInfo.ElementName);
					var element = this.RowElements.FirstOrDefault(predicate);
					if (element != null)
					{
						if (prop.PropertyType == typeof(Int16?))
						{
							prop.SetValue(rowData, element.InnerText == null ? (Int16?)null : (Int16?)Int16.Parse(element.InnerText), null);
							return;
						}
						object value = null;
						if (prop.PropertyType.IsEnum)
							value = Enum.ToObject(prop.PropertyType, Convert.ToInt32(element.InnerText));
						else
							value = element.InnerText;

						prop.SetValue(rowData, Convert.ChangeType(value, prop.PropertyType), null);
					}
				}
			});
			return rowData;
		}
	}
}