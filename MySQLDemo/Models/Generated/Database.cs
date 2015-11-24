﻿



















// This file was automatically generated by the PetaPoco T4 Template
// Do not make changes directly to this file - edit the template instead
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: `RCS`
//     Provider:               `MySql.Data.MySqlClient`
//     Connection String:      `Server=127.0.0.1;Database=csc_rhtx;Uid=maming;Pwd=maming;pooling=false;`
//     Schema:                 ``
//     Include Views:          `False`



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;

namespace Models.RCS
{

	public partial class RCSDB : Database
	{
		public RCSDB() 
			: base("RCS")
		{
			CommonConstruct();
		}

		public RCSDB(string connectionStringName) 
			: base(connectionStringName)
		{
			CommonConstruct();
		}
		
		partial void CommonConstruct();
		
		public interface IFactory
		{
			RCSDB GetInstance();
		}
		
		public static IFactory Factory { get; set; }
        public static RCSDB GetInstance()
        {
			if (_instance!=null)
				return _instance;
				
			if (Factory!=null)
				return Factory.GetInstance();
			else
				return new RCSDB();
        }

		[ThreadStatic] static RCSDB _instance;
		
		public override void OnBeginTransaction()
		{
			if (_instance==null)
				_instance=this;
		}
		
		public override void OnEndTransaction()
		{
			if (_instance==this)
				_instance=null;
		}
        

		public class Record<T> where T:new()
		{
			public static RCSDB repo { get { return RCSDB.GetInstance(); } }
			public bool IsNew() { return repo.IsNew(this); }
			public object Insert() { return repo.Insert(this); }

			public void Save() { repo.Save(this); }
			public int Update() { return repo.Update(this); }

			public int Update(IEnumerable<string> columns) { return repo.Update(this, columns); }
			public static int Update(string sql, params object[] args) { return repo.Update<T>(sql, args); }
			public static int Update(Sql sql) { return repo.Update<T>(sql); }
			public int Delete() { return repo.Delete(this); }
			public static int Delete(string sql, params object[] args) { return repo.Delete<T>(sql, args); }
			public static int Delete(Sql sql) { return repo.Delete<T>(sql); }
			public static int Delete(object primaryKey) { return repo.Delete<T>(primaryKey); }
			public static bool Exists(object primaryKey) { return repo.Exists<T>(primaryKey); }
			public static bool Exists(string sql, params object[] args) { return repo.Exists<T>(sql, args); }
			public static T SingleOrDefault(object primaryKey) { return repo.SingleOrDefault<T>(primaryKey); }
			public static T SingleOrDefault(string sql, params object[] args) { return repo.SingleOrDefault<T>(sql, args); }
			public static T SingleOrDefault(Sql sql) { return repo.SingleOrDefault<T>(sql); }
			public static T FirstOrDefault(string sql, params object[] args) { return repo.FirstOrDefault<T>(sql, args); }
			public static T FirstOrDefault(Sql sql) { return repo.FirstOrDefault<T>(sql); }
			public static T Single(object primaryKey) { return repo.Single<T>(primaryKey); }
			public static T Single(string sql, params object[] args) { return repo.Single<T>(sql, args); }
			public static T Single(Sql sql) { return repo.Single<T>(sql); }
			public static T First(string sql, params object[] args) { return repo.First<T>(sql, args); }
			public static T First(Sql sql) { return repo.First<T>(sql); }
			public static List<T> Fetch(string sql, params object[] args) { return repo.Fetch<T>(sql, args); }
			public static List<T> Fetch(Sql sql) { return repo.Fetch<T>(sql); }
			public static List<T> Fetch(long page, long itemsPerPage, string sql, params object[] args) { return repo.Fetch<T>(page, itemsPerPage, sql, args); }
			public static List<T> Fetch(long page, long itemsPerPage, Sql sql) { return repo.Fetch<T>(page, itemsPerPage, sql); }
			public static List<T> SkipTake(long skip, long take, string sql, params object[] args) { return repo.SkipTake<T>(skip, take, sql, args); }
			public static List<T> SkipTake(long skip, long take, Sql sql) { return repo.SkipTake<T>(skip, take, sql); }
			public static Page<T> Page(long page, long itemsPerPage, string sql, params object[] args) { return repo.Page<T>(page, itemsPerPage, sql, args); }
			public static Page<T> Page(long page, long itemsPerPage, Sql sql) { return repo.Page<T>(page, itemsPerPage, sql); }
			public static IEnumerable<T> Query(string sql, params object[] args) { return repo.Query<T>(sql, args); }
			public static IEnumerable<T> Query(Sql sql) { return repo.Query<T>(sql); }

		}

	}
	



    
	[TableName("sys_const_province")]


	[ExplicitColumns]
    public partial class sys_const_province : RCSDB.Record<sys_const_province>  
    {



