namespace 课程设计_药库管理
{
    partial class frm_Manage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Manage));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("入库请求");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("新开单据");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("待审核单据");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("待入帐单据");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("已入帐单据");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("已冲销单据");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("已作废单据");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("入库业务", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("出库请求");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("新开单据");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("待审核单据");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("待入帐单据");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("已入帐单据");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("已作废单据");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("出库业务", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("出入库业务导航", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode15});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.出入库业务IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出入库导航ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.补填发票号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.汇款作业ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存管理SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帐页管理AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.采购业务PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.统计查询QToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统维护MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.il_File = new System.Windows.Forms.ImageList(this.components);
            this.pnl_Navigation = new System.Windows.Forms.Panel();
            this.dgv_Bills = new System.Windows.Forms.DataGridView();
            this.dgv_Details = new System.Windows.Forms.DataGridView();
            this.btn_Return = new System.Windows.Forms.Button();
            this.btn_NewBill = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnl_Navigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Details)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.出入库业务IToolStripMenuItem,
            this.库存管理SToolStripMenuItem,
            this.帐页管理AToolStripMenuItem,
            this.采购业务PToolStripMenuItem,
            this.统计查询QToolStripMenuItem,
            this.系统维护MToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1451, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 出入库业务IToolStripMenuItem
            // 
            this.出入库业务IToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.出入库导航ToolStripMenuItem,
            this.补填发票号ToolStripMenuItem,
            this.汇款作业ToolStripMenuItem});
            this.出入库业务IToolStripMenuItem.Name = "出入库业务IToolStripMenuItem";
            this.出入库业务IToolStripMenuItem.Size = new System.Drawing.Size(157, 28);
            this.出入库业务IToolStripMenuItem.Text = "出入库业务（I）";
            // 
            // 出入库导航ToolStripMenuItem
            // 
            this.出入库导航ToolStripMenuItem.Name = "出入库导航ToolStripMenuItem";
            this.出入库导航ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.出入库导航ToolStripMenuItem.Text = "出入库导航";
            this.出入库导航ToolStripMenuItem.Click += new System.EventHandler(this.出入库导航ToolStripMenuItem_Click);
            // 
            // 补填发票号ToolStripMenuItem
            // 
            this.补填发票号ToolStripMenuItem.Name = "补填发票号ToolStripMenuItem";
            this.补填发票号ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.补填发票号ToolStripMenuItem.Text = "补填发票号";
            // 
            // 汇款作业ToolStripMenuItem
            // 
            this.汇款作业ToolStripMenuItem.Name = "汇款作业ToolStripMenuItem";
            this.汇款作业ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.汇款作业ToolStripMenuItem.Text = "汇款作业";
            // 
            // 库存管理SToolStripMenuItem
            // 
            this.库存管理SToolStripMenuItem.Name = "库存管理SToolStripMenuItem";
            this.库存管理SToolStripMenuItem.Size = new System.Drawing.Size(144, 28);
            this.库存管理SToolStripMenuItem.Text = "库存管理（S）";
            // 
            // 帐页管理AToolStripMenuItem
            // 
            this.帐页管理AToolStripMenuItem.Name = "帐页管理AToolStripMenuItem";
            this.帐页管理AToolStripMenuItem.Size = new System.Drawing.Size(147, 28);
            this.帐页管理AToolStripMenuItem.Text = "帐页管理（A）";
            // 
            // 采购业务PToolStripMenuItem
            // 
            this.采购业务PToolStripMenuItem.Name = "采购业务PToolStripMenuItem";
            this.采购业务PToolStripMenuItem.Size = new System.Drawing.Size(145, 28);
            this.采购业务PToolStripMenuItem.Text = "采购业务（P）";
            // 
            // 统计查询QToolStripMenuItem
            // 
            this.统计查询QToolStripMenuItem.Name = "统计查询QToolStripMenuItem";
            this.统计查询QToolStripMenuItem.Size = new System.Drawing.Size(149, 28);
            this.统计查询QToolStripMenuItem.Text = "统计查询（Q）";
            // 
            // 系统维护MToolStripMenuItem
            // 
            this.系统维护MToolStripMenuItem.Name = "系统维护MToolStripMenuItem";
            this.系统维护MToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.系统维护MToolStripMenuItem.Text = "系统维护（M）";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(112, 28);
            this.帮助HToolStripMenuItem.Text = "帮助（H）";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 32);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1451, 33);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.il_File;
            this.treeView1.Location = new System.Drawing.Point(0, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点3";
            treeNode1.Text = "入库请求";
            treeNode2.Name = "节点4";
            treeNode2.Text = "新开单据";
            treeNode3.Name = "节点5";
            treeNode3.Text = "待审核单据";
            treeNode4.Name = "节点6";
            treeNode4.Text = "待入帐单据";
            treeNode5.Name = "节点7";
            treeNode5.Text = "已入帐单据";
            treeNode6.Name = "节点8";
            treeNode6.Text = "已冲销单据";
            treeNode7.Name = "节点9";
            treeNode7.Text = "已作废单据";
            treeNode8.Name = "节点1";
            treeNode8.Text = "入库业务";
            treeNode9.Name = "节点10";
            treeNode9.Text = "出库请求";
            treeNode10.Name = "节点11";
            treeNode10.Text = "新开单据";
            treeNode11.Name = "节点12";
            treeNode11.Text = "待审核单据";
            treeNode12.Name = "节点13";
            treeNode12.Text = "待入帐单据";
            treeNode13.Name = "节点14";
            treeNode13.Text = "已入帐单据";
            treeNode14.Name = "节点15";
            treeNode14.Text = "已作废单据";
            treeNode15.Name = "节点2";
            treeNode15.Text = "出库业务";
            treeNode16.Name = "节点0";
            treeNode16.Text = "出入库业务导航";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(219, 863);
            this.treeView1.TabIndex = 2;
            // 
            // il_File
            // 
            this.il_File.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_File.ImageStream")));
            this.il_File.TransparentColor = System.Drawing.Color.Transparent;
            this.il_File.Images.SetKeyName(0, "p1");
            // 
            // pnl_Navigation
            // 
            this.pnl_Navigation.Controls.Add(this.tableLayoutPanel1);
            this.pnl_Navigation.Controls.Add(this.dgv_Details);
            this.pnl_Navigation.Controls.Add(this.dgv_Bills);
            this.pnl_Navigation.Controls.Add(this.treeView1);
            this.pnl_Navigation.Location = new System.Drawing.Point(0, 71);
            this.pnl_Navigation.Name = "pnl_Navigation";
            this.pnl_Navigation.Size = new System.Drawing.Size(1446, 871);
            this.pnl_Navigation.TabIndex = 3;
            this.pnl_Navigation.Visible = false;
            // 
            // dgv_Bills
            // 
            this.dgv_Bills.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_Bills.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Bills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Bills.Location = new System.Drawing.Point(225, 3);
            this.dgv_Bills.Name = "dgv_Bills";
            this.dgv_Bills.RowHeadersWidth = 62;
            this.dgv_Bills.RowTemplate.Height = 30;
            this.dgv_Bills.Size = new System.Drawing.Size(1035, 251);
            this.dgv_Bills.TabIndex = 3;
            // 
            // dgv_Details
            // 
            this.dgv_Details.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_Details.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Details.Location = new System.Drawing.Point(225, 275);
            this.dgv_Details.Name = "dgv_Details";
            this.dgv_Details.RowHeadersWidth = 62;
            this.dgv_Details.RowTemplate.Height = 30;
            this.dgv_Details.Size = new System.Drawing.Size(1218, 301);
            this.dgv_Details.TabIndex = 4;
            // 
            // btn_Return
            // 
            this.btn_Return.Location = new System.Drawing.Point(3, 3);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(133, 35);
            this.btn_Return.TabIndex = 5;
            this.btn_Return.Text = "返回（R）";
            this.btn_Return.UseVisualStyleBackColor = true;
            // 
            // btn_NewBill
            // 
            this.btn_NewBill.Location = new System.Drawing.Point(3, 44);
            this.btn_NewBill.Name = "btn_NewBill";
            this.btn_NewBill.Size = new System.Drawing.Size(133, 35);
            this.btn_NewBill.TabIndex = 6;
            this.btn_NewBill.Text = "新开（N）";
            this.btn_NewBill.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(3, 85);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(133, 35);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "保存（S）";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(3, 167);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(133, 35);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "作废（C）";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(3, 126);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(133, 35);
            this.btn_Send.TabIndex = 9;
            this.btn_Send.Text = "发送（E）";
            this.btn_Send.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 208);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 40);
            this.button6.TabIndex = 10;
            this.button6.Text = "入库（I）";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Return, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn_cancel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_Send, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_Save, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_NewBill, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1266, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(139, 251);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // frm_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 1014);
            this.Controls.Add(this.pnl_Navigation);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frm_Manage";
            this.Text = "药库管理";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnl_Navigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Details)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 出入库业务IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出入库导航ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 补填发票号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 汇款作业ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存管理SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帐页管理AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 采购业务PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 统计查询QToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统维护MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList il_File;
        private System.Windows.Forms.Panel pnl_Navigation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_NewBill;
        private System.Windows.Forms.DataGridView dgv_Details;
        private System.Windows.Forms.DataGridView dgv_Bills;
    }
}