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
			this.swapCollection = new System.Windows.Forms.Button();
			this.errorLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// promptItemList
			// 
			this.promptItemList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
			this.promptItemList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.promptItemList.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.promptItemList.ForeColor = System.Drawing.Color.White;
			this.promptItemList.FormattingEnabled = true;
			this.promptItemList.Location = new System.Drawing.Point(38, 152);
			this.promptItemList.Name = "promptItemList";
			this.promptItemList.Size = new System.Drawing.Size(364, 140);
			this.promptItemList.TabIndex = 0;
			this.promptItemList.TabStop = false;
			// 
			// promptsLabel
			// 
			this.promptsLabel.AutoSize = true;
			this.promptsLabel.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold);
			this.promptsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
			this.promptsLabel.Location = new System.Drawing.Point(44, 125);
			this.promptsLabel.Name = "promptsLabel";
			this.promptsLabel.Size = new System.Drawing.Size(95, 25);
			this.promptsLabel.TabIndex = 1;
			this.promptsLabel.Text = "Prompts:";
			// 
			// addPromptButton
			// 
			this.addPromptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
			this.addPromptButton.FlatAppearance.BorderSize = 0;
			this.addPromptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addPromptButton.Font = new System.Drawing.Font("Yu Gothic", 10.25F, System.Drawing.FontStyle.Bold);
			this.addPromptButton.ForeColor = System.Drawing.Color.White;
			this.addPromptButton.Location = new System.Drawing.Point(428, 151);
			this.addPromptButton.Name = "addPromptButton";
			this.addPromptButton.Size = new System.Drawing.Size(75, 27);
			this.addPromptButton.TabIndex = 2;
			this.addPromptButton.TabStop = false;
			this.addPromptButton.Text = "Add Prompt";
			this.addPromptButton.UseVisualStyleBackColor = false;
			this.addPromptButton.Click += new System.EventHandler(this.addPromptButton_Click);
			// 
			// editPromptTextBox
			// 
			this.editPromptTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.editPromptTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.editPromptTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
			this.editPromptTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.editPromptTextBox.Font = new System.Drawing.Font("Yu Gothic", 12.14F, System.Drawing.FontStyle.Bold);
			this.editPromptTextBox.ForeColor = System.Drawing.Color.White;
			this.editPromptTextBox.Location = new System.Drawing.Point(38, 340);
			this.editPromptTextBox.Name = "editPromptTextBox";
			this.editPromptTextBox.Size = new System.Drawing.Size(361, 26);
			this.editPromptTextBox.TabIndex = 3;
			// 
			// editPromptLabel
			// 
			this.editPromptLabel.AutoSize = true;
			this.editPromptLabel.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold);
			this.editPromptLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
			this.editPromptLabel.Location = new System.Drawing.Point(43, 311);
			this.editPromptLabel.Name = "editPromptLabel";
			this.editPromptLabel.Size = new System.Drawing.Size(120, 25);
			this.editPromptLabel.TabIndex = 4;
			this.editPromptLabel.Text = "Edit Prompt";
			// 
			// editPromptAnswerTextBox
			// 
			this.editPromptAnswerTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.editPromptAnswerTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.editPromptAnswerTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
			this.editPromptAnswerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.editPromptAnswerTextBox.Font = new System.Drawing.Font("Yu Gothic", 12.14F, System.Drawing.FontStyle.Bold);
			this.editPromptAnswerTextBox.ForeColor = System.Drawing.Color.White;
			this.editPromptAnswerTextBox.Location = new System.Drawing.Point(38, 371);
			this.editPromptAnswerTextBox.Name = "editPromptAnswerTextBox";
			this.editPromptAnswerTextBox.Size = new System.Drawing.Size(361, 26);
			this.editPromptAnswerTextBox.TabIndex = 5;
			// 
			// loadButton
			// 
			this.loadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
			this.loadButton.FlatAppearance.BorderSize = 0;
			this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loadButton.Font = new System.Drawing.Font("Yu Gothic", 10.25F, System.Drawing.FontStyle.Bold);
			this.loadButton.ForeColor = System.Drawing.Color.White;
			this.loadButton.Location = new System.Drawing.Point(509, 360);
			this.loadButton.Name = "loadButton";
			this.loadButton.Size = new System.Drawing.Size(75, 27);
			this.loadButton.TabIndex = 7;
			this.loadButton.TabStop = false;
			this.loadButton.Text = "Load";
			this.loadButton.UseVisualStyleBackColor = false;
			this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
			this.saveButton.FlatAppearance.BorderSize = 0;
			this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.saveButton.Font = new System.Drawing.Font("Yu Gothic", 10.25F, System.Drawing.FontStyle.Bold);
			this.saveButton.ForeColor = System.Drawing.Color.White;
			this.saveButton.Location = new System.Drawing.Point(428, 360);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 27);
			this.saveButton.TabIndex = 6;
			this.saveButton.TabStop = false;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = false;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// loadFileDialog
			// 
			this.loadFileDialog.DefaultExt = "json";
			this.loadFileDialog.FileName = "loadFileDialog";
			this.loadFileDialog.Filter = "Json files (*.json)|*.json";
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.DefaultExt = "json";
			// 
			// removePrompt
			// 
			this.removePrompt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
			this.removePrompt.FlatAppearance.BorderSize = 0;
			this.removePrompt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.removePrompt.Font = new System.Drawing.Font("Yu Gothic", 10.25F, System.Drawing.FontStyle.Bold);
			this.removePrompt.ForeColor = System.Drawing.Color.White;
			this.removePrompt.Location = new System.Drawing.Point(509, 151);
			this.removePrompt.Name = "removePrompt";
			this.removePrompt.Size = new System.Drawing.Size(75, 27);
			this.removePrompt.TabIndex = 8;
			this.removePrompt.TabStop = false;
			this.removePrompt.Text = "Remove Prompt";
			this.removePrompt.UseVisualStyleBackColor = false;
			this.removePrompt.Click += new System.EventHandler(this.removePrompt_Click);
			// 
			// clearPrompts
			// 
			this.clearPrompts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
			this.clearPrompts.FlatAppearance.BorderSize = 0;
			this.clearPrompts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clearPrompts.Font = new System.Drawing.Font("Yu Gothic", 10.25F, System.Drawing.FontStyle.Bold);
			this.clearPrompts.ForeColor = System.Drawing.Color.White;
			this.clearPrompts.Location = new System.Drawing.Point(428, 184);
			this.clearPrompts.Name = "clearPrompts";
			this.clearPrompts.Size = new System.Drawing.Size(156, 27);
			this.clearPrompts.TabIndex = 9;
			this.clearPrompts.TabStop = false;
			this.clearPrompts.Text = "Clear Prompts";
			this.clearPrompts.UseVisualStyleBackColor = false;
			this.clearPrompts.Click += new System.EventHandler(this.clearPrompts_Click);
			// 
			// swapCollection
			// 
			this.swapCollection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
			this.swapCollection.FlatAppearance.BorderSize = 0;
			this.swapCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.swapCollection.Font = new System.Drawing.Font("Yu Gothic", 10.25F, System.Drawing.FontStyle.Bold);
			this.swapCollection.ForeColor = System.Drawing.Color.White;
			this.swapCollection.Location = new System.Drawing.Point(428, 229);
			this.swapCollection.Name = "swapCollection";
			this.swapCollection.Size = new System.Drawing.Size(156, 27);
			this.swapCollection.TabIndex = 10;
			this.swapCollection.TabStop = false;
			this.swapCollection.Text = "Swap Collection";
			this.swapCollection.UseVisualStyleBackColor = false;
			this.swapCollection.Click += new System.EventHandler(this.swapCollection_Click);
			// 
			// errorLabel
			// 
			this.errorLabel.AutoSize = true;
			this.errorLabel.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold);
			this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.errorLabel.Location = new System.Drawing.Point(453, 339);
			this.errorLabel.Name = "errorLabel";
			this.errorLabel.Size = new System.Drawing.Size(110, 18);
			this.errorLabel.TabIndex = 11;
			this.errorLabel.Text = "Incorrect JSON";
			this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.errorLabel.Visible = false;
			// 
			// UC_Edit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.errorLabel);
			this.Controls.Add(this.swapCollection);
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
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.UC_Edit_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.UC_Edit_DragEnter);
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
		public System.Windows.Forms.Button swapCollection;
		public System.Windows.Forms.Label errorLabel;
	}
}
