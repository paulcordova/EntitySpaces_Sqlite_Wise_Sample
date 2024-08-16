
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
	/// Encapsulates the 'Supplier' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Supplier))]	
	[XmlType("Supplier")]
	public partial class Supplier : esSupplier
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Supplier();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 id)
		{
			var obj = new Supplier();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 id, esSqlAccessType sqlAccessType)
		{
			var obj = new Supplier();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("SupplierCollection")]
	public partial class SupplierCollection : esSupplierCollection, IEnumerable<Supplier>
	{
		public Supplier FindByPrimaryKey(System.Int32 id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
				
	}



	[Serializable]	
	public partial class SupplierQuery : esSupplierQuery
	{
		public SupplierQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public SupplierQuery(string joinAlias, out SupplierQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "SupplierQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(SupplierQuery query)
		{
			return SupplierQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator SupplierQuery(string query)
		{
			return (SupplierQuery)SupplierQuery.SerializeHelper.FromXml(query, typeof(SupplierQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esSupplier : esEntity
	{
		public esSupplier()
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
			SupplierQuery query = new SupplierQuery();
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
		/// Maps to Supplier.Id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Id
		{
			get
			{
				return base.GetSystemInt32(SupplierMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemInt32(SupplierMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.CompanyName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String CompanyName
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.CompanyName);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.CompanyName, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.CompanyName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.ContactName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ContactName
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.ContactName);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.ContactName, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.ContactName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.ContactTitle
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ContactTitle
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.ContactTitle);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.ContactTitle, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.ContactTitle);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.Address
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Address
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.Address);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.Address, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.Address);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.City
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String City
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.City);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.City, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.City);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.Region
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Region
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.Region);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.Region, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.Region);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.PostalCode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String PostalCode
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.PostalCode);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.PostalCode, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.PostalCode);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.Country
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Country
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.Country);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.Country, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.Country);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.Phone
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Phone
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.Phone);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.Phone, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.Phone);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.Fax
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Fax
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.Fax);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.Fax, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.Fax);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.HomePage
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String HomePage
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.HomePage);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.HomePage, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.HomePage);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return SupplierMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public SupplierQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SupplierQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SupplierQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(SupplierQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private SupplierQuery query;		
	}



	[Serializable]
	abstract public partial class esSupplierCollection : esEntityCollection<Supplier>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return SupplierMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "SupplierCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public SupplierQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SupplierQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SupplierQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new SupplierQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(SupplierQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((SupplierQuery)query);
		}

		#endregion
		
		private SupplierQuery query;
	}



	[Serializable]
	abstract public partial class esSupplierQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return SupplierMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "CompanyName": return this.CompanyName;
				case "ContactName": return this.ContactName;
				case "ContactTitle": return this.ContactTitle;
				case "Address": return this.Address;
				case "City": return this.City;
				case "Region": return this.Region;
				case "PostalCode": return this.PostalCode;
				case "Country": return this.Country;
				case "Phone": return this.Phone;
				case "Fax": return this.Fax;
				case "HomePage": return this.HomePage;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.Id, esSystemType.Int32); }
		} 
		
		public esQueryItem CompanyName
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.CompanyName, esSystemType.String); }
		} 
		
		public esQueryItem ContactName
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.ContactName, esSystemType.String); }
		} 
		
		public esQueryItem ContactTitle
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.ContactTitle, esSystemType.String); }
		} 
		
		public esQueryItem Address
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.Address, esSystemType.String); }
		} 
		
		public esQueryItem City
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.City, esSystemType.String); }
		} 
		
		public esQueryItem Region
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.Region, esSystemType.String); }
		} 
		
		public esQueryItem PostalCode
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.PostalCode, esSystemType.String); }
		} 
		
		public esQueryItem Country
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.Country, esSystemType.String); }
		} 
		
		public esQueryItem Phone
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.Phone, esSystemType.String); }
		} 
		
		public esQueryItem Fax
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.Fax, esSystemType.String); }
		} 
		
		public esQueryItem HomePage
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.HomePage, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class Supplier : esSupplier
	{

		
		
	}
	



	[Serializable]
	public partial class SupplierMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected SupplierMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(SupplierMetadata.ColumnNames.Id, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SupplierMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.CompanyName, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.CompanyName;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.ContactName, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.ContactName;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.ContactTitle, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.ContactTitle;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.Address, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.Address;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.City, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.City;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.Region, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.Region;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.PostalCode, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.PostalCode;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.Country, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.Country;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.Phone, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.Phone;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.Fax, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.Fax;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.HomePage, 11, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.HomePage;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public SupplierMetadata Meta()
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
			 public const string ContactName = "ContactName";
			 public const string ContactTitle = "ContactTitle";
			 public const string Address = "Address";
			 public const string City = "City";
			 public const string Region = "Region";
			 public const string PostalCode = "PostalCode";
			 public const string Country = "Country";
			 public const string Phone = "Phone";
			 public const string Fax = "Fax";
			 public const string HomePage = "HomePage";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string CompanyName = "CompanyName";
			 public const string ContactName = "ContactName";
			 public const string ContactTitle = "ContactTitle";
			 public const string Address = "Address";
			 public const string City = "City";
			 public const string Region = "Region";
			 public const string PostalCode = "PostalCode";
			 public const string Country = "Country";
			 public const string Phone = "Phone";
			 public const string Fax = "Fax";
			 public const string HomePage = "HomePage";
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
			lock (typeof(SupplierMetadata))
			{
				if(SupplierMetadata.mapDelegates == null)
				{
					SupplierMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (SupplierMetadata.meta == null)
				{
					SupplierMetadata.meta = new SupplierMetadata();
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
				meta.AddTypeMap("ContactName", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("ContactTitle", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Address", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("City", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Region", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("PostalCode", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Country", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Phone", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Fax", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("HomePage", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "Supplier";
				meta.Destination = "Supplier";
				
				meta.spInsert = "proc_SupplierInsert";				
				meta.spUpdate = "proc_SupplierUpdate";		
				meta.spDelete = "proc_SupplierDelete";
				meta.spLoadAll = "proc_SupplierLoadAll";
				meta.spLoadByPrimaryKey = "proc_SupplierLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private SupplierMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
