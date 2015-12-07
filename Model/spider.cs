/**  版本信息模板在安装目录下，可自行修改。
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
namespace ScrapyForm.Model
{
    /// <summary>
    /// spider:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class spider
    {
        public spider()
        { }
        #region Model
        private int _sid;
        private string _spidername;
        private int _spiderconfigid = -1;
        private DateTime _createtime = Convert.ToDateTime(DateTime.Now);
        private int _isdel = 1;
        /// <summary>
        /// auto_increment
        /// </summary>
        public int Sid
        {
            set { _sid = value; }
            get { return _sid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SpiderName
        {
            set { _spidername = value; }
            get { return _spidername; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int SpiderConfigID
        {
            set { _spiderconfigid = value; }
            get { return _spiderconfigid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateTime
        {
            set { _createtime = value; }
            get { return _createtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int IsDel
        {
            set { _isdel = value; }
            get { return _isdel; }
        }
        #endregion Model

    }
}

