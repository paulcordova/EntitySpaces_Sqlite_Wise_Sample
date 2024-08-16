
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2024.3.0001.1
EntitySpaces Driver  : SQLite
Date Generated       : 12-08-2024 17:29:51
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
	/// Encapsulates the 'Employee' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Employee))]	
	[XmlType("Employee")]
	public partial class Employee : esEmployee
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Employee();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 id)
		{
			var obj = new Employee();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 id, esSqlAccessType sqlAccessType)
		{
			var obj = new Employee();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("EmployeeCollection")]
	public partial class EmployeeCollection : esEmployeeCollection, IEnumerable<Employee>
	{
		public Employee FindByPrimaryKey(System.Int32 id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
				
	}



	[Serializable]	
	public partial class EmployeeQuery : esEmployeeQuery
	{
		public EmployeeQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public EmployeeQuery(string joinAlias, out EmployeeQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "EmployeeQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(EmployeeQuery query)
		{
			return EmployeeQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator EmployeeQuery(string query)
		{
			return (EmployeeQuery)EmployeeQuery.SerializeHelper.FromXml(query, typeof(EmployeeQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esEmployee : esEntity
	{
		public esEmployee()
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
			EmployeeQuery query = new EmployeeQuery();
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
		/// Maps to Employee.Id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Id
		{
			get
			{
				return base.GetSystemInt32(EmployeeMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemInt32(EmployeeMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Employee.LastName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LastName
		{
			get
			{
				return base.GetSystemString(EmployeeMetadata.ColumnNames.LastName);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeMetadata.ColumnNames.LastName, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.LastName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Employee.FirstName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String FirstName
		{
			get
			{
				return base.GetSystemString(EmployeeMetadata.ColumnNames.FirstName);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeMetadata.ColumnNames.FirstName, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.FirstName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Employee.Title
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Title
		{
			get
			{
				return base.GetSystemString(EmployeeMetadata.ColumnNames.Title);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeMetadata.ColumnNames.Title, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.Title);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Employee.TitleOfCourtesy
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String TitleOfCourtesy
		{
			get
			{
				return base.GetSystemString(EmployeeMetadata.ColumnNames.TitleOfCourtesy);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeMetadata.ColumnNames.TitleOfCourtesy, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.TitleOfCourtesy);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Employee.BirthDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String BirthDate
		{
			get
			{
				return base.GetSystemString(EmployeeMetadata.ColumnNames.BirthDate);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeMetadata.ColumnNames.BirthDate, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.BirthDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Employee.HireDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String HireDate
		{
			get
			{
				return base.GetSystemString(EmployeeMetadata.ColumnNames.HireDate);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeMetadata.ColumnNames.HireDate, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.HireDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Employee.Address
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Address
		{
			get
			{
				return base.GetSystemString(EmployeeMetadata.ColumnNames.Address);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeMetadata.ColumnNames.Address, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.Address);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Employee.City
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String City
		{
			get
			{
				return base.GetSystemString(EmployeeMetadata.ColumnNames.City);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeMetadata.ColumnNames.City, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.City);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Employee.Region
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Region
		{
			get
			{
				return base.GetSystemString(EmployeeMetadata.ColumnNames.Region);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeMetadata.ColumnNames.Region, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.Region);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Employee.PostalCode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String PostalCode
		{
			get
			{
				return base.GetSystemString(EmployeeMetadata.ColumnNames.PostalCode);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeMetadata.ColumnNames.PostalCode, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.PostalCode);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Employee.Country
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Country
		{
			get
			{
				return base.GetSystemString(EmployeeMetadata.ColumnNames.Country);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeMetadata.ColumnNames.Country, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.Country);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Employee.HomePhone
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String HomePhone
		{
			get
			{
				return base.GetSystemString(EmployeeMetadata.ColumnNames.HomePhone);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeMetadata.ColumnNames.HomePhone, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.HomePhone);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Employee.Extension
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Extension
		{
			get
			{
				return base.GetSystemString(EmployeeMetadata.ColumnNames.Extension);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeMetadata.ColumnNames.Extension, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.Extension);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Employee.Photo
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Byte[] Photo
		{
			get
			{
				return base.GetSystemByteArray(EmployeeMetadata.ColumnNames.Photo);
			}
			
			set
			{
				if(base.SetSystemByteArray(EmployeeMetadata.ColumnNames.Photo, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.Photo);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Employee.Notes
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Notes
		{
			get
			{
				return base.GetSystemString(EmployeeMetadata.ColumnNames.Notes);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeMetadata.ColumnNames.Notes, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.Notes);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Employee.ReportsTo
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? ReportsTo
		{
			get
			{
				return base.GetSystemInt32(EmployeeMetadata.ColumnNames.ReportsTo);
			}
			
			set
			{
				if(base.SetSystemInt32(EmployeeMetadata.ColumnNames.ReportsTo, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.ReportsTo);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Employee.PhotoPath
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String PhotoPath
		{
			get
			{
				return base.GetSystemString(EmployeeMetadata.ColumnNames.PhotoPath);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeMetadata.ColumnNames.PhotoPath, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.PhotoPath);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return EmployeeMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public EmployeeQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new EmployeeQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(EmployeeQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(EmployeeQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private EmployeeQuery query;		
	}



	[Serializable]
	abstract public partial class esEmployeeCollection : esEntityCollection<Employee>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return EmployeeMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "EmployeeCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public EmployeeQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new EmployeeQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(EmployeeQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new EmployeeQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(EmployeeQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((EmployeeQuery)query);
		}

		#endregion
		
		private EmployeeQuery query;
	}



	[Serializable]
	abstract public partial class esEmployeeQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return EmployeeMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "LastName": return this.LastName;
				case "FirstName": return this.FirstName;
				case "Title": return this.Title;
				case "TitleOfCourtesy": return this.TitleOfCourtesy;
				case "BirthDate": return this.BirthDate;
				case "HireDate": return this.HireDate;
				case "Address": return this.Address;
				case "City": return this.City;
				case "Region": return this.Region;
				case "PostalCode": return this.PostalCode;
				case "Country": return this.Country;
				case "HomePhone": return this.HomePhone;
				case "Extension": return this.Extension;
				case "Photo": return this.Photo;
				case "Notes": return this.Notes;
				case "ReportsTo": return this.ReportsTo;
				case "PhotoPath": return this.PhotoPath;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.Id, esSystemType.Int32); }
		} 
		
		public esQueryItem LastName
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.LastName, esSystemType.String); }
		} 
		
		public esQueryItem FirstName
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.FirstName, esSystemType.String); }
		} 
		
		public esQueryItem Title
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.Title, esSystemType.String); }
		} 
		
		public esQueryItem TitleOfCourtesy
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.TitleOfCourtesy, esSystemType.String); }
		} 
		
		public esQueryItem BirthDate
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.BirthDate, esSystemType.String); }
		} 
		
		public esQueryItem HireDate
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.HireDate, esSystemType.String); }
		} 
		
		public esQueryItem Address
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.Address, esSystemType.String); }
		} 
		
		public esQueryItem City
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.City, esSystemType.String); }
		} 
		
		public esQueryItem Region
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.Region, esSystemType.String); }
		} 
		
		public esQueryItem PostalCode
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.PostalCode, esSystemType.String); }
		} 
		
		public esQueryItem Country
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.Country, esSystemType.String); }
		} 
		
		public esQueryItem HomePhone
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.HomePhone, esSystemType.String); }
		} 
		
		public esQueryItem Extension
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.Extension, esSystemType.String); }
		} 
		
		public esQueryItem Photo
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.Photo, esSystemType.ByteArray); }
		} 
		
		public esQueryItem Notes
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.Notes, esSystemType.String); }
		} 
		
		public esQueryItem ReportsTo
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.ReportsTo, esSystemType.Int32); }
		} 
		
		public esQueryItem PhotoPath
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.PhotoPath, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class Employee : esEmployee
	{

		
		
	}
	



	[Serializable]
	public partial class EmployeeMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected EmployeeMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.Id, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = EmployeeMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.LastName, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeMetadata.PropertyNames.LastName;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.FirstName, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeMetadata.PropertyNames.FirstName;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.Title, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeMetadata.PropertyNames.Title;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.TitleOfCourtesy, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeMetadata.PropertyNames.TitleOfCourtesy;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.BirthDate, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeMetadata.PropertyNames.BirthDate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.HireDate, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeMetadata.PropertyNames.HireDate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.Address, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeMetadata.PropertyNames.Address;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.City, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeMetadata.PropertyNames.City;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.Region, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeMetadata.PropertyNames.Region;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.PostalCode, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeMetadata.PropertyNames.PostalCode;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.Country, 11, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeMetadata.PropertyNames.Country;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.HomePhone, 12, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeMetadata.PropertyNames.HomePhone;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.Extension, 13, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeMetadata.PropertyNames.Extension;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.Photo, 14, typeof(System.Byte[]), esSystemType.ByteArray);
			c.PropertyName = EmployeeMetadata.PropertyNames.Photo;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.Notes, 15, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeMetadata.PropertyNames.Notes;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.ReportsTo, 16, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = EmployeeMetadata.PropertyNames.ReportsTo;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.PhotoPath, 17, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeMetadata.PropertyNames.PhotoPath;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public EmployeeMetadata Meta()
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
			 public const string LastName = "LastName";
			 public const string FirstName = "FirstName";
			 public const string Title = "Title";
			 public const string TitleOfCourtesy = "TitleOfCourtesy";
			 public const string BirthDate = "BirthDate";
			 public const string HireDate = "HireDate";
			 public const string Address = "Address";
			 public const string City = "City";
			 public const string Region = "Region";
			 public const string PostalCode = "PostalCode";
			 public const string Country = "Country";
			 public const string HomePhone = "HomePhone";
			 public const string Extension = "Extension";
			 public const string Photo = "Photo";
			 public const string Notes = "Notes";
			 public const string ReportsTo = "ReportsTo";
			 public const string PhotoPath = "PhotoPath";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string LastName = "LastName";
			 public const string FirstName = "FirstName";
			 public const string Title = "Title";
			 public const string TitleOfCourtesy = "TitleOfCourtesy";
			 public const string BirthDate = "BirthDate";
			 public const string HireDate = "HireDate";
			 public const string Address = "Address";
			 public const string City = "City";
			 public const string Region = "Region";
			 public const string PostalCode = "PostalCode";
			 public const string Country = "Country";
			 public const string HomePhone = "HomePhone";
			 public const string Extension = "Extension";
			 public const string Photo = "Photo";
			 public const string Notes = "Notes";
			 public const string ReportsTo = "ReportsTo";
			 public const string PhotoPath = "PhotoPath";
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
			lock (typeof(EmployeeMetadata))
			{
				if(EmployeeMetadata.mapDelegates == null)
				{
					EmployeeMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (EmployeeMetadata.meta == null)
				{
					EmployeeMetadata.meta = new EmployeeMetadata();
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
				meta.AddTypeMap("LastName", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("FirstName", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Title", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("TitleOfCourtesy", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("BirthDate", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("HireDate", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Address", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("City", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Region", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("PostalCode", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Country", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("HomePhone", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Extension", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Photo", new esTypeMap("blob", "System.Byte[]"));
				meta.AddTypeMap("Notes", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("ReportsTo", new esTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("PhotoPath", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "Employee";
				meta.Destination = "Employee";
				
				meta.spInsert = "proc_EmployeeInsert";				
				meta.spUpdate = "proc_EmployeeUpdate";		
				meta.spDelete = "proc_EmployeeDelete";
				meta.spLoadAll = "proc_EmployeeLoadAll";
				meta.spLoadByPrimaryKey = "proc_EmployeeLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private EmployeeMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
