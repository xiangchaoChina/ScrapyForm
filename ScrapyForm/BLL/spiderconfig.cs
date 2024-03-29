﻿/**  版本信息模板在安装目录下，可自行修改。
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
using System.Collections.Generic;
using Maticsoft.Common;
using ScrapyForm.Model;
namespace ScrapyForm.BLL
{
	/// <summary>
	/// spiderconfig
	/// </summary>
	public partial class spiderconfig
	{
		private readonly ScrapyForm.DAL.spiderconfig dal=new ScrapyForm.DAL.spiderconfig();
		public spiderconfig()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Cid)
		{
			return dal.Exists(Cid);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ScrapyForm.Model.spiderconfig model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(ScrapyForm.Model.spiderconfig model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Cid)
		{
			
			return dal.Delete(Cid);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string Cidlist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(Cidlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ScrapyForm.Model.spiderconfig GetModel(int Cid)
		{
			
			return dal.GetModel(Cid);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public ScrapyForm.Model.spiderconfig GetModelByCache(int Cid)
		{
			
			string CacheKey = "spiderconfigModel-" + Cid;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Cid);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (ScrapyForm.Model.spiderconfig)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ScrapyForm.Model.spiderconfig> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ScrapyForm.Model.spiderconfig> DataTableToList(DataTable dt)
		{
			List<ScrapyForm.Model.spiderconfig> modelList = new List<ScrapyForm.Model.spiderconfig>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ScrapyForm.Model.spiderconfig model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

