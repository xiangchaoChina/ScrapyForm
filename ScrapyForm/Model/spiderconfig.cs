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
namespace ScrapyForm.Model
{
	/// <summary>
	/// spiderconfig:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class spiderconfig
	{
		public spiderconfig()
		{}
		#region Model
		private int _cid;
		private string _configname;
		private string _spiderpath;
		private string _logname;
		private string _spideroutput;
		private string _autoparms;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int Cid
		{
			set{ _cid=value;}
			get{return _cid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ConfigName
		{
			set{ _configname=value;}
			get{return _configname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SpiderPath
		{
			set{ _spiderpath=value;}
			get{return _spiderpath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LogName
		{
			set{ _logname=value;}
			get{return _logname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SpiderOutPut
		{
			set{ _spideroutput=value;}
			get{return _spideroutput;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AutoParms
		{
			set{ _autoparms=value;}
			get{return _autoparms;}
		}
		#endregion Model

	}
}

