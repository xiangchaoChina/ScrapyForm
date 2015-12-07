using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ScrapyForm
{
    public class ScrapyCommand
    {

        //将Spider Model 转成CMD 命令
        public static string ConvertModelToCmd(Model.RunSpider runspider)
        {
            StringBuilder cmdstr = new StringBuilder(" ");
            //--logfile=test.log
            //cd C:\Users\yifeitax\OneDrive\Project\Pyspider\douban && scrapy crawl douban_groupmember -o douban_groupmember.xml -t xml  -a target=252583
            if (runspider.Spider == null || runspider.SpiderConfig == null)
            {
                cmdstr.Append("");
            }
            else
            {
                //验证文件夹是否存在
                cmdstr.AppendFormat("cd {0} && scrapy crawl {1}", runspider.SpiderConfig.SpiderPath, runspider.Spider.SpiderName);
                if (!string.IsNullOrWhiteSpace(runspider.SpiderConfig.LogName))
                {
                    if (runspider.SpiderConfig.LogName.Contains("nolog"))
                    {
                        cmdstr.AppendFormat(" {0} ", runspider.SpiderConfig.LogName);
                    }
                    else
                    {
                        cmdstr.AppendFormat("  --logfile={0}", runspider.SpiderConfig.LogName);
                    }
                }
                if (!string.IsNullOrWhiteSpace(runspider.SpiderConfig.SpiderOutPut))
                {
                    cmdstr.AppendFormat(" -o {0} -t {1} ", runspider.SpiderConfig.SpiderOutPut, Path.GetExtension(runspider.SpiderConfig.SpiderOutPut).Replace(".", ""));
                }
                if (!string.IsNullOrWhiteSpace(runspider.SpiderConfig.AutoParms))
                {
                    cmdstr.AppendFormat(" -a {0} ", runspider.SpiderConfig.AutoParms);
                }

                cmdstr.Append(" &exit");
            }

            return cmdstr.ToString();
        }


        public static void RunSpiderCommand(List<string> cmdlist)
        {
            string output = string.Empty;
            //采用并行的方法来执行list 
            Parallel.ForEach(cmdlist, cmd =>
            {
                CmdHelper.RunCmd(cmd, out output);
            });
        }
    }


    public enum Info
    {
        Right,
        Loading,
        Error,
        Warning
    }
}
