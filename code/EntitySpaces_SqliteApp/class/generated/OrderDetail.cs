
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
	/// Encapsulates the 'OrderDetail' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(OrderDetail))]	
	[XmlType("OrderDetail")]
	public partial class OrderDetail : esOrderDetail
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new OrderDetail();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String id)
		{
			var obj = new OrderDetail();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String id, esSqlAccessType sqlAccessType)
		{
			var obj = new OrderDetail();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("OrderDetailCollection")]
	public partial class OrderDetailCollection : esOrderDetailCollection, IEnumerable<OrderDetail>
	{
		public OrderDetail FindByPrimaryKey(System.String id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
				
	}



	[Serializable]	
	public partial class OrderDetailQuery : esOrderDetailQuery
	{
		public OrderDetailQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public OrderDetailQuery(string joinAlias, out OrderDetailQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "OrderDetailQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(OrderDetailQuery query)
		{
			return OrderDetailQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator OrderDetailQuery(string query)
		{
			return (OrderDetailQuery)OrderDetailQuery.SerializeHelper.FromXml(query, typeof(OrderDetailQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esOrderDetail : esEntity
	{
		public esOrderDetail()
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
			OrderDetailQuery query = new OrderDetailQuery();
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
		/// Maps to OrderDetail.Id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Id
		{
			get
			{
				return base.GetSystemString(OrderDetailMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemString(OrderDetailMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(OrderDetailMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to OrderDetail.OrderId
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? OrderId
		{
			get
			{
				return base.GetSystemInt32(OrderDetailMetadata.ColumnNames.OrderId);
			}
			
			set
			{
				if(base.SetSystemInt32(OrderDetailMetadata.ColumnNames.OrderId, value))
				{
					OnPropertyChanged(OrderDetailMetadata.PropertyNames.OrderId);
				}
			}
		}		
		
		/// <summary>
		/// Maps to OrderDetail.ProductId
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? ProductId
		{
			get
			{
				return base.GetSystemInt32(OrderDetailMetadata.ColumnNames.ProductId);
			}
			
			set
			{
				if(base.SetSystemInt32(OrderDetailMetadata.ColumnNames.ProductId, value))
				{
					OnPropertyChanged(OrderDetailMetadata.PropertyNames.ProductId);
				}
			}
		}		
		
		/// <summary>
		/// Maps to OrderDetail.UnitPrice
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? UnitPrice
		{
			get
			{
				return base.GetSystemDecimal(OrderDetailMetadata.ColumnNames.UnitPrice);
			}
			
			set
			{
				if(base.SetSystemDecimal(OrderDetailMetadata.ColumnNames.UnitPrice, value))
				{
					OnPropertyChanged(OrderDetailMetadata.PropertyNames.UnitPrice);
				}
			}
		}		
		
		/// <summary>
		/// Maps to OrderDetail.Quantity
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Quantity
		{
			get
			{
				return base.GetSystemInt32(OrderDetailMetadata.ColumnNames.Quantity);
			}
			
			set
			{
				if(base.SetSystemInt32(OrderDetailMetadata.ColumnNames.Quantity, value))
				{
					OnPropertyChanged(OrderDetailMetadata.PropertyNames.Quantity);
				}
			}
		}		
		
		/// <summary>
		/// Maps to OrderDetail.Discount
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Discount
		{
			get
			{
				return base.GetSystemDouble(OrderDetailMetadata.ColumnNames.Discount);
			}
			
			set
			{
				if(base.SetSystemDouble(OrderDetailMetadata.ColumnNames.Discount, value))
				{
					OnPropertyChanged(OrderDetailMetadata.PropertyNames.Discount);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return OrderDetailMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public OrderDetailQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new OrderDetailQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(OrderDetailQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(OrderDetailQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private OrderDetailQuery query;		
	}



	[Serializable]
	abstract public partial class esOrderDetailCollection : esEntityCollection<OrderDetail>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return OrderDetailMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "OrderDetailCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public OrderDetailQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new OrderDetailQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(OrderDetailQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new OrderDetailQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(OrderDetailQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((OrderDetailQuery)query);
		}

		#endregion
		
		private OrderDetailQuery query;
	}



	[Serializable]
	abstract public partial class esOrderDetailQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return OrderDetailMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "OrderId": return this.OrderId;
				case "ProductId": return this.ProductId;
				case "UnitPrice": return this.UnitPrice;
				case "Quantity": return this.Quantity;
				case "Discount": return this.Discount;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, OrderDetailMetadata.ColumnNames.Id, esSystemType.String); }
		} 
		
		public esQueryItem OrderId
		{
			get { return new esQueryItem(this, OrderDetailMetadata.ColumnNames.OrderId, esSystemType.Int32); }
		} 
		
		public esQueryItem ProductId
		{
			get { return new esQueryItem(this, OrderDetailMetadata.ColumnNames.ProductId, esSystemType.Int32); }
		} 
		
		public esQueryItem UnitPrice
		{
			get { return new esQueryItem(this, OrderDetailMetadata.ColumnNames.UnitPrice, esSystemType.Decimal); }
		} 
		
		public esQueryItem Quantity
		{
			get { return new esQueryItem(this, OrderDetailMetadata.ColumnNames.Quantity, esSystemType.Int32); }
		} 
		
		public esQueryItem Discount
		{
			get { return new esQueryItem(this, OrderDetailMetadata.ColumnNames.Discount, esSystemType.Double); }
		} 
		
		#endregion
		
	}


	
	public partial class OrderDetail : esOrderDetail
	{

		
		
	}
	



	[Serializable]
	public partial class OrderDetailMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected OrderDetailMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(OrderDetailMetadata.ColumnNames.Id, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = OrderDetailMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrderDetailMetadata.ColumnNames.OrderId, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = OrderDetailMetadata.PropertyNames.OrderId;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrderDetailMetadata.ColumnNames.ProductId, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = OrderDetailMetadata.PropertyNames.ProductId;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrderDetailMetadata.ColumnNames.UnitPrice, 3, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OrderDetailMetadata.PropertyNames.UnitPrice;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrderDetailMetadata.ColumnNames.Quantity, 4, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = OrderDetailMetadata.PropertyNames.Quantity;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrderDetailMetadata.ColumnNames.Discount, 5, typeof(System.Double), esSystemType.Double);
			c.PropertyName = OrderDetailMetadata.PropertyNames.Discount;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public OrderDetailMetadata Meta()
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
			 public const string OrderId = "OrderId";
			 public const string ProductId = "ProductId";
			 public const string UnitPrice = "UnitPrice";
			 public const string Quantity = "Quantity";
			 public const string Discount = "Discount";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string OrderId = "OrderId";
			 public const string ProductId = "ProductId";
			 public const string UnitPrice = "UnitPrice";
			 public const string Quantity = "Quantity";
			 public const string Discount = "Discount";
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
			lock (typeof(OrderDetailMetadata))
			{
				if(OrderDetailMetadata.mapDelegates == null)
				{
					OrderDetailMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (OrderDetailMetadata.meta == null)
				{
					OrderDetailMetadata.meta = new OrderDetailMetadata();
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
				meta.AddTypeMap("OrderId", new esTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("ProductId", new esTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("UnitPrice", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("Quantity", new esTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("Discount", new esTypeMap("double", "System.Double"));			
				
				
				
				meta.Source = "OrderDetail";
				meta.Destination = "OrderDetail";
				
				meta.spInsert = "proc_OrderDetailInsert";				
				meta.spUpdate = "proc_OrderDetailUpdate";		
				meta.spDelete = "proc_OrderDetailDelete";
				meta.spLoadAll = "proc_OrderDetailLoadAll";
				meta.spLoadByPrimaryKey = "proc_OrderDetailLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private OrderDetailMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
