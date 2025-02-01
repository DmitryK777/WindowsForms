using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using Microsoft.Win32;

namespace Clock
{
	public partial class MainForm : Form
	{
		FontDialog fontDialog;
		AlarmsForm alarmsForm;
		Alarm nextAlarm;

		public MainForm()
		{
			InitializeComponent();

			labelTime.BackColor = Color.AliceBlue;
			this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - (2 * this.Width), 100);
			
			toolStripMenuItemShowControls.Checked = true;
			toolStripMenuItemShowConsole.Checked = false;
			
			//fontDialog = new FontDialog();
			Console.WriteLine(Directory.GetCurrentDirectory());

			LoadSettings();
			alarmsForm = new AlarmsForm(this);

			if(fontDialog == null) fontDialog = new FontDialog();
		}

		
		void SetVisibility (bool visible)
		{
			checkBoxShowDate.Visible = visible;
			checkBoxShowWeekDay.Visible = visible;
			buttonHideControls.Visible = visible;
			this.FormBorderStyle = visible ? FormBorderStyle.FixedDialog : FormBorderStyle.None;
			this.ShowInTaskbar = visible;
			this.TransparencyKey = visible ? Color.Empty : this.BackColor;
		}

		void LoadSettings()
		{
			StreamReader sr = null;

			try
			{
				sr = new StreamReader($"{Path.GetDirectoryName(Application.ExecutablePath)}\\..\\..\\Settings.ini");

				toolStripMenuItemTopmost.Checked = Boolean.Parse(sr.ReadLine());         // TopMost
				toolStripMenuItemShowControls.Checked = Boolean.Parse(sr.ReadLine());    // ShowControls
				toolStripMenuItemShowConsole.Checked = Boolean.Parse(sr.ReadLine());     // ShowConsole
				toolStripMenuItemShowDate.Checked = Boolean.Parse(sr.ReadLine());        // ShowDate
				toolStripMenuItemShowWeekday.Checked = Boolean.Parse(sr.ReadLine());     // ShowWeekday

				string fontname = sr.ReadLine();                                         // Font
				float fontsize = (float)Convert.ToDouble(sr.ReadLine());                 // FontSize

				labelTime.BackColor = Color.FromArgb(Convert.ToInt32(sr.ReadLine()));    // BackgroundColor
				labelTime.ForeColor = Color.FromArgb(Convert.ToInt32(sr.ReadLine()));    // ForegroundColor

				sr.Close();

				fontDialog = new FontDialog(fontname, fontsize);
				labelTime.Font = fontDialog.Font;

				
			}
			catch (Exception ex) 
			{
				MessageBox.Show(this, ex.Message, "In LoadSettings()", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(this, ex.ToString(), "In LoadSettings()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			

			
		}

		void SaveSettings()
		{
			StreamWriter sw = 
				new StreamWriter($"{ Path.GetDirectoryName(Application.ExecutablePath)}\\..\\..\\Settings.ini");

			sw.WriteLine($"{toolStripMenuItemTopmost.Checked}");       // TopMost
			sw.WriteLine($"{toolStripMenuItemShowControls.Checked}");  // ShowControls
			sw.WriteLine($"{toolStripMenuItemShowConsole.Checked}");   // ShowConsole
			sw.WriteLine($"{toolStripMenuItemShowDate.Checked}");      // ShowDate
			sw.WriteLine($"{toolStripMenuItemShowWeekday.Checked}");   // ShowWeekday

			sw.WriteLine($"{fontDialog.FontFilename}");                // Font
			sw.WriteLine($"{labelTime.Font.Size}");                    // FontSize

			sw.WriteLine($"{labelTime.BackColor.ToArgb()}");           // BackgroundColor
			sw.WriteLine($"{labelTime.ForeColor.ToArgb()}");           // ForegroundColor

			sw.Close();
		}

		Alarm FindNextAlarm()
		{
			nextAlarm = alarmsForm.Alarms.Items.Cast<Alarm>().ToArray().Min();

			return nextAlarm;
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			//this.DoubleBuffered = true;
			//this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

			labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
			//labelTime.Text = DateTime.Now.ToString("HH:mm:ss");

			if (checkBoxShowDate.Checked) 
				labelTime.Text += $"\n{DateTime.Now.ToString("yyyy.MM.dd")}";

			if (checkBoxShowWeekDay.Checked) 
				labelTime.Text += $"\n{DateTime.Now.DayOfWeek}";

			notifyIcon.Text = 
				$"{DateTime.Now.ToString("HH:mm:ss")}\n" +
				$"{DateTime.Now.ToString("yyyy:MM:dd")}\n" +
				$"{DateTime.Now.DayOfWeek}";

			
			nextAlarm = FindNextAlarm();
			if(nextAlarm != null) Console.WriteLine(nextAlarm);
			

		}

		private void buttonHideControls_Click(object sender, EventArgs e)
		{
			//SetVisibility(false);
			toolStripMenuItemShowControls.Checked = false;
		}

		private void labelTime_DoubleClick(object sender, EventArgs e)
		{
			//SetVisibility(true);
			toolStripMenuItemShowControls.Checked = false;
		}

		private void toolStripMenuItemExit_Click(object sender, EventArgs e) => this.Close();

		private void toolStripMenuItemTopmost_CheckedChanged(object sender, EventArgs e) => this.TopMost = toolStripMenuItemTopmost.Checked;

		private void toolStripMenuItemShowControls_CheckStateChanged(object sender, EventArgs e) => 
			SetVisibility(toolStripMenuItemShowControls.Checked);

		private void toolStripMenuItemShowDate_CheckedChanged(object sender, EventArgs e) => 
			checkBoxShowDate.Checked = toolStripMenuItemShowDate.Checked;

		private void checkBoxShowDate_CheckedChanged(object sender, EventArgs e) => 
			toolStripMenuItemShowDate.Checked = checkBoxShowDate.Checked;

		private void toolStripMenuItemShowWeekday_CheckedChanged(object sender, EventArgs e) => 
			checkBoxShowWeekDay.Checked = toolStripMenuItemShowWeekday.Checked;

		private void checkBoxShowWeekDay_CheckedChanged(object sender, EventArgs e) => 
			toolStripMenuItemShowWeekday.Checked = checkBoxShowWeekDay.Checked;

		private void toolStripMenuItemBackgroundColor_Click(object sender, EventArgs e)
		{
			colorDialog.Color = labelTime.BackColor;
			DialogResult result = colorDialog.ShowDialog(this);
			if (result == DialogResult.OK) labelTime.BackColor = colorDialog.Color;
		}

		private void toolStripMenuItemForegroundColor_Click(object sender, EventArgs e)
		{
			colorDialog.Color = labelTime.ForeColor;
			if (colorDialog.ShowDialog(this) == DialogResult.OK) labelTime.ForeColor = colorDialog.Color;
		}

		private void toolStripMenuItemChooseFont_Click(object sender, EventArgs e)
		{
			if (fontDialog.ShowDialog(this) == DialogResult.OK)
			{
				labelTime.Font = fontDialog.Font;
			}
		}
		
		private void notifyIcon_DoubleClick(object sender, EventArgs e)
		{
			if (!this.TopMost)
			{
				this.TopMost = true;
				this.TopMost = false;
			}
		}

		private void toolStripMenuItemShowConsole_CheckedChanged(object sender, EventArgs e)
		{
			AllocConsole();
			bool show = toolStripMenuItemShowConsole.Checked ? AllocConsole() : FreeConsole();
		}
		[DllImport("kernel32.dll")]
		static extern bool AllocConsole();
		[DllImport("kernel32.dll")]
		static extern bool FreeConsole();

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveSettings();
		}

		private void toolStripMenuItemLoadOnWindowsStartup_CheckedChanged(object sender, EventArgs e)
		{
			string key_name = "Clock_VPD_311";
			RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true); // true - writable

			if (toolStripMenuItemLoadOnWindowsStartup.Checked) key.SetValue(key_name, Application.ExecutablePath);
			else key.DeleteValue(key_name, false); // false - throwOnMissingValue (бросить исключение если удаляемое значение отсутствует)

			key.Dispose(); // Высвобождение ресурсов
		}

		private void toolStripMenuItemAlarms_Click(object sender, EventArgs e)
		{
			alarmsForm.ShowDialog();
		}
	}
}
