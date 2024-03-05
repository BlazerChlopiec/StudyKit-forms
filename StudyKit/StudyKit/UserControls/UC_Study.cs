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

		// if pressed enter and input was incorrect this is set to true
		// we use this to show correct answer below and pause for one enter press 
		bool lastEnterIncorrect;

		float promptLabelOriginalSize = 21.27f;


		// streak
		private int Streak
		{
			get { return streak; }
			set
			{
				streak = value;
				streakLabel.Text = $"Streak: {streak}";
			}
		}
		private int streak;
		//

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

		public void ProcessAnswer() // this is basically "when pressed enter on textBox or the green button"
		{
			if (currentPrompt == null)
			{
				MessageBox.Show("Add prompts first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				textBox.Clear();
				return;
			}

			if (lastEnterIncorrect) // if last enter was incorrect refresh the streak on this enter and RefreshPrompt()
			{
				Streak = 0;
				RefreshPrompt();
				return;
			}

			var input = textBox.Text;
			var correctAnswer = currentPrompt.correctAnswer;

			SpellCheck(input);

			if (input.ToLower().TrimEnd() == correctAnswer.ToLower().TrimEnd())
			{
				RefreshPrompt();

				Streak++;
			}
			else
			{
				lastEnterIncorrect = true;
				promptLabel.ForeColor = Color.FromArgb(204, 82, 82);

				correctLabel.Text = correctAnswer;
				correctLabel.Visible = true;
			}
		}

		private void SpellCheck(string input)
		{
			if (input == string.Empty || currentPrompt == null) return;

			var correctAnswer = currentPrompt.correctAnswer;

			var cursorPosition = textBox.SelectionStart;

			var redIndex = -1; // starting Index from which red should be painted

			for (int i = 0; i < textBox.TextLength; i++) // loop through text
			{
				// if length is shorter than i OR is correctAnswer[i] is different
				if ((correctAnswer.Length <= i || input.ToLower()[i] != correctAnswer.ToLower()[i])
					&& redIndex == -1) redIndex = i; // and if start red Index hasn't been assigned yet - set it to i
			}

			if (redIndex > -1) // if there is a red index to start painting
			{
				textBox.Select(redIndex, textBox.TextLength);
				textBox.SelectionColor = BaseForm.flatRed;

				// set cursor at previous pos in text before spell check
				textBox.Select(cursorPosition, textBox.TextLength);
				textBox.SelectionLength = 0; // deselect
			}
			else // unpaint previous highlighted red
			{
				textBox.Select(0, textBox.TextLength);
				textBox.SelectionColor = BaseForm.flatLightBlue;

				// set cursor at previous pos in text before spell check
				textBox.Select(cursorPosition, textBox.TextLength);
				textBox.SelectionLength = 0; // deselect
			}
		}

		public void RefreshPrompt()
		{
			lastEnterIncorrect = false;
			correctLabel.Visible = false;
			promptLabel.ForeColor = Color.White;

			if (uc_edit.promptItemList.Items.Count == 0)
			{
				currentPrompt = null;
				promptLabel.Text = "---";
				return;
			}

			textBox.Enabled = true;
			textBox.Text = string.Empty;
			textBox.Focus();

			checkButton.Enabled = true;

			previousPrompt = currentPrompt;
			currentPrompt = GetRandomPrompt();

			promptLabel.Text = currentPrompt.promptText;

			ScalePromptLabel();
		}

		private void ScalePromptLabel()
		{
			promptLabel.Font = new Font(promptLabel.Font.FontFamily, promptLabelOriginalSize, promptLabel.Font.Style);

			SizeF textSize;

			using (Graphics g = promptLabel.CreateGraphics())
				textSize = g.MeasureString(promptLabel.Text, promptLabel.Font);

			var minFontSize = 10;
			while (textSize.Width > promptLabel.Width && promptLabel.Font.Size > minFontSize)
			{
				promptLabel.Font = new Font(promptLabel.Font.FontFamily, promptLabel.Font.Size - 1, promptLabel.Font.Style);
				using (Graphics g = promptLabel.CreateGraphics())
					textSize = g.MeasureString(promptLabel.Text, promptLabel.Font);
			}
		}

		private Prompt GetRandomPrompt()
		{
			uc_edit.UpdateCheckState();

			var validPrompts = new List<Prompt>();
			foreach (var item in uc_edit.promptItemList.Items)
			{
				var prompt = (Prompt)item;
				if (prompt.checkState == CheckState.Unchecked ||
				   (previousPrompt != null && prompt.promptText == previousPrompt.promptText && uc_edit.promptItemList.Items.Count != 1)) continue;
				else validPrompts.Add(prompt);
			}

			Random random = new Random();
			var value = random.Next(0, validPrompts.Count);

			return validPrompts.Count == 0 ? previousPrompt : validPrompts[value];
		}

		private void checkButton_Click(object sender, EventArgs e) => ProcessAnswer();

		private void textBox_TextChanged(object sender, EventArgs e) { if (lastEnterIncorrect) SpellCheck(input: textBox.Text); }
	}
}
