using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TextSearcher
{
	using BuilderNodes = Dictionary<string, Dictionary<string, List<Result.Line>>>;
	using BuilderSubNodes = Dictionary<string, List<Result.Line>>;

	public partial class Result : Form
	{
		public struct Line
		{
			public string line;
			public int lineNumber;

			public Line(string line, int lineNumber)
			{
				this.line = line;
				this.lineNumber = lineNumber;
			}

			public override string ToString()
			{
				return "[" + lineNumber + "] " + line;
			}
		}

		public Result()
		{
			InitializeComponent();
		}

		public class Builder
		{
			public Builder(Result result)
			{
				_result = result;
				_needleNodes = new BuilderNodes();
				_fileNodes = new BuilderNodes();
			}

			private Result _result;
			private BuilderNodes _needleNodes;
			private BuilderNodes _fileNodes;

			public void Found(string needle, string filename, string line, int lineNumber)
			{
				var l = new Line(line, lineNumber);
				AddNode(needle, filename, l, _needleNodes);
				AddNode(filename, needle, l, _fileNodes);
			}

			private static void AddNode(string mainKey, string subKey, Line line, BuilderNodes bns)
			{
				BuilderSubNodes bsn;
				if (!bns.TryGetValue(mainKey, out bsn))
					bns.Add(mainKey, new BuilderSubNodes { { subKey, new List<Line> { line } } });
				else if (!bsn.TryGetValue(subKey, out List<Line> ls))
					bsn.Add(subKey, new List<Line> { line });
				else
					ls.Add(line);
			}

			private static void BuildNodes(TreeNodeCollection tnc, BuilderNodes bns)
			{
				foreach (var bsns in bns)
				{
					var node1 = tnc.Add(bsns.Key);
					var nc1 = node1.Nodes;
					foreach (var bsn in bsns.Value)
					{
						var node2 = nc1.Add(bsn.Key);
						var nc2 = node2.Nodes;
						foreach (var line in bsn.Value)
							nc2.Add(line.ToString());
					}
				}
			}

			/// <summary>
			/// 构建nodes
			/// </summary>
			public void Build()
			{
				if(_result.InvokeRequired)
				{
					_result.Invoke(new Action(Build));
					return;
				}

				BuildNodes(_result.tvNeedles.Nodes, _needleNodes);
				BuildNodes(_result.tvFiles.Nodes, _fileNodes);
			}
		}
	}
}
