namespace TextSearcher
{
	partial class Result
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
			System.Windows.Forms.TabControl tabControl1;
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tvNeedles = new System.Windows.Forms.TreeView();
			this.tvFiles = new System.Windows.Forms.TreeView();
			tabControl1 = new System.Windows.Forms.TabControl();
			tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(this.tabPage1);
			tabControl1.Controls.Add(this.tabPage2);
			tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			tabControl1.Location = new System.Drawing.Point(0, 0);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new System.Drawing.Size(800, 450);
			tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.tvNeedles);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(792, 424);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "按查找内容";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.tvFiles);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(792, 424);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "按文件";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tvNeedles
			// 
			this.tvNeedles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tvNeedles.Location = new System.Drawing.Point(3, 3);
			this.tvNeedles.Name = "tvNeedles";
			this.tvNeedles.Size = new System.Drawing.Size(786, 418);
			this.tvNeedles.TabIndex = 0;
			// 
			// tvFiles
			// 
			this.tvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tvFiles.Location = new System.Drawing.Point(3, 3);
			this.tvFiles.Name = "tvFiles";
			this.tvFiles.Size = new System.Drawing.Size(786, 418);
			this.tvFiles.TabIndex = 0;
			// 
			// Result
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(tabControl1);
			this.Name = "Result";
			this.ShowIcon = false;
			this.Text = "Result";
			tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TreeView tvNeedles;
		private System.Windows.Forms.TreeView tvFiles;
	}
}