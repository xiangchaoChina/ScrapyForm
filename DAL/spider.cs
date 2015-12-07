﻿/**  版本信息模板在安装目录下，可自行修改。
* spider.cs
*
* 功 能： N/A
* 类 名： spider
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
	/// 数据访问类:spider
	/// </summary>
	public partial class spider
	{
		public spider()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("Sid", "spider"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Sid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from spider");
			strSql.Append(" where Sid=@Sid");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Sid", MySqlDbType.Int32)
			};
			parameters[0].Value = Sid;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ScrapyForm.Model.spider model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into spider(");
			strSql.Append("SpiderName,SpiderConfigID,CreateTime,IsDel)");
			strSql.Append(" values (");
			strSql.Append("@SpiderName,@SpiderConfigID,@CreateTime,@IsDel)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@SpiderName", MySqlDbType.VarChar,100),
					new MySqlParameter("@SpiderConfigID", MySqlDbType.Int32,11),
					new MySqlParameter("@CreateTime", MySqlDbType.DateTime),
					new MySqlParameter("@IsDel", MySqlDbType.Int32,4)};
			parameters[0].Value = model.SpiderName;
			parameters[1].Value = model.SpiderConfigID;
			parameters[2].Value = model.CreateTime;
			parameters[3].Value = model.IsDel;

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
		public bool Update(ScrapyForm.Model.spider model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update spider set ");
			strSql.Append("SpiderName=@SpiderName,");
			strSql.Append("SpiderConfigID=@SpiderConfigID,");
			strSql.Append("CreateTime=@CreateTime,");
			strSql.Append("IsDel=@IsDel");
			strSql.Append(" where Sid=@Sid");
			MySqlParameter[] parameters = {
					new MySqlParameter("@SpiderName", MySqlDbType.VarChar,100),
					new MySqlParameter("@SpiderConfigID", MySqlDbType.Int32,11),
					new MySqlParameter("@CreateTime", MySqlDbType.DateTime),
					new MySqlParameter("@IsDel", MySqlDbType.Int32,4),
					new MySqlParameter("@Sid", MySqlDbType.Int32,11)};
			parameters[0].Value = model.SpiderName;
			parameters[1].Value = model.SpiderConfigID;
			parameters[2].Value = model.CreateTime;
			parameters[3].Value = model.IsDel;
			parameters[4].Value = model.Sid;

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
		public bool Delete(int Sid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from spider ");
			strSql.Append(" where Sid=@Sid");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Sid", MySqlDbType.Int32)
			};
			parameters[0].Value = Sid;

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
		public bool DeleteList(string Sidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from spider ");
			strSql.Append(" where Sid in ("+Sidlist + ")  ");
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
		public ScrapyForm.Model.spider GetModel(int Sid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Sid,SpiderName,SpiderConfigID,CreateTime,IsDel from spider ");
			strSql.Append(" where Sid=@Sid");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Sid", MySqlDbType.Int32)
			};
			parameters[0].Value = Sid;

			ScrapyForm.Model.spider model=new ScrapyForm.Model.spider();
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
		public ScrapyForm.Model.spider DataRowToModel(DataRow row)
		{
			ScrapyForm.Model.spider model=new ScrapyForm.Model.spider();
			if (row != null)
			{
				if(row["Sid"]!=null && row["Sid"].ToString()!="")
				{
					model.Sid=int.Parse(row["Sid"].ToString());
				}
				if(row["SpiderName"]!=null)
				{
					model.SpiderName=row["SpiderName"].ToString();
				}
				if(row["SpiderConfigID"]!=null && row["SpiderConfigID"].ToString()!="")
				{
					model.SpiderConfigID=int.Parse(row["SpiderConfigID"].ToString());
				}
				if(row["CreateTime"]!=null && row["CreateTime"].ToString()!="")
				{
					model.CreateTime=DateTime.Parse(row["CreateTime"].ToString());
				}
				if(row["IsDel"]!=null && row["IsDel"].ToString()!="")
				{
					model.IsDel=int.Parse(row["IsDel"].ToString());
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
			strSql.Append("select Sid,SpiderName,SpiderConfigID,CreateTime,IsDel ");
			strSql.Append(" FROM spider ");
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
			strSql.Append("select count(1) FROM spider ");
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
				strSql.Append("order by T.Sid desc");
			}
			strSql.Append(")AS Row, T.*  from spider T ");
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
			parameters[0].Value = "spider";
			parameters[1].Value = "Sid";
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

