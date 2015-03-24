namespace CVLeap
{
	partial class Settings
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
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.SADwindowSize = new System.Windows.Forms.TrackBar();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.numOfDisparities = new System.Windows.Forms.TrackBar();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.preFilterCap = new System.Windows.Forms.TrackBar();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.minDisparity = new System.Windows.Forms.TrackBar();
			this.uniquenessRatio = new System.Windows.Forms.GroupBox();
			this.uniqRatio = new System.Windows.Forms.TrackBar();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.speckleWindowSize = new System.Windows.Forms.TrackBar();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.speckleRange = new System.Windows.Forms.TrackBar();
			this.disp12MaxDiff = new System.Windows.Forms.GroupBox();
			this.dispMaxDiff = new System.Windows.Forms.TrackBar();
			this.flowLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SADwindowSize)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numOfDisparities)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.preFilterCap)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.minDisparity)).BeginInit();
			this.uniquenessRatio.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uniqRatio)).BeginInit();
			this.groupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.speckleWindowSize)).BeginInit();
			this.groupBox7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.speckleRange)).BeginInit();
			this.disp12MaxDiff.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dispMaxDiff)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.groupBox1);
			this.flowLayoutPanel1.Controls.Add(this.groupBox2);
			this.flowLayoutPanel1.Controls.Add(this.groupBox3);
			this.flowLayoutPanel1.Controls.Add(this.groupBox4);
			this.flowLayoutPanel1.Controls.Add(this.uniquenessRatio);
			this.flowLayoutPanel1.Controls.Add(this.groupBox6);
			this.flowLayoutPanel1.Controls.Add(this.groupBox7);
			this.flowLayoutPanel1.Controls.Add(this.disp12MaxDiff);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(230, 570);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.SADwindowSize);
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(218, 65);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "SADwindowSize";
			// 
			// SADwindowSize
			// 
			this.SADwindowSize.LargeChange = 3;
			this.SADwindowSize.Location = new System.Drawing.Point(9, 20);
			this.SADwindowSize.Maximum = 20;
			this.SADwindowSize.Minimum = 1;
			this.SADwindowSize.Name = "SADwindowSize";
			this.SADwindowSize.Size = new System.Drawing.Size(209, 45);
			this.SADwindowSize.TabIndex = 0;
			this.SADwindowSize.Value = 5;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.numOfDisparities);
			this.groupBox2.Location = new System.Drawing.Point(3, 74);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(218, 65);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "numOfDisparities";
			// 
			// numOfDisparities
			// 
			this.numOfDisparities.Location = new System.Drawing.Point(9, 20);
			this.numOfDisparities.Minimum = 1;
			this.numOfDisparities.Name = "numOfDisparities";
			this.numOfDisparities.Size = new System.Drawing.Size(209, 45);
			this.numOfDisparities.TabIndex = 0;
			this.numOfDisparities.Value = 4;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.preFilterCap);
			this.groupBox3.Location = new System.Drawing.Point(3, 145);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(218, 65);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "preFilterCap";
			// 
			// preFilterCap
			// 
			this.preFilterCap.Location = new System.Drawing.Point(9, 20);
			this.preFilterCap.Name = "preFilterCap";
			this.preFilterCap.Size = new System.Drawing.Size(209, 45);
			this.preFilterCap.TabIndex = 0;
			this.preFilterCap.Value = 4;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.minDisparity);
			this.groupBox4.Location = new System.Drawing.Point(3, 216);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(218, 65);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "minDisparity";
			// 
			// minDisparity
			// 
			this.minDisparity.Location = new System.Drawing.Point(9, 20);
			this.minDisparity.Maximum = 20;
			this.minDisparity.Name = "minDisparity";
			this.minDisparity.Size = new System.Drawing.Size(209, 45);
			this.minDisparity.TabIndex = 0;
			this.minDisparity.Value = 1;
			// 
			// uniquenessRatio
			// 
			this.uniquenessRatio.Controls.Add(this.uniqRatio);
			this.uniquenessRatio.Location = new System.Drawing.Point(3, 287);
			this.uniquenessRatio.Name = "uniquenessRatio";
			this.uniquenessRatio.Size = new System.Drawing.Size(218, 65);
			this.uniquenessRatio.TabIndex = 4;
			this.uniquenessRatio.TabStop = false;
			this.uniquenessRatio.Text = "uniquinessRatio";
			// 
			// uniqRatio
			// 
			this.uniqRatio.Location = new System.Drawing.Point(9, 20);
			this.uniqRatio.Maximum = 15;
			this.uniqRatio.Minimum = 5;
			this.uniqRatio.Name = "uniqRatio";
			this.uniqRatio.Size = new System.Drawing.Size(209, 45);
			this.uniqRatio.TabIndex = 0;
			this.uniqRatio.Value = 5;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.speckleWindowSize);
			this.groupBox6.Location = new System.Drawing.Point(3, 358);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(218, 65);
			this.groupBox6.TabIndex = 5;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "speckleWindowSize";
			// 
			// speckleWindowSize
			// 
			this.speckleWindowSize.LargeChange = 50;
			this.speckleWindowSize.Location = new System.Drawing.Point(-3, 20);
			this.speckleWindowSize.Maximum = 200;
			this.speckleWindowSize.Name = "speckleWindowSize";
			this.speckleWindowSize.Size = new System.Drawing.Size(209, 45);
			this.speckleWindowSize.SmallChange = 10;
			this.speckleWindowSize.TabIndex = 0;
			this.speckleWindowSize.Value = 150;
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.speckleRange);
			this.groupBox7.Location = new System.Drawing.Point(3, 429);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(218, 65);
			this.groupBox7.TabIndex = 6;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "speckleRange";
			// 
			// speckleRange
			// 
			this.speckleRange.Location = new System.Drawing.Point(-3, 20);
			this.speckleRange.Maximum = 5;
			this.speckleRange.Name = "speckleRange";
			this.speckleRange.Size = new System.Drawing.Size(209, 45);
			this.speckleRange.TabIndex = 0;
			this.speckleRange.Value = 2;
			// 
			// disp12MaxDiff
			// 
			this.disp12MaxDiff.Controls.Add(this.dispMaxDiff);
			this.disp12MaxDiff.Location = new System.Drawing.Point(3, 500);
			this.disp12MaxDiff.Name = "disp12MaxDiff";
			this.disp12MaxDiff.Size = new System.Drawing.Size(218, 65);
			this.disp12MaxDiff.TabIndex = 7;
			this.disp12MaxDiff.TabStop = false;
			this.disp12MaxDiff.Text = "disp12MaxDiff";
			// 
			// dispMaxDiff
			// 
			this.dispMaxDiff.Location = new System.Drawing.Point(-3, 20);
			this.dispMaxDiff.Maximum = 20;
			this.dispMaxDiff.Name = "dispMaxDiff";
			this.dispMaxDiff.Size = new System.Drawing.Size(209, 45);
			this.dispMaxDiff.TabIndex = 0;
			this.dispMaxDiff.Value = 10;
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(230, 570);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "Settings";
			this.Text = "Settings";
			this.flowLayoutPanel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.SADwindowSize)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numOfDisparities)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.preFilterCap)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.minDisparity)).EndInit();
			this.uniquenessRatio.ResumeLayout(false);
			this.uniquenessRatio.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.uniqRatio)).EndInit();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.speckleWindowSize)).EndInit();
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.speckleRange)).EndInit();
			this.disp12MaxDiff.ResumeLayout(false);
			this.disp12MaxDiff.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dispMaxDiff)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.TrackBar SADwindowSize;
		private System.Windows.Forms.GroupBox groupBox2;
		public System.Windows.Forms.TrackBar numOfDisparities;
		private System.Windows.Forms.GroupBox groupBox3;
		public System.Windows.Forms.TrackBar preFilterCap;
		private System.Windows.Forms.GroupBox groupBox4;
		public System.Windows.Forms.TrackBar minDisparity;
		private System.Windows.Forms.GroupBox uniquenessRatio;
		public System.Windows.Forms.TrackBar uniqRatio;
		private System.Windows.Forms.GroupBox groupBox6;
		public System.Windows.Forms.TrackBar speckleWindowSize;
		private System.Windows.Forms.GroupBox groupBox7;
		public System.Windows.Forms.TrackBar speckleRange;
		private System.Windows.Forms.GroupBox disp12MaxDiff;
		public System.Windows.Forms.TrackBar dispMaxDiff;
	}
}