
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
	/// Encapsulates the 'CustomerCustomerDemo' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(CustomerCustomerDemo))]	
	[XmlType("CustomerCustomerDemo")]
	public partial class CustomerCustomerDemo : esCustomerCustomerDemo
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new CustomerCustomerDemo();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String id)
		{
			var obj = new CustomerCustomerDemo();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String id, esSqlAccessType sqlAccessType)
		{
			var obj = new CustomerCustomerDemo();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("CustomerCustomerDemoCollection")]
	public partial class CustomerCustomerDemoCollection : esCustomerCustomerDemoCollection, IEnumerable<CustomerCustomerDemo>
	{
		public CustomerCustomerDemo FindByPrimaryKey(System.String id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
				
	}



	[Serializable]	
	public partial class CustomerCustomerDemoQuery : esCustomerCustomerDemoQuery
	{
		public CustomerCustomerDemoQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public CustomerCustomerDemoQuery(string joinAlias, out CustomerCustomerDemoQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "CustomerCustomerDemoQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(CustomerCustomerDemoQuery query)
		{
			return CustomerCustomerDemoQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator CustomerCustomerDemoQuery(string query)
		{
			return (CustomerCustomerDemoQuery)CustomerCustomerDemoQuery.SerializeHelper.FromXml(query, typeof(CustomerCustomerDemoQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esCustomerCustomerDemo : esEntity
	{
		public esCustomerCustomerDemo()
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
			CustomerCustomerDemoQuery query = new CustomerCustomerDemoQuery();
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
		/// Maps to CustomerCustomerDemo.Id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Id
		{
			get
			{
				return base.GetSystemString(CustomerCustomerDemoMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemString(CustomerCustomerDemoMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(CustomerCustomerDemoMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to CustomerCustomerDemo.CustomerTypeId
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String CustomerTypeId
		{
			get
			{
				return base.GetSystemString(CustomerCustomerDemoMetadata.ColumnNames.CustomerTypeId);
			}
			
			set
			{
				if(base.SetSystemString(CustomerCustomerDemoMetadata.ColumnNames.CustomerTypeId, value))
				{
					OnPropertyChanged(CustomerCustomerDemoMetadata.PropertyNames.CustomerTypeId);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return CustomerCustomerDemoMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public CustomerCustomerDemoQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CustomerCustomerDemoQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CustomerCustomerDemoQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(CustomerCustomerDemoQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private CustomerCustomerDemoQuery query;		
	}



	[Serializable]
	abstract public partial class esCustomerCustomerDemoCollection : esEntityCollection<CustomerCustomerDemo>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return CustomerCustomerDemoMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "CustomerCustomerDemoCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public CustomerCustomerDemoQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CustomerCustomerDemoQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CustomerCustomerDemoQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new CustomerCustomerDemoQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(CustomerCustomerDemoQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((CustomerCustomerDemoQuery)query);
		}

		#endregion
		
		private CustomerCustomerDemoQuery query;
	}



	[Serializable]
	abstract public partial class esCustomerCustomerDemoQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return CustomerCustomerDemoMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "CustomerTypeId": return this.CustomerTypeId;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, CustomerCustomerDemoMetadata.ColumnNames.Id, esSystemType.String); }
		} 
		
		public esQueryItem CustomerTypeId
		{
			get { return new esQueryItem(this, CustomerCustomerDemoMetadata.ColumnNames.CustomerTypeId, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class CustomerCustomerDemo : esCustomerCustomerDemo
	{

		
		
	}
	



	[Serializable]
	public partial class CustomerCustomerDemoMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected CustomerCustomerDemoMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(CustomerCustomerDemoMetadata.ColumnNames.Id, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomerCustomerDemoMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomerCustomerDemoMetadata.ColumnNames.CustomerTypeId, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomerCustomerDemoMetadata.PropertyNames.CustomerTypeId;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public CustomerCustomerDemoMetadata Meta()
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
			 public const string CustomerTypeId = "CustomerTypeId";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string CustomerTypeId = "CustomerTypeId";
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
			lock (typeof(CustomerCustomerDemoMetadata))
			{
				if(CustomerCustomerDemoMetadata.mapDelegates == null)
				{
					CustomerCustomerDemoMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (CustomerCustomerDemoMetadata.meta == null)
				{
					CustomerCustomerDemoMetadata.meta = new CustomerCustomerDemoMetadata();
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
				meta.AddTypeMap("CustomerTypeId", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "CustomerCustomerDemo";
				meta.Destination = "CustomerCustomerDemo";
				
				meta.spInsert = "proc_CustomerCustomerDemoInsert";				
				meta.spUpdate = "proc_CustomerCustomerDemoUpdate";		
				meta.spDelete = "proc_CustomerCustomerDemoDelete";
				meta.spLoadAll = "proc_CustomerCustomerDemoLoadAll";
				meta.spLoadByPrimaryKey = "proc_CustomerCustomerDemoLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private CustomerCustomerDemoMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
