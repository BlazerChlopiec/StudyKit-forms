using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StudyKit
{
	public partial class BaseForm : Form
	{
		EditForm editForm;
		Prompt currentPrompt;
		Prompt previousPrompt;

		bool lastEnterIncorrect;

		public BaseForm()
		{
			InitializeComponent();

			editForm = new EditForm();
			editForm.baseForm = this;

			textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);
			void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
			{
				if (e.KeyChar == (char)Keys.Return)

				{
					e.Handled = true;
					ProcessAnswer();
				}
			}
		}

		private void editButton_click(object sender, System.EventArgs e) => editForm.Show();

		private void checkButton_Click(object sender, EventArgs e) => ProcessAnswer();

		private void ProcessAnswer()
		{
			if (lastEnterIncorrect)
			{
				RefreshPrompt();
				return;
			}

			var input = textBox.Text;
			var correctAnswer = currentPrompt.correctAnswer;

			if (input.ToLower() == correctAnswer.ToLower())
			{
				Console.WriteLine("Correct");
				RefreshPrompt();
			}
			else
			{
				Console.WriteLine("Incorrect");
				lastEnterIncorrect = true;
				promptLabel.ForeColor = Color.Red;

				correctLabel.Text = correctAnswer;
				correctLabel.Visible = true;
			}
		}

		public void RefreshPrompt()
		{
			if (editForm.promptItemList.Items.Count == 0)
			{
				//MessageBox.Show("There are no available prompts!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Console.WriteLine("There are no available prompts!");
				return;
			}

			promptLabel.ForeColor = Color.Black;

			textBox.Enabled = true;
			textBox.Text = string.Empty;
			textBox.Focus();

			checkButton.Enabled = true;

			previousPrompt = currentPrompt;
			currentPrompt = GetRandomPrompt();

			promptLabel.Text = currentPrompt.promptText;

			correctLabel.Visible = false;
			lastEnterIncorrect = false;

			Console.WriteLine("Refreshed");
		}

		private Prompt GetRandomPrompt()
		{
			editForm.UpdateCheckState();

			var validPrompts = new List<Prompt>();
			foreach (var item in editForm.promptItemList.Items)
			{
				var prompt = (Prompt)item;
				if (prompt.checkState == CheckState.Unchecked || prompt == previousPrompt) continue;
				else validPrompts.Add(prompt);
			}

			Random random = new Random();
			var value = random.Next(0, validPrompts.Count);

			return validPrompts[value];
		}
	}
}