		[Column] public Guid Id { get; set; }





		[Column] public int? ProvinceId { get; set; }





		[Column] public string ProvinceCode { get; set; }





		[Column] public string ProvinceName { get; set; }





		[Column] public int Rank { get; set; }





		[Column] public int? Version { get; set; }





		[Column] public bool? IsDelete { get; set; }





		[Column] public string CMCode { get; set; }



	}

    
	[TableName("sys_department")]


	[PrimaryKey("Id", autoIncrement=false)]

	[ExplicitColumns]
    public partial class sys_department : RCSDB.Record<sys_department>  
    {



		[Column] public string Id { get; set; }





		[Column] public string Name { get; set; }





		[Column] public string ParentId { get; set; }





		[Column] public int? Version { get; set; }





		[Column] public bool? IsDelete { get; set; }





		[Column] public int? ListOrder { get; set; }





		[Column] public DateTime? CreateDate { get; set; }



	}

    
	[TableName("sys_menu")]


	[PrimaryKey("ID", autoIncrement=false)]

	[ExplicitColumns]
    public partial class sys_menu : RCSDB.Record<sys_menu>  
    {



		[Column] public Guid ID { get; set; }





		[Column] public string Code { get; set; }





		[Column] public string MenuName { get; set; }





		[Column] public string Url { get; set; }





		[Column] public short MenuLevel { get; set; }





		[Column] public string Icon { get; set; }





		[Column] public string ParentId { get; set; }





		[Column] public string OpenTarget { get; set; }





		[Column] public bool? IsRight { get; set; }





		[Column] public short Sequence { get; set; }





		[Column] public int? Version { get; set; }





		[Column] public bool? IsDelete { get; set; }



	}

    
	[TableName("sys_operator")]


	[PrimaryKey("ID", autoIncrement=false)]

	[ExplicitColumns]
    public partial class sys_operator : RCSDB.Record<sys_operator>  
    {



		[Column] public Guid ID { get; set; }





		[Column] public string Code { get; set; }





		[Column] public Guid MenuID { get; set; }





		[Column] public string OperatorName { get; set; }





		[Column] public string Descript { get; set; }





		[Column] public bool? IsRight { get; set; }





		[Column] public int? Version { get; set; }





		[Column] public bool? IsDelete { get; set; }



	}

    
	[TableName("sys_role")]


	[PrimaryKey("ID", autoIncrement=false)]

	[ExplicitColumns]
    public partial class sys_role : RCSDB.Record<sys_role>  
    {



		[Column] public Guid ID { get; set; }





		[Column] public string Name { get; set; }





		[Column] public string Code { get; set; }





		[Column] public string Description { get; set; }





		[Column] public DateTime? CreateDate { get; set; }





		[Column] public int? RoleType { get; set; }





		[Column] public int? State { get; set; }





		[Column] public int? Version { get; set; }





		[Column] public bool? IsDelete { get; set; }



	}

    
	[TableName("sys_role_permisson")]


	[PrimaryKey("ID", autoIncrement=false)]

	[ExplicitColumns]
    public partial class sys_role_permisson : RCSDB.Record<sys_role_permisson>  
    {



		[Column] public Guid ID { get; set; }





		[Column] public Guid RoleID { get; set; }





		[Column] public Guid PermissonID { get; set; }





		[Column] public int PermissonType { get; set; }





		[Column] public int? Version { get; set; }





		[Column] public bool? IsDelete { get; set; }



	}

    
	[TableName("sys_role_user")]


	[PrimaryKey("ID", autoIncrement=false)]

	[ExplicitColumns]
    public partial class sys_role_user : RCSDB.Record<sys_role_user>  
    {



		[Column] public Guid ID { get; set; }





		[Column] public Guid RoleID { get; set; }





		[Column] public Guid UserID { get; set; }



	}

    
	[TableName("sys_user")]


	[PrimaryKey("ID", autoIncrement=false)]

	[ExplicitColumns]
    public partial class sys_user : RCSDB.Record<sys_user>  
    {



		[Column] public Guid ID { get; set; }





		[Column] public string LoginName { get; set; }





		[Column] public string NickName { get; set; }





		[Column] public string Pwd { get; set; }





		[Column] public string Mobile { get; set; }





		[Column] public string FetionID { get; set; }





		[Column] public string Email { get; set; }





		[Column] public DateTime? LiveDate { get; set; }





		[Column] public string Province { get; set; }





		[Column] public string Organization { get; set; }





		[Column] public string Description { get; set; }





		[Column] public DateTime? CreateDate { get; set; }





		[Column] public int? State { get; set; }





		[Column] public int? Version { get; set; }





		[Column] public sbyte? IsDelete { get; set; }





		[Column] public DateTime? LastModifyPwdDate { get; set; }





		[Column] public string Dept { get; set; }



	}


}



