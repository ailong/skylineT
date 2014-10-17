namespace skyline_CS
{
    partial class TE3DMain
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TE3DMain));
            this.axTE3DMain = new AxTerraExplorerX.AxTE3DWindow();
            ((System.ComponentModel.ISupportInitialize)(this.axTE3DMain)).BeginInit();
            this.SuspendLayout();
            // 
            // axTE3DMain
            // 
            this.axTE3DMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axTE3DMain.Enabled = true;
            this.axTE3DMain.Location = new System.Drawing.Point(0, 0);
            this.axTE3DMain.Name = "axTE3DMain";
            this.axTE3DMain.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTE3DMain.OcxState")));
            this.axTE3DMain.Size = new System.Drawing.Size(945, 600);
            this.axTE3DMain.TabIndex = 0;
            // 
            // TE3DMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.axTE3DMain);
            this.Name = "TE3DMain";
            this.Size = new System.Drawing.Size(945, 600);
            ((System.ComponentModel.ISupportInitialize)(this.axTE3DMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public AxTerraExplorerX.AxTE3DWindow axTE3DMain;


    }
}
