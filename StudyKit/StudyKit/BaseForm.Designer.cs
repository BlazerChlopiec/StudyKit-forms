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
			this.bobibenLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// editButton
			// 
			this.editButton.Location = new System.Drawing.Point(26, 24);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(84, 30);
			this.editButton.TabIndex = 0;
			this.editButton.Text = "Edit";
			this.editButton.UseVisualStyleBackColor = true;
			this.editButton.Click += new System.EventHandler(this.editButton_click);
			// 
			// checkButton
			// 
			this.checkButton.Enabled = false;
			this.checkButton.Location = new System.Drawing.Point(125, 203);
			this.checkButton.Name = "checkButton";
			this.checkButton.Size = new System.Drawing.Size(141, 46);
			this.checkButton.TabIndex = 2;
			this.checkButton.Text = "Check";
			this.checkButton.UseVisualStyleBackColor = true;
			this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
			// 
			// textBox
			// 
			this.textBox.Enabled = false;
			this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBox.Location = new System.Drawing.Point(44, 157);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(309, 30);
			this.textBox.TabIndex = 1;
			// 
			// promptLabel
			// 
			this.promptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.promptLabel.Location = new System.Drawing.Point(40, 62);
			this.promptLabel.Name = "promptLabel";
			this.promptLabel.Size = new System.Drawing.Size(313, 63);
			this.promptLabel.TabIndex = 0;
			this.promptLabel.Text = "---";
			this.promptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// correctLabel
			// 
			this.correctLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.correctLabel.Location = new System.Drawing.Point(40, 252);
			this.correctLabel.Name = "correctLabel";
			this.correctLabel.Size = new System.Drawing.Size(313, 63);
			this.correctLabel.TabIndex = 0;
			this.correctLabel.Text = "---";
			this.correctLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.correctLabel.Visible = false;
			// 
			// bobibenLabel
			// 
			this.bobibenLabel.AutoSize = true;
			this.bobibenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.bobibenLabel.Location = new System.Drawing.Point(276, 335);
			this.bobibenLabel.Name = "bobibenLabel";
			this.bobibenLabel.Size = new System.Drawing.Size(109, 13);
			this.bobibenLabel.TabIndex = 4;
			this.bobibenLabel.Text = "Bobi Ben Productions";
			// 
			// BaseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(397, 357);
			this.Controls.Add(this.bobibenLabel);
			this.Controls.Add(this.correctLabel);
			this.Controls.Add(this.promptLabel);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.checkButton);
			this.Controls.Add(this.editButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "BaseForm";
			this.Text = "StudyKit";
			this.ResumeLayout(false);
			this.PerformLayout();

		}


		#endregion

		public System.Windows.Forms.Button editButton;
		public System.Windows.Forms.Button checkButton;
		public System.Windows.Forms.TextBox textBox;
		public System.Windows.Forms.Label promptLabel;
		public System.Windows.Forms.Label correctLabel;
		private System.Windows.Forms.Label bobibenLabel;
	}
}

