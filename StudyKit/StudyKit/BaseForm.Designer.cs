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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
			this.editButton = new System.Windows.Forms.Button();
			this.optionPanel = new System.Windows.Forms.Panel();
			this.macro1 = new System.Windows.Forms.TextBox();
			this.quitButton = new System.Windows.Forms.Button();
			this.studyButton = new System.Windows.Forms.Button();
			this.basePanel = new System.Windows.Forms.Panel();
			this.optionPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// editButton
			// 
			this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(204)))), ((int)(((byte)(137)))));
			this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.editButton.FlatAppearance.BorderSize = 0;
			this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.editButton.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold);
			this.editButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.editButton.Location = new System.Drawing.Point(159, 26);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(116, 49);
			this.editButton.TabIndex = 0;
			this.editButton.TabStop = false;
			this.editButton.Text = "Edit";
			this.editButton.UseVisualStyleBackColor = false;
			this.editButton.Click += new System.EventHandler(this.editButton_click);
			// 
			// optionPanel
			// 
			this.optionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
			this.optionPanel.Controls.Add(this.macro1);
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
			// macro1
			// 
			this.macro1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.macro1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.macro1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.macro1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(28)))), ((int)(((byte)(53)))));
			this.macro1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.macro1.Font = new System.Drawing.Font("Yu Gothic", 17F, System.Drawing.FontStyle.Bold);
			this.macro1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(173)))), ((int)(((byte)(253)))));
			this.macro1.Location = new System.Drawing.Point(288, 34);
			this.macro1.Name = "macro1";
			this.macro1.Size = new System.Drawing.Size(31, 37);
			this.macro1.TabIndex = 0;
			this.macro1.TabStop = false;
			this.macro1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.macro1.WordWrap = false;
			// 
			// quitButton
			// 
			this.quitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
			this.quitButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.quitButton.FlatAppearance.BorderSize = 0;
			this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.quitButton.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold);
			this.quitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.quitButton.Location = new System.Drawing.Point(487, 26);
			this.quitButton.Name = "quitButton";
			this.quitButton.Size = new System.Drawing.Size(116, 49);
			this.quitButton.TabIndex = 2;
			this.quitButton.TabStop = false;
			this.quitButton.Text = "Quit";
			this.quitButton.UseVisualStyleBackColor = false;
			this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
			// 
			// studyButton
			// 
			this.studyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
			this.studyButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.studyButton.FlatAppearance.BorderSize = 0;
			this.studyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.studyButton.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold);
			this.studyButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.studyButton.Location = new System.Drawing.Point(24, 26);
			this.studyButton.Name = "studyButton";
			this.studyButton.Size = new System.Drawing.Size(116, 49);
			this.studyButton.TabIndex = 1;
			this.studyButton.TabStop = false;
			this.studyButton.Text = "Study";
			this.studyButton.UseVisualStyleBackColor = false;
			this.studyButton.Click += new System.EventHandler(this.studyButton_Click);
			// 
			// basePanel
			// 
			this.basePanel.AllowDrop = true;
			this.basePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(28)))), ((int)(((byte)(53)))));
			this.basePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.basePanel.Location = new System.Drawing.Point(0, 0);
			this.basePanel.Name = "basePanel";
			this.basePanel.Size = new System.Drawing.Size(634, 411);
			this.basePanel.TabIndex = 4;
			this.basePanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.basePanel_DragDrop);
			this.basePanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.basePanel_DragEnter);
			// 
			// BaseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.ClientSize = new System.Drawing.Size(634, 411);
			this.Controls.Add(this.optionPanel);
			this.Controls.Add(this.basePanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "BaseForm";
			this.Text = "StudyKit";
			this.optionPanel.ResumeLayout(false);
			this.optionPanel.PerformLayout();
			this.ResumeLayout(false);

		}


		#endregion

		public System.Windows.Forms.Button editButton;
		private System.Windows.Forms.Panel optionPanel;
		public System.Windows.Forms.Button quitButton;
		public System.Windows.Forms.Button studyButton;
		private System.Windows.Forms.Panel basePanel;
		private System.Windows.Forms.TextBox macro1;
	}
}

