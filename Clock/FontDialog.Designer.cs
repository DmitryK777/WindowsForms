namespace Clock
{
	partial class FontDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FontDialog));
			this.comboBoxFonts = new System.Windows.Forms.ComboBox();
			this.labelChooseFont = new System.Windows.Forms.Label();
			this.labelFontSize = new System.Windows.Forms.Label();
			this.numericUpDownFontSize = new System.Windows.Forms.NumericUpDown();
			this.labelExample = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonApply = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBoxFonts
			// 
			this.comboBoxFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxFonts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBoxFonts.FormattingEnabled = true;
			this.comboBoxFonts.Location = new System.Drawing.Point(12, 40);
			this.comboBoxFonts.Name = "comboBoxFonts";
			this.comboBoxFonts.Size = new System.Drawing.Size(327, 32);
			this.comboBoxFonts.TabIndex = 0;
			this.comboBoxFonts.SelectedIndexChanged += new System.EventHandler(this.comboBoxFonts_SelectedIndexChanged);
			// 
			// labelChooseFont
			// 
			this.labelChooseFont.AutoSize = true;
			this.labelChooseFont.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelChooseFont.Location = new System.Drawing.Point(13, 13);
			this.labelChooseFont.Name = "labelChooseFont";
			this.labelChooseFont.Size = new System.Drawing.Size(159, 18);
			this.labelChooseFont.TabIndex = 1;
			this.labelChooseFont.Text = "Выберите шрифт";
			// 
			// labelFontSize
			// 
			this.labelFontSize.AutoSize = true;
			this.labelFontSize.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelFontSize.Location = new System.Drawing.Point(353, 13);
			this.labelFontSize.Name = "labelFontSize";
			this.labelFontSize.Size = new System.Drawing.Size(140, 18);
			this.labelFontSize.TabIndex = 2;
			this.labelFontSize.Text = "Размер шрифта";
			// 
			// numericUpDownFontSize
			// 
			this.numericUpDownFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numericUpDownFontSize.Location = new System.Drawing.Point(356, 41);
			this.numericUpDownFontSize.Maximum = new decimal(new int[] {
            58,
            0,
            0,
            0});
			this.numericUpDownFontSize.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.numericUpDownFontSize.Name = "numericUpDownFontSize";
			this.numericUpDownFontSize.Size = new System.Drawing.Size(137, 29);
			this.numericUpDownFontSize.TabIndex = 3;
			this.numericUpDownFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDownFontSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
			// 
			// labelExample
			// 
			this.labelExample.AutoSize = true;
			this.labelExample.Font = new System.Drawing.Font("Arial", 32.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelExample.Location = new System.Drawing.Point(16, 123);
			this.labelExample.Name = "labelExample";
			this.labelExample.Size = new System.Drawing.Size(198, 49);
			this.labelExample.TabIndex = 4;
			this.labelExample.Text = "Example";
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonOK.Location = new System.Drawing.Point(298, 243);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(82, 36);
			this.buttonOK.TabIndex = 5;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonCancel.Location = new System.Drawing.Point(386, 243);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(107, 36);
			this.buttonCancel.TabIndex = 6;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonApply
			// 
			this.buttonApply.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonApply.Location = new System.Drawing.Point(356, 87);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(137, 37);
			this.buttonApply.TabIndex = 7;
			this.buttonApply.Text = "Применить";
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
			// 
			// FontDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(509, 292);
			this.Controls.Add(this.buttonApply);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.labelExample);
			this.Controls.Add(this.numericUpDownFontSize);
			this.Controls.Add(this.labelFontSize);
			this.Controls.Add(this.labelChooseFont);
			this.Controls.Add(this.comboBoxFonts);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FontDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Choose clock font";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxFonts;
		private System.Windows.Forms.Label labelChooseFont;
		private System.Windows.Forms.Label labelFontSize;
		private System.Windows.Forms.Label labelExample;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonApply;
		public System.Windows.Forms.NumericUpDown numericUpDownFontSize;
	}
}