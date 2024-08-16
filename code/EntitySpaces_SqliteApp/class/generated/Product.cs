
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
	/// Encapsulates the 'Product' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Product))]	
	[XmlType("Product")]
	public partial class Product : esProduct
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Product();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 id)
		{
			var obj = new Product();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 id, esSqlAccessType sqlAccessType)
		{
			var obj = new Product();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("ProductCollection")]
	public partial class ProductCollection : esProductCollection, IEnumerable<Product>
	{
		public Product FindByPrimaryKey(System.Int32 id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
				
	}



	[Serializable]	
	public partial class ProductQuery : esProductQuery
	{
		public ProductQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public ProductQuery(string joinAlias, out ProductQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "ProductQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ProductQuery query)
		{
			return ProductQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ProductQuery(string query)
		{
			return (ProductQuery)ProductQuery.SerializeHelper.FromXml(query, typeof(ProductQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esProduct : esEntity
	{
		public esProduct()
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
			ProductQuery query = new ProductQuery();
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
		/// Maps to Product.Id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Id
		{
			get
			{
				return base.GetSystemInt32(ProductMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemInt32(ProductMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(ProductMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Product.ProductName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ProductName
		{
			get
			{
				return base.GetSystemString(ProductMetadata.ColumnNames.ProductName);
			}
			
			set
			{
				if(base.SetSystemString(ProductMetadata.ColumnNames.ProductName, value))
				{
					OnPropertyChanged(ProductMetadata.PropertyNames.ProductName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Product.SupplierId
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? SupplierId
		{
			get
			{
				return base.GetSystemInt32(ProductMetadata.ColumnNames.SupplierId);
			}
			
			set
			{
				if(base.SetSystemInt32(ProductMetadata.ColumnNames.SupplierId, value))
				{
					OnPropertyChanged(ProductMetadata.PropertyNames.SupplierId);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Product.CategoryId
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? CategoryId
		{
			get
			{
				return base.GetSystemInt32(ProductMetadata.ColumnNames.CategoryId);
			}
			
			set
			{
				if(base.SetSystemInt32(ProductMetadata.ColumnNames.CategoryId, value))
				{
					OnPropertyChanged(ProductMetadata.PropertyNames.CategoryId);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Product.QuantityPerUnit
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String QuantityPerUnit
		{
			get
			{
				return base.GetSystemString(ProductMetadata.ColumnNames.QuantityPerUnit);
			}
			
			set
			{
				if(base.SetSystemString(ProductMetadata.ColumnNames.QuantityPerUnit, value))
				{
					OnPropertyChanged(ProductMetadata.PropertyNames.QuantityPerUnit);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Product.UnitPrice
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? UnitPrice
		{
			get
			{
				return base.GetSystemDecimal(ProductMetadata.ColumnNames.UnitPrice);
			}
			
			set
			{
				if(base.SetSystemDecimal(ProductMetadata.ColumnNames.UnitPrice, value))
				{
					OnPropertyChanged(ProductMetadata.PropertyNames.UnitPrice);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Product.UnitsInStock
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? UnitsInStock
		{
			get
			{
				return base.GetSystemInt32(ProductMetadata.ColumnNames.UnitsInStock);
			}
			
			set
			{
				if(base.SetSystemInt32(ProductMetadata.ColumnNames.UnitsInStock, value))
				{
					OnPropertyChanged(ProductMetadata.PropertyNames.UnitsInStock);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Product.UnitsOnOrder
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? UnitsOnOrder
		{
			get
			{
				return base.GetSystemInt32(ProductMetadata.ColumnNames.UnitsOnOrder);
			}
			
			set
			{
				if(base.SetSystemInt32(ProductMetadata.ColumnNames.UnitsOnOrder, value))
				{
					OnPropertyChanged(ProductMetadata.PropertyNames.UnitsOnOrder);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Product.ReorderLevel
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? ReorderLevel
		{
			get
			{
				return base.GetSystemInt32(ProductMetadata.ColumnNames.ReorderLevel);
			}
			
			set
			{
				if(base.SetSystemInt32(ProductMetadata.ColumnNames.ReorderLevel, value))
				{
					OnPropertyChanged(ProductMetadata.PropertyNames.ReorderLevel);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Product.Discontinued
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Discontinued
		{
			get
			{
				return base.GetSystemInt32(ProductMetadata.ColumnNames.Discontinued);
			}
			
			set
			{
				if(base.SetSystemInt32(ProductMetadata.ColumnNames.Discontinued, value))
				{
					OnPropertyChanged(ProductMetadata.PropertyNames.Discontinued);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ProductMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ProductQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProductQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ProductQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ProductQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ProductQuery query;		
	}



	[Serializable]
	abstract public partial class esProductCollection : esEntityCollection<Product>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ProductMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ProductCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ProductQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProductQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ProductQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ProductQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ProductQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ProductQuery)query);
		}

		#endregion
		
		private ProductQuery query;
	}



	[Serializable]
	abstract public partial class esProductQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ProductMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "ProductName": return this.ProductName;
				case "SupplierId": return this.SupplierId;
				case "CategoryId": return this.CategoryId;
				case "QuantityPerUnit": return this.QuantityPerUnit;
				case "UnitPrice": return this.UnitPrice;
				case "UnitsInStock": return this.UnitsInStock;
				case "UnitsOnOrder": return this.UnitsOnOrder;
				case "ReorderLevel": return this.ReorderLevel;
				case "Discontinued": return this.Discontinued;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, ProductMetadata.ColumnNames.Id, esSystemType.Int32); }
		} 
		
		public esQueryItem ProductName
		{
			get { return new esQueryItem(this, ProductMetadata.ColumnNames.ProductName, esSystemType.String); }
		} 
		
		public esQueryItem SupplierId
		{
			get { return new esQueryItem(this, ProductMetadata.ColumnNames.SupplierId, esSystemType.Int32); }
		} 
		
		public esQueryItem CategoryId
		{
			get { return new esQueryItem(this, ProductMetadata.ColumnNames.CategoryId, esSystemType.Int32); }
		} 
		
		public esQueryItem QuantityPerUnit
		{
			get { return new esQueryItem(this, ProductMetadata.ColumnNames.QuantityPerUnit, esSystemType.String); }
		} 
		
		public esQueryItem UnitPrice
		{
			get { return new esQueryItem(this, ProductMetadata.ColumnNames.UnitPrice, esSystemType.Decimal); }
		} 
		
		public esQueryItem UnitsInStock
		{
			get { return new esQueryItem(this, ProductMetadata.ColumnNames.UnitsInStock, esSystemType.Int32); }
		} 
		
		public esQueryItem UnitsOnOrder
		{
			get { return new esQueryItem(this, ProductMetadata.ColumnNames.UnitsOnOrder, esSystemType.Int32); }
		} 
		
		public esQueryItem ReorderLevel
		{
			get { return new esQueryItem(this, ProductMetadata.ColumnNames.ReorderLevel, esSystemType.Int32); }
		} 
		
		public esQueryItem Discontinued
		{
			get { return new esQueryItem(this, ProductMetadata.ColumnNames.Discontinued, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class Product : esProduct
	{

		
		
	}
	



	[Serializable]
	public partial class ProductMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ProductMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ProductMetadata.ColumnNames.Id, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProductMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductMetadata.ColumnNames.ProductName, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ProductMetadata.PropertyNames.ProductName;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductMetadata.ColumnNames.SupplierId, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProductMetadata.PropertyNames.SupplierId;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductMetadata.ColumnNames.CategoryId, 3, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProductMetadata.PropertyNames.CategoryId;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductMetadata.ColumnNames.QuantityPerUnit, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = ProductMetadata.PropertyNames.QuantityPerUnit;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductMetadata.ColumnNames.UnitPrice, 5, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = ProductMetadata.PropertyNames.UnitPrice;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductMetadata.ColumnNames.UnitsInStock, 6, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProductMetadata.PropertyNames.UnitsInStock;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductMetadata.ColumnNames.UnitsOnOrder, 7, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProductMetadata.PropertyNames.UnitsOnOrder;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductMetadata.ColumnNames.ReorderLevel, 8, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProductMetadata.PropertyNames.ReorderLevel;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductMetadata.ColumnNames.Discontinued, 9, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProductMetadata.PropertyNames.Discontinued;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ProductMetadata Meta()
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
			 public const string ProductName = "ProductName";
			 public const string SupplierId = "SupplierId";
			 public const string CategoryId = "CategoryId";
			 public const string QuantityPerUnit = "QuantityPerUnit";
			 public const string UnitPrice = "UnitPrice";
			 public const string UnitsInStock = "UnitsInStock";
			 public const string UnitsOnOrder = "UnitsOnOrder";
			 public const string ReorderLevel = "ReorderLevel";
			 public const string Discontinued = "Discontinued";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string ProductName = "ProductName";
			 public const string SupplierId = "SupplierId";
			 public const string CategoryId = "CategoryId";
			 public const string QuantityPerUnit = "QuantityPerUnit";
			 public const string UnitPrice = "UnitPrice";
			 public const string UnitsInStock = "UnitsInStock";
			 public const string UnitsOnOrder = "UnitsOnOrder";
			 public const string ReorderLevel = "ReorderLevel";
			 public const string Discontinued = "Discontinued";
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
			lock (typeof(ProductMetadata))
			{
				if(ProductMetadata.mapDelegates == null)
				{
					ProductMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ProductMetadata.meta == null)
				{
					ProductMetadata.meta = new ProductMetadata();
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
				meta.AddTypeMap("ProductName", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("SupplierId", new esTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("CategoryId", new esTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("QuantityPerUnit", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("UnitPrice", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("UnitsInStock", new esTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("UnitsOnOrder", new esTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("ReorderLevel", new esTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("Discontinued", new esTypeMap("integer", "System.Int32"));			
				
				
				
				meta.Source = "Product";
				meta.Destination = "Product";
				
				meta.spInsert = "proc_ProductInsert";				
				meta.spUpdate = "proc_ProductUpdate";		
				meta.spDelete = "proc_ProductDelete";
				meta.spLoadAll = "proc_ProductLoadAll";
				meta.spLoadByPrimaryKey = "proc_ProductLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ProductMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
