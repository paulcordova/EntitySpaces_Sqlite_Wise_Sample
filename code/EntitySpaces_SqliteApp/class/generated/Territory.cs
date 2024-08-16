
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
	/// Encapsulates the 'Territory' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Territory))]	
	[XmlType("Territory")]
	public partial class Territory : esTerritory
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Territory();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String id)
		{
			var obj = new Territory();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String id, esSqlAccessType sqlAccessType)
		{
			var obj = new Territory();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("TerritoryCollection")]
	public partial class TerritoryCollection : esTerritoryCollection, IEnumerable<Territory>
	{
		public Territory FindByPrimaryKey(System.String id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
				
	}



	[Serializable]	
	public partial class TerritoryQuery : esTerritoryQuery
	{
		public TerritoryQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public TerritoryQuery(string joinAlias, out TerritoryQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "TerritoryQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(TerritoryQuery query)
		{
			return TerritoryQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator TerritoryQuery(string query)
		{
			return (TerritoryQuery)TerritoryQuery.SerializeHelper.FromXml(query, typeof(TerritoryQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esTerritory : esEntity
	{
		public esTerritory()
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
			TerritoryQuery query = new TerritoryQuery();
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
		/// Maps to Territory.Id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Id
		{
			get
			{
				return base.GetSystemString(TerritoryMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemString(TerritoryMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(TerritoryMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Territory.TerritoryDescription
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String TerritoryDescription
		{
			get
			{
				return base.GetSystemString(TerritoryMetadata.ColumnNames.TerritoryDescription);
			}
			
			set
			{
				if(base.SetSystemString(TerritoryMetadata.ColumnNames.TerritoryDescription, value))
				{
					OnPropertyChanged(TerritoryMetadata.PropertyNames.TerritoryDescription);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Territory.RegionId
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? RegionId
		{
			get
			{
				return base.GetSystemInt32(TerritoryMetadata.ColumnNames.RegionId);
			}
			
			set
			{
				if(base.SetSystemInt32(TerritoryMetadata.ColumnNames.RegionId, value))
				{
					OnPropertyChanged(TerritoryMetadata.PropertyNames.RegionId);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return TerritoryMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public TerritoryQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new TerritoryQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(TerritoryQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(TerritoryQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private TerritoryQuery query;		
	}



	[Serializable]
	abstract public partial class esTerritoryCollection : esEntityCollection<Territory>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return TerritoryMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "TerritoryCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public TerritoryQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new TerritoryQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(TerritoryQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new TerritoryQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(TerritoryQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((TerritoryQuery)query);
		}

		#endregion
		
		private TerritoryQuery query;
	}



	[Serializable]
	abstract public partial class esTerritoryQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return TerritoryMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "TerritoryDescription": return this.TerritoryDescription;
				case "RegionId": return this.RegionId;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, TerritoryMetadata.ColumnNames.Id, esSystemType.String); }
		} 
		
		public esQueryItem TerritoryDescription
		{
			get { return new esQueryItem(this, TerritoryMetadata.ColumnNames.TerritoryDescription, esSystemType.String); }
		} 
		
		public esQueryItem RegionId
		{
			get { return new esQueryItem(this, TerritoryMetadata.ColumnNames.RegionId, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class Territory : esTerritory
	{

		
		
	}
	



	[Serializable]
	public partial class TerritoryMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected TerritoryMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(TerritoryMetadata.ColumnNames.Id, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = TerritoryMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TerritoryMetadata.ColumnNames.TerritoryDescription, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = TerritoryMetadata.PropertyNames.TerritoryDescription;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TerritoryMetadata.ColumnNames.RegionId, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = TerritoryMetadata.PropertyNames.RegionId;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public TerritoryMetadata Meta()
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
			 public const string TerritoryDescription = "TerritoryDescription";
			 public const string RegionId = "RegionId";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string TerritoryDescription = "TerritoryDescription";
			 public const string RegionId = "RegionId";
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
			lock (typeof(TerritoryMetadata))
			{
				if(TerritoryMetadata.mapDelegates == null)
				{
					TerritoryMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (TerritoryMetadata.meta == null)
				{
					TerritoryMetadata.meta = new TerritoryMetadata();
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
				meta.AddTypeMap("TerritoryDescription", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("RegionId", new esTypeMap("integer", "System.Int32"));			
				
				
				
				meta.Source = "Territory";
				meta.Destination = "Territory";
				
				meta.spInsert = "proc_TerritoryInsert";				
				meta.spUpdate = "proc_TerritoryUpdate";		
				meta.spDelete = "proc_TerritoryDelete";
				meta.spLoadAll = "proc_TerritoryLoadAll";
				meta.spLoadByPrimaryKey = "proc_TerritoryLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private TerritoryMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
