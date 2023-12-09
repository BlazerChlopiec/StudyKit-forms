namespace StudyKit.UserControls
{
	partial class UC_Edit
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.promptItemList = new System.Windows.Forms.CheckedListBox();
			this.promptsLabel = new System.Windows.Forms.Label();
			this.addPromptButton = new System.Windows.Forms.Button();
			this.editPromptTextBox = new System.Windows.Forms.TextBox();
			this.editPromptLabel = new System.Windows.Forms.Label();
			this.editPromptAnswerTextBox = new System.Windows.Forms.TextBox();
			this.loadButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.loadFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.removePrompt = new System.Windows.Forms.Button();
			this.clearPrompts = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// promptItemList
			// 
			this.promptItemList.FormattingEnabled = true;
			this.promptItemList.Location = new System.Drawing.Point(139, 53);
			this.promptItemList.Name = "promptItemList";
			this.promptItemList.Size = new System.Drawing.Size(364, 199);
			this.promptItemList.TabIndex = 0;
			this.promptItemList.TabStop = false;
			// 
			// promptsLabel
			// 
			this.promptsLabel.AutoSize = true;
			this.promptsLabel.Location = new System.Drawing.Point(144, 33);
			this.promptsLabel.Name = "promptsLabel";
			this.promptsLabel.Size = new System.Drawing.Size(48, 13);
			this.promptsLabel.TabIndex = 1;
			this.promptsLabel.Text = "Prompts:";
			// 
			// addPromptButton
			// 
			this.addPromptButton.Location = new System.Drawing.Point(142, 263);
			this.addPromptButton.Name = "addPromptButton";
			this.addPromptButton.Size = new System.Drawing.Size(75, 23);
			this.addPromptButton.TabIndex = 2;
			this.addPromptButton.TabStop = false;
			this.addPromptButton.Text = "Add Prompt";
			this.addPromptButton.UseVisualStyleBackColor = true;
			this.addPromptButton.Click += new System.EventHandler(this.addPromptButton_Click);
			// 
			// editPromptTextBox
			// 
			this.editPromptTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.editPromptTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.editPromptTextBox.Location = new System.Drawing.Point(142, 331);
			this.editPromptTextBox.Name = "editPromptTextBox";
			this.editPromptTextBox.Size = new System.Drawing.Size(361, 20);
			this.editPromptTextBox.TabIndex = 3;
			// 
			// editPromptLabel
			// 
			this.editPromptLabel.AutoSize = true;
			this.editPromptLabel.Location = new System.Drawing.Point(144, 315);
			this.editPromptLabel.Name = "editPromptLabel";
			this.editPromptLabel.Size = new System.Drawing.Size(61, 13);
			this.editPromptLabel.TabIndex = 4;
			this.editPromptLabel.Text = "Edit Prompt";
			// 
			// editPromptAnswerTextBox
			// 
			this.editPromptAnswerTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.editPromptAnswerTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.editPromptAnswerTextBox.Location = new System.Drawing.Point(142, 357);
			this.editPromptAnswerTextBox.Name = "editPromptAnswerTextBox";
			this.editPromptAnswerTextBox.Size = new System.Drawing.Size(361, 20);
			this.editPromptAnswerTextBox.TabIndex = 5;
			// 
			// loadButton
			// 
			this.loadButton.Location = new System.Drawing.Point(427, 263);
			this.loadButton.Name = "loadButton";
			this.loadButton.Size = new System.Drawing.Size(75, 23);
			this.loadButton.TabIndex = 7;
			this.loadButton.TabStop = false;
			this.loadButton.Text = "Load";
			this.loadButton.UseVisualStyleBackColor = true;
			this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(346, 263);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 6;
			this.saveButton.TabStop = false;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// loadFileDialog
			// 
			this.loadFileDialog.DefaultExt = "json";
			this.loadFileDialog.FileName = "loadFileDialog";
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.DefaultExt = "json";
			// 
			// removePrompt
			// 
			this.removePrompt.Location = new System.Drawing.Point(223, 263);
			this.removePrompt.Name = "removePrompt";
			this.removePrompt.Size = new System.Drawing.Size(96, 23);
			this.removePrompt.TabIndex = 8;
			this.removePrompt.TabStop = false;
			this.removePrompt.Text = "Remove Prompt";
			this.removePrompt.UseVisualStyleBackColor = true;
			this.removePrompt.Click += new System.EventHandler(this.removePrompt_Click);
			// 
			// clearPrompts
			// 
			this.clearPrompts.Location = new System.Drawing.Point(223, 292);
			this.clearPrompts.Name = "clearPrompts";
			this.clearPrompts.Size = new System.Drawing.Size(96, 23);
			this.clearPrompts.TabIndex = 9;
			this.clearPrompts.TabStop = false;
			this.clearPrompts.Text = "Clear Prompts";
			this.clearPrompts.UseVisualStyleBackColor = true;
			this.clearPrompts.Click += new System.EventHandler(this.clearPrompts_Click);
			// 
			// UC_Edit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.clearPrompts);
			this.Controls.Add(this.removePrompt);
			this.Controls.Add(this.loadButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.editPromptAnswerTextBox);
			this.Controls.Add(this.editPromptLabel);
			this.Controls.Add(this.editPromptTextBox);
			this.Controls.Add(this.addPromptButton);
			this.Controls.Add(this.promptsLabel);
			this.Controls.Add(this.promptItemList);
			this.Name = "UC_Edit";
			this.Size = new System.Drawing.Size(634, 411);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UC_Edit_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Button clearPrompts;
		public System.Windows.Forms.Button removePrompt;
		private System.Windows.Forms.Button loadButton;
		private System.Windows.Forms.Button saveButton;
		public System.Windows.Forms.TextBox editPromptAnswerTextBox;
		public System.Windows.Forms.Label editPromptLabel;
		public System.Windows.Forms.TextBox editPromptTextBox;
		public System.Windows.Forms.Button addPromptButton;
		public System.Windows.Forms.Label promptsLabel;
		public System.Windows.Forms.CheckedListBox promptItemList;
		private System.Windows.Forms.OpenFileDialog loadFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
	}
}
