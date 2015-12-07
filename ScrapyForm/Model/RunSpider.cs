using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapyForm.Model
{
    public class RunSpider
    {
        public spider Spider { get; set; }
        public spiderconfig SpiderConfig { get; set; }
        public int RowIndex { get; set; }
    }
}
