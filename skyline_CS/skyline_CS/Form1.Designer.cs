namespace skyline_CS
{
    partial class SouthRMS_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SouthRMS_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitCMain = new System.Windows.Forms.SplitContainer();
            this.splitCTree = new System.Windows.Forms.SplitContainer();
            this.ProTreeView = new System.Windows.Forms.TreeView();
            this.新建NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为SAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.推出QToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitCMain)).BeginInit();
            this.splitCMain.Panel1.SuspendLayout();
            this.splitCMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitCTree)).BeginInit();
            this.splitCTree.Panel1.SuspendLayout();
            this.splitCTree.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1322, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建NToolStripMenuItem,
            this.打开OToolStripMenuItem,
            this.保存SToolStripMenuItem,
            this.另存为SAToolStripMenuItem,
            this.关闭CToolStripMenuItem,
            this.推出QToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(54, 21);
            this.文件FToolStripMenuItem.Text = "文件 &F";
            // 
            // splitCMain
            // 
            this.splitCMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitCMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCMain.Location = new System.Drawing.Point(0, 25);
            this.splitCMain.Name = "splitCMain";
            // 
            // splitCMain.Panel1
            // 
            this.splitCMain.Panel1.Controls.Add(this.splitCTree);
            this.splitCMain.Size = new System.Drawing.Size(1322, 672);
            this.splitCMain.SplitterDistance = 237;
            this.splitCMain.TabIndex = 1;
            // 
            // splitCTree
            // 
            this.splitCTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitCTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCTree.Location = new System.Drawing.Point(0, 0);
            this.splitCTree.Name = "splitCTree";
            this.splitCTree.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitCTree.Panel1
            // 
            this.splitCTree.Panel1.Controls.Add(this.ProTreeView);
            this.splitCTree.Size = new System.Drawing.Size(237, 672);
            this.splitCTree.SplitterDistance = 354;
            this.splitCTree.TabIndex = 0;
            // 
            // ProTreeView
            // 
            this.ProTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProTreeView.Location = new System.Drawing.Point(0, 0);
            this.ProTreeView.Name = "ProTreeView";
            this.ProTreeView.Size = new System.Drawing.Size(235, 352);
            this.ProTreeView.TabIndex = 0;
            // 
            // 新建NToolStripMenuItem
            // 
            this.新建NToolStripMenuItem.Name = "新建NToolStripMenuItem";
            this.新建NToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.新建NToolStripMenuItem.Text = "新建 &N";
            // 
            // 打开OToolStripMenuItem
            // 
            this.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem";
            this.打开OToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.打开OToolStripMenuItem.Text = "打开 &O";
            this.打开OToolStripMenuItem.Click += new System.EventHandler(this.打开OToolStripMenuItem_Click);
            // 
            // 保存SToolStripMenuItem
            // 
            this.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem";
            this.保存SToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.保存SToolStripMenuItem.Text = "保存 &S";
            // 
            // 另存为SAToolStripMenuItem
            // 
            this.另存为SAToolStripMenuItem.Name = "另存为SAToolStripMenuItem";
            this.另存为SAToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.另存为SAToolStripMenuItem.Text = "另存为 &A";
            // 
            // 关闭CToolStripMenuItem
            // 
            this.关闭CToolStripMenuItem.Name = "关闭CToolStripMenuItem";
            this.关闭CToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关闭CToolStripMenuItem.Text = "关闭 &C";
            // 
            // 推出QToolStripMenuItem
            // 
            this.推出QToolStripMenuItem.Name = "推出QToolStripMenuItem";
            this.推出QToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.推出QToolStripMenuItem.Text = "推出 &Q";
            // 
            // SouthRMS_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 697);
            this.Controls.Add(this.splitCMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SouthRMS_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "南方数码快速建模系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitCMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCMain)).EndInit();
            this.splitCMain.ResumeLayout(false);
            this.splitCTree.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCTree)).EndInit();
            this.splitCTree.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitCMain;
        private System.Windows.Forms.SplitContainer splitCTree;
        private System.Windows.Forms.TreeView ProTreeView;
        private System.Windows.Forms.ToolStripMenuItem 新建NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为SAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 推出QToolStripMenuItem;
    }
}

