using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace StudyKit.UserControls
{
	public partial class UC_Edit : UserControl
	{
		public UC_Study uc_study;

		Prompt currentlyEditedPrompt;


		public UC_Edit()
		{
			InitializeComponent();

			promptItemList.DisplayMember = "displayListName";

			promptItemList.ItemCheck += (b, a) =>
			{
				var edited = (Prompt)promptItemList.Items[a.Index];
				edited.checkState = a.CurrentValue;
			};

			promptItemList.SelectedIndexChanged += (e, a) =>
			{
				currentlyEditedPrompt = (Prompt)promptItemList.SelectedItem;
				if (currentlyEditedPrompt != null)
				{
					editPromptTextBox.Text = currentlyEditedPrompt.promptText;
					editPromptAnswerTextBox.Text = currentlyEditedPrompt.correctAnswer;
				}
			};

			editPromptTextBox.TextChanged += (e, a) =>
			{
				if (currentlyEditedPrompt != null)
				{
					currentlyEditedPrompt.promptText = editPromptTextBox.Text;
					promptItemList.Invalidate();
					promptItemList.Update();
				}
			};

			editPromptAnswerTextBox.TextChanged += (e, a) =>
			{
				if (currentlyEditedPrompt != null)
				{
					currentlyEditedPrompt.correctAnswer = editPromptAnswerTextBox.Text;
					promptItemList.Invalidate();
					promptItemList.Update();
				}
			};
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			// macros shortcuts CTRL + 123...
			for (int i = 0; i < Macros.macrosAmount; i++)
			{
				if (keyData == (Keys.D1 + i | Keys.Control))
				{
					BaseForm.macros.InvokeMacro(i);
					return true;
				}
			}

			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void addPromptButton_Click(object sender, EventArgs e) => AddPrompt(editPromptTextBox.Text, editPromptAnswerTextBox.Text);

		private void AddPrompt(string promptText = "Default", string correctAnswer = "DefaultAnswer", CheckState checkState = CheckState.Checked)
		{
			var prompt = new Prompt();
			prompt.promptText = promptText == string.Empty || string.IsNullOrWhiteSpace(promptText) ? "Default" : promptText;
			prompt.correctAnswer = correctAnswer == string.Empty || string.IsNullOrWhiteSpace(correctAnswer) ? "DefaultAnswer" : correctAnswer; ;
			prompt.checkState = checkState;

			promptItemList.Items.Add(prompt);
			promptItemList.SetItemCheckState(promptItemList.Items.Count - 1, prompt.checkState);
			promptItemList.SelectedIndex = promptItemList.Items.Count - 1;

			editPromptTextBox.Focus();
			editPromptTextBox.SelectAll();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			UpdateCheckState();

			var prompts = new List<Prompt>();
			foreach (var item in promptItemList.Items)
				prompts.Add((Prompt)item);

			var jsonContainer = new JsonContainer { prompts = prompts, macros = BaseForm.macros };
			string output = JsonConvert.SerializeObject(jsonContainer);
			var result = saveFileDialog.ShowDialog();

			if (result == DialogResult.OK)
			{
				string path = saveFileDialog.FileName;

				File.WriteAllText(path, output, new UTF8Encoding(true));
			}
		}

		private void loadButton_Click(object sender, EventArgs e)
		{
			var result = loadFileDialog.ShowDialog();

			if (result == DialogResult.OK)
				LoadFromJSON(loadFileDialog.FileName);
		}

		// returns whether the JSON was valid
		public bool LoadFromJSON(string jsonPath)
		{
			using (StreamReader r = new StreamReader(jsonPath))
			{
				string json = r.ReadToEnd();

				try
				{
					var jsonContainer = JsonConvert.DeserializeObject<JsonContainer>(json);

					if (jsonContainer == null || jsonContainer.prompts == null)
					{
						MessageBox.Show("JSON Incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}

					ClearAllPrompts(); // clear all prompts before loading new ones
					uc_study.Streak = 0;

					foreach (var prompt in jsonContainer.prompts)
						AddPrompt(prompt.promptText, prompt.correctAnswer, prompt.checkState);

					var values = jsonContainer.macros.values;
					BaseForm.macros.LoadValues(values);

					return true; // JSON valid
				}
				catch (Exception)
				{
					MessageBox.Show("JSON Incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

					return false; // JSON invalid
				}
			}
		}

		private void removePrompt_Click(object sender, EventArgs e)
		{
			promptItemList.Items.Remove(promptItemList.SelectedItem);
			promptItemList.SelectedIndex = promptItemList.Items.Count - 1;
		}

		private void clearPrompts_Click(object sender, EventArgs e) => ClearAllPrompts();

		public void UpdateCheckState()
		{
			foreach (var item in promptItemList.Items)
			{
				var itemPrompt = (Prompt)item;
				var index = promptItemList.Items.IndexOf(item);
				itemPrompt.checkState = promptItemList.GetItemCheckState(index);
			}
		}

		private void ClearAllPrompts()
		{
			promptItemList.Items.Clear();
			editPromptAnswerTextBox.Clear();
			editPromptTextBox.Clear();
		}

		private void swapCollection_Click(object sender, EventArgs e)
		{
			foreach (Prompt prompt in promptItemList.Items)
			{
				var pt = prompt.promptText;
				var ca = prompt.correctAnswer;
				prompt.correctAnswer = pt;
				prompt.promptText = ca;
			}

			promptItemList.Focus();
		}

		// this is when KeyDown on both prompt editing textBoxes 
		private void promptEditing_KeyDown(object sender, KeyEventArgs e)
		{
			// CTRL + N shortcut
			if (e.Modifiers == Keys.Control && e.KeyCode == Keys.N)
			{
				AddPrompt(promptText: editPromptTextBox.Text, correctAnswer: editPromptAnswerTextBox.Text);

				// suppress the *beep* windows sound;
				e.Handled = true;
				e.SuppressKeyPress = true;
				//
			}
		}

		private void clearMacros_Click(object sender, EventArgs e)
		{
			var macros = BaseForm.macros;

			macros.list.ForEach(macro => { macro.Text = ""; });
			macros.values = new string[Macros.macrosAmount];
		}

		private void editPromptTextBox_Enter(object sender, EventArgs e) => BaseForm.macros.target = editPromptTextBox;

		private void editPromptAnswerTextBox_Enter(object sender, EventArgs e) => BaseForm.macros.target = editPromptAnswerTextBox;
	}
}