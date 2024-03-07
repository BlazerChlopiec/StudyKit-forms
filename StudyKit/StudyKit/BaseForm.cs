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
		public static Color flatLightBlue = Color.FromArgb(135, 173, 253);

		UC_Study uc_study;
		UC_Edit uc_edit;

		public static Macros macros;

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

			InitializeMacros();
		}

		private void InitializeMacros()
		{
			macros = new Macros();
			macros.list.Add(macro1);

			for (int i = 0; i < Macros.macrosAmount - 1; i++)
			{
				var macro = macro1.Clone();
				macros.list.Add(macro);
				macro.Location = new Point(macro1.Location.X + 39 * (i + 1), macro1.Location.Y);
				macro.Show();
			}

			foreach (var macro in macros.list)
			{
				macro.MouseDoubleClick += new MouseEventHandler(delegate
				{
					if (macro.TextLength > 0)
					{
						uc_study.textBox.Text += macro.Text;
						macro.SelectionLength = 0;
						macro.SelectionStart = 1;
					}
				});

				macro.TextChanged += new EventHandler(delegate
				{
					macro.Text = macro.Text.Substring(0, 1); // this allows for one character only

					macro.SelectionStart = 1;

					var index = macros.list.IndexOf(macro);
					macros.values[index] = macro.Text;
				});
			}
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
			macros.list.ForEach((m) => { m.Enabled = false; });
			DarkenButtonAndLock(sender);
		}

		private void studyButton_Click(object sender, EventArgs e)
		{
			AddUserControl(uc_study);
			uc_study.RefreshPrompt();
			macros.list.ForEach((m) => { m.Enabled = true; });
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

		private void basePanel_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				// this gets all our dragged files
				var files = (string[])e.Data.GetData(DataFormats.FileDrop);

				var json = files[0]; // we can only use one file from drag & drop

				if (uc_edit.LoadFromJSON(json)) // if JSON loaded successfully
					uc_study.RefreshPrompt(); // fetch new prompt for studying
			}
		}

		private void basePanel_DragEnter(object sender, DragEventArgs e)
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