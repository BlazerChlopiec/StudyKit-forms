using StudyKit.UserControls;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace StudyKit
{
	public partial class BaseForm : Form
	{
		public static Color flatRed = Color.FromArgb(204, 82, 82);

		UC_Study uc_study;
		UC_Edit uc_edit;

		Button currentButton;
		Color previousButtonColor;

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


		public BaseForm()
		{
			InitializeComponent();

			uc_study = new UC_Study();
			AddUserControl(uc_study);

			uc_edit = new UC_Edit();
			uc_edit.uc_study = uc_study;

			uc_study.uc_edit = uc_edit;

			DarkenButtonAndLock(studyButton);
		}

		private void AddUserControl(UserControl uc)
		{
			uc.Dock = DockStyle.Fill;
			basePanel.Controls.Clear();
			basePanel.Controls.Add(uc);
			uc.BringToFront();
		}

		private void editButton_click(object sender, System.EventArgs e)
		{
			AddUserControl(uc_edit);
			DarkenButtonAndLock(sender);
		}

		private void studyButton_Click(object sender, EventArgs e)
		{
			AddUserControl(uc_study);
			if (uc_study.currentPrompt == null) uc_study.RefreshPrompt();
			DarkenButtonAndLock(sender);
		}

		private void quitButton_Click(object sender, EventArgs e) => Application.Exit();

		private void optionPanel_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(Handle, 0x112, 0xf012, 0);
		}

		private void DarkenButtonAndLock(object sender)
		{
			if (currentButton != null) currentButton.Enabled = true;
			if (previousButtonColor != Color.Empty) currentButton.BackColor = previousButtonColor;

			currentButton = sender as Button;

			currentButton.Enabled = false;
			previousButtonColor = currentButton.BackColor;

			var proc = .4f;
			currentButton.BackColor = Color.FromArgb((int)(currentButton.BackColor.R * (1f - proc)),
													(int)(currentButton.BackColor.G * (1f - proc)),
													(int)(currentButton.BackColor.B * (1f - proc)));
		}
	}
}