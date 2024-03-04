using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

			AllowDrop = true;

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

		private void addPromptButton_Click(object sender, EventArgs e) => AddPrompt();

		private void AddPrompt(string promptText = "Default", string correctAnswer = "DefaultAnswer", CheckState checkState = CheckState.Checked)
		{
			var prompt = new Prompt();
			prompt.promptText = promptText;
			prompt.correctAnswer = correctAnswer;
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
			{
				prompts.Add((Prompt)item);
			}

			string output = JsonConvert.SerializeObject(prompts);
			var result = saveFileDialog.ShowDialog();

			if (result == DialogResult.OK)
			{
				string path = saveFileDialog.FileName;

				File.WriteAllText(path, output);
			}
		}

		private void loadButton_Click(object sender, EventArgs e)
		{
			var result = loadFileDialog.ShowDialog();

			if (result == DialogResult.OK)
			{
				ClearAllPrompts();
				LoadFromJSON(loadFileDialog.FileName);
			}
		}

		private void LoadFromJSON(string jsonPath)
		{
			using (StreamReader r = new StreamReader(jsonPath))
			{
				string json = r.ReadToEnd();

				try
				{
					var prompts = JsonConvert.DeserializeObject<List<Prompt>>(json);

					// if could load JSON correctly remove the errorLabel if shown
					errorLabel.Visible = false;

					foreach (var prompt in prompts)
					{
						AddPrompt(prompt.promptText, prompt.correctAnswer, prompt.checkState);
					}

				}
				catch (Exception) // if JSON is invalid
				{
					errorLabel.Visible = true;
					Console.WriteLine("JSON Incorrect!");
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

		private void UC_Edit_KeyDown(object sender, KeyEventArgs e)
		{
			// Add Prompt Shortcut CTRL + N
			if (e.Modifiers == Keys.Control && e.KeyCode == Keys.N)
			{
				AddPrompt();
			}
		}

		private void UC_Edit_DragDrop(object sender, DragEventArgs e)
		{
			try
			{
				if (e.Data.GetDataPresent(DataFormats.FileDrop))
				{
					// this gets all our dragged files
					var files = (string[])e.Data.GetData(DataFormats.FileDrop);

					LoadFromJSON(files[0]); // we only use one dragged json file
				}
			}
			catch (Exception)
			{
				Console.WriteLine("Couldn't fetch dropData");
			}
		}

		private void UC_Edit_DragEnter(object sender, DragEventArgs e)
		{
			// Check if the Data being dragged is of a format you can accept
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.All; // Or another appropriate effect
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}
	}
}