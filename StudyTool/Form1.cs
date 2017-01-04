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
		protected int fontSize = 12;

		protected bool BoldStatus = false;
		protected bool UnderlineStatus = false;
		protected bool ItalicStatus = false;

		public Form1()
		{
			InitializeComponent();
			SizeBox.Text = "Font Size";
			TypeBox.Text = "Font Type";
			initialFontType();
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

		private void changeFontSize()
		{
			int n;

			bool isNumeric = int.TryParse(SizeBox.Text, out n);

			if (isNumeric)
			{
				fontSize = Convert.ToInt32(SizeBox.Text);
				Font currentFont = richTextBox1.SelectionFont;
				FontStyle newFont = (FontStyle)(currentFont.Style);
				richTextBox1.SelectionFont = new Font(currentFont.FontFamily, fontSize, newFont);
			}
		}

		private void initialFontType ()
		{
			Font currentFont = richTextBox1.SelectionFont;
			FontStyle newFont = (FontStyle)(currentFont.Style);
			richTextBox1.SelectionFont = new Font("Times New Roman", fontSize, newFont);
		}

		//Allow the user to make the text Bold.
		private void boldToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!BoldStatus) //Current Text state is not bold.
			{
				BoldStatus = true;
			}

			else if (BoldStatus) //Current Text state is bold. So when bold is hit again switch back to normal text.
			{
				BoldStatus = false;
			}

			if (BoldStatus)
			{
				Font currentFont = richTextBox1.SelectionFont;
				richTextBox1.SelectionFont = new Font("Times New Roman", fontSize, FontStyle.Bold);
			}
			
			else if (!BoldStatus)
			{
				Font currentFont = richTextBox1.SelectionFont;
				richTextBox1.SelectionFont = new Font("Times New Roman", fontSize, FontStyle.Regular);
			}
		}

		private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void SizeBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) //Enter key was pressed while within the SizeBox.
			{
				changeFontSize();
			}
		}

		private void SizeBox_Click(object sender, EventArgs e)
		{
			SizeBox.ForeColor = Color.Black;
			SizeBox.Text = "";
		}

		private void TypeBox_Click(object sender, EventArgs e)
		{

		}
	}
}
