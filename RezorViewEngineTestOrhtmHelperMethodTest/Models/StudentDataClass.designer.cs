﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RezorViewEngineTestOrhtmHelperMethodTest.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="StudentDatabase")]
	public partial class StudentDataClassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertStudentTable(StudentTable instance);
    partial void UpdateStudentTable(StudentTable instance);
    partial void DeleteStudentTable(StudentTable instance);
    #endregion
		
		public StudentDataClassDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["StudentDatabaseConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public StudentDataClassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StudentDataClassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StudentDataClassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StudentDataClassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<StudentTable> StudentTables
		{
			get
			{
				return this.GetTable<StudentTable>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.StudentTable")]
	public partial class StudentTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _studentID;
		
		private string _studentName;
		
		private string _studentAddress;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnstudentIDChanging(string value);
    partial void OnstudentIDChanged();
    partial void OnstudentNameChanging(string value);
    partial void OnstudentNameChanged();
    partial void OnstudentAddressChanging(string value);
    partial void OnstudentAddressChanged();
    #endregion
		
		public StudentTable()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_studentID", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string studentID
		{
			get
			{
				return this._studentID;
			}
			set
			{
				if ((this._studentID != value))
				{
					this.OnstudentIDChanging(value);
					this.SendPropertyChanging();
					this._studentID = value;
					this.SendPropertyChanged("studentID");
					this.OnstudentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_studentName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string studentName
		{
			get
			{
				return this._studentName;
			}
			set
			{
				if ((this._studentName != value))
				{
					this.OnstudentNameChanging(value);
					this.SendPropertyChanging();
					this._studentName = value;
					this.SendPropertyChanged("studentName");
					this.OnstudentNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_studentAddress", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string studentAddress
		{
			get
			{
				return this._studentAddress;
			}
			set
			{
				if ((this._studentAddress != value))
				{
					this.OnstudentAddressChanging(value);
					this.SendPropertyChanging();
					this._studentAddress = value;
					this.SendPropertyChanged("studentAddress");
					this.OnstudentAddressChanged();
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
