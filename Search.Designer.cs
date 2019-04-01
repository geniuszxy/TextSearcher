namespace TextSearcher
{
	partial class Search
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
			System.Windows.Forms.GroupBox groupBox1;
			System.Windows.Forms.Label label1;
			this.btnDeleteFolder = new System.Windows.Forms.Button();
			this.btnAddFolder = new System.Windows.Forms.Button();
			this.folderList = new System.Windows.Forms.ListBox();
			this.tbFilter = new System.Windows.Forms.TextBox();
			this.tabControlNeedles = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tbNeedle = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tbNeedles = new System.Windows.Forms.TextBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.btnSelectNeedles = new System.Windows.Forms.Button();
			this.tbNeedleFilePath = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			groupBox1 = new System.Windows.Forms.GroupBox();
			label1 = new System.Windows.Forms.Label();
			groupBox1.SuspendLayout();
			this.tabControlNeedles.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(this.btnDeleteFolder);
			groupBox1.Controls.Add(this.btnAddFolder);
			groupBox1.Controls.Add(this.folderList);
			groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			groupBox1.Location = new System.Drawing.Point(5, 10);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(564, 137);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "文件夹";
			// 
			// btnDeleteFolder
			// 
			this.btnDeleteFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDeleteFolder.Location = new System.Drawing.Point(402, 108);
			this.btnDeleteFolder.Name = "btnDeleteFolder";
			this.btnDeleteFolder.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteFolder.TabIndex = 2;
			this.btnDeleteFolder.Text = "删除";
			this.btnDeleteFolder.UseVisualStyleBackColor = true;
			this.btnDeleteFolder.Visible = false;
			this.btnDeleteFolder.Click += new System.EventHandler(this.btnDeleteFolder_Click);
			// 
			// btnAddFolder
			// 
			this.btnAddFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddFolder.Location = new System.Drawing.Point(483, 108);
			this.btnAddFolder.Name = "btnAddFolder";
			this.btnAddFolder.Size = new System.Drawing.Size(75, 23);
			this.btnAddFolder.TabIndex = 1;
			this.btnAddFolder.Text = "添加";
			this.btnAddFolder.UseVisualStyleBackColor = true;
			this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
			// 
			// folderList
			// 
			this.folderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.folderList.FormattingEnabled = true;
			this.folderList.IntegralHeight = false;
			this.folderList.ItemHeight = 12;
			this.folderList.Location = new System.Drawing.Point(6, 17);
			this.folderList.Name = "folderList";
			this.folderList.Size = new System.Drawing.Size(552, 85);
			this.folderList.TabIndex = 0;
			this.folderList.SelectedIndexChanged += new System.EventHandler(this.folderList_SelectedIndexChanged);
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(9, 8);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(29, 12);
			label1.TabIndex = 2;
			label1.Text = "过滤";
			// 
			// tbFilter
			// 
			this.tbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbFilter.Location = new System.Drawing.Point(55, 5);
			this.tbFilter.Name = "tbFilter";
			this.tbFilter.Size = new System.Drawing.Size(508, 21);
			this.tbFilter.TabIndex = 3;
			// 
			// tabControlNeedles
			// 
			this.tabControlNeedles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControlNeedles.Controls.Add(this.tabPage1);
			this.tabControlNeedles.Controls.Add(this.tabPage2);
			this.tabControlNeedles.Controls.Add(this.tabPage3);
			this.tabControlNeedles.Location = new System.Drawing.Point(11, 32);
			this.tabControlNeedles.Name = "tabControlNeedles";
			this.tabControlNeedles.SelectedIndex = 0;
			this.tabControlNeedles.Size = new System.Drawing.Size(552, 184);
			this.tabControlNeedles.TabIndex = 4;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage1.Controls.Add(this.tbNeedle);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(544, 158);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "单行";
			// 
			// tbNeedle
			// 
			this.tbNeedle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbNeedle.Location = new System.Drawing.Point(3, 3);
			this.tbNeedle.Name = "tbNeedle";
			this.tbNeedle.Size = new System.Drawing.Size(538, 21);
			this.tbNeedle.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.tbNeedles);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(544, 158);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "多行";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tbNeedles
			// 
			this.tbNeedles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbNeedles.Location = new System.Drawing.Point(3, 3);
			this.tbNeedles.Multiline = true;
			this.tbNeedles.Name = "tbNeedles";
			this.tbNeedles.Size = new System.Drawing.Size(538, 152);
			this.tbNeedles.TabIndex = 0;
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage3.Controls.Add(this.btnSelectNeedles);
			this.tabPage3.Controls.Add(this.tbNeedleFilePath);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(544, 158);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "从文件";
			// 
			// btnSelectNeedles
			// 
			this.btnSelectNeedles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSelectNeedles.Location = new System.Drawing.Point(463, 4);
			this.btnSelectNeedles.Name = "btnSelectNeedles";
			this.btnSelectNeedles.Size = new System.Drawing.Size(75, 23);
			this.btnSelectNeedles.TabIndex = 1;
			this.btnSelectNeedles.Text = "选择";
			this.btnSelectNeedles.UseVisualStyleBackColor = true;
			this.btnSelectNeedles.Click += new System.EventHandler(this.btnSelectNeedles_Click);
			// 
			// tbNeedleFilePath
			// 
			this.tbNeedleFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbNeedleFilePath.Location = new System.Drawing.Point(6, 6);
			this.tbNeedleFilePath.Name = "tbNeedleFilePath";
			this.tbNeedleFilePath.Size = new System.Drawing.Size(451, 21);
			this.tbNeedleFilePath.TabIndex = 0;
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnSearch.Location = new System.Drawing.Point(250, 222);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.Text = "查找";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(groupBox1);
			this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
			this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.splitContainer1.Panel1MinSize = 100;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.btnSearch);
			this.splitContainer1.Panel2.Controls.Add(label1);
			this.splitContainer1.Panel2.Controls.Add(this.tbFilter);
			this.splitContainer1.Panel2.Controls.Add(this.tabControlNeedles);
			this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.splitContainer1.Panel2MinSize = 140;
			this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.splitContainer1.Size = new System.Drawing.Size(574, 402);
			this.splitContainer1.SplitterDistance = 147;
			this.splitContainer1.SplitterWidth = 1;
			this.splitContainer1.TabIndex = 7;
			// 
			// Search
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(574, 402);
			this.Controls.Add(this.splitContainer1);
			this.MinimumSize = new System.Drawing.Size(16, 275);
			this.Name = "Search";
			this.ShowIcon = false;
			this.Text = "文字查找工具";
			groupBox1.ResumeLayout(false);
			this.tabControlNeedles.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnAddFolder;
		private System.Windows.Forms.ListBox folderList;
		private System.Windows.Forms.TextBox tbFilter;
		private System.Windows.Forms.TabControl tabControlNeedles;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TextBox tbNeedle;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox tbNeedles;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Button btnSelectNeedles;
		private System.Windows.Forms.TextBox tbNeedleFilePath;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button btnDeleteFolder;
	}
}

