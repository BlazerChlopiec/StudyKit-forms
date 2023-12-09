namespace StudyKit
{
	partial class BaseForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.editButton = new System.Windows.Forms.Button();
			this.checkButton = new System.Windows.Forms.Button();
			this.textBox = new System.Windows.Forms.TextBox();
			this.promptLabel = new System.Windows.Forms.Label();
			this.correctLabel = new System.Windows.Forms.Label();
			this.optionPanel = new System.Windows.Forms.Panel();
			this.quitButton = new System.Windows.Forms.Button();
			this.studyButton = new System.Windows.Forms.Button();
			this.optionPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// editButton
			// 
			this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(204)))), ((int)(((byte)(137)))));
			this.editButton.FlatAppearance.BorderSize = 0;
			this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.editButton.Font = new System.Drawing.Font("Uni Sans Heavy CAPS", 14.25F, System.Drawing.FontStyle.Bold);
			this.editButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.editButton.Location = new System.Drawing.Point(159, 26);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(116, 49);
			this.editButton.TabIndex = 0;
			this.editButton.Text = "Edit";
			this.editButton.UseVisualStyleBackColor = false;
			this.editButton.Click += new System.EventHandler(this.editButton_click);
			// 
			// checkButton
			// 
			this.checkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(204)))), ((int)(((byte)(137)))));
			this.checkButton.BackgroundImage = global::StudyKit.Properties.Resources.arrow;
			this.checkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.checkButton.Enabled = false;
			this.checkButton.FlatAppearance.BorderSize = 0;
			this.checkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkButton.Font = new System.Drawing.Font("Uni Sans Heavy CAPS", 21.27F, System.Drawing.FontStyle.Bold);
			this.checkButton.Location = new System.Drawing.Point(488, 205);
			this.checkButton.Name = "checkButton";
			this.checkButton.Size = new System.Drawing.Size(39, 39);
			this.checkButton.TabIndex = 2;
			this.checkButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.checkButton.UseVisualStyleBackColor = false;
			this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
			// 
			// textBox
			// 
			this.textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
			this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox.Enabled = false;
			this.textBox.Font = new System.Drawing.Font("Uni Sans Heavy CAPS", 24.29F, System.Drawing.FontStyle.Bold);
			this.textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(173)))), ((int)(((byte)(253)))));
			this.textBox.Location = new System.Drawing.Point(101, 205);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(371, 39);
			this.textBox.TabIndex = 1;
			// 
			// promptLabel
			// 
			this.promptLabel.Font = new System.Drawing.Font("Uni Sans Heavy CAPS", 21.27F, System.Drawing.FontStyle.Bold);
			this.promptLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.promptLabel.Location = new System.Drawing.Point(155, 139);
			this.promptLabel.Name = "promptLabel";
			this.promptLabel.Size = new System.Drawing.Size(313, 63);
			this.promptLabel.TabIndex = 0;
			this.promptLabel.Text = "---";
			this.promptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// correctLabel
			// 
			this.correctLabel.Font = new System.Drawing.Font("Uni Sans Heavy CAPS", 21.27F, System.Drawing.FontStyle.Bold);
			this.correctLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
			this.correctLabel.Location = new System.Drawing.Point(155, 263);
			this.correctLabel.Name = "correctLabel";
			this.correctLabel.Size = new System.Drawing.Size(313, 63);
			this.correctLabel.TabIndex = 0;
			this.correctLabel.Text = "---";
			this.correctLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.correctLabel.Visible = false;
			// 
			// optionPanel
			// 
			this.optionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
			this.optionPanel.Controls.Add(this.quitButton);
			this.optionPanel.Controls.Add(this.studyButton);
			this.optionPanel.Controls.Add(this.editButton);
			this.optionPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.optionPanel.Location = new System.Drawing.Point(0, 0);
			this.optionPanel.Name = "optionPanel";
			this.optionPanel.Size = new System.Drawing.Size(634, 100);
			this.optionPanel.TabIndex = 3;
			this.optionPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.optionPanel_MouseDown);
			// 
			// quitButton
			// 
			this.quitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
			this.quitButton.FlatAppearance.BorderSize = 0;
			this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.quitButton.Font = new System.Drawing.Font("Uni Sans Heavy CAPS", 14.25F, System.Drawing.FontStyle.Bold);
			this.quitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.quitButton.Location = new System.Drawing.Point(487, 26);
			this.quitButton.Name = "quitButton";
			this.quitButton.Size = new System.Drawing.Size(116, 49);
			this.quitButton.TabIndex = 2;
			this.quitButton.Text = "Quit";
			this.quitButton.UseVisualStyleBackColor = false;
			this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
			// 
			// studyButton
			// 
			this.studyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
			this.studyButton.FlatAppearance.BorderSize = 0;
			this.studyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.studyButton.Font = new System.Drawing.Font("Uni Sans Heavy CAPS", 14.25F, System.Drawing.FontStyle.Bold);
			this.studyButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.studyButton.Location = new System.Drawing.Point(24, 26);
			this.studyButton.Name = "studyButton";
			this.studyButton.Size = new System.Drawing.Size(116, 49);
			this.studyButton.TabIndex = 1;
			this.studyButton.Text = "Study";
			this.studyButton.UseVisualStyleBackColor = false;
			// 
			// BaseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(28)))), ((int)(((byte)(53)))));
			this.ClientSize = new System.Drawing.Size(634, 411);
			this.Controls.Add(this.optionPanel);
			this.Controls.Add(this.correctLabel);
			this.Controls.Add(this.promptLabel);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.checkButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "BaseForm";
			this.Text = "StudyKit";
			this.optionPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}


		#endregion

		public System.Windows.Forms.Button editButton;
		public System.Windows.Forms.Button checkButton;
		public System.Windows.Forms.TextBox textBox;
		public System.Windows.Forms.Label promptLabel;
		public System.Windows.Forms.Label correctLabel;
		private System.Windows.Forms.Panel optionPanel;
		public System.Windows.Forms.Button quitButton;
		public System.Windows.Forms.Button studyButton;
	}
}

