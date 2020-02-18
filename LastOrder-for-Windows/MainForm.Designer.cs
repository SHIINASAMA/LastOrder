namespace LastOrder_for_Windows
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查找FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.NextBtn = new System.Windows.Forms.Button();
            this.PreBtn = new System.Windows.Forms.Button();
            this.NowStatus = new System.Windows.Forms.StatusStrip();
            this.Tab1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.书签BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuBar.SuspendLayout();
            this.NowStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(754, 25);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.另存为ToolStripMenuItem,
            this.toolStripSeparator1,
            this.书签BToolStripMenuItem,
            this.查找FToolStripMenuItem,
            this.toolStripSeparator2,
            this.关闭ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.打开ToolStripMenuItem.Text = "打开(&O)";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.保存ToolStripMenuItem.Text = "保存(&S)";
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.另存为ToolStripMenuItem.Text = "另存为(&A)";
            // 
            // 查找FToolStripMenuItem
            // 
            this.查找FToolStripMenuItem.Name = "查找FToolStripMenuItem";
            this.查找FToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.查找FToolStripMenuItem.Text = "查找(&F)";
            this.查找FToolStripMenuItem.Click += new System.EventHandler(this.查找FToolStripMenuItem_Click);
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.关闭ToolStripMenuItem.Text = "关闭(&C)";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.关闭ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.退出ToolStripMenuItem.Text = "退出(&E)";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.关于ToolStripMenuItem.Text = "关于(&A)";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.FullRowSelect = true;
            listViewGroup4.Header = "ListViewGroup";
            listViewGroup4.Name = "Index";
            listViewGroup4.Tag = "索引值";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 28);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(754, 410);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(0, 444);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(754, 73);
            this.textBox2.TabIndex = 4;
            // 
            // NextBtn
            // 
            this.NextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NextBtn.Location = new System.Drawing.Point(93, 523);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(75, 23);
            this.NextBtn.TabIndex = 5;
            this.NextBtn.Text = "下一句(&N)";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // PreBtn
            // 
            this.PreBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PreBtn.Location = new System.Drawing.Point(12, 523);
            this.PreBtn.Name = "PreBtn";
            this.PreBtn.Size = new System.Drawing.Size(75, 23);
            this.PreBtn.TabIndex = 6;
            this.PreBtn.Text = "前一句(&P)";
            this.PreBtn.UseVisualStyleBackColor = true;
            this.PreBtn.Click += new System.EventHandler(this.PreBtn_Click);
            // 
            // NowStatus
            // 
            this.NowStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tab1});
            this.NowStatus.Location = new System.Drawing.Point(0, 549);
            this.NowStatus.Name = "NowStatus";
            this.NowStatus.Size = new System.Drawing.Size(754, 22);
            this.NowStatus.TabIndex = 7;
            this.NowStatus.Text = "statusStrip1";
            // 
            // Tab1
            // 
            this.Tab1.Name = "Tab1";
            this.Tab1.Size = new System.Drawing.Size(32, 17);
            this.Tab1.Text = "就绪";
            // 
            // 书签BToolStripMenuItem
            // 
            this.书签BToolStripMenuItem.Name = "书签BToolStripMenuItem";
            this.书签BToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.书签BToolStripMenuItem.Text = "书签(&B)";
            this.书签BToolStripMenuItem.Click += new System.EventHandler(this.书签BToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 571);
            this.Controls.Add(this.NowStatus);
            this.Controls.Add(this.PreBtn);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.MenuBar);
            this.MainMenuStrip = this.MenuBar;
            this.Name = "MainForm";
            this.Text = "LastOrder for Windows";
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.NowStatus.ResumeLayout(false);
            this.NowStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button PreBtn;
        private System.Windows.Forms.ToolStripMenuItem 查找FToolStripMenuItem;
        private System.Windows.Forms.StatusStrip NowStatus;
        private System.Windows.Forms.ToolStripStatusLabel Tab1;
        private System.Windows.Forms.ToolStripMenuItem 书签BToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

