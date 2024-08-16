
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
	/// Encapsulates the 'Order' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Order))]	
	[XmlType("Order")]
	public partial class Order : esOrder
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Order();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 id)
		{
			var obj = new Order();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 id, esSqlAccessType sqlAccessType)
		{
			var obj = new Order();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("OrderCollection")]
	public partial class OrderCollection : esOrderCollection, IEnumerable<Order>
	{
		public Order FindByPrimaryKey(System.Int32 id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
				
	}



	[Serializable]	
	public partial class OrderQuery : esOrderQuery
	{
		public OrderQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public OrderQuery(string joinAlias, out OrderQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "OrderQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(OrderQuery query)
		{
			return OrderQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator OrderQuery(string query)
		{
			return (OrderQuery)OrderQuery.SerializeHelper.FromXml(query, typeof(OrderQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esOrder : esEntity
	{
		public esOrder()
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
			OrderQuery query = new OrderQuery();
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
		/// Maps to Order.Id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Id
		{
			get
			{
				return base.GetSystemInt32(OrderMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemInt32(OrderMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(OrderMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Order.CustomerId
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String CustomerId
		{
			get
			{
				return base.GetSystemString(OrderMetadata.ColumnNames.CustomerId);
			}
			
			set
			{
				if(base.SetSystemString(OrderMetadata.ColumnNames.CustomerId, value))
				{
					OnPropertyChanged(OrderMetadata.PropertyNames.CustomerId);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Order.EmployeeId
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? EmployeeId
		{
			get
			{
				return base.GetSystemInt32(OrderMetadata.ColumnNames.EmployeeId);
			}
			
			set
			{
				if(base.SetSystemInt32(OrderMetadata.ColumnNames.EmployeeId, value))
				{
					OnPropertyChanged(OrderMetadata.PropertyNames.EmployeeId);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Order.OrderDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String OrderDate
		{
			get
			{
				return base.GetSystemString(OrderMetadata.ColumnNames.OrderDate);
			}
			
			set
			{
				if(base.SetSystemString(OrderMetadata.ColumnNames.OrderDate, value))
				{
					OnPropertyChanged(OrderMetadata.PropertyNames.OrderDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Order.RequiredDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String RequiredDate
		{
			get
			{
				return base.GetSystemString(OrderMetadata.ColumnNames.RequiredDate);
			}
			
			set
			{
				if(base.SetSystemString(OrderMetadata.ColumnNames.RequiredDate, value))
				{
					OnPropertyChanged(OrderMetadata.PropertyNames.RequiredDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Order.ShippedDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ShippedDate
		{
			get
			{
				return base.GetSystemString(OrderMetadata.ColumnNames.ShippedDate);
			}
			
			set
			{
				if(base.SetSystemString(OrderMetadata.ColumnNames.ShippedDate, value))
				{
					OnPropertyChanged(OrderMetadata.PropertyNames.ShippedDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Order.ShipVia
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? ShipVia
		{
			get
			{
				return base.GetSystemInt32(OrderMetadata.ColumnNames.ShipVia);
			}
			
			set
			{
				if(base.SetSystemInt32(OrderMetadata.ColumnNames.ShipVia, value))
				{
					OnPropertyChanged(OrderMetadata.PropertyNames.ShipVia);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Order.Freight
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Freight
		{
			get
			{
				return base.GetSystemDecimal(OrderMetadata.ColumnNames.Freight);
			}
			
			set
			{
				if(base.SetSystemDecimal(OrderMetadata.ColumnNames.Freight, value))
				{
					OnPropertyChanged(OrderMetadata.PropertyNames.Freight);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Order.ShipName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ShipName
		{
			get
			{
				return base.GetSystemString(OrderMetadata.ColumnNames.ShipName);
			}
			
			set
			{
				if(base.SetSystemString(OrderMetadata.ColumnNames.ShipName, value))
				{
					OnPropertyChanged(OrderMetadata.PropertyNames.ShipName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Order.ShipAddress
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ShipAddress
		{
			get
			{
				return base.GetSystemString(OrderMetadata.ColumnNames.ShipAddress);
			}
			
			set
			{
				if(base.SetSystemString(OrderMetadata.ColumnNames.ShipAddress, value))
				{
					OnPropertyChanged(OrderMetadata.PropertyNames.ShipAddress);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Order.ShipCity
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ShipCity
		{
			get
			{
				return base.GetSystemString(OrderMetadata.ColumnNames.ShipCity);
			}
			
			set
			{
				if(base.SetSystemString(OrderMetadata.ColumnNames.ShipCity, value))
				{
					OnPropertyChanged(OrderMetadata.PropertyNames.ShipCity);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Order.ShipRegion
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ShipRegion
		{
			get
			{
				return base.GetSystemString(OrderMetadata.ColumnNames.ShipRegion);
			}
			
			set
			{
				if(base.SetSystemString(OrderMetadata.ColumnNames.ShipRegion, value))
				{
					OnPropertyChanged(OrderMetadata.PropertyNames.ShipRegion);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Order.ShipPostalCode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ShipPostalCode
		{
			get
			{
				return base.GetSystemString(OrderMetadata.ColumnNames.ShipPostalCode);
			}
			
			set
			{
				if(base.SetSystemString(OrderMetadata.ColumnNames.ShipPostalCode, value))
				{
					OnPropertyChanged(OrderMetadata.PropertyNames.ShipPostalCode);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Order.ShipCountry
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ShipCountry
		{
			get
			{
				return base.GetSystemString(OrderMetadata.ColumnNames.ShipCountry);
			}
			
			set
			{
				if(base.SetSystemString(OrderMetadata.ColumnNames.ShipCountry, value))
				{
					OnPropertyChanged(OrderMetadata.PropertyNames.ShipCountry);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return OrderMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public OrderQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new OrderQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(OrderQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(OrderQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private OrderQuery query;		
	}



	[Serializable]
	abstract public partial class esOrderCollection : esEntityCollection<Order>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return OrderMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "OrderCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public OrderQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new OrderQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(OrderQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new OrderQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(OrderQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((OrderQuery)query);
		}

		#endregion
		
		private OrderQuery query;
	}



	[Serializable]
	abstract public partial class esOrderQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return OrderMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "CustomerId": return this.CustomerId;
				case "EmployeeId": return this.EmployeeId;
				case "OrderDate": return this.OrderDate;
				case "RequiredDate": return this.RequiredDate;
				case "ShippedDate": return this.ShippedDate;
				case "ShipVia": return this.ShipVia;
				case "Freight": return this.Freight;
				case "ShipName": return this.ShipName;
				case "ShipAddress": return this.ShipAddress;
				case "ShipCity": return this.ShipCity;
				case "ShipRegion": return this.ShipRegion;
				case "ShipPostalCode": return this.ShipPostalCode;
				case "ShipCountry": return this.ShipCountry;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, OrderMetadata.ColumnNames.Id, esSystemType.Int32); }
		} 
		
		public esQueryItem CustomerId
		{
			get { return new esQueryItem(this, OrderMetadata.ColumnNames.CustomerId, esSystemType.String); }
		} 
		
		public esQueryItem EmployeeId
		{
			get { return new esQueryItem(this, OrderMetadata.ColumnNames.EmployeeId, esSystemType.Int32); }
		} 
		
		public esQueryItem OrderDate
		{
			get { return new esQueryItem(this, OrderMetadata.ColumnNames.OrderDate, esSystemType.String); }
		} 
		
		public esQueryItem RequiredDate
		{
			get { return new esQueryItem(this, OrderMetadata.ColumnNames.RequiredDate, esSystemType.String); }
		} 
		
		public esQueryItem ShippedDate
		{
			get { return new esQueryItem(this, OrderMetadata.ColumnNames.ShippedDate, esSystemType.String); }
		} 
		
		public esQueryItem ShipVia
		{
			get { return new esQueryItem(this, OrderMetadata.ColumnNames.ShipVia, esSystemType.Int32); }
		} 
		
		public esQueryItem Freight
		{
			get { return new esQueryItem(this, OrderMetadata.ColumnNames.Freight, esSystemType.Decimal); }
		} 
		
		public esQueryItem ShipName
		{
			get { return new esQueryItem(this, OrderMetadata.ColumnNames.ShipName, esSystemType.String); }
		} 
		
		public esQueryItem ShipAddress
		{
			get { return new esQueryItem(this, OrderMetadata.ColumnNames.ShipAddress, esSystemType.String); }
		} 
		
		public esQueryItem ShipCity
		{
			get { return new esQueryItem(this, OrderMetadata.ColumnNames.ShipCity, esSystemType.String); }
		} 
		
		public esQueryItem ShipRegion
		{
			get { return new esQueryItem(this, OrderMetadata.ColumnNames.ShipRegion, esSystemType.String); }
		} 
		
		public esQueryItem ShipPostalCode
		{
			get { return new esQueryItem(this, OrderMetadata.ColumnNames.ShipPostalCode, esSystemType.String); }
		} 
		
		public esQueryItem ShipCountry
		{
			get { return new esQueryItem(this, OrderMetadata.ColumnNames.ShipCountry, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class Order : esOrder
	{

		
		
	}
	



	[Serializable]
	public partial class OrderMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected OrderMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(OrderMetadata.ColumnNames.Id, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = OrderMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrderMetadata.ColumnNames.CustomerId, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = OrderMetadata.PropertyNames.CustomerId;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrderMetadata.ColumnNames.EmployeeId, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = OrderMetadata.PropertyNames.EmployeeId;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrderMetadata.ColumnNames.OrderDate, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = OrderMetadata.PropertyNames.OrderDate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrderMetadata.ColumnNames.RequiredDate, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = OrderMetadata.PropertyNames.RequiredDate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrderMetadata.ColumnNames.ShippedDate, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = OrderMetadata.PropertyNames.ShippedDate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrderMetadata.ColumnNames.ShipVia, 6, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = OrderMetadata.PropertyNames.ShipVia;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrderMetadata.ColumnNames.Freight, 7, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OrderMetadata.PropertyNames.Freight;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrderMetadata.ColumnNames.ShipName, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = OrderMetadata.PropertyNames.ShipName;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrderMetadata.ColumnNames.ShipAddress, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = OrderMetadata.PropertyNames.ShipAddress;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrderMetadata.ColumnNames.ShipCity, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = OrderMetadata.PropertyNames.ShipCity;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrderMetadata.ColumnNames.ShipRegion, 11, typeof(System.String), esSystemType.String);
			c.PropertyName = OrderMetadata.PropertyNames.ShipRegion;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrderMetadata.ColumnNames.ShipPostalCode, 12, typeof(System.String), esSystemType.String);
			c.PropertyName = OrderMetadata.PropertyNames.ShipPostalCode;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrderMetadata.ColumnNames.ShipCountry, 13, typeof(System.String), esSystemType.String);
			c.PropertyName = OrderMetadata.PropertyNames.ShipCountry;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public OrderMetadata Meta()
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
			 public const string CustomerId = "CustomerId";
			 public const string EmployeeId = "EmployeeId";
			 public const string OrderDate = "OrderDate";
			 public const string RequiredDate = "RequiredDate";
			 public const string ShippedDate = "ShippedDate";
			 public const string ShipVia = "ShipVia";
			 public const string Freight = "Freight";
			 public const string ShipName = "ShipName";
			 public const string ShipAddress = "ShipAddress";
			 public const string ShipCity = "ShipCity";
			 public const string ShipRegion = "ShipRegion";
			 public const string ShipPostalCode = "ShipPostalCode";
			 public const string ShipCountry = "ShipCountry";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string CustomerId = "CustomerId";
			 public const string EmployeeId = "EmployeeId";
			 public const string OrderDate = "OrderDate";
			 public const string RequiredDate = "RequiredDate";
			 public const string ShippedDate = "ShippedDate";
			 public const string ShipVia = "ShipVia";
			 public const string Freight = "Freight";
			 public const string ShipName = "ShipName";
			 public const string ShipAddress = "ShipAddress";
			 public const string ShipCity = "ShipCity";
			 public const string ShipRegion = "ShipRegion";
			 public const string ShipPostalCode = "ShipPostalCode";
			 public const string ShipCountry = "ShipCountry";
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
			lock (typeof(OrderMetadata))
			{
				if(OrderMetadata.mapDelegates == null)
				{
					OrderMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (OrderMetadata.meta == null)
				{
					OrderMetadata.meta = new OrderMetadata();
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
				meta.AddTypeMap("CustomerId", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("EmployeeId", new esTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("OrderDate", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("RequiredDate", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("ShippedDate", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("ShipVia", new esTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("Freight", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("ShipName", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("ShipAddress", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("ShipCity", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("ShipRegion", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("ShipPostalCode", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("ShipCountry", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "Order";
				meta.Destination = "Order";
				
				meta.spInsert = "proc_OrderInsert";				
				meta.spUpdate = "proc_OrderUpdate";		
				meta.spDelete = "proc_OrderDelete";
				meta.spLoadAll = "proc_OrderLoadAll";
				meta.spLoadByPrimaryKey = "proc_OrderLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private OrderMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
