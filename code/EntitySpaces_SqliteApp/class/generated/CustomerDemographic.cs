
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
	/// Encapsulates the 'CustomerDemographic' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(CustomerDemographic))]	
	[XmlType("CustomerDemographic")]
	public partial class CustomerDemographic : esCustomerDemographic
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new CustomerDemographic();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String id)
		{
			var obj = new CustomerDemographic();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String id, esSqlAccessType sqlAccessType)
		{
			var obj = new CustomerDemographic();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("CustomerDemographicCollection")]
	public partial class CustomerDemographicCollection : esCustomerDemographicCollection, IEnumerable<CustomerDemographic>
	{
		public CustomerDemographic FindByPrimaryKey(System.String id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
				
	}



	[Serializable]	
	public partial class CustomerDemographicQuery : esCustomerDemographicQuery
	{
		public CustomerDemographicQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public CustomerDemographicQuery(string joinAlias, out CustomerDemographicQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "CustomerDemographicQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(CustomerDemographicQuery query)
		{
			return CustomerDemographicQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator CustomerDemographicQuery(string query)
		{
			return (CustomerDemographicQuery)CustomerDemographicQuery.SerializeHelper.FromXml(query, typeof(CustomerDemographicQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esCustomerDemographic : esEntity
	{
		public esCustomerDemographic()
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
			CustomerDemographicQuery query = new CustomerDemographicQuery();
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
		/// Maps to CustomerDemographic.Id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Id
		{
			get
			{
				return base.GetSystemString(CustomerDemographicMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemString(CustomerDemographicMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(CustomerDemographicMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to CustomerDemographic.CustomerDesc
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String CustomerDesc
		{
			get
			{
				return base.GetSystemString(CustomerDemographicMetadata.ColumnNames.CustomerDesc);
			}
			
			set
			{
				if(base.SetSystemString(CustomerDemographicMetadata.ColumnNames.CustomerDesc, value))
				{
					OnPropertyChanged(CustomerDemographicMetadata.PropertyNames.CustomerDesc);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return CustomerDemographicMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public CustomerDemographicQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CustomerDemographicQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CustomerDemographicQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(CustomerDemographicQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private CustomerDemographicQuery query;		
	}



	[Serializable]
	abstract public partial class esCustomerDemographicCollection : esEntityCollection<CustomerDemographic>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return CustomerDemographicMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "CustomerDemographicCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public CustomerDemographicQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CustomerDemographicQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CustomerDemographicQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new CustomerDemographicQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(CustomerDemographicQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((CustomerDemographicQuery)query);
		}

		#endregion
		
		private CustomerDemographicQuery query;
	}



	[Serializable]
	abstract public partial class esCustomerDemographicQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return CustomerDemographicMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "CustomerDesc": return this.CustomerDesc;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, CustomerDemographicMetadata.ColumnNames.Id, esSystemType.String); }
		} 
		
		public esQueryItem CustomerDesc
		{
			get { return new esQueryItem(this, CustomerDemographicMetadata.ColumnNames.CustomerDesc, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class CustomerDemographic : esCustomerDemographic
	{

		
		
	}
	



	[Serializable]
	public partial class CustomerDemographicMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected CustomerDemographicMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(CustomerDemographicMetadata.ColumnNames.Id, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomerDemographicMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomerDemographicMetadata.ColumnNames.CustomerDesc, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomerDemographicMetadata.PropertyNames.CustomerDesc;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public CustomerDemographicMetadata Meta()
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
			 public const string CustomerDesc = "CustomerDesc";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string CustomerDesc = "CustomerDesc";
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
			lock (typeof(CustomerDemographicMetadata))
			{
				if(CustomerDemographicMetadata.mapDelegates == null)
				{
					CustomerDemographicMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (CustomerDemographicMetadata.meta == null)
				{
					CustomerDemographicMetadata.meta = new CustomerDemographicMetadata();
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
				meta.AddTypeMap("CustomerDesc", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "CustomerDemographic";
				meta.Destination = "CustomerDemographic";
				
				meta.spInsert = "proc_CustomerDemographicInsert";				
				meta.spUpdate = "proc_CustomerDemographicUpdate";		
				meta.spDelete = "proc_CustomerDemographicDelete";
				meta.spLoadAll = "proc_CustomerDemographicLoadAll";
				meta.spLoadByPrimaryKey = "proc_CustomerDemographicLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private CustomerDemographicMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
