﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace StudyKit
{
	public partial class BaseForm : Form
	{
		EditForm editForm;
		Prompt currentPrompt;
		Prompt previousPrompt;

		bool lastEnterIncorrect;

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


		public BaseForm()
		{
			InitializeComponent();

			editForm = new EditForm();
			editForm.baseForm = this;
		}

		private void editButton_click(object sender, System.EventArgs e) => editForm.Show();

		private void quitButton_Click(object sender, EventArgs e) => Application.Exit();

		private void checkButton_Click(object sender, EventArgs e) => ProcessAnswer();

		private void optionPanel_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(Handle, 0x112, 0xf012, 0);
		}

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
				promptLabel.ForeColor = Color.FromArgb(204, 82, 82);

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
	}
}