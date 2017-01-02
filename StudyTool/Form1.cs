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
		public Form1()
		{
			InitializeComponent();
			FontBox.Text = "Font Size";
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

		//Change to DropDown Menu later.
		private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
		{
			int n;
			bool isNumber = int.TryParse(FontBox.Text, out n);

			if  (isNumber)
			{
				int fontSize = Convert.ToInt32(FontBox.Text);

				Font currentFont = richTextBox1.SelectionFont;

				FontStyle newFont = (FontStyle)(currentFont.Style);
				richTextBox1.SelectionFont = new Font(currentFont.FontFamily, fontSize, newFont);
			}

			
		}
	}
}
