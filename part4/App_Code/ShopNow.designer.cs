﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ShopNow")]
public partial class ShopNowDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertCPU(CPU instance);
  partial void UpdateCPU(CPU instance);
  partial void DeleteCPU(CPU instance);
  partial void InsertHardDrive(HardDrive instance);
  partial void UpdateHardDrive(HardDrive instance);
  partial void DeleteHardDrive(HardDrive instance);
  partial void InsertMonitor(Monitor instance);
  partial void UpdateMonitor(Monitor instance);
  partial void DeleteMonitor(Monitor instance);
  partial void InsertO(O instance);
  partial void UpdateO(O instance);
  partial void DeleteO(O instance);
  partial void InsertRAM(RAM instance);
  partial void UpdateRAM(RAM instance);
  partial void DeleteRAM(RAM instance);
  partial void InsertSoundCard(SoundCard instance);
  partial void UpdateSoundCard(SoundCard instance);
  partial void DeleteSoundCard(SoundCard instance);
  partial void Insertuser(user instance);
  partial void Updateuser(user instance);
  partial void Deleteuser(user instance);
  #endregion
	
	public ShopNowDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ShopNowConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public ShopNowDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public ShopNowDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public ShopNowDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public ShopNowDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<CPU> CPUs
	{
		get
		{
			return this.GetTable<CPU>();
		}
	}
	
	public System.Data.Linq.Table<Feedback> Feedbacks
	{
		get
		{
			return this.GetTable<Feedback>();
		}
	}
	
	public System.Data.Linq.Table<HardDrive> HardDrives
	{
		get
		{
			return this.GetTable<HardDrive>();
		}
	}
	
	public System.Data.Linq.Table<Monitor> Monitors
	{
		get
		{
			return this.GetTable<Monitor>();
		}
	}
	
	public System.Data.Linq.Table<Order> Orders
	{
		get
		{
			return this.GetTable<Order>();
		}
	}
	
	public System.Data.Linq.Table<O> Os
	{
		get
		{
			return this.GetTable<O>();
		}
	}
	
	public System.Data.Linq.Table<PreMade> PreMades
	{
		get
		{
			return this.GetTable<PreMade>();
		}
	}
	
	public System.Data.Linq.Table<privatesecurity> privatesecurities
	{
		get
		{
			return this.GetTable<privatesecurity>();
		}
	}
	
	public System.Data.Linq.Table<RAM> RAMs
	{
		get
		{
			return this.GetTable<RAM>();
		}
	}
	
	public System.Data.Linq.Table<SoundCard> SoundCards
	{
		get
		{
			return this.GetTable<SoundCard>();
		}
	}
	
	public System.Data.Linq.Table<user> users
	{
		get
		{
			return this.GetTable<user>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CPU")]
public partial class CPU : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Name;
	
	private string _Cost;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnCostChanging(string value);
    partial void OnCostChanged();
    #endregion
	
	public CPU()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
	public string Name
	{
		get
		{
			return this._Name;
		}
		set
		{
			if ((this._Name != value))
			{
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._Name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cost", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
	public string Cost
	{
		get
		{
			return this._Cost;
		}
		set
		{
			if ((this._Cost != value))
			{
				this.OnCostChanging(value);
				this.SendPropertyChanging();
				this._Cost = value;
				this.SendPropertyChanged("Cost");
				this.OnCostChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Feedback")]
public partial class Feedback
{
	
	private string _User_Feedback;
	
	public Feedback()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Feedback", DbType="VarChar(300)", IsPrimaryKey = true)]
	public string User_Feedback
	{
		get
		{
			return this._User_Feedback;
		}
		set
		{
			if ((this._User_Feedback != value))
			{
				this._User_Feedback = value;
			}
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HardDrive")]
public partial class HardDrive : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Name;
	
	private string _Cost;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnCostChanging(string value);
    partial void OnCostChanged();
    #endregion
	
	public HardDrive()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
	public string Name
	{
		get
		{
			return this._Name;
		}
		set
		{
			if ((this._Name != value))
			{
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._Name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cost", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
	public string Cost
	{
		get
		{
			return this._Cost;
		}
		set
		{
			if ((this._Cost != value))
			{
				this.OnCostChanging(value);
				this.SendPropertyChanging();
				this._Cost = value;
				this.SendPropertyChanged("Cost");
				this.OnCostChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Monitor")]
public partial class Monitor : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Name;
	
	private string _Cost;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnCostChanging(string value);
    partial void OnCostChanged();
    #endregion
	
	public Monitor()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
	public string Name
	{
		get
		{
			return this._Name;
		}
		set
		{
			if ((this._Name != value))
			{
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._Name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cost", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
	public string Cost
	{
		get
		{
			return this._Cost;
		}
		set
		{
			if ((this._Cost != value))
			{
				this.OnCostChanging(value);
				this.SendPropertyChanging();
				this._Cost = value;
				this.SendPropertyChanged("Cost");
				this.OnCostChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Orders")]
public partial class Order
{
	
	private int _OS_ID;
	
	private int _CPU_ID;
	
	private int _RAM_ID;
	
	private int _HardDrive_ID;
	
	private int _Monitor_ID;
	
	private int _SoundCard_ID;
	
	private string _Cost;
	
	private string _Username;
	
	public Order()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OS_ID", DbType="Int NOT NULL")]
	public int OS_ID
	{
		get
		{
			return this._OS_ID;
		}
		set
		{
			if ((this._OS_ID != value))
			{
				this._OS_ID = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CPU_ID", DbType="Int NOT NULL")]
	public int CPU_ID
	{
		get
		{
			return this._CPU_ID;
		}
		set
		{
			if ((this._CPU_ID != value))
			{
				this._CPU_ID = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RAM_ID", DbType="Int NOT NULL")]
	public int RAM_ID
	{
		get
		{
			return this._RAM_ID;
		}
		set
		{
			if ((this._RAM_ID != value))
			{
				this._RAM_ID = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HardDrive_ID", DbType="Int NOT NULL")]
	public int HardDrive_ID
	{
		get
		{
			return this._HardDrive_ID;
		}
		set
		{
			if ((this._HardDrive_ID != value))
			{
				this._HardDrive_ID = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Monitor_ID", DbType="Int NOT NULL")]
	public int Monitor_ID
	{
		get
		{
			return this._Monitor_ID;
		}
		set
		{
			if ((this._Monitor_ID != value))
			{
				this._Monitor_ID = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoundCard_ID", DbType="Int NOT NULL")]
	public int SoundCard_ID
	{
		get
		{
			return this._SoundCard_ID;
		}
		set
		{
			if ((this._SoundCard_ID != value))
			{
				this._SoundCard_ID = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cost", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
	public string Cost
	{
		get
		{
			return this._Cost;
		}
		set
		{
			if ((this._Cost != value))
			{
				this._Cost = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Username
	{
		get
		{
			return this._Username;
		}
		set
		{
			if ((this._Username != value))
			{
				this._Username = value;
			}
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OS")]
public partial class O : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Name;
	
	private string _Cost;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnCostChanging(string value);
    partial void OnCostChanged();
    #endregion
	
	public O()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
	public string Name
	{
		get
		{
			return this._Name;
		}
		set
		{
			if ((this._Name != value))
			{
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._Name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cost", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
	public string Cost
	{
		get
		{
			return this._Cost;
		}
		set
		{
			if ((this._Cost != value))
			{
				this.OnCostChanging(value);
				this.SendPropertyChanging();
				this._Cost = value;
				this.SendPropertyChanged("Cost");
				this.OnCostChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PreMade")]
public partial class PreMade
{
	
	private int _Premade_ID;
	
	private int _OS_ID;
	
	private int _CPU_ID;
	
	private int _RAM_ID;
	
	private int _HardDrive_ID;
	
	private int _Monitor_ID;
	
	private int _SoundCard_ID;
	
	private string _Name;
	
	private string _Cost;
	
	public PreMade()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Premade_ID", DbType="Int NOT NULL")]
	public int Premade_ID
	{
		get
		{
			return this._Premade_ID;
		}
		set
		{
			if ((this._Premade_ID != value))
			{
				this._Premade_ID = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OS_ID", DbType="Int NOT NULL")]
	public int OS_ID
	{
		get
		{
			return this._OS_ID;
		}
		set
		{
			if ((this._OS_ID != value))
			{
				this._OS_ID = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CPU_ID", DbType="Int NOT NULL")]
	public int CPU_ID
	{
		get
		{
			return this._CPU_ID;
		}
		set
		{
			if ((this._CPU_ID != value))
			{
				this._CPU_ID = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RAM_ID", DbType="Int NOT NULL")]
	public int RAM_ID
	{
		get
		{
			return this._RAM_ID;
		}
		set
		{
			if ((this._RAM_ID != value))
			{
				this._RAM_ID = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HardDrive_ID", DbType="Int NOT NULL")]
	public int HardDrive_ID
	{
		get
		{
			return this._HardDrive_ID;
		}
		set
		{
			if ((this._HardDrive_ID != value))
			{
				this._HardDrive_ID = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Monitor_ID", DbType="Int NOT NULL")]
	public int Monitor_ID
	{
		get
		{
			return this._Monitor_ID;
		}
		set
		{
			if ((this._Monitor_ID != value))
			{
				this._Monitor_ID = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoundCard_ID", DbType="Int NOT NULL")]
	public int SoundCard_ID
	{
		get
		{
			return this._SoundCard_ID;
		}
		set
		{
			if ((this._SoundCard_ID != value))
			{
				this._SoundCard_ID = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
	public string Name
	{
		get
		{
			return this._Name;
		}
		set
		{
			if ((this._Name != value))
			{
				this._Name = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cost", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
	public string Cost
	{
		get
		{
			return this._Cost;
		}
		set
		{
			if ((this._Cost != value))
			{
				this._Cost = value;
			}
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.privatesecurity")]
public partial class privatesecurity
{
	
	private string _Email;
	
	private string _SecurityQuestion;
	
	private string _SecurityAnswer;
	
	public privatesecurity()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string Email
	{
		get
		{
			return this._Email;
		}
		set
		{
			if ((this._Email != value))
			{
				this._Email = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SecurityQuestion", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string SecurityQuestion
	{
		get
		{
			return this._SecurityQuestion;
		}
		set
		{
			if ((this._SecurityQuestion != value))
			{
				this._SecurityQuestion = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SecurityAnswer", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string SecurityAnswer
	{
		get
		{
			return this._SecurityAnswer;
		}
		set
		{
			if ((this._SecurityAnswer != value))
			{
				this._SecurityAnswer = value;
			}
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RAM")]
public partial class RAM : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Name;
	
	private string _Cost;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnCostChanging(string value);
    partial void OnCostChanged();
    #endregion
	
	public RAM()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
	public string Name
	{
		get
		{
			return this._Name;
		}
		set
		{
			if ((this._Name != value))
			{
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._Name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cost", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
	public string Cost
	{
		get
		{
			return this._Cost;
		}
		set
		{
			if ((this._Cost != value))
			{
				this.OnCostChanging(value);
				this.SendPropertyChanging();
				this._Cost = value;
				this.SendPropertyChanged("Cost");
				this.OnCostChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SoundCard")]
public partial class SoundCard : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Name;
	
	private string _Cost;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnCostChanging(string value);
    partial void OnCostChanged();
    #endregion
	
	public SoundCard()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
	public string Name
	{
		get
		{
			return this._Name;
		}
		set
		{
			if ((this._Name != value))
			{
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._Name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cost", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
	public string Cost
	{
		get
		{
			return this._Cost;
		}
		set
		{
			if ((this._Cost != value))
			{
				this.OnCostChanging(value);
				this.SendPropertyChanging();
				this._Cost = value;
				this.SendPropertyChanged("Cost");
				this.OnCostChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.users")]
public partial class user : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _Username;
	
	private string _Password;
	
	private string _Email;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
	
	public user()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string Username
	{
		get
		{
			return this._Username;
		}
		set
		{
			if ((this._Username != value))
			{
				this.OnUsernameChanging(value);
				this.SendPropertyChanging();
				this._Username = value;
				this.SendPropertyChanged("Username");
				this.OnUsernameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Password
	{
		get
		{
			return this._Password;
		}
		set
		{
			if ((this._Password != value))
			{
				this.OnPasswordChanging(value);
				this.SendPropertyChanging();
				this._Password = value;
				this.SendPropertyChanged("Password");
				this.OnPasswordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Email
	{
		get
		{
			return this._Email;
		}
		set
		{
			if ((this._Email != value))
			{
				this.OnEmailChanging(value);
				this.SendPropertyChanging();
				this._Email = value;
				this.SendPropertyChanged("Email");
				this.OnEmailChanged();
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
