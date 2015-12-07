using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrapyForm.Common
{
    public static class CommonHelper
    {

        public static Bitmap GetImgageByName(string imagename, Form form)
        {
            //Assembly assem=typeof(Resources).Assembly
            Assembly assem = form.GetType().Assembly;
            ResourceManager resman = new ResourceManager("ScrapyForm.Properties.Resources", assem);
            return (Bitmap)resman.GetObject(imagename);
        }

    }
}
