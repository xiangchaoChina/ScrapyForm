/**  版本信息模板在安装目录下，可自行修改。
* spiderconfig.cs
*
* 功 能： N/A
* 类 名： spiderconfig
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/10/7 20:41:36   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace ScrapyForm.DAL
{
	/// <summary>
	/// 数据访问类:spiderconfig
	/// </summary>
	public partial class spiderconfig
	{
		public spiderconfig()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("Cid", "spiderconfig"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Cid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from spiderconfig");
			strSql.Append(" where Cid=@Cid");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Cid", MySqlDbType.Int32)
			};
			parameters[0].Value = Cid;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ScrapyForm.Model.spiderconfig model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into spiderconfig(");
			strSql.Append("ConfigName,SpiderPath,LogName,SpiderOutPut,AutoParms)");
			strSql.Append(" values (");
			strSql.Append("@ConfigName,@SpiderPath,@LogName,@SpiderOutPut,@AutoParms)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ConfigName", MySqlDbType.VarChar,100),
					new MySqlParameter("@SpiderPath", MySqlDbType.VarChar,512),
					new MySqlParameter("@LogName", MySqlDbType.VarChar,256),
					new MySqlParameter("@SpiderOutPut", MySqlDbType.VarChar,256),
					new MySqlParameter("@AutoParms", MySqlDbType.VarChar,256)};
			parameters[0].Value = model.ConfigName;
			parameters[1].Value = model.SpiderPath;
			parameters[2].Value = model.LogName;
			parameters[3].Value = model.SpiderOutPut;
			parameters[4].Value = model.AutoParms;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(ScrapyForm.Model.spiderconfig model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update spiderconfig set ");
			strSql.Append("ConfigName=@ConfigName,");
			strSql.Append("SpiderPath=@SpiderPath,");
			strSql.Append("LogName=@LogName,");
			strSql.Append("SpiderOutPut=@SpiderOutPut,");
			strSql.Append("AutoParms=@AutoParms");
			strSql.Append(" where Cid=@Cid");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ConfigName", MySqlDbType.VarChar,100),
					new MySqlParameter("@SpiderPath", MySqlDbType.VarChar,512),
					new MySqlParameter("@LogName", MySqlDbType.VarChar,256),
					new MySqlParameter("@SpiderOutPut", MySqlDbType.VarChar,256),
					new MySqlParameter("@AutoParms", MySqlDbType.VarChar,256),
					new MySqlParameter("@Cid", MySqlDbType.Int32,11)};
			parameters[0].Value = model.ConfigName;
			parameters[1].Value = model.SpiderPath;
			parameters[2].Value = model.LogName;
			parameters[3].Value = model.SpiderOutPut;
			parameters[4].Value = model.AutoParms;
			parameters[5].Value = model.Cid;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(int Cid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from spiderconfig ");
			strSql.Append(" where Cid=@Cid");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Cid", MySqlDbType.Int32)
			};
			parameters[0].Value = Cid;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string Cidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from spiderconfig ");
			strSql.Append(" where Cid in ("+Cidlist + ")  ");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
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
		public ScrapyForm.Model.spiderconfig GetModel(int Cid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Cid,ConfigName,SpiderPath,LogName,SpiderOutPut,AutoParms from spiderconfig ");
			strSql.Append(" where Cid=@Cid");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Cid", MySqlDbType.Int32)
			};
			parameters[0].Value = Cid;

			ScrapyForm.Model.spiderconfig model=new ScrapyForm.Model.spiderconfig();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ScrapyForm.Model.spiderconfig DataRowToModel(DataRow row)
		{
			ScrapyForm.Model.spiderconfig model=new ScrapyForm.Model.spiderconfig();
			if (row != null)
			{
				if(row["Cid"]!=null && row["Cid"].ToString()!="")
				{
					model.Cid=int.Parse(row["Cid"].ToString());
				}
				if(row["ConfigName"]!=null)
				{
					model.ConfigName=row["ConfigName"].ToString();
				}
				if(row["SpiderPath"]!=null)
				{
					model.SpiderPath=row["SpiderPath"].ToString();
				}
				if(row["LogName"]!=null)
				{
					model.LogName=row["LogName"].ToString();
				}
				if(row["SpiderOutPut"]!=null)
				{
					model.SpiderOutPut=row["SpiderOutPut"].ToString();
				}
				if(row["AutoParms"]!=null)
				{
					model.AutoParms=row["AutoParms"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Cid,ConfigName,SpiderPath,LogName,SpiderOutPut,AutoParms ");
			strSql.Append(" FROM spiderconfig ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM spiderconfig ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Cid desc");
			}
			strSql.Append(")AS Row, T.*  from spiderconfig T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			MySqlParameter[] parameters = {
					new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@PageSize", MySqlDbType.Int32),
					new MySqlParameter("@PageIndex", MySqlDbType.Int32),
					new MySqlParameter("@IsReCount", MySqlDbType.Bit),
					new MySqlParameter("@OrderType", MySqlDbType.Bit),
					new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
					};
			parameters[0].Value = "spiderconfig";
			parameters[1].Value = "Cid";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

