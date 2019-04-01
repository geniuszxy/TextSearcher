using FolderSelect;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace TextSearcher
{
	public partial class Search : Form
	{
		private FolderSelectDialog _folderDialog;
		private OpenFileDialog _fileDialog;
		private int _lastFolderIndex = -1;

		private class SearchData
		{
			public string[] folders;
			public string[] needles;
			public string[] filters;
			public bool ignoreCase;

			public FileSearcher searcher;
			public Searching searching;
			public Result result;

			public void DoSearch(object state)
			{
				var builder = new Result.Builder(result);
				searcher.OnFound += builder.Found;
				searcher.OnProgress += searching.ReportProgress;
				searcher.OnComplete += builder.Build;
				searcher.OnComplete += OnSearchComplete;
				searcher.Search(folders, needles, filters, ignoreCase);
			}

			public void OnSearchComplete()
			{
				searching.Invoke(new Action(_Complete));
			}

			private void _Complete()
			{
				result.Show();
				searching.Close();
			}
		}

		public Search()
		{
			InitializeComponent();
		}

		//Show add folder dialog
		private void btnAddFolder_Click(object sender, EventArgs e)
		{
			if (_folderDialog == null)
				_folderDialog = new FolderSelectDialog();

			if (_folderDialog.ShowDialog(Handle))
			{
				var folder = _folderDialog.FileName;
				var items = folderList.Items;
				//add folder
				if (!items.Contains(folder))
					items.Add(folder);
				//prevent the dialog enter the folder
				_folderDialog.InitialDirectory = Path.GetDirectoryName(folder);
			}
		}

		//Delete a folder
		private void btnDeleteFolder_Click(object sender, EventArgs e)
		{
			folderList.Items.RemoveAt(folderList.SelectedIndex);
			folderList.SelectedIndex = -1;
			btnDeleteFolder.Visible = false;
		}

		//Show dialog to select a file contains needles
		private void btnSelectNeedles_Click(object sender, EventArgs e)
		{
			if (_fileDialog == null)
				_fileDialog = new OpenFileDialog();

			if (_fileDialog.ShowDialog(this) == DialogResult.OK)
				tbNeedleFilePath.Text = _fileDialog.FileName;
		}

		//Start search
		private void btnSearch_Click(object sender, EventArgs e)
		{
			var searchData = new SearchData();

			//folders
			var folderItems = folderList.Items;
			var folderCount = folderItems.Count;
			if (folderCount == 0)
			{
				MessageBox.Show("No folder selected");
				return;
			}
			string[] folders = new string[folderCount];
			folderItems.CopyTo(folders, 0);
			searchData.folders = folders;

			//filters
			var filterText = tbFilter.Text;
			if (string.IsNullOrEmpty(filterText))
			{
				MessageBox.Show("No filters");
				return;
			}
			var filterTexts = filterText.Split(new char[] { ';', ',' },
				StringSplitOptions.RemoveEmptyEntries);
			var filters = new string[filterTexts.Length];
			for (int i = 0; i < filterTexts.Length; i++)
			{
				var ext = filterTexts[i];
				if (ext.StartsWith("."))
					filters[i] = ext;
				else
					filters[i] = "." + ext;
			}
			searchData.filters = filters;

			//needles
			string[] needles = null;
			switch (tabControlNeedles.SelectedIndex)
			{
			case 0:
				if(string.IsNullOrEmpty(tbNeedle.Text))
				{
					MessageBox.Show("No needle");
					return;
				}
				needles = new string[] { tbNeedle.Text };
				break;
			case 1:
				if (!string.IsNullOrEmpty(tbNeedles.Text))
				{
					needles = tbNeedles.Text.Split(new char[] { '\n', '\r' },
					StringSplitOptions.RemoveEmptyEntries);
				}
				if(needles == null || needles.Length == 0)
				{
					MessageBox.Show("No needles");
					return;
				}
				break;
			case 2:
				if (string.IsNullOrEmpty(tbNeedleFilePath.Text))
				{
					MessageBox.Show("No needle file selected");
					return;
				}
				var validLines = new List<string>();
				foreach (var line in FileSearcher.GetLines(tbNeedleFilePath.Text))
					if (!string.IsNullOrEmpty(line))
						validLines.Add(line);
				if(validLines.Count == 0)
				{
					MessageBox.Show("No needles");
					return;
				}
				needles = validLines.ToArray();
				break;
			default:
				MessageBox.Show("Invalid tab");
				return;
			}
			searchData.needles = needles;

			//ignore case
			searchData.ignoreCase = false;

			//ready
			searchData.searcher = new FileSearcher();
			searchData.searching = new Searching();
			searchData.result = new Result();
			searchData.searching.Show();
			var task = new Thread(searchData.DoSearch);
			task.Start(searchData);
		}

		//Show delete button if select something
		//Click the same list item twice to cancel selection
		private void folderList_SelectedIndexChanged(object sender, EventArgs e)
		{
			int index = folderList.SelectedIndex;
			if (index >= 0)
			{
				if (_lastFolderIndex == index)
				{
					folderList.SelectedIndex = -1;
					btnDeleteFolder.Visible = false;
					return;
				}
				else
					btnDeleteFolder.Visible = true;
			}
			_lastFolderIndex = index;
		}
	}
}
