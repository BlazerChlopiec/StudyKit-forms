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
			this.specialCharacter1 = new System.Windows.Forms.Button();
			this.specialCharacter2 = new System.Windows.Forms.Button();
			this.specialCharacter3 = new System.Windows.Forms.Button();
			this.specialCharacter4 = new System.Windows.Forms.Button();
			this.specialCharacter5 = new System.Windows.Forms.Button();
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
			// specialCharacter1
			// 
			this.specialCharacter1.Enabled = false;
			this.specialCharacter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.specialCharacter1.Location = new System.Drawing.Point(91, 128);
			this.specialCharacter1.Name = "specialCharacter1";
			this.specialCharacter1.Size = new System.Drawing.Size(37, 23);
			this.specialCharacter1.TabIndex = 5;
			this.specialCharacter1.Text = "ä";
			this.specialCharacter1.UseVisualStyleBackColor = true;
			this.specialCharacter1.Click += new System.EventHandler(this.specialCharacter1_Click);
			// 
			// specialCharacter2
			// 
			this.specialCharacter2.Enabled = false;
			this.specialCharacter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.specialCharacter2.Location = new System.Drawing.Point(134, 128);
			this.specialCharacter2.Name = "specialCharacter2";
			this.specialCharacter2.Size = new System.Drawing.Size(37, 23);
			this.specialCharacter2.TabIndex = 6;
			this.specialCharacter2.Text = "ö";
			this.specialCharacter2.UseVisualStyleBackColor = true;
			this.specialCharacter2.Click += new System.EventHandler(this.specialCharacter2_Click);
			// 
			// specialCharacter3
			// 
			this.specialCharacter3.Enabled = false;
			this.specialCharacter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.specialCharacter3.Location = new System.Drawing.Point(177, 128);
			this.specialCharacter3.Name = "specialCharacter3";
			this.specialCharacter3.Size = new System.Drawing.Size(37, 23);
			this.specialCharacter3.TabIndex = 7;
			this.specialCharacter3.Text = "ü";
			this.specialCharacter3.UseVisualStyleBackColor = true;
			this.specialCharacter3.Click += new System.EventHandler(this.specialCharacter3_Click);
			// 
			// specialCharacter4
			// 
			this.specialCharacter4.Enabled = false;
			this.specialCharacter4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.specialCharacter4.Location = new System.Drawing.Point(220, 128);
			this.specialCharacter4.Name = "specialCharacter4";
			this.specialCharacter4.Size = new System.Drawing.Size(37, 23);
			this.specialCharacter4.TabIndex = 8;
			this.specialCharacter4.Text = "ß";
			this.specialCharacter4.UseVisualStyleBackColor = true;
			this.specialCharacter4.Click += new System.EventHandler(this.specialCharacter4_Click);
			// 
			// specialCharacter5
			// 
			this.specialCharacter5.Enabled = false;
			this.specialCharacter5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.specialCharacter5.Location = new System.Drawing.Point(263, 128);
			this.specialCharacter5.Name = "specialCharacter5";
			this.specialCharacter5.Size = new System.Drawing.Size(37, 23);
			this.specialCharacter5.TabIndex = 9;
			this.specialCharacter5.Text = "-̈";
			this.specialCharacter5.UseVisualStyleBackColor = true;
			this.specialCharacter5.Click += new System.EventHandler(this.specialCharacter5_Click);
			// 
			// BaseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(397, 357);
			this.Controls.Add(this.specialCharacter5);
			this.Controls.Add(this.specialCharacter4);
			this.Controls.Add(this.specialCharacter3);
			this.Controls.Add(this.specialCharacter2);
			this.Controls.Add(this.specialCharacter1);
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
		public System.Windows.Forms.Button specialCharacter1;
		public System.Windows.Forms.Button specialCharacter2;
		public System.Windows.Forms.Button specialCharacter3;
		public System.Windows.Forms.Button specialCharacter4;
		public System.Windows.Forms.Button specialCharacter5;
	}
}

