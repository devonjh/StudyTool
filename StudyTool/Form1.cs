using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyTool
{
	public partial class Form1 : Form
	{
		protected int fontSize;

		public Form1()
		{
			InitializeComponent();
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();

			ofd.Filter = "TextFiles (.txt)|*.txt";
			ofd.Title = "Open a file...";

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				System.IO.StreamReader SR = new System.IO.StreamReader(ofd.FileName);
				richTextBox1.Text = SR.ReadToEnd();
				SR.Close();
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog save = new SaveFileDialog();

			save.Filter = "Text Files (.txt)|*.txt";
			save.Title = "Save file...";

			if (save.ShowDialog() == DialogResult.OK)
			{
				System.IO.StreamWriter write = new System.IO.StreamWriter(save.FileName);
				write.Write(richTextBox1.Text);
				write.Close();
			}
		}

		private void undoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Undo();
		}

		private void redoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Redo();
		}

		private void cutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Cut();
		}

		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Copy();
		}

		private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Paste();
		}

		private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectAll();
		}

		private void changeFontSize (int Size)
		{
			int fontSize = Size;

			Font currentFont = richTextBox1.SelectionFont;
			FontStyle newFont = (FontStyle)(currentFont.Style);
			richTextBox1.SelectionFont = new Font(currentFont.FontFamily, fontSize, newFont);
		}

		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			fontSize = 6;
			changeFontSize(fontSize);
		}

		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			fontSize = 8;
			changeFontSize(fontSize);
		}

		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
			fontSize = 10;
			changeFontSize(fontSize);
		}

		private void toolStripMenuItem5_Click(object sender, EventArgs e)
		{
			fontSize = 12;
			changeFontSize(fontSize);
		}

		private void toolStripMenuItem6_Click(object sender, EventArgs e)
		{
			fontSize = 14;
			changeFontSize(fontSize);
		}

		private void toolStripMenuItem7_Click(object sender, EventArgs e)
		{
			fontSize = 16;
			changeFontSize(fontSize);
		}

		private void toolStripMenuItem8_Click(object sender, EventArgs e)
		{
			fontSize = 18;
			changeFontSize(fontSize);
		}

		private void toolStripMenuItem9_Click(object sender, EventArgs e)
		{
			fontSize = 20;
			changeFontSize(fontSize);
		}

		private void toolStripMenuItem10_Click(object sender, EventArgs e)
		{
			fontSize = 22;
			changeFontSize(fontSize);
		}

		private void toolStripMenuItem11_Click(object sender, EventArgs e)
		{
			fontSize = 24;
			changeFontSize(fontSize);
		}


	}
}
