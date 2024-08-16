
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
	/// Encapsulates the 'Shipper' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Shipper))]	
	[XmlType("Shipper")]
	public partial class Shipper : esShipper
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Shipper();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 id)
		{
			var obj = new Shipper();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 id, esSqlAccessType sqlAccessType)
		{
			var obj = new Shipper();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("ShipperCollection")]
	public partial class ShipperCollection : esShipperCollection, IEnumerable<Shipper>
	{
		public Shipper FindByPrimaryKey(System.Int32 id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
				
	}



	[Serializable]	
	public partial class ShipperQuery : esShipperQuery
	{
		public ShipperQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public ShipperQuery(string joinAlias, out ShipperQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "ShipperQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ShipperQuery query)
		{
			return ShipperQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ShipperQuery(string query)
		{
			return (ShipperQuery)ShipperQuery.SerializeHelper.FromXml(query, typeof(ShipperQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esShipper : esEntity
	{
		public esShipper()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 id)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(id);
			else
				return LoadByPrimaryKeyStoredProcedure(id);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 id)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(id);
			else
				return LoadByPrimaryKeyStoredProcedure(id);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 id)
		{
			ShipperQuery query = new ShipperQuery();
			query.Where(query.Id == id);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 id)
		{
			esParameters parms = new esParameters();
			parms.Add("Id", id);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to Shipper.Id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Id
		{
			get
			{
				return base.GetSystemInt32(ShipperMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemInt32(ShipperMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(ShipperMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Shipper.CompanyName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String CompanyName
		{
			get
			{
				return base.GetSystemString(ShipperMetadata.ColumnNames.CompanyName);
			}
			
			set
			{
				if(base.SetSystemString(ShipperMetadata.ColumnNames.CompanyName, value))
				{
					OnPropertyChanged(ShipperMetadata.PropertyNames.CompanyName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Shipper.Phone
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Phone
		{
			get
			{
				return base.GetSystemString(ShipperMetadata.ColumnNames.Phone);
			}
			
			set
			{
				if(base.SetSystemString(ShipperMetadata.ColumnNames.Phone, value))
				{
					OnPropertyChanged(ShipperMetadata.PropertyNames.Phone);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ShipperMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ShipperQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ShipperQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ShipperQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ShipperQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ShipperQuery query;		
	}



	[Serializable]
	abstract public partial class esShipperCollection : esEntityCollection<Shipper>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ShipperMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ShipperCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ShipperQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ShipperQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ShipperQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ShipperQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ShipperQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ShipperQuery)query);
		}

		#endregion
		
		private ShipperQuery query;
	}



	[Serializable]
	abstract public partial class esShipperQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ShipperMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "CompanyName": return this.CompanyName;
				case "Phone": return this.Phone;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, ShipperMetadata.ColumnNames.Id, esSystemType.Int32); }
		} 
		
		public esQueryItem CompanyName
		{
			get { return new esQueryItem(this, ShipperMetadata.ColumnNames.CompanyName, esSystemType.String); }
		} 
		
		public esQueryItem Phone
		{
			get { return new esQueryItem(this, ShipperMetadata.ColumnNames.Phone, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class Shipper : esShipper
	{

		
		
	}
	



	[Serializable]
	public partial class ShipperMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ShipperMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ShipperMetadata.ColumnNames.Id, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ShipperMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ShipperMetadata.ColumnNames.CompanyName, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ShipperMetadata.PropertyNames.CompanyName;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ShipperMetadata.ColumnNames.Phone, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = ShipperMetadata.PropertyNames.Phone;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ShipperMetadata Meta()
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
			 public const string CompanyName = "CompanyName";
			 public const string Phone = "Phone";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string CompanyName = "CompanyName";
			 public const string Phone = "Phone";
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
			lock (typeof(ShipperMetadata))
			{
				if(ShipperMetadata.mapDelegates == null)
				{
					ShipperMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ShipperMetadata.meta == null)
				{
					ShipperMetadata.meta = new ShipperMetadata();
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


				meta.AddTypeMap("Id", new esTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("CompanyName", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Phone", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "Shipper";
				meta.Destination = "Shipper";
				
				meta.spInsert = "proc_ShipperInsert";				
				meta.spUpdate = "proc_ShipperUpdate";		
				meta.spDelete = "proc_ShipperDelete";
				meta.spLoadAll = "proc_ShipperLoadAll";
				meta.spLoadByPrimaryKey = "proc_ShipperLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ShipperMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
