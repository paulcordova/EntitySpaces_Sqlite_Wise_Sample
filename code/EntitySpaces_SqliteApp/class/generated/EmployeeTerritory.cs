
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2024.3.0001.1
EntitySpaces Driver  : SQLite
Date Generated       : 12-08-2024 17:29:53
===============================================================================
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Linq;
using System.Data;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

using EntitySpaces.Core;
using EntitySpaces.Interfaces;
using EntitySpaces.DynamicQuery;



namespace BusinessObjects
{
	/// <summary>
	/// Encapsulates the 'EmployeeTerritory' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(EmployeeTerritory))]	
	[XmlType("EmployeeTerritory")]
	public partial class EmployeeTerritory : esEmployeeTerritory
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new EmployeeTerritory();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String id)
		{
			var obj = new EmployeeTerritory();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String id, esSqlAccessType sqlAccessType)
		{
			var obj = new EmployeeTerritory();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("EmployeeTerritoryCollection")]
	public partial class EmployeeTerritoryCollection : esEmployeeTerritoryCollection, IEnumerable<EmployeeTerritory>
	{
		public EmployeeTerritory FindByPrimaryKey(System.String id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
				
	}



	[Serializable]	
	public partial class EmployeeTerritoryQuery : esEmployeeTerritoryQuery
	{
		public EmployeeTerritoryQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public EmployeeTerritoryQuery(string joinAlias, out EmployeeTerritoryQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "EmployeeTerritoryQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(EmployeeTerritoryQuery query)
		{
			return EmployeeTerritoryQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator EmployeeTerritoryQuery(string query)
		{
			return (EmployeeTerritoryQuery)EmployeeTerritoryQuery.SerializeHelper.FromXml(query, typeof(EmployeeTerritoryQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esEmployeeTerritory : esEntity
	{
		public esEmployeeTerritory()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.String id)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(id);
			else
				return LoadByPrimaryKeyStoredProcedure(id);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.String id)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(id);
			else
				return LoadByPrimaryKeyStoredProcedure(id);
		}

		private bool LoadByPrimaryKeyDynamic(System.String id)
		{
			EmployeeTerritoryQuery query = new EmployeeTerritoryQuery();
			query.Where(query.Id == id);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String id)
		{
			esParameters parms = new esParameters();
			parms.Add("Id", id);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to EmployeeTerritory.Id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Id
		{
			get
			{
				return base.GetSystemString(EmployeeTerritoryMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeTerritoryMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(EmployeeTerritoryMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to EmployeeTerritory.EmployeeId
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? EmployeeId
		{
			get
			{
				return base.GetSystemInt32(EmployeeTerritoryMetadata.ColumnNames.EmployeeId);
			}
			
			set
			{
				if(base.SetSystemInt32(EmployeeTerritoryMetadata.ColumnNames.EmployeeId, value))
				{
					OnPropertyChanged(EmployeeTerritoryMetadata.PropertyNames.EmployeeId);
				}
			}
		}		
		
		/// <summary>
		/// Maps to EmployeeTerritory.TerritoryId
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String TerritoryId
		{
			get
			{
				return base.GetSystemString(EmployeeTerritoryMetadata.ColumnNames.TerritoryId);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeTerritoryMetadata.ColumnNames.TerritoryId, value))
				{
					OnPropertyChanged(EmployeeTerritoryMetadata.PropertyNames.TerritoryId);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return EmployeeTerritoryMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public EmployeeTerritoryQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new EmployeeTerritoryQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(EmployeeTerritoryQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(EmployeeTerritoryQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private EmployeeTerritoryQuery query;		
	}



	[Serializable]
	abstract public partial class esEmployeeTerritoryCollection : esEntityCollection<EmployeeTerritory>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return EmployeeTerritoryMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "EmployeeTerritoryCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public EmployeeTerritoryQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new EmployeeTerritoryQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(EmployeeTerritoryQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new EmployeeTerritoryQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(EmployeeTerritoryQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((EmployeeTerritoryQuery)query);
		}

		#endregion
		
		private EmployeeTerritoryQuery query;
	}



	[Serializable]
	abstract public partial class esEmployeeTerritoryQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return EmployeeTerritoryMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "EmployeeId": return this.EmployeeId;
				case "TerritoryId": return this.TerritoryId;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, EmployeeTerritoryMetadata.ColumnNames.Id, esSystemType.String); }
		} 
		
		public esQueryItem EmployeeId
		{
			get { return new esQueryItem(this, EmployeeTerritoryMetadata.ColumnNames.EmployeeId, esSystemType.Int32); }
		} 
		
		public esQueryItem TerritoryId
		{
			get { return new esQueryItem(this, EmployeeTerritoryMetadata.ColumnNames.TerritoryId, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class EmployeeTerritory : esEmployeeTerritory
	{

		
		
	}
	



	[Serializable]
	public partial class EmployeeTerritoryMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected EmployeeTerritoryMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(EmployeeTerritoryMetadata.ColumnNames.Id, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeTerritoryMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeTerritoryMetadata.ColumnNames.EmployeeId, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = EmployeeTerritoryMetadata.PropertyNames.EmployeeId;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeTerritoryMetadata.ColumnNames.TerritoryId, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeTerritoryMetadata.PropertyNames.TerritoryId;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public EmployeeTerritoryMetadata Meta()
		{
			return meta;
		}	
		
		public Guid DataID
		{
			get { return base.m_dataID; }
		}	
		
		public bool MultiProviderMode
		{
			get { return false; }
		}		

		public esColumnMetadataCollection Columns
		{
			get	{ return base.m_columns; }
		}
		
		#region ColumnNames
		public class ColumnNames
		{ 
			 public const string Id = "Id";
			 public const string EmployeeId = "EmployeeId";
			 public const string TerritoryId = "TerritoryId";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string EmployeeId = "EmployeeId";
			 public const string TerritoryId = "TerritoryId";
		}
		#endregion	

		public esProviderSpecificMetadata GetProviderMetadata(string mapName)
		{
			MapToMeta mapMethod = mapDelegates[mapName];

			if (mapMethod != null)
				return mapMethod(mapName);
			else
				return null;
		}
		
		#region MAP esDefault
		
		static private int RegisterDelegateesDefault()
		{
			// This is only executed once per the life of the application
			lock (typeof(EmployeeTerritoryMetadata))
			{
				if(EmployeeTerritoryMetadata.mapDelegates == null)
				{
					EmployeeTerritoryMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (EmployeeTerritoryMetadata.meta == null)
				{
					EmployeeTerritoryMetadata.meta = new EmployeeTerritoryMetadata();
				}
				
				MapToMeta mapMethod = new MapToMeta(meta.esDefault);
				mapDelegates.Add("esDefault", mapMethod);
				mapMethod("esDefault");
			}
			return 0;
		}			

		private esProviderSpecificMetadata esDefault(string mapName)
		{
			if(!m_providerMetadataMaps.ContainsKey(mapName))
			{
				esProviderSpecificMetadata meta = new esProviderSpecificMetadata();			


				meta.AddTypeMap("Id", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("EmployeeId", new esTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("TerritoryId", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "EmployeeTerritory";
				meta.Destination = "EmployeeTerritory";
				
				meta.spInsert = "proc_EmployeeTerritoryInsert";				
				meta.spUpdate = "proc_EmployeeTerritoryUpdate";		
				meta.spDelete = "proc_EmployeeTerritoryDelete";
				meta.spLoadAll = "proc_EmployeeTerritoryLoadAll";
				meta.spLoadByPrimaryKey = "proc_EmployeeTerritoryLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private EmployeeTerritoryMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
