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



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Slideshow")]
public partial class SlideshowDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  #endregion
	
	public SlideshowDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SlideshowConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public SlideshowDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public SlideshowDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public SlideshowDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public SlideshowDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Image> Images
	{
		get
		{
			return this.GetTable<Image>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Image")]
public partial class Image
{
	
	private int _Image_ID;
	
	private string _Image_URL;
	
	private string _Image_Caption;
	
	public Image()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image_ID", DbType="Int NOT NULL")]
	public int Image_ID
	{
		get
		{
			return this._Image_ID;
		}
		set
		{
			if ((this._Image_ID != value))
			{
				this._Image_ID = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image_URL", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Image_URL
	{
		get
		{
			return this._Image_URL;
		}
		set
		{
			if ((this._Image_URL != value))
			{
				this._Image_URL = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image_Caption", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Image_Caption
	{
		get
		{
			return this._Image_Caption;
		}
		set
		{
			if ((this._Image_Caption != value))
			{
				this._Image_Caption = value;
			}
		}
	}
}
#pragma warning restore 1591
