﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database")]
public partial class dataclassDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void Insertlogin(login instance);
  partial void Updatelogin(login instance);
  partial void Deletelogin(login instance);
  partial void InsertTable(Table instance);
  partial void UpdateTable(Table instance);
  partial void DeleteTable(Table instance);
  #endregion
	
	public dataclassDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public dataclassDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public dataclassDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public dataclassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public dataclassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<login> logins
	{
		get
		{
			return this.GetTable<login>();
		}
	}
	
	public System.Data.Linq.Table<Table> Tables
	{
		get
		{
			return this.GetTable<Table>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.login")]
public partial class login : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _uid;
	
	private string _username;
	
	private string _password;
	
	private int _account_type;
	
	private string _security_question;
	
	private string _security_answer;
	
	private string _address;
	
	private string _contact_no;
	
	private string _email_id;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuidChanging(string value);
    partial void OnuidChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void Onaccount_typeChanging(int value);
    partial void Onaccount_typeChanged();
    partial void Onsecurity_questionChanging(string value);
    partial void Onsecurity_questionChanged();
    partial void Onsecurity_answerChanging(string value);
    partial void Onsecurity_answerChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    partial void Oncontact_noChanging(string value);
    partial void Oncontact_noChanged();
    partial void Onemail_idChanging(string value);
    partial void Onemail_idChanged();
    #endregion
	
	public login()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uid", DbType="NVarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string uid
	{
		get
		{
			return this._uid;
		}
		set
		{
			if ((this._uid != value))
			{
				this.OnuidChanging(value);
				this.SendPropertyChanging();
				this._uid = value;
				this.SendPropertyChanged("uid");
				this.OnuidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
	public string username
	{
		get
		{
			return this._username;
		}
		set
		{
			if ((this._username != value))
			{
				this.OnusernameChanging(value);
				this.SendPropertyChanging();
				this._username = value;
				this.SendPropertyChanged("username");
				this.OnusernameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string password
	{
		get
		{
			return this._password;
		}
		set
		{
			if ((this._password != value))
			{
				this.OnpasswordChanging(value);
				this.SendPropertyChanging();
				this._password = value;
				this.SendPropertyChanged("password");
				this.OnpasswordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_account_type", DbType="Int NOT NULL")]
	public int account_type
	{
		get
		{
			return this._account_type;
		}
		set
		{
			if ((this._account_type != value))
			{
				this.Onaccount_typeChanging(value);
				this.SendPropertyChanging();
				this._account_type = value;
				this.SendPropertyChanged("account_type");
				this.Onaccount_typeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_security_question", DbType="NVarChar(150)")]
	public string security_question
	{
		get
		{
			return this._security_question;
		}
		set
		{
			if ((this._security_question != value))
			{
				this.Onsecurity_questionChanging(value);
				this.SendPropertyChanging();
				this._security_question = value;
				this.SendPropertyChanged("security_question");
				this.Onsecurity_questionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_security_answer", DbType="VarChar(50)")]
	public string security_answer
	{
		get
		{
			return this._security_answer;
		}
		set
		{
			if ((this._security_answer != value))
			{
				this.Onsecurity_answerChanging(value);
				this.SendPropertyChanging();
				this._security_answer = value;
				this.SendPropertyChanged("security_answer");
				this.Onsecurity_answerChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="NVarChar(200)")]
	public string address
	{
		get
		{
			return this._address;
		}
		set
		{
			if ((this._address != value))
			{
				this.OnaddressChanging(value);
				this.SendPropertyChanging();
				this._address = value;
				this.SendPropertyChanged("address");
				this.OnaddressChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contact_no", DbType="NVarChar(15)")]
	public string contact_no
	{
		get
		{
			return this._contact_no;
		}
		set
		{
			if ((this._contact_no != value))
			{
				this.Oncontact_noChanging(value);
				this.SendPropertyChanging();
				this._contact_no = value;
				this.SendPropertyChanged("contact_no");
				this.Oncontact_noChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email_id", DbType="NVarChar(20)")]
	public string email_id
	{
		get
		{
			return this._email_id;
		}
		set
		{
			if ((this._email_id != value))
			{
				this.Onemail_idChanging(value);
				this.SendPropertyChanging();
				this._email_id = value;
				this.SendPropertyChanged("email_id");
				this.Onemail_idChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Table]")]
public partial class Table : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _suggestionid;
	
	private string _username;
	
	private string _department;
	
	private string _subject;
	
	private string _suggestion;
	
	private System.DateTime _date_time;
	
	private int _status;
	
	private string _admin1note;
	
	private string _admin2note;
	
	private string _admin3note;
	
	private int _likes;
	
	private string _suggestion_temp;
	
	private string _name;
	
	private string _like_list;
	
	private System.Nullable<int> _modstatus;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnsuggestionidChanging(int value);
    partial void OnsuggestionidChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OndepartmentChanging(string value);
    partial void OndepartmentChanged();
    partial void OnsubjectChanging(string value);
    partial void OnsubjectChanged();
    partial void OnsuggestionChanging(string value);
    partial void OnsuggestionChanged();
    partial void Ondate_timeChanging(System.DateTime value);
    partial void Ondate_timeChanged();
    partial void OnstatusChanging(int value);
    partial void OnstatusChanged();
    partial void Onadmin1noteChanging(string value);
    partial void Onadmin1noteChanged();
    partial void Onadmin2noteChanging(string value);
    partial void Onadmin2noteChanged();
    partial void Onadmin3noteChanging(string value);
    partial void Onadmin3noteChanged();
    partial void OnlikesChanging(int value);
    partial void OnlikesChanged();
    partial void Onsuggestion_tempChanging(string value);
    partial void Onsuggestion_tempChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void Onlike_listChanging(string value);
    partial void Onlike_listChanged();
    partial void OnmodstatusChanging(System.Nullable<int> value);
    partial void OnmodstatusChanged();
    #endregion
	
	public Table()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_suggestionid", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int suggestionid
	{
		get
		{
			return this._suggestionid;
		}
		set
		{
			if ((this._suggestionid != value))
			{
				this.OnsuggestionidChanging(value);
				this.SendPropertyChanging();
				this._suggestionid = value;
				this.SendPropertyChanged("suggestionid");
				this.OnsuggestionidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
	public string username
	{
		get
		{
			return this._username;
		}
		set
		{
			if ((this._username != value))
			{
				this.OnusernameChanging(value);
				this.SendPropertyChanging();
				this._username = value;
				this.SendPropertyChanged("username");
				this.OnusernameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_department", DbType="NVarChar(30)")]
	public string department
	{
		get
		{
			return this._department;
		}
		set
		{
			if ((this._department != value))
			{
				this.OndepartmentChanging(value);
				this.SendPropertyChanging();
				this._department = value;
				this.SendPropertyChanged("department");
				this.OndepartmentChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_subject", DbType="NChar(50) NOT NULL", CanBeNull=false)]
	public string subject
	{
		get
		{
			return this._subject;
		}
		set
		{
			if ((this._subject != value))
			{
				this.OnsubjectChanging(value);
				this.SendPropertyChanging();
				this._subject = value;
				this.SendPropertyChanged("subject");
				this.OnsubjectChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_suggestion", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
	public string suggestion
	{
		get
		{
			return this._suggestion;
		}
		set
		{
			if ((this._suggestion != value))
			{
				this.OnsuggestionChanging(value);
				this.SendPropertyChanging();
				this._suggestion = value;
				this.SendPropertyChanged("suggestion");
				this.OnsuggestionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[date-time]", Storage="_date_time", DbType="DateTime NOT NULL")]
	public System.DateTime date_time
	{
		get
		{
			return this._date_time;
		}
		set
		{
			if ((this._date_time != value))
			{
				this.Ondate_timeChanging(value);
				this.SendPropertyChanging();
				this._date_time = value;
				this.SendPropertyChanged("date_time");
				this.Ondate_timeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Int NOT NULL")]
	public int status
	{
		get
		{
			return this._status;
		}
		set
		{
			if ((this._status != value))
			{
				this.OnstatusChanging(value);
				this.SendPropertyChanging();
				this._status = value;
				this.SendPropertyChanged("status");
				this.OnstatusChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_admin1note", DbType="NVarChar(MAX)")]
	public string admin1note
	{
		get
		{
			return this._admin1note;
		}
		set
		{
			if ((this._admin1note != value))
			{
				this.Onadmin1noteChanging(value);
				this.SendPropertyChanging();
				this._admin1note = value;
				this.SendPropertyChanged("admin1note");
				this.Onadmin1noteChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_admin2note", DbType="NVarChar(MAX)")]
	public string admin2note
	{
		get
		{
			return this._admin2note;
		}
		set
		{
			if ((this._admin2note != value))
			{
				this.Onadmin2noteChanging(value);
				this.SendPropertyChanging();
				this._admin2note = value;
				this.SendPropertyChanged("admin2note");
				this.Onadmin2noteChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_admin3note", DbType="NVarChar(MAX)")]
	public string admin3note
	{
		get
		{
			return this._admin3note;
		}
		set
		{
			if ((this._admin3note != value))
			{
				this.Onadmin3noteChanging(value);
				this.SendPropertyChanging();
				this._admin3note = value;
				this.SendPropertyChanged("admin3note");
				this.Onadmin3noteChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_likes", DbType="Int NOT NULL")]
	public int likes
	{
		get
		{
			return this._likes;
		}
		set
		{
			if ((this._likes != value))
			{
				this.OnlikesChanging(value);
				this.SendPropertyChanging();
				this._likes = value;
				this.SendPropertyChanged("likes");
				this.OnlikesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_suggestion_temp", DbType="NVarChar(80)")]
	public string suggestion_temp
	{
		get
		{
			return this._suggestion_temp;
		}
		set
		{
			if ((this._suggestion_temp != value))
			{
				this.Onsuggestion_tempChanging(value);
				this.SendPropertyChanging();
				this._suggestion_temp = value;
				this.SendPropertyChanged("suggestion_temp");
				this.Onsuggestion_tempChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(30)")]
	public string name
	{
		get
		{
			return this._name;
		}
		set
		{
			if ((this._name != value))
			{
				this.OnnameChanging(value);
				this.SendPropertyChanging();
				this._name = value;
				this.SendPropertyChanged("name");
				this.OnnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_like_list", DbType="NVarChar(MAX)")]
	public string like_list
	{
		get
		{
			return this._like_list;
		}
		set
		{
			if ((this._like_list != value))
			{
				this.Onlike_listChanging(value);
				this.SendPropertyChanging();
				this._like_list = value;
				this.SendPropertyChanged("like_list");
				this.Onlike_listChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_modstatus", DbType="Int")]
	public System.Nullable<int> modstatus
	{
		get
		{
			return this._modstatus;
		}
		set
		{
			if ((this._modstatus != value))
			{
				this.OnmodstatusChanging(value);
				this.SendPropertyChanging();
				this._modstatus = value;
				this.SendPropertyChanged("modstatus");
				this.OnmodstatusChanged();
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
#pragma warning restore 1591