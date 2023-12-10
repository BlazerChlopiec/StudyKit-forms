using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StudyKit.UserControls
{
	public partial class UC_Study : UserControl
	{
		public Prompt currentPrompt { get; private set; }
		Prompt previousPrompt;

		bool lastEnterIncorrect;

		public UC_Edit uc_edit;

		public UC_Study()
		{
			InitializeComponent();
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (ActiveControl == textBox && keyData == Keys.Return)
			{
				ProcessAnswer();
				return true;
			}
			else
			{
				return base.ProcessCmdKey(ref msg, keyData);
			}
		}

		public void ProcessAnswer()
		{
			if (currentPrompt == null)
			{
				MessageBox.Show("Add prompts first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				textBox.Clear();
				return;
			}

			if (lastEnterIncorrect)
			{
				RefreshPrompt();
				return;
			}

			var input = textBox.Text;
			var correctAnswer = currentPrompt.correctAnswer;

			if (input != string.Empty)
			{
				var startRed = -1;
				for (int i = 0; i < textBox.TextLength; i++)
					if ((correctAnswer.Length <= i || input[i] != correctAnswer[i]) && startRed == -1) startRed = i;

				if (startRed != -1)
				{
					textBox.Select(startRed, textBox.TextLength);
					textBox.SelectionColor = Color.Red;
					textBox.SelectionLength = 0;

					// set cursor at last pos in text
					textBox.Select(textBox.TextLength, 0);
					textBox.SelectionLength = 0;
				}
			}

			if (input.ToLower().TrimEnd() == correctAnswer.ToLower().TrimEnd()) RefreshPrompt();

			else
			{
				lastEnterIncorrect = true;
				promptLabel.ForeColor = Color.FromArgb(204, 82, 82);

				correctLabel.Text = correctAnswer;
				correctLabel.Visible = true;
			}
		}

		public void RefreshPrompt()
		{
			if (uc_edit.promptItemList.Items.Count == 0) return;

			promptLabel.ForeColor = Color.White;

			textBox.Enabled = true;
			textBox.Text = string.Empty;
			textBox.Focus();

			checkButton.Enabled = true;

			previousPrompt = currentPrompt;
			currentPrompt = GetRandomPrompt();

			promptLabel.Text = currentPrompt.promptText;

			correctLabel.Visible = false;
			lastEnterIncorrect = false;
		}

		private Prompt GetRandomPrompt()
		{
			uc_edit.UpdateCheckState();

			var validPrompts = new List<Prompt>();
			foreach (var item in uc_edit.promptItemList.Items)
			{
				var prompt = (Prompt)item;
				if (prompt.checkState == CheckState.Unchecked || (prompt == previousPrompt && uc_edit.promptItemList.Items.Count != 1)) continue;
				else validPrompts.Add(prompt);
			}

			Random random = new Random();
			var value = random.Next(0, validPrompts.Count);

			return validPrompts[value];
		}

		private void checkButton_Click(object sender, EventArgs e) => ProcessAnswer();
	}
}
