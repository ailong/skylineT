using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TerraExplorerX;
using System.IO;
using System.Windows.Forms;

namespace skyline_CS
{
    class Project
    {
        public Control OpenProject()
        {
            TE3DMain tE3DMain = new TE3DMain();

            string tMsg = String.Empty;
            //打开文件选择对话框

            string tProjectUrl = "";
            OpenFileDialog tProjectUrlDialog = new OpenFileDialog();
            //tProjectUrlDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\  
            tProjectUrlDialog.Filter = "fly文件|*.fly*|所有文件|*.*";
            tProjectUrlDialog.RestoreDirectory = true;
            tProjectUrlDialog.FilterIndex = 1;
            if (tProjectUrlDialog.ShowDialog() == DialogResult.OK) 
            {
                tProjectUrl = tProjectUrlDialog.FileName;
            }

            bool bIsAsync = false;
            string tUser = String.Empty;
            string tPassword = String.Empty;
            //创建TE实例
            try
            {
                var sgworld = new SGWorld65();
                //注册装载完成事件
                sgworld.OnLoadFinished += new _ISGWorld65Events_OnLoadFinishedEventHandler(OnProjectLoadFinished);
                //根据参数打开项目
                sgworld.Project.Open(tProjectUrl, bIsAsync, tUser, tPassword);
                MessageBox.Show("使用异步方式打开项目： " + tProjectUrl + "成功！");
            }
            catch (Exception ex)
            {
                tMsg = String.Format("打开项目失败: {0}", ex.Message);
                MessageBox.Show(tMsg);
            }

            return tE3DMain;
        }

        private void OnProjectLoadFinished()
        {
            string tMsg = String.Empty;
            try
            {
                // OnLoadFinished event Received
                MessageBox.Show("收到项目加载完成事件");
            }
            catch (Exception ex)
            {
                tMsg = String.Format("项目加载失败: {0}", ex.Message);
                MessageBox.Show(tMsg);
            }
        }
    }
}
