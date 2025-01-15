namespace Clock
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.labelTime = new System.Windows.Forms.Label();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.checkBoxShowDate = new System.Windows.Forms.CheckBox();
			this.checkBoxShowWeekDay = new System.Windows.Forms.CheckBox();
			this.buttonHideControls = new System.Windows.Forms.Button();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ToolStripMenuItemTopmost = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemShowControls = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripMenuItemShowDate = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemShowWeekday = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripMenuItemChooseFont = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemColors = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemForegroundColor = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripMenuItemLoadOnWindowsStartup = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelTime
			// 
			this.labelTime.AutoSize = true;
			this.labelTime.ContextMenuStrip = this.contextMenuStrip;
			this.labelTime.Font = new System.Drawing.Font("Arial Black", 32.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelTime.Location = new System.Drawing.Point(12, 25);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(142, 60);
			this.labelTime.TabIndex = 0;
			this.labelTime.Text = "Time";
			this.labelTime.DoubleClick += new System.EventHandler(this.labelTime_DoubleClick);
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// checkBoxShowDate
			// 
			this.checkBoxShowDate.AutoSize = true;
			this.checkBoxShowDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBoxShowDate.Location = new System.Drawing.Point(22, 221);
			this.checkBoxShowDate.Name = "checkBoxShowDate";
			this.checkBoxShowDate.Size = new System.Drawing.Size(128, 28);
			this.checkBoxShowDate.TabIndex = 1;
			this.checkBoxShowDate.Text = "Show date";
			this.checkBoxShowDate.UseVisualStyleBackColor = true;
			// 
			// checkBoxShowWeekDay
			// 
			this.checkBoxShowWeekDay.AutoSize = true;
			this.checkBoxShowWeekDay.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBoxShowWeekDay.Location = new System.Drawing.Point(22, 255);
			this.checkBoxShowWeekDay.Name = "checkBoxShowWeekDay";
			this.checkBoxShowWeekDay.Size = new System.Drawing.Size(171, 28);
			this.checkBoxShowWeekDay.TabIndex = 2;
			this.checkBoxShowWeekDay.Text = "Show weekday";
			this.checkBoxShowWeekDay.UseVisualStyleBackColor = true;
			// 
			// buttonHideControls
			// 
			this.buttonHideControls.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonHideControls.Location = new System.Drawing.Point(23, 298);
			this.buttonHideControls.Name = "buttonHideControls";
			this.buttonHideControls.Size = new System.Drawing.Size(155, 39);
			this.buttonHideControls.TabIndex = 3;
			this.buttonHideControls.Text = "Hide controls";
			this.buttonHideControls.UseVisualStyleBackColor = true;
			this.buttonHideControls.Click += new System.EventHandler(this.buttonHideControls_Click);
			// 
			// notifyIcon
			// 
			this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "notifyIcon";
			this.notifyIcon.Visible = true;
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemTopmost,
            this.ToolStripMenuItemShowControls,
            this.toolStripSeparator1,
            this.ToolStripMenuItemShowDate,
            this.ToolStripMenuItemShowWeekday,
            this.toolStripSeparator2,
            this.ToolStripMenuItemChooseFont,
            this.ToolStripMenuItemColors,
            this.toolStripSeparator3,
            this.ToolStripMenuItemLoadOnWindowsStartup,
            this.ToolStripMenuItemExit});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(210, 198);
			// 
			// ToolStripMenuItemTopmost
			// 
			this.ToolStripMenuItemTopmost.CheckOnClick = true;
			this.ToolStripMenuItemTopmost.Name = "ToolStripMenuItemTopmost";
			this.ToolStripMenuItemTopmost.Size = new System.Drawing.Size(209, 22);
			this.ToolStripMenuItemTopmost.Text = "Topmost";
			// 
			// ToolStripMenuItemShowControls
			// 
			this.ToolStripMenuItemShowControls.CheckOnClick = true;
			this.ToolStripMenuItemShowControls.Name = "ToolStripMenuItemShowControls";
			this.ToolStripMenuItemShowControls.Size = new System.Drawing.Size(209, 22);
			this.ToolStripMenuItemShowControls.Text = "Show controls";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
			// 
			// ToolStripMenuItemShowDate
			// 
			this.ToolStripMenuItemShowDate.CheckOnClick = true;
			this.ToolStripMenuItemShowDate.Name = "ToolStripMenuItemShowDate";
			this.ToolStripMenuItemShowDate.Size = new System.Drawing.Size(209, 22);
			this.ToolStripMenuItemShowDate.Text = "Show date";
			// 
			// ToolStripMenuItemShowWeekday
			// 
			this.ToolStripMenuItemShowWeekday.CheckOnClick = true;
			this.ToolStripMenuItemShowWeekday.Name = "ToolStripMenuItemShowWeekday";
			this.ToolStripMenuItemShowWeekday.Size = new System.Drawing.Size(209, 22);
			this.ToolStripMenuItemShowWeekday.Text = "Show weekday";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
			// 
			// ToolStripMenuItemChooseFont
			// 
			this.ToolStripMenuItemChooseFont.Name = "ToolStripMenuItemChooseFont";
			this.ToolStripMenuItemChooseFont.Size = new System.Drawing.Size(209, 22);
			this.ToolStripMenuItemChooseFont.Text = "Choose font";
			// 
			// ToolStripMenuItemColors
			// 
			this.ToolStripMenuItemColors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemBackgroundColor,
            this.ToolStripMenuItemForegroundColor});
			this.ToolStripMenuItemColors.Name = "ToolStripMenuItemColors";
			this.ToolStripMenuItemColors.Size = new System.Drawing.Size(209, 22);
			this.ToolStripMenuItemColors.Text = "Colors";
			// 
			// ToolStripMenuItemBackgroundColor
			// 
			this.ToolStripMenuItemBackgroundColor.Name = "ToolStripMenuItemBackgroundColor";
			this.ToolStripMenuItemBackgroundColor.Size = new System.Drawing.Size(180, 22);
			this.ToolStripMenuItemBackgroundColor.Text = "Background color";
			// 
			// ToolStripMenuItemForegroundColor
			// 
			this.ToolStripMenuItemForegroundColor.Name = "ToolStripMenuItemForegroundColor";
			this.ToolStripMenuItemForegroundColor.Size = new System.Drawing.Size(180, 22);
			this.ToolStripMenuItemForegroundColor.Text = "Foreground color";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(206, 6);
			// 
			// ToolStripMenuItemLoadOnWindowsStartup
			// 
			this.ToolStripMenuItemLoadOnWindowsStartup.CheckOnClick = true;
			this.ToolStripMenuItemLoadOnWindowsStartup.Name = "ToolStripMenuItemLoadOnWindowsStartup";
			this.ToolStripMenuItemLoadOnWindowsStartup.Size = new System.Drawing.Size(209, 22);
			this.ToolStripMenuItemLoadOnWindowsStartup.Text = "Load on Windows startup";
			// 
			// ToolStripMenuItemExit
			// 
			this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
			this.ToolStripMenuItemExit.Size = new System.Drawing.Size(209, 22);
			this.ToolStripMenuItemExit.Text = "Exit";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(352, 352);
			this.ContextMenuStrip = this.contextMenuStrip;
			this.Controls.Add(this.buttonHideControls);
			this.Controls.Add(this.checkBoxShowWeekDay);
			this.Controls.Add(this.checkBoxShowDate);
			this.Controls.Add(this.labelTime);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Clock VPD_311";
			this.contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTime;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.CheckBox checkBoxShowDate;
		private System.Windows.Forms.CheckBox checkBoxShowWeekDay;
		private System.Windows.Forms.Button buttonHideControls;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTopmost;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemShowControls;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemShowDate;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemShowWeekday;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemChooseFont;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemColors;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemBackgroundColor;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemForegroundColor;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLoadOnWindowsStartup;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
	}
}

