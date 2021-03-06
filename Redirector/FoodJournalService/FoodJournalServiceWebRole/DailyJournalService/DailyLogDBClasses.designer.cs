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

namespace FoodJournalServiceWebRole.DailyJournalService
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DailyLog_db")]
	public partial class DailyLogDBClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEmailReport(EmailReport instance);
    partial void UpdateEmailReport(EmailReport instance);
    partial void DeleteEmailReport(EmailReport instance);
    partial void InsertExceptionReport(ExceptionReport instance);
    partial void UpdateExceptionReport(ExceptionReport instance);
    partial void DeleteExceptionReport(ExceptionReport instance);
    partial void InsertFeedback(Feedback instance);
    partial void UpdateFeedback(Feedback instance);
    partial void DeleteFeedback(Feedback instance);
    partial void InsertPerformanceReport(PerformanceReport instance);
    partial void UpdatePerformanceReport(PerformanceReport instance);
    partial void DeletePerformanceReport(PerformanceReport instance);
    partial void InsertAppInstance(AppInstance instance);
    partial void UpdateAppInstance(AppInstance instance);
    partial void DeleteAppInstance(AppInstance instance);
    partial void InsertQuery(Query instance);
    partial void UpdateQuery(Query instance);
    partial void DeleteQuery(Query instance);
    partial void InsertWebRequest(WebRequest instance);
    partial void UpdateWebRequest(WebRequest instance);
    partial void DeleteWebRequest(WebRequest instance);
    #endregion
		
		public DailyLogDBClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DailyLog_dbConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DailyLogDBClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DailyLogDBClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DailyLogDBClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DailyLogDBClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<EmailReport> EmailReports
		{
			get
			{
				return this.GetTable<EmailReport>();
			}
		}
		
		public System.Data.Linq.Table<ExceptionReport> ExceptionReports
		{
			get
			{
				return this.GetTable<ExceptionReport>();
			}
		}
		
		public System.Data.Linq.Table<Feedback> Feedbacks
		{
			get
			{
				return this.GetTable<Feedback>();
			}
		}
		
		public System.Data.Linq.Table<PerformanceReport> PerformanceReports
		{
			get
			{
				return this.GetTable<PerformanceReport>();
			}
		}
		
		public System.Data.Linq.Table<AppInstance> AppInstances
		{
			get
			{
				return this.GetTable<AppInstance>();
			}
		}
		
		public System.Data.Linq.Table<Query> Queries
		{
			get
			{
				return this.GetTable<Query>();
			}
		}
		
		public System.Data.Linq.Table<WebRequest> WebRequests
		{
			get
			{
				return this.GetTable<WebRequest>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="DailyLog.EmailReport")]
	public partial class EmailReport : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _id;
		
		private System.Nullable<System.Guid> _appinstance;
		
		private string _email;
		
		private string _report;
		
		private System.Nullable<int> _days;
		
		private System.Nullable<System.DateTime> _timestamp;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(long value);
    partial void OnidChanged();
    partial void OnappinstanceChanging(System.Nullable<System.Guid> value);
    partial void OnappinstanceChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnreportChanging(string value);
    partial void OnreportChanged();
    partial void OndaysChanging(System.Nullable<int> value);
    partial void OndaysChanged();
    partial void OntimestampChanging(System.Nullable<System.DateTime> value);
    partial void OntimestampChanged();
    #endregion
		
		public EmailReport()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_appinstance", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> appinstance
		{
			get
			{
				return this._appinstance;
			}
			set
			{
				if ((this._appinstance != value))
				{
					this.OnappinstanceChanging(value);
					this.SendPropertyChanging();
					this._appinstance = value;
					this.SendPropertyChanged("appinstance");
					this.OnappinstanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_report", DbType="NVarChar(MAX)")]
		public string report
		{
			get
			{
				return this._report;
			}
			set
			{
				if ((this._report != value))
				{
					this.OnreportChanging(value);
					this.SendPropertyChanging();
					this._report = value;
					this.SendPropertyChanged("report");
					this.OnreportChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_days", DbType="Int")]
		public System.Nullable<int> days
		{
			get
			{
				return this._days;
			}
			set
			{
				if ((this._days != value))
				{
					this.OndaysChanging(value);
					this.SendPropertyChanging();
					this._days = value;
					this.SendPropertyChanged("days");
					this.OndaysChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_timestamp", DbType="DateTime")]
		public System.Nullable<System.DateTime> timestamp
		{
			get
			{
				return this._timestamp;
			}
			set
			{
				if ((this._timestamp != value))
				{
					this.OntimestampChanging(value);
					this.SendPropertyChanging();
					this._timestamp = value;
					this.SendPropertyChanged("timestamp");
					this.OntimestampChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="DailyLog.ExceptionReport")]
	public partial class ExceptionReport : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _id;
		
		private System.Nullable<System.Guid> _appinstance;
		
		private string _report;
		
		private System.Nullable<System.DateTime> _timestamp;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(long value);
    partial void OnidChanged();
    partial void OnappinstanceChanging(System.Nullable<System.Guid> value);
    partial void OnappinstanceChanged();
    partial void OnreportChanging(string value);
    partial void OnreportChanged();
    partial void OntimestampChanging(System.Nullable<System.DateTime> value);
    partial void OntimestampChanged();
    #endregion
		
		public ExceptionReport()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_appinstance", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> appinstance
		{
			get
			{
				return this._appinstance;
			}
			set
			{
				if ((this._appinstance != value))
				{
					this.OnappinstanceChanging(value);
					this.SendPropertyChanging();
					this._appinstance = value;
					this.SendPropertyChanged("appinstance");
					this.OnappinstanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_report", DbType="NVarChar(MAX)")]
		public string report
		{
			get
			{
				return this._report;
			}
			set
			{
				if ((this._report != value))
				{
					this.OnreportChanging(value);
					this.SendPropertyChanging();
					this._report = value;
					this.SendPropertyChanged("report");
					this.OnreportChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_timestamp", DbType="DateTime")]
		public System.Nullable<System.DateTime> timestamp
		{
			get
			{
				return this._timestamp;
			}
			set
			{
				if ((this._timestamp != value))
				{
					this.OntimestampChanging(value);
					this.SendPropertyChanging();
					this._timestamp = value;
					this.SendPropertyChanged("timestamp");
					this.OntimestampChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="DailyLog.Feedback")]
	public partial class Feedback : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _id;
		
		private System.Nullable<System.Guid> _appinstance;
		
		private string _email;
		
		private string _feedback1;
		
		private System.Nullable<System.DateTime> _timestamp;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(long value);
    partial void OnidChanged();
    partial void OnappinstanceChanging(System.Nullable<System.Guid> value);
    partial void OnappinstanceChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void Onfeedback1Changing(string value);
    partial void Onfeedback1Changed();
    partial void OntimestampChanging(System.Nullable<System.DateTime> value);
    partial void OntimestampChanged();
    #endregion
		
		public Feedback()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_appinstance", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> appinstance
		{
			get
			{
				return this._appinstance;
			}
			set
			{
				if ((this._appinstance != value))
				{
					this.OnappinstanceChanging(value);
					this.SendPropertyChanging();
					this._appinstance = value;
					this.SendPropertyChanged("appinstance");
					this.OnappinstanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="feedback", Storage="_feedback1", DbType="NVarChar(MAX)")]
		public string feedback1
		{
			get
			{
				return this._feedback1;
			}
			set
			{
				if ((this._feedback1 != value))
				{
					this.Onfeedback1Changing(value);
					this.SendPropertyChanging();
					this._feedback1 = value;
					this.SendPropertyChanged("feedback1");
					this.Onfeedback1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_timestamp", DbType="DateTime")]
		public System.Nullable<System.DateTime> timestamp
		{
			get
			{
				return this._timestamp;
			}
			set
			{
				if ((this._timestamp != value))
				{
					this.OntimestampChanging(value);
					this.SendPropertyChanging();
					this._timestamp = value;
					this.SendPropertyChanged("timestamp");
					this.OntimestampChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="DailyLog.PerformanceReport")]
	public partial class PerformanceReport : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _id;
		
		private System.Nullable<System.Guid> _appinstance;
		
		private string _report;
		
		private System.Nullable<System.DateTime> _timestamp;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(long value);
    partial void OnidChanged();
    partial void OnappinstanceChanging(System.Nullable<System.Guid> value);
    partial void OnappinstanceChanged();
    partial void OnreportChanging(string value);
    partial void OnreportChanged();
    partial void OntimestampChanging(System.Nullable<System.DateTime> value);
    partial void OntimestampChanged();
    #endregion
		
		public PerformanceReport()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_appinstance", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> appinstance
		{
			get
			{
				return this._appinstance;
			}
			set
			{
				if ((this._appinstance != value))
				{
					this.OnappinstanceChanging(value);
					this.SendPropertyChanging();
					this._appinstance = value;
					this.SendPropertyChanged("appinstance");
					this.OnappinstanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_report", DbType="NVarChar(MAX)")]
		public string report
		{
			get
			{
				return this._report;
			}
			set
			{
				if ((this._report != value))
				{
					this.OnreportChanging(value);
					this.SendPropertyChanging();
					this._report = value;
					this.SendPropertyChanged("report");
					this.OnreportChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_timestamp", DbType="DateTime")]
		public System.Nullable<System.DateTime> timestamp
		{
			get
			{
				return this._timestamp;
			}
			set
			{
				if ((this._timestamp != value))
				{
					this.OntimestampChanging(value);
					this.SendPropertyChanging();
					this._timestamp = value;
					this.SendPropertyChanged("timestamp");
					this.OntimestampChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="DailyLog.AppInstance")]
	public partial class AppInstance : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _id;
		
		private System.Nullable<System.Guid> _appinstance1;
		
		private string _istrial;
		
		private string _wpmodel;
		
		private string _wpversion;
		
		private string _locale;
		
		private string _timezone;
		
		private string _themecolor;
		
		private string _details;
		
		private System.Nullable<System.DateTime> _timestamp;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(long value);
    partial void OnidChanged();
    partial void Onappinstance1Changing(System.Nullable<System.Guid> value);
    partial void Onappinstance1Changed();
    partial void OnistrialChanging(string value);
    partial void OnistrialChanged();
    partial void OnwpmodelChanging(string value);
    partial void OnwpmodelChanged();
    partial void OnwpversionChanging(string value);
    partial void OnwpversionChanged();
    partial void OnlocaleChanging(string value);
    partial void OnlocaleChanged();
    partial void OntimezoneChanging(string value);
    partial void OntimezoneChanged();
    partial void OnthemecolorChanging(string value);
    partial void OnthemecolorChanged();
    partial void OndetailsChanging(string value);
    partial void OndetailsChanged();
    partial void OntimestampChanging(System.Nullable<System.DateTime> value);
    partial void OntimestampChanged();
    #endregion
		
		public AppInstance()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="appinstance", Storage="_appinstance1", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> appinstance1
		{
			get
			{
				return this._appinstance1;
			}
			set
			{
				if ((this._appinstance1 != value))
				{
					this.Onappinstance1Changing(value);
					this.SendPropertyChanging();
					this._appinstance1 = value;
					this.SendPropertyChanged("appinstance1");
					this.Onappinstance1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_istrial", DbType="NVarChar(25)")]
		public string istrial
		{
			get
			{
				return this._istrial;
			}
			set
			{
				if ((this._istrial != value))
				{
					this.OnistrialChanging(value);
					this.SendPropertyChanging();
					this._istrial = value;
					this.SendPropertyChanged("istrial");
					this.OnistrialChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_wpmodel", DbType="NVarChar(100)")]
		public string wpmodel
		{
			get
			{
				return this._wpmodel;
			}
			set
			{
				if ((this._wpmodel != value))
				{
					this.OnwpmodelChanging(value);
					this.SendPropertyChanging();
					this._wpmodel = value;
					this.SendPropertyChanged("wpmodel");
					this.OnwpmodelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_wpversion", DbType="NVarChar(25)")]
		public string wpversion
		{
			get
			{
				return this._wpversion;
			}
			set
			{
				if ((this._wpversion != value))
				{
					this.OnwpversionChanging(value);
					this.SendPropertyChanging();
					this._wpversion = value;
					this.SendPropertyChanged("wpversion");
					this.OnwpversionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_locale", DbType="NVarChar(25)")]
		public string locale
		{
			get
			{
				return this._locale;
			}
			set
			{
				if ((this._locale != value))
				{
					this.OnlocaleChanging(value);
					this.SendPropertyChanging();
					this._locale = value;
					this.SendPropertyChanged("locale");
					this.OnlocaleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_timezone", DbType="NVarChar(100)")]
		public string timezone
		{
			get
			{
				return this._timezone;
			}
			set
			{
				if ((this._timezone != value))
				{
					this.OntimezoneChanging(value);
					this.SendPropertyChanging();
					this._timezone = value;
					this.SendPropertyChanged("timezone");
					this.OntimezoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_themecolor", DbType="NVarChar(25)")]
		public string themecolor
		{
			get
			{
				return this._themecolor;
			}
			set
			{
				if ((this._themecolor != value))
				{
					this.OnthemecolorChanging(value);
					this.SendPropertyChanging();
					this._themecolor = value;
					this.SendPropertyChanged("themecolor");
					this.OnthemecolorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_details", DbType="NVarChar(MAX)")]
		public string details
		{
			get
			{
				return this._details;
			}
			set
			{
				if ((this._details != value))
				{
					this.OndetailsChanging(value);
					this.SendPropertyChanging();
					this._details = value;
					this.SendPropertyChanged("details");
					this.OndetailsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_timestamp", DbType="DateTime")]
		public System.Nullable<System.DateTime> timestamp
		{
			get
			{
				return this._timestamp;
			}
			set
			{
				if ((this._timestamp != value))
				{
					this.OntimestampChanging(value);
					this.SendPropertyChanging();
					this._timestamp = value;
					this.SendPropertyChanged("timestamp");
					this.OntimestampChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="DailyLog.Query")]
	public partial class Query : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _id;
		
		private System.Nullable<System.Guid> _appinstance;
		
		private string _query1;
		
		private string _locale;
		
		private System.Nullable<int> _USDACount;
		
		private System.Nullable<int> _NutritionIXCount;
		
		private System.Nullable<int> _FatsecretCount;
		
		private string _details;
		
		private System.Nullable<System.DateTime> _timestamp;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(long value);
    partial void OnidChanged();
    partial void OnappinstanceChanging(System.Nullable<System.Guid> value);
    partial void OnappinstanceChanged();
    partial void Onquery1Changing(string value);
    partial void Onquery1Changed();
    partial void OnlocaleChanging(string value);
    partial void OnlocaleChanged();
    partial void OnUSDACountChanging(System.Nullable<int> value);
    partial void OnUSDACountChanged();
    partial void OnNutritionIXCountChanging(System.Nullable<int> value);
    partial void OnNutritionIXCountChanged();
    partial void OnFatsecretCountChanging(System.Nullable<int> value);
    partial void OnFatsecretCountChanged();
    partial void OndetailsChanging(string value);
    partial void OndetailsChanged();
    partial void OntimestampChanging(System.Nullable<System.DateTime> value);
    partial void OntimestampChanged();
    #endregion
		
		public Query()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_appinstance", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> appinstance
		{
			get
			{
				return this._appinstance;
			}
			set
			{
				if ((this._appinstance != value))
				{
					this.OnappinstanceChanging(value);
					this.SendPropertyChanging();
					this._appinstance = value;
					this.SendPropertyChanged("appinstance");
					this.OnappinstanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="query", Storage="_query1", DbType="NVarChar(100)")]
		public string query1
		{
			get
			{
				return this._query1;
			}
			set
			{
				if ((this._query1 != value))
				{
					this.Onquery1Changing(value);
					this.SendPropertyChanging();
					this._query1 = value;
					this.SendPropertyChanged("query1");
					this.Onquery1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_locale", DbType="NVarChar(25)")]
		public string locale
		{
			get
			{
				return this._locale;
			}
			set
			{
				if ((this._locale != value))
				{
					this.OnlocaleChanging(value);
					this.SendPropertyChanging();
					this._locale = value;
					this.SendPropertyChanged("locale");
					this.OnlocaleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_USDACount", DbType="Int")]
		public System.Nullable<int> USDACount
		{
			get
			{
				return this._USDACount;
			}
			set
			{
				if ((this._USDACount != value))
				{
					this.OnUSDACountChanging(value);
					this.SendPropertyChanging();
					this._USDACount = value;
					this.SendPropertyChanged("USDACount");
					this.OnUSDACountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NutritionIXCount", DbType="Int")]
		public System.Nullable<int> NutritionIXCount
		{
			get
			{
				return this._NutritionIXCount;
			}
			set
			{
				if ((this._NutritionIXCount != value))
				{
					this.OnNutritionIXCountChanging(value);
					this.SendPropertyChanging();
					this._NutritionIXCount = value;
					this.SendPropertyChanged("NutritionIXCount");
					this.OnNutritionIXCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FatsecretCount", DbType="Int")]
		public System.Nullable<int> FatsecretCount
		{
			get
			{
				return this._FatsecretCount;
			}
			set
			{
				if ((this._FatsecretCount != value))
				{
					this.OnFatsecretCountChanging(value);
					this.SendPropertyChanging();
					this._FatsecretCount = value;
					this.SendPropertyChanged("FatsecretCount");
					this.OnFatsecretCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_details", DbType="NVarChar(MAX)")]
		public string details
		{
			get
			{
				return this._details;
			}
			set
			{
				if ((this._details != value))
				{
					this.OndetailsChanging(value);
					this.SendPropertyChanging();
					this._details = value;
					this.SendPropertyChanged("details");
					this.OndetailsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_timestamp", DbType="DateTime")]
		public System.Nullable<System.DateTime> timestamp
		{
			get
			{
				return this._timestamp;
			}
			set
			{
				if ((this._timestamp != value))
				{
					this.OntimestampChanging(value);
					this.SendPropertyChanging();
					this._timestamp = value;
					this.SendPropertyChanged("timestamp");
					this.OntimestampChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="DailyLog.WebRequest")]
	public partial class WebRequest : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _id;
		
		private string _ipaddress;
		
		private string _querystring;
		
		private string _referrer;
		
		private System.Nullable<System.Guid> _appinstance;
		
		private string _requestdata;
		
		private System.Nullable<System.DateTime> _timestamp;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(long value);
    partial void OnidChanged();
    partial void OnipaddressChanging(string value);
    partial void OnipaddressChanged();
    partial void OnquerystringChanging(string value);
    partial void OnquerystringChanged();
    partial void OnreferrerChanging(string value);
    partial void OnreferrerChanged();
    partial void OnappinstanceChanging(System.Nullable<System.Guid> value);
    partial void OnappinstanceChanged();
    partial void OnrequestdataChanging(string value);
    partial void OnrequestdataChanged();
    partial void OntimestampChanging(System.Nullable<System.DateTime> value);
    partial void OntimestampChanged();
    #endregion
		
		public WebRequest()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ipaddress", DbType="NVarChar(20)")]
		public string ipaddress
		{
			get
			{
				return this._ipaddress;
			}
			set
			{
				if ((this._ipaddress != value))
				{
					this.OnipaddressChanging(value);
					this.SendPropertyChanging();
					this._ipaddress = value;
					this.SendPropertyChanged("ipaddress");
					this.OnipaddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_querystring", DbType="NVarChar(20)")]
		public string querystring
		{
			get
			{
				return this._querystring;
			}
			set
			{
				if ((this._querystring != value))
				{
					this.OnquerystringChanging(value);
					this.SendPropertyChanging();
					this._querystring = value;
					this.SendPropertyChanged("querystring");
					this.OnquerystringChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_referrer", DbType="NVarChar(MAX)")]
		public string referrer
		{
			get
			{
				return this._referrer;
			}
			set
			{
				if ((this._referrer != value))
				{
					this.OnreferrerChanging(value);
					this.SendPropertyChanging();
					this._referrer = value;
					this.SendPropertyChanged("referrer");
					this.OnreferrerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_appinstance", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> appinstance
		{
			get
			{
				return this._appinstance;
			}
			set
			{
				if ((this._appinstance != value))
				{
					this.OnappinstanceChanging(value);
					this.SendPropertyChanging();
					this._appinstance = value;
					this.SendPropertyChanged("appinstance");
					this.OnappinstanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_requestdata", DbType="NVarChar(MAX)")]
		public string requestdata
		{
			get
			{
				return this._requestdata;
			}
			set
			{
				if ((this._requestdata != value))
				{
					this.OnrequestdataChanging(value);
					this.SendPropertyChanging();
					this._requestdata = value;
					this.SendPropertyChanged("requestdata");
					this.OnrequestdataChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_timestamp", DbType="DateTime")]
		public System.Nullable<System.DateTime> timestamp
		{
			get
			{
				return this._timestamp;
			}
			set
			{
				if ((this._timestamp != value))
				{
					this.OntimestampChanging(value);
					this.SendPropertyChanging();
					this._timestamp = value;
					this.SendPropertyChanged("timestamp");
					this.OntimestampChanged();
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
