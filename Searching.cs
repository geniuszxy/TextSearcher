using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextSearcher
{
	public partial class Searching : Form
	{
		private double _progress;
		private Action _updateProgress;

		public Searching()
		{
			InitializeComponent();
			_updateProgress = UpdateProgress;
		}

		public void ReportProgress(double progress)
		{
			_progress = progress;
			Invoke(_updateProgress);
		}

		private void UpdateProgress()
		{
			progressBar.Value = (int)(_progress * 1000);
		}
	}
}
