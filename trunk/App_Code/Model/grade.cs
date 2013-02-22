
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using GS.DBUtility;//Please add references
namespace NutLab.Grade
{
	/// <summary>
	/// 类grade。
	/// </summary>
	[Serializable]
	public partial class grade
	{
		public grade()
		{}
		#region Model
		private string _studentid;
		private string _name;
		private string _idcode;
		private string _politicaltheorymark;
		private string _foreignlanguagemark;
		private string _specializedcourseonemark;
		private string _specializedcoursetwomark;
		private string _summark;
		private string _others;
		/// <summary>
		/// 
		/// </summary>
		public string studentId
		{
			set{ _studentid=value;}
			get{return _studentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string idCode
		{
			set{ _idcode=value;}
			get{return _idcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string politicalTheoryMark
		{
			set{ _politicaltheorymark=value;}
			get{return _politicaltheorymark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string foreignLanguageMark
		{
			set{ _foreignlanguagemark=value;}
			get{return _foreignlanguagemark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string specializedCourseOneMark
		{
			set{ _specializedcourseonemark=value;}
			get{return _specializedcourseonemark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string specializedCourseTwoMark
		{
			set{ _specializedcoursetwomark=value;}
			get{return _specializedcoursetwomark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sumMark
		{
			set{ _summark=value;}
			get{return _summark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string others
		{
			set{ _others=value;}
			get{return _others;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public grade(string studentId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select studentId,name,idCode,politicalTheoryMark,foreignLanguageMark,specializedCourseOneMark,specializedCourseTwoMark,sumMark,others ");
			strSql.Append(" FROM [grade2013] ");
			strSql.Append(" where studentId=@studentId ");
			SqlParameter[] parameters = {
					new SqlParameter("@studentId", SqlDbType.NVarChar,-1)};
			parameters[0].Value = studentId;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["studentId"]!=null)
				{
					this.studentId=ds.Tables[0].Rows[0]["studentId"].ToString();
				}
				if(ds.Tables[0].Rows[0]["name"]!=null)
				{
					this.name=ds.Tables[0].Rows[0]["name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["idCode"]!=null)
				{
					this.idCode=ds.Tables[0].Rows[0]["idCode"].ToString();
				}
				if(ds.Tables[0].Rows[0]["politicalTheoryMark"]!=null)
				{
					this.politicalTheoryMark=ds.Tables[0].Rows[0]["politicalTheoryMark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["foreignLanguageMark"]!=null)
				{
					this.foreignLanguageMark=ds.Tables[0].Rows[0]["foreignLanguageMark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["specializedCourseOneMark"]!=null)
				{
					this.specializedCourseOneMark=ds.Tables[0].Rows[0]["specializedCourseOneMark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["specializedCourseTwoMark"]!=null)
				{
					this.specializedCourseTwoMark=ds.Tables[0].Rows[0]["specializedCourseTwoMark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sumMark"]!=null)
				{
					this.sumMark=ds.Tables[0].Rows[0]["sumMark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["others"]!=null)
				{
					this.others=ds.Tables[0].Rows[0]["others"].ToString();
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string studentId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [grade2013]");
			strSql.Append(" where studentId=@studentId ");

			SqlParameter[] parameters = {
					new SqlParameter("@studentId", SqlDbType.NVarChar,-1)};
			parameters[0].Value = studentId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into [grade2013] (");
			strSql.Append("studentId,name,idCode,politicalTheoryMark,foreignLanguageMark,specializedCourseOneMark,specializedCourseTwoMark,sumMark,others)");
			strSql.Append(" values (");
			strSql.Append("@studentId,@name,@idCode,@politicalTheoryMark,@foreignLanguageMark,@specializedCourseOneMark,@specializedCourseTwoMark,@sumMark,@others)");
			SqlParameter[] parameters = {
					new SqlParameter("@studentId", SqlDbType.NVarChar,50),
					new SqlParameter("@name", SqlDbType.NVarChar,50),
					new SqlParameter("@idCode", SqlDbType.NVarChar,50),
					new SqlParameter("@politicalTheoryMark", SqlDbType.NVarChar,50),
					new SqlParameter("@foreignLanguageMark", SqlDbType.NVarChar,50),
					new SqlParameter("@specializedCourseOneMark", SqlDbType.NVarChar,50),
					new SqlParameter("@specializedCourseTwoMark", SqlDbType.NVarChar,50),
					new SqlParameter("@sumMark", SqlDbType.NVarChar,50),
					new SqlParameter("@others", SqlDbType.NVarChar,200)};
			parameters[0].Value = studentId;
			parameters[1].Value = name;
			parameters[2].Value = idCode;
			parameters[3].Value = politicalTheoryMark;
			parameters[4].Value = foreignLanguageMark;
			parameters[5].Value = specializedCourseOneMark;
			parameters[6].Value = specializedCourseTwoMark;
			parameters[7].Value = sumMark;
			parameters[8].Value = others;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update [grade2013] set ");
			strSql.Append("name=@name,");
			strSql.Append("idCode=@idCode,");
			strSql.Append("politicalTheoryMark=@politicalTheoryMark,");
			strSql.Append("foreignLanguageMark=@foreignLanguageMark,");
			strSql.Append("specializedCourseOneMark=@specializedCourseOneMark,");
			strSql.Append("specializedCourseTwoMark=@specializedCourseTwoMark,");
			strSql.Append("sumMark=@sumMark,");
			strSql.Append("others=@others");
			strSql.Append(" where studentId=@studentId ");
			SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.NVarChar,50),
					new SqlParameter("@idCode", SqlDbType.NVarChar,50),
					new SqlParameter("@politicalTheoryMark", SqlDbType.NVarChar,50),
					new SqlParameter("@foreignLanguageMark", SqlDbType.NVarChar,50),
					new SqlParameter("@specializedCourseOneMark", SqlDbType.NVarChar,50),
					new SqlParameter("@specializedCourseTwoMark", SqlDbType.NVarChar,50),
					new SqlParameter("@sumMark", SqlDbType.NVarChar,50),
					new SqlParameter("@others", SqlDbType.NVarChar,200),
					new SqlParameter("@studentId", SqlDbType.NVarChar,50)};
			parameters[0].Value = name;
			parameters[1].Value = idCode;
			parameters[2].Value = politicalTheoryMark;
			parameters[3].Value = foreignLanguageMark;
			parameters[4].Value = specializedCourseOneMark;
			parameters[5].Value = specializedCourseTwoMark;
			parameters[6].Value = sumMark;
			parameters[7].Value = others;
			parameters[8].Value = studentId;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string studentId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from [grade2013] ");
			strSql.Append(" where studentId=@studentId ");
			SqlParameter[] parameters = {
					new SqlParameter("@studentId", SqlDbType.NVarChar,-1)};
			parameters[0].Value = studentId;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public void GetModel(string studentId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select studentId,name,idCode,politicalTheoryMark,foreignLanguageMark,specializedCourseOneMark,specializedCourseTwoMark,sumMark,others ");
			strSql.Append(" FROM [grade2013] ");
			strSql.Append(" where studentId=@studentId ");
			SqlParameter[] parameters = {
					new SqlParameter("@studentId", SqlDbType.NVarChar,-1)};
			parameters[0].Value = studentId;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["studentId"]!=null )
				{
					this.studentId=ds.Tables[0].Rows[0]["studentId"].ToString();
				}
				if(ds.Tables[0].Rows[0]["name"]!=null )
				{
					this.name=ds.Tables[0].Rows[0]["name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["idCode"]!=null )
				{
					this.idCode=ds.Tables[0].Rows[0]["idCode"].ToString();
				}
				if(ds.Tables[0].Rows[0]["politicalTheoryMark"]!=null )
				{
					this.politicalTheoryMark=ds.Tables[0].Rows[0]["politicalTheoryMark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["foreignLanguageMark"]!=null )
				{
					this.foreignLanguageMark=ds.Tables[0].Rows[0]["foreignLanguageMark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["specializedCourseOneMark"]!=null )
				{
					this.specializedCourseOneMark=ds.Tables[0].Rows[0]["specializedCourseOneMark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["specializedCourseTwoMark"]!=null )
				{
					this.specializedCourseTwoMark=ds.Tables[0].Rows[0]["specializedCourseTwoMark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sumMark"]!=null )
				{
					this.sumMark=ds.Tables[0].Rows[0]["sumMark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["others"]!=null )
				{
					this.others=ds.Tables[0].Rows[0]["others"].ToString();
				}
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM [grade2013] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

