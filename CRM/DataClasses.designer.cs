﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRM
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="tas")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 擴充性方法定義
    partial void OnCreated();
    partial void Insertmytable(mytable instance);
    partial void Updatemytable(mytable instance);
    partial void Deletemytable(mytable instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::CRM.Properties.Settings.Default.tasConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<mytable> mytable
		{
			get
			{
				return this.GetTable<mytable>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.mytable")]
	public partial class mytable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _first_name;
		
		private string _last_name;
		
		private string _nick_name;
		
		private string _phone_number;
		
		private int _phone_number_cat;
		
		private string _phone_number2;
		
		private System.Nullable<int> _phone_number2_cat;
		
		private string _email;
		
		private string _adress;
		
		private string _describe;
		
		private string _icon;
		
		private string _id;
		
		private System.Nullable<int> _displayed;
		
    #region 擴充性方法定義
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onfirst_nameChanging(string value);
    partial void Onfirst_nameChanged();
    partial void Onlast_nameChanging(string value);
    partial void Onlast_nameChanged();
    partial void Onnick_nameChanging(string value);
    partial void Onnick_nameChanged();
    partial void Onphone_numberChanging(string value);
    partial void Onphone_numberChanged();
    partial void Onphone_number_catChanging(int value);
    partial void Onphone_number_catChanged();
    partial void Onphone_number2Changing(string value);
    partial void Onphone_number2Changed();
    partial void Onphone_number2_catChanging(System.Nullable<int> value);
    partial void Onphone_number2_catChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnadressChanging(string value);
    partial void OnadressChanged();
    partial void OndescribeChanging(string value);
    partial void OndescribeChanged();
    partial void OniconChanging(string value);
    partial void OniconChanged();
    partial void OnidChanging(string value);
    partial void OnidChanged();
    partial void OndisplayedChanging(System.Nullable<int> value);
    partial void OndisplayedChanged();
    #endregion
		
		public mytable()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_first_name", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string first_name
		{
			get
			{
				return this._first_name;
			}
			set
			{
				if ((this._first_name != value))
				{
					this.Onfirst_nameChanging(value);
					this.SendPropertyChanging();
					this._first_name = value;
					this.SendPropertyChanged("first_name");
					this.Onfirst_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_last_name", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string last_name
		{
			get
			{
				return this._last_name;
			}
			set
			{
				if ((this._last_name != value))
				{
					this.Onlast_nameChanging(value);
					this.SendPropertyChanging();
					this._last_name = value;
					this.SendPropertyChanged("last_name");
					this.Onlast_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nick_name", DbType="NChar(10)")]
		public string nick_name
		{
			get
			{
				return this._nick_name;
			}
			set
			{
				if ((this._nick_name != value))
				{
					this.Onnick_nameChanging(value);
					this.SendPropertyChanging();
					this._nick_name = value;
					this.SendPropertyChanged("nick_name");
					this.Onnick_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone_number", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string phone_number
		{
			get
			{
				return this._phone_number;
			}
			set
			{
				if ((this._phone_number != value))
				{
					this.Onphone_numberChanging(value);
					this.SendPropertyChanging();
					this._phone_number = value;
					this.SendPropertyChanged("phone_number");
					this.Onphone_numberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone_number_cat", DbType="Int NOT NULL")]
		public int phone_number_cat
		{
			get
			{
				return this._phone_number_cat;
			}
			set
			{
				if ((this._phone_number_cat != value))
				{
					this.Onphone_number_catChanging(value);
					this.SendPropertyChanging();
					this._phone_number_cat = value;
					this.SendPropertyChanged("phone_number_cat");
					this.Onphone_number_catChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone_number2", DbType="NChar(10)")]
		public string phone_number2
		{
			get
			{
				return this._phone_number2;
			}
			set
			{
				if ((this._phone_number2 != value))
				{
					this.Onphone_number2Changing(value);
					this.SendPropertyChanging();
					this._phone_number2 = value;
					this.SendPropertyChanged("phone_number2");
					this.Onphone_number2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone_number2_cat", DbType="Int")]
		public System.Nullable<int> phone_number2_cat
		{
			get
			{
				return this._phone_number2_cat;
			}
			set
			{
				if ((this._phone_number2_cat != value))
				{
					this.Onphone_number2_catChanging(value);
					this.SendPropertyChanging();
					this._phone_number2_cat = value;
					this.SendPropertyChanged("phone_number2_cat");
					this.Onphone_number2_catChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NChar(255)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adress", DbType="NChar(255)")]
		public string adress
		{
			get
			{
				return this._adress;
			}
			set
			{
				if ((this._adress != value))
				{
					this.OnadressChanging(value);
					this.SendPropertyChanging();
					this._adress = value;
					this.SendPropertyChanged("adress");
					this.OnadressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_describe", DbType="NChar(255)")]
		public string describe
		{
			get
			{
				return this._describe;
			}
			set
			{
				if ((this._describe != value))
				{
					this.OndescribeChanging(value);
					this.SendPropertyChanging();
					this._describe = value;
					this.SendPropertyChanged("describe");
					this.OndescribeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_icon", DbType="NChar(10)")]
		public string icon
		{
			get
			{
				return this._icon;
			}
			set
			{
				if ((this._icon != value))
				{
					this.OniconChanging(value);
					this.SendPropertyChanging();
					this._icon = value;
					this.SendPropertyChanged("icon");
					this.OniconChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="NChar(255) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_displayed", DbType="Int")]
		public System.Nullable<int> displayed
		{
			get
			{
				return this._displayed;
			}
			set
			{
				if ((this._displayed != value))
				{
					this.OndisplayedChanging(value);
					this.SendPropertyChanging();
					this._displayed = value;
					this.SendPropertyChanged("displayed");
					this.OndisplayedChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
