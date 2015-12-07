using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using ScrapyForm.Model;
using ScrapyForm.BLL;
using System.Resources;
using System.Reflection;
using ScrapyForm.Common;

namespace ScrapyForm
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        ScrapyForm.BLL.spiderconfig bllspiderconfig = new BLL.spiderconfig();
        ScrapyForm.BLL.spider bllspider = new BLL.spider();

        private ComboBox cbxcurrent;
        private void btnselectpath_Click(object sender, EventArgs e)
        {
            fbdselectpath.ShowDialog();

            txtselectpath.Text = fbdselectpath.SelectedPath;

            btnspiderinit.Enabled = true;
        }

        private void btnspiderinit_Click(object sender, EventArgs e)
        {
            List<string> listspider = new List<string>();
            if (string.IsNullOrEmpty(txtselectpath.Text) || !Directory.Exists(txtselectpath.Text))
            {
                NoteInfo(Info.Error, "未能发现爬虫文件夹!");
                return;
            }

            if (Directory.GetFiles(txtselectpath.Text).Where(x => x.ToLower().Contains("scrapy.cfg")).Count() < 1)
            {
                NoteInfo(Info.Error, "未能发现爬虫配置文件!");
                return;
            }

            string foldername = Path.GetFileNameWithoutExtension(txtselectpath.Text);

            string spiderpath = string.Format("{0}\\{1}\\{2}", txtselectpath.Text, foldername, "spiders");


            var arrfile = Directory.GetFiles(spiderpath, "*.py");

            if (arrfile == null || arrfile.Count() < 1)
            {
                NoteInfo(Info.Error, "未能发现爬虫文件夹内爬虫文件!");
                return;
            }

            Array.ForEach(arrfile, fileinfo =>
            {
                //name = 'cnblogsnexx'
                string tmpfile = File.ReadAllText(fileinfo);

                var ma = Regex.Match(tmpfile, @"name.?=.?[""'](.*?)[""']");

                if (ma.Success)
                {
                    listspider.Add(ma.Groups[1].Value);
                }
            });
            cbxspider.DataSource = listspider.Distinct().Where(x => !string.IsNullOrWhiteSpace(x)).ToList();

            return;
        }

        private void cbxlog_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxlog.SelectedItem.ToString().Contains("nolog") || cbxlog.SelectedItem.ToString().Contains("无"))
            {
                txtlogname.Hide();
            }
            else
            {
                txtlogname.Show();
            }
        }

        private void cbxoutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbxoutput.SelectedItem.ToString().Contains("无"))
            {
                txtoutputname.Show();
            }
            else
            {
                txtoutputname.Hide();
            }
        }

        private void btnstartspider_Click(object sender, EventArgs e)
        {
            Task taskcmd = new Task(RunSpider);
            taskcmd.Start();
        }

        private void RunSpider()
        {
            bool res = true;
            List<Model.RunSpider> runspiderlist = new List<RunSpider>();
            List<string> cmdlist = new List<string>();


            //frist get the select one 

            for (int i = 0; i < dgvconfigspider.Rows.Count; i++)
            {
                //check if it is select 
                if (Convert.ToBoolean(dgvconfigspider.Rows[i].Cells["IsSelect"].EditedFormattedValue))
                {

                    //dgvconfigspider.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    int spiderid = Convert.ToInt32(dgvconfigspider.Rows[i].Cells["Sid"].Value);
                    int configID = Convert.ToInt32(dgvconfigspider.Rows[i].Cells["SpiderConfigID"].Value);
                    Model.RunSpider runspider = new RunSpider();
                    runspider.RowIndex = i;
                    runspider.Spider = bllspider.GetModel(spiderid);
                    runspider.SpiderConfig = bllspiderconfig.GetModel(configID);
                    runspiderlist.Add(runspider);
                }
            }

            if (runspiderlist.Count < 1)
            {
                NoteInfo(Info.Warning, "未选中任何一行爬虫，请重试!");
                return;
            }

            //then generate the sqlscript
            runspiderlist.ForEach(x =>
            {
                var cmd = ScrapyCommand.ConvertModelToCmd(x);
                cmdlist.Add(cmd);
            });

            btnstartspider.Invoke((EventHandler)delegate
            {
                btnstartspider.Enabled = false;
            });
            NoteInfo(Info.Loading, "多线程执行中...");
            try
            {
                ScrapyCommand.RunSpiderCommand(cmdlist);
            }
            catch (Exception ex)
            {

                NoteInfo(Info.Error, ex.ToString());
                res = true;
            }
            finally
            {
                btnstartspider.Invoke((EventHandler)delegate
                {
                    btnstartspider.Enabled = true;
                });

            }
            NoteInfo(Info.Right, "执行成功，请查看文件");
        }




        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadSpider();
        }


        private void LoadSpider()
        {
            //udpate the dgv inside combox data 
            this.spiderconfigTableAdapter.Fill(this.spidercenterDataSet.spiderconfig);
            List<Model.spider> list = new List<Model.spider>();
            BLL.spider spiderbll = new BLL.spider();
            list = spiderbll.GetModelList("");
            dgvconfigspider.DataSource = list;

        }

        //全选
        private void dgvconfigspider_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //DataGridView dgv = (DataGridView)sender;
            if (e.ColumnIndex == 0)
            {
                dgvconfigspider.EndEdit();
                for (int i = 0; i < dgvconfigspider.Rows.Count; i++)
                {
                    dgvconfigspider.Rows[i].Cells[0].Value = 1;
                }
            }
        }

        //全不选
        private void dgvconfigspider_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (e.ColumnIndex == 0)
            {
                dgvconfigspider.EndEdit();
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    dgvconfigspider.Rows[i].Cells[0].Value = 0;
                }
            }
        }

        //整行选中进入编辑模式
        private void dgvconfigspider_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                DataGridView dgvcurrnet = sender as DataGridView;
                var rowindex = e.RowIndex;
                DataGridViewRow row = dgvconfigspider.Rows[rowindex];
                var spiderConfigID = Convert.ToInt32(row.Cells["SpiderConfigID"].Value);
                var sid = Convert.ToInt32(row.Cells["Sid"].Value);
                Model.spiderconfig config = bllspiderconfig.GetModel(spiderConfigID);
                Model.spider spidermodel = bllspider.GetModel(sid);
                if (config != null && config.Cid > 0)
                {
                    txtselectpath.Text = config.SpiderPath;
                    cbxspider.DataSource = null;
                    cbxspider.Items.Clear();
                    cbxspider.Items.Insert(0, spidermodel.SpiderName);
                    cbxspider.SelectedIndex = 0;
                    if (!string.IsNullOrEmpty(config.LogName))
                    {
                        cbxlog.SelectedItem = Path.GetExtension(config.LogName);

                        if (config.LogName.Contains("nolog"))
                        {
                            cbxlog.SelectedItem = config.LogName;
                        }
                        txtlogname.Text = Path.GetFileNameWithoutExtension(config.LogName);
                    }

                    if (!string.IsNullOrEmpty(config.SpiderOutPut))
                    {
                        cbxoutput.SelectedItem = Path.GetExtension(config.SpiderOutPut);
                        txtoutputname.Text = Path.GetFileNameWithoutExtension(config.SpiderOutPut);
                    }
                    txtconfigname.Text = config.ConfigName;
                    txtautoparms.Text = config.AutoParms;
                    lblhidconfigid.Text = config.Cid.ToString();

                    NoteInfo(Info.Right, "当前成功选中行:" + (e.RowIndex + 1).ToString());
                }


            }
            catch (Exception ex)
            {
                NoteInfo(Info.Error, "出现未知错误:" + ex.ToString());
            }

        }

        //button click the value 
        private void dgvconfigspider_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == 0)
            {
                return;
            }
            string buttontext = string.Empty;
            if (dgvconfigspider.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                buttontext = dgvconfigspider.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
            //If button is save 
            if (buttontext.ToLower() == "save")
            {
                int spiderid = Convert.ToInt32(dgvconfigspider.Rows[e.RowIndex].Cells["Sid"].Value);
                DialogResult res = MessageBox.Show("确定保存?", "编辑提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    //update the model 
                    Model.spider currentspider = bllspider.GetModel(spiderid);
                    if (currentspider != null && currentspider.Sid > 0)
                    {

                        int configid = Convert.ToInt32(dgvconfigspider.Rows[e.RowIndex].Cells["SpiderConfigID"].Value);
                        currentspider.IsDel = Convert.ToInt32(dgvconfigspider.Rows[e.RowIndex].Cells["IsDel"].Value);
                        currentspider.SpiderConfigID = configid;
                        currentspider.SpiderName = dgvconfigspider.Rows[e.RowIndex].Cells["SpiderName"].Value.ToString();
                        if (bllspider.Update(currentspider))
                        {
                            NoteInfo(Info.Right);
                            LoadSpider();
                        }

                    }

                }
            }
            //MessageBox.Show(buttontext);
        }



        private void dgvconfigspider_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            //判断相应的列
            if (dgv.CurrentCell.GetType().Name == "DataGridViewComboBoxCell" && dgv.CurrentCell.RowIndex != -1 && dgv.CurrentCell.ColumnIndex == dgv.Rows[0].Cells["SpiderConfigID"].ColumnIndex)
            {

                //给这个DataGridViewComboBoxCell加上下拉事件
                //(e.Control as ComboBox).SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
                cbxcurrent = e.Control as ComboBox;
                dgv.CurrentCell.Value = cbxcurrent.SelectedValue;
            }
        }

        private void btnaddnewrow_Click(object sender, EventArgs e)
        {
            //
            //dgvconfigspider.Rows.Add("0","0");
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            LoadSpider();
        }


        //edit the config spider model 
        private void btnconfigedit_Click(object sender, EventArgs e)
        {
            int spiderconfigid = Convert.ToInt32(lblhidconfigid.Text.ToString());
            if (spiderconfigid == 0)
            {
                return;
            }
            Model.spiderconfig spiderconfig = bllspiderconfig.GetModel(spiderconfigid);
            if (spiderconfig == null || spiderconfig.Cid < 1)
            {
                return;
            }

            spiderconfig.ConfigName = txtconfigname.Text.Trim();
            spiderconfig.SpiderPath = txtselectpath.Text.Trim();
            spiderconfig.AutoParms = txtautoparms.Text.Trim();
            spiderconfig.LogName = "";
            spiderconfig.SpiderOutPut = "";
            if (txtlogname.Visible)
            {
                spiderconfig.LogName = txtlogname.Text.Trim() + cbxlog.SelectedItem.ToString();
            }
            if (cbxlog.SelectedItem.ToString().Contains("nolog") && !txtlogname.Visible)
            {
                spiderconfig.LogName = cbxlog.SelectedItem.ToString();
            }

            if (txtoutputname.Visible)
            {
                spiderconfig.SpiderOutPut = txtoutputname.Text.Trim() + cbxoutput.SelectedItem.ToString();
            }

            if (bllspiderconfig.Update(spiderconfig))
            {
                NoteInfo(Info.Right, "更新方案成功");
                LoadSpider();
            }
            else
            {
                NoteInfo(Info.Error, "更新方案失败");
            }

        }


        private void NoteInfo(Info info)
        {

            string message = string.Empty;
            string ico = string.Empty;
            if (info == Info.Right)
            {
                ico = "Right";
                message = "操作成功!";
            }
            else if (info == Info.Error)
            {
                ico = "Error";
                message = "操作失败";
            }

            else if (info == Info.Warning)
            {
                ico = "Warning";
                message = "操作警告";
            }
            else if (info == Info.Loading)
            {
                ico = "Loading";
                message = "正在执行";
            }

            //stglblprocess.Image = 
            stglblprocess.Image = CommonHelper.GetImgageByName(ico, this);
            stglblprocess.Visible = true;
            stglblinfo.Visible = true;
            stglblinfo.Text = message;

        }


        private void NoteInfo(Info info, string message)
        {
            string ico = string.Empty;
            if (info == Info.Right)
            {
                ico = "Right";
            }
            else if (info == Info.Error)
            {
                ico = "Error";
            }

            else if (info == Info.Warning)
            {
                ico = "Warning";
            }
            else if (info == Info.Loading)
            {
                ico = "Loading";
            }

            //stglblprocess.Image = 
            stglblprocess.Image = CommonHelper.GetImgageByName(ico, this);
            stglblprocess.Visible = true;
            stglblinfo.Visible = true;
            stglblinfo.Text = message;
        }

        private void btnaddspdier_Click(object sender, EventArgs e)
        {
            
            //int cid = 1;
            int cid = bllspiderconfig.GetMaxId();
            if (cbxspider.SelectedItem == null)
            {
                NoteInfo(Info.Warning, "当前列表为空!");
                return;
            }
            Model.spider curspider = new Model.spider();
            curspider.SpiderName = cbxspider.SelectedItem.ToString();
            curspider.SpiderConfigID = cid;
            curspider.IsDel = 0;
            if (bllspider.Add(curspider))
            {
                NoteInfo(Info.Right, "添加新Spider成功!");
            }
            else
            {
                NoteInfo(Info.Error, "添加新Spider失败!");
            }

            //判断文件夹下的项目名字spider都是否唯一
        }

        //AddConfig
        private void btnaddconfig_Click(object sender, EventArgs e)
        {
            NoteInfo(Info.Loading, "增加方案中...");
            try
            {

                Model.spiderconfig spiderconfig = new Model.spiderconfig();
                spiderconfig.ConfigName = txtconfigname.Text.Trim();
                spiderconfig.SpiderPath = txtselectpath.Text.Trim();
                spiderconfig.AutoParms = txtautoparms.Text.Trim();
                spiderconfig.LogName = "";
                spiderconfig.SpiderOutPut = "";
                if (txtlogname.Visible)
                {
                    spiderconfig.LogName = txtlogname.Text.Trim() + cbxlog.SelectedItem.ToString();
                }
                if (cbxlog.SelectedItem.ToString().Contains("nolog") && !txtlogname.Visible)
                {
                    spiderconfig.LogName = cbxlog.SelectedItem.ToString();
                }

                if (txtoutputname.Visible)
                {
                    spiderconfig.SpiderOutPut = txtoutputname.Text.Trim() + cbxoutput.SelectedItem.ToString();
                }

                if (bllspiderconfig.Add(spiderconfig))
                {
                    NoteInfo(Info.Right, "新增一条配置成功!");
                    LoadSpider();
                }
                else
                {
                    NoteInfo(Info.Error, "新增失败!");
                }
            }
            catch (Exception ex)
            {

                NoteInfo(Info.Error, "增加方案失败:" + ex.ToString());
                throw;
            }
        }


        /*暂时还不确定是否有必要加上事件，个人觉得没有必要*/
        //private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ComboBox combox = sender as ComboBox;

        //    //这里比较重要
        //    combox.Leave += new EventHandler(combox_Leave);
        //    try
        //    {
        //        //在这里就可以做值是否改变判断
        //        if (combox.SelectedItem != null)
        //        {
        //            //Set The Value to info 
        //            MessageBox.Show(combox.SelectedValue.ToString());
        //        }
        //        System.Threading.Thread.Sleep(100);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void combox_Leave(object sender, EventArgs e)
        //{
        //    ComboBox combox = sender as ComboBox;
        //    //做完处理，须撤销动态事件
        //    combox.SelectedIndexChanged -= new EventHandler(ComboBox_SelectedIndexChanged);
        //}


    }
}
