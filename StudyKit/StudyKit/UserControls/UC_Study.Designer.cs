﻿namespace StudyKit.UserControls
{
	partial class UC_Study
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
			this.correctLabel = new System.Windows.Forms.Label();
			this.promptLabel = new System.Windows.Forms.Label();
			this.textBox = new System.Windows.Forms.TextBox();
			this.checkButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// correctLabel
			// 
			this.correctLabel.Font = new System.Drawing.Font("Uni Sans Heavy CAPS", 21.27F, System.Drawing.FontStyle.Bold);
			this.correctLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
			this.correctLabel.Location = new System.Drawing.Point(158, 282);
			this.correctLabel.Name = "correctLabel";
			this.correctLabel.Size = new System.Drawing.Size(313, 63);
			this.correctLabel.TabIndex = 3;
			this.correctLabel.Text = "---";
			this.correctLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.correctLabel.Visible = false;
			// 
			// promptLabel
			// 
			this.promptLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(28)))), ((int)(((byte)(53)))));
			this.promptLabel.Font = new System.Drawing.Font("Uni Sans Heavy CAPS", 21.27F, System.Drawing.FontStyle.Bold);
			this.promptLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.promptLabel.Location = new System.Drawing.Point(158, 158);
			this.promptLabel.Name = "promptLabel";
			this.promptLabel.Size = new System.Drawing.Size(313, 63);
			this.promptLabel.TabIndex = 4;
			this.promptLabel.Text = "---";
			this.promptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox
			// 
			this.textBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.textBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
			this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox.Enabled = false;
			this.textBox.Font = new System.Drawing.Font("Uni Sans Heavy CAPS", 24.29F, System.Drawing.FontStyle.Bold);
			this.textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(173)))), ((int)(((byte)(253)))));
			this.textBox.Location = new System.Drawing.Point(104, 224);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(371, 39);
			this.textBox.TabIndex = 5;
			// 
			// checkButton
			// 
			this.checkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(204)))), ((int)(((byte)(137)))));
			this.checkButton.BackgroundImage = global::StudyKit.Properties.Resources.arrow;
			this.checkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.checkButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkButton.Enabled = false;
			this.checkButton.FlatAppearance.BorderSize = 0;
			this.checkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkButton.Font = new System.Drawing.Font("Uni Sans Heavy CAPS", 21.27F, System.Drawing.FontStyle.Bold);
			this.checkButton.Location = new System.Drawing.Point(491, 224);
			this.checkButton.Name = "checkButton";
			this.checkButton.Size = new System.Drawing.Size(39, 39);
			this.checkButton.TabIndex = 6;
			this.checkButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.checkButton.UseVisualStyleBackColor = false;
			this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
			// 
			// UC_Study
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.correctLabel);
			this.Controls.Add(this.promptLabel);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.checkButton);
			this.Name = "UC_Study";
			this.Size = new System.Drawing.Size(634, 411);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label correctLabel;
		public System.Windows.Forms.Label promptLabel;
		public System.Windows.Forms.TextBox textBox;
		public System.Windows.Forms.Button checkButton;
	}
}